//define menu controller 课程管理
OnlineApp.controller('courseManager', function ($scope, $window, courseStore, courseService, USER_LAYERS, toolService, coursePlanService, PLAN_TYPES, homeWorkService) {
    //显示当前课程列表内容
    $scope.courseList = courseStore;
    //是否正在加载页面
    $scope.loadingForm = true;
    //用来保存用户所在层级(小学、中学)
    $scope.userLayers = USER_LAYERS;
    //当前显示的页面
    $scope.pageType = "list";
    //计划类型
    $scope.planTypes = PLAN_TYPES;

    // Linked date and time picker 
    // start date date and time picker 
    $('#datepicker-start').datetimepicker();

    // End date date and time picker 
    $('#datepicker-end').datetimepicker({
        useCurrent: false
    });

    // start date picke on chagne event [select minimun date for end date datepicker]
    $("#datepicker-start").on("dp.change", function (e) {
        $('#datepicker-end').data("DateTimePicker").minDate(e.date);
    });
    // Start date picke on chagne event [select maxmimum date for start date datepicker]
    $("#datepicker-end").on("dp.change", function (e) {
        $('#datepicker-start').data("DateTimePicker").maxDate(e.date);
    });

    $('#form-dialog').modal('show');
    $scope.btn_upload = "浏览图片";
    $scope.pic_error = false;

    //设置查询条件
    $scope.query = {
        teacherName: "",
        courseName: "",
        isPrimary: true,
        isMiddle: true,
        PageSize: 10,
        CurPage: 1
    }

    //更新列表信息
    initList();
    function initList() {
        $scope.loadingForm = true;
        $('#form-dialog').modal('show');
        courseService.GetCoursePageData($scope.query).then(function (data) {
            if (data == "") {
                $('#form-dialog').modal('hide');
                $scope.loadingForm = false;
                return;
            }
            data = JSON.parse(data);
            if (data.type == "success") {
                $scope.courseList = data.result.PageList;
                $scope.$apply();
                $('#form-dialog').modal('hide');
                $scope.loadingForm = false;
            }
        });
    }

    //加载更多
    $scope.addMore = function () {
        for (var i = 0; i < 3 && i < courseStore.length; i++) {
            var course = _.clone(courseStore[i]);
            $scope.courseList.push(course);
        }
    }

    //搜索数据
    $scope.serachData = function () {
        initList();
    }

    //新课程对象
    $scope.newcourse = {
    }

    $scope.userCtrlType = "add";

    //弹出新增课程窗口
    $scope.showAddCourse = function () {
        $scope.userCtrlType = 'add';
        $scope.pic_error = false;
        $scope.newcourse = {
            courseName: "",
            userName: "",
            layerType: "中学",
            note: "",
            content: "",
            show: true,
            title: "",
            pic: "",
            linkBook: "",
        }
    }

    //改变图片时候触发
    $scope.showImg = function (file) {
        if (file.length == 0)
            return;
        if (file[0].size / 1024 > 300) {
            $scope.pic_error = true;
            $scope.$apply();
            return;
        }
        //console.log("imgUrl" + $scope.newperson);
        $scope.btn_upload = "图片上传中...";
        var nowInput = $("#ImgUpload");
        var nowfile = {
            file: file[0],
            picName: 'course',
            type: 'course'
        }
        toolService.uploadImg(nowfile).then(function (data) {
            //data = JSON.parse(data);
            if (data.status == "200") {
                console.log(data.data);
                $scope.btn_upload = "浏览图片";
                $scope.newcourse.pic = data.data;
                $scope.pic_error = false;
            }
        })
    }

    //新增或修改课程表单是否正确
    $scope.validate = false;
    $scope.$watch("newcourse", function () {
        $scope.validate =
        $scope.newcourse.courseName &&
        $scope.newcourse.linkBook &&
        $scope.newcourse.pic &&
        $scope.newcourse.title;
    }, true);

    //当前编辑的对象
    $scope.editCourseIndex = 0;

    //添加新课程
    $scope.addNewCourse = function () {
        if ($scope.userCtrlType == 'add' && $scope.validate) {
            courseService.AddCourse($scope.newcourse).then(function (data) {
                data = JSON.parse(data);
                if (data.type == "success") {
                    //$scope.courseList.push($scope.newcourse);
                    //$('#form-dialog').modal('hide');
                    //$scope.$apply();
                    initList();
                }
            });
        }
        else if ($scope.userCtrlType == 'edit' && $scope.validate) {
            courseService.UpdateCourse($scope.newcourse).then(function (data) {
                data = JSON.parse(data);
                if (data.type == "success") {
                    //$scope.courseList[$scope.editPersonIndex] = $scope.newcourse;
                    //$('#form-dialog').modal('hide');
                    //$scope.$apply();
                    initList();
                }
            });
        }
    }

    //当前选中项
    $scope.nowindex = 0;

    //查看当前点击的项目
    $scope.showDeatil = function (index) {
        $scope.userCtrlType = 'view';
        $scope.nowindex = index;
        $('#form-dialog').modal('show');
    }

    //当前删除项
    $scope.delCourseIndex = 0;

    //删除当前要删除项
    $scope.delCourse = function (index) {
        $scope.userCtrlType = 'delete';
        $scope.delCourseIndex = index;
        $('#form-dialog').modal('show');
    }

    //执行删除操作
    $scope.confirmDel = function () {
        var strDelete = {
            strDelete: ""
        };
        strDelete.strDelete = $scope.courseList[$scope.delCourseIndex].Id;
        courseService.DeleteCourse(strDelete).then(function (data) {
            data = JSON.parse(data);
            if (data.type == "success") {
                $scope.courseList.splice($scope.delCourseIndex, 1);
                $scope.delCourseIndex = 0;
                $('#form-dialog').modal('hide');
                $scope.$apply();
            }
        });
    }

    //弹出编辑课程窗口
    $scope.showEditWnd = function (index) {
        $scope.userCtrlType = 'edit';
        $scope.editCourseIndex = index;
        $scope.newcourse = {
            id: $scope.courseList[index].Id,
            courseName: $scope.courseList[index].courseName,
            userName: $scope.courseList[index].userName,
            layerType: $scope.courseList[index].layerType,
            note: $scope.courseList[index].note,
            content: $scope.courseList[index].content,
            show: $scope.courseList[index].show,
            title: $scope.courseList[index].title,
            linkBook: $scope.courseList[index].linkBook,
            pic: $scope.courseList[index].pic,
        }
        /*$scope.newcourse = $scope.courseList[index];*/
        $('#form-dialog').modal('show');
    }

    //支持选中课程
    $scope.AddCourseSupport = function (index) {
        var addItem = {
            id: ""
        };
        addItem.id = $scope.courseList[index].Id;
        courseService.AddCourseSupport(addItem).then(function (data) {
            data = JSON.parse(data);
            if (data.type == "success") {
                initList();
            }
        });
    }

    //反对选中课程
    $scope.AddCourseOppose = function (index) {
        var addItem = {
            id: ""
        };
        addItem.id = $scope.courseList[index].Id;
        courseService.AddCourseOppose(addItem).then(function (data) {
            data = JSON.parse(data);
            if (data.type == "success") {
                initList();
            }
        });
    }

    //当前课程的所有计划
    $scope.planIndex = 0;
    $scope.showPlan = function (index) {
        $scope.pageType = 'plancourse';
        $scope.planIndex = index;
        $scope.initPlanList();
    }

    //课程关联的计划查询
    $scope.queryPlan = {
    }

    //初始化课程计划
    $scope.initPlanList = function () {
        $('#form-dialog').modal('show');
        $scope.loadingForm = true;
        $scope.queryPlan = {
            PageSize: 100,
            CurPage: 1,
            teacherId: $scope.courseList[$scope.planIndex].teacherId,
            teacherName: $scope.courseList[$scope.planIndex].teacherName,
            courseId: $scope.courseList[$scope.planIndex].Id,
            courseName: $scope.courseList[$scope.planIndex].courseName
        }
        coursePlanService.GetCoursePlanPageData($scope.queryPlan).then(function (data) {
            if (data == "") {
                $('#form-dialog').modal('hide');
                $scope.loadingForm = false;
                return;
            }
            data = JSON.parse(data);
            if (data.type == "success") {
                $scope.coursePlanList = data.result.PageList;
                $scope.$apply();
                $('#form-dialog').modal('hide');
                $scope.loadingForm = false;
            }
        });
    }


    //返回列表页面
    $scope.backToList = function () {
        $scope.pageType = "list";
    }

    //绑定新的课程计划
    $scope.newplan = {};

    //显示新增课程计划窗体
    $scope.showAddPlan = function () {
        $scope.userCtrlType = 'addplan';
        $scope.pic_error = false;
        $scope.newplan = {
            courseId: $scope.courseList[$scope.planIndex].Id,
            courseName: $scope.courseList[$scope.planIndex].courseName,
            name: "",
            type: "",
            video: "",
            pic: "",
            content: "",
            status: 1,
            study: "",
            test: "",
            startTime: "",
            planTime: "",
            finishTime: ""
        }
    }

    //关闭视频播放
    $('#form-dialog').on('hide.bs.modal', function () {
        // 执行一些动作...
        console.log("你关了我了 ~V~");
        var video = $('#plan_video');
        if (video[0]) {
            video[0].pause();
        }
    })

    //改变计划图片时候触发
    $scope.showPlanImg = function (file) {
        if (file.length == 0)
            return;
        if (file[0].size / 1024 > 300) {
            $scope.pic_error = true;
            $scope.$apply();
            return;
        }
        $scope.btn_upload = "图片上传中...";
        var nowfile = {
            file: file[0],
            picName: 'planPic',
            type: 'planPic'
        }
        toolService.uploadImg(nowfile).then(function (data) {
            if (data.status == "200") {
                console.log(data.data);
                $scope.btn_upload = "浏览图片";
                $scope.newplan.pic = data.data;
                $scope.pic_error = false;
            }
        })
    }

    $scope.btn_uploadvideo = "浏览视频";
    $scope.video_error = false;

    //改变视频时触发
    $scope.showPlanVideo = function (file) {
        if (file.length == 0)
            return;
        for (var i = 0; i < file.length; i++) {
            if (file[i].size / 1024 / 1024 > 300) {
                $scope.video_error = true;
                $scope.$apply();
                return;
            }
        }
        $scope.btn_uploadvideo = "视频上传中...";
        var nowfile = {
            file: file[0],
            picName: 'planVideo',
            type: 'planVideo'
        }
        toolService.uploadFile(nowfile).then(function (data) {
            if (data.status == "200") {
                console.log(data.data);
                $scope.btn_uploadvideo = "浏览视频";
                $scope.newplan.video = data.data.split(";")[0];
                $scope.pic_error = false;
            }
        })
    }

    //更新上传信息
    $scope.$on("Index->UpdateProcess", function (evt, dat) {
        $scope.btn_uploadvideo = dat;
    })

    //改变课件时触发
    $scope.showPlanStudy = function (file) {
        if (file.length == 0)
            return;
        for (var i = 0; i < file.length; i++) {
            if (file[i].size / 1024 / 1024 > 30) {
                $scope.video_error = true;
                $scope.$apply();
                return;
            }
        }
        $scope.btn_uploadvideo = "文件上传中...";
        var nowfile = {
            file: file[0],
            picName: 'planStudy',
            type: 'planStudy'
        }
        toolService.uploadFile(nowfile).then(function (data) {
            if (data.status == "200") {
                console.log(data.data);
                $scope.btn_uploadvideo = "浏览文件";
                $scope.newplan.study = data.data.split(";")[0];
                $scope.pic_error = false;
            }
        })
    }

    //改变课程计划类型时候触发
    $scope.changePlanType = function () {
        if ($scope.newplan.type == 1) {
            $scope.btn_uploadvideo = "浏览视频";
        }
        else if ($scope.newplan.type == 2) {
            $scope.btn_uploadvideo = "浏览文件";
        }
    }

    //新增或修改课程表单是否正确
    $scope.planvalidate = false;
    $scope.$watch("newplan", function () {
        $scope.planvalidate =
        (($scope.newplan.type == 1 && $scope.newplan.video) ||
        ($scope.newplan.type == 2 && $scope.newplan.study) ||
        $scope.newplan.type == 3) &&
        $scope.newplan.content &&
        $scope.newplan.pic &&
        $scope.newplan.name;
    }, true);

    //新增或编辑课程计划
    $scope.addNewCoursePlan = function () {
        if ($scope.newplan.type == 1) {
            $scope.newplan.study = "";
            $scope.newplan.test = "";
        }
        else if ($scope.newplan.type == 2) {
            $scope.newplan.video = "";
            $scope.newplan.test = "";
        }
        else if ($scope.newplan.type == 3) {
            $scope.newplan.study = "";
            $scope.newplan.video = "";
        }
        if ($scope.userCtrlType == 'addplan' && $scope.planvalidate) {
            coursePlanService.AddCoursePlan($scope.newplan).then(function (data) {
                data = JSON.parse(data);
                if (data.type == "success") {
                    $scope.initPlanList();
                }
            });
        }
        else if ($scope.userCtrlType == 'editplan' && $scope.planvalidate) {
            coursePlanService.UpdateCoursePlan($scope.newplan).then(function (data) {
                data = JSON.parse(data);
                if (data.type == "success") {
                    $scope.initPlanList();
                }
            });
        }
    }

    //显示当前计划
    $scope.showPlanDeatil = function (index) {
        $scope.userCtrlType = 'viewplan';
        $scope.nowindex = index;
        $('#form-dialog').modal('show');
    }

    //当前删除项
    $scope.delCoursePlanIndex = 0;

    //删除当前选中的课程计划
    $scope.delCoursePlan = function (index) {
        $scope.userCtrlType = 'deletePlan';
        $scope.delCoursePlanIndex = index;
        $('#form-dialog').modal('show');
    }

    //执行课程计划删除操作
    $scope.confirmDelPlan = function () {
        var strDelete = {
            strDelete: ""
        };
        strDelete.strDelete = $scope.coursePlanList[$scope.delCoursePlanIndex].Id;
        coursePlanService.DeleteCoursePlan(strDelete).then(function (data) {
            data = JSON.parse(data);
            if (data.type == "success") {
                $scope.coursePlanList.splice($scope.delCoursePlanIndex, 1);
                $scope.delCoursePlanIndex = 0;
                $('#form-dialog').modal('hide');
                $scope.$apply();
            }
        });
    }

    //当前编辑的课程计划对象
    $scope.editCoursePlanIndex = 0;

    //弹出编辑课程计划窗口
    $scope.showEditPlanWnd = function (index) {
        $scope.userCtrlType = 'editplan';
        $scope.editCoursePlanIndex = index;
        $scope.newplan = {
            id: $scope.coursePlanList[index].Id,
            courseId: $scope.courseList[$scope.planIndex].Id,
            courseName: $scope.courseList[$scope.planIndex].courseName,
            name: $scope.coursePlanList[index].name,
            type: $scope.coursePlanList[index].type,
            video: $scope.coursePlanList[index].video,
            pic: $scope.coursePlanList[index].pic,
            content: $scope.coursePlanList[index].content,
            status: $scope.coursePlanList[index].status,
            study: $scope.coursePlanList[index].study,
            test: $scope.coursePlanList[index].test,
            startTime: $scope.coursePlanList[index].startTime,
            planTime: $scope.coursePlanList[index].planTime,
            finishTime: $scope.coursePlanList[index].finishTime,
        }
        $('#form-dialog').modal('show');
        $scope.changePlanType();
    }

    //查询课程计划下面的作业
    $scope.queryHomeWork = {
    };

    //当前作业对象
    $scope.nowHomeWork = {
    };

    //弹出该课程计划下的作业
    $scope.showHomeWork = function (index) {
        $('#form-dialog').modal('show');
        $scope.loadingForm = true;
        $scope.queryHomeWork = {
            PageSize: 100,
            CurPage: 1,
            teacherId: $scope.courseList[$scope.planIndex].teacherId,
            teacherName: $scope.courseList[$scope.planIndex].teacherName,
            courseId: $scope.courseList[$scope.planIndex].Id,
            courseName: $scope.courseList[$scope.planIndex].courseName,
            planId: $scope.coursePlanList[index].Id,
            planName: $scope.coursePlanList[index].name
        } 
        homeWorkService.GetAssignmentPageData($scope.queryHomeWork).then(function (data) {
            if (data == "") {
                $('#form-dialog').modal('hide');
                $scope.loadingForm = false;
                return;
            }
            data = JSON.parse(data);
            if (data.type == "success") {
                if (data.result.PageList.length == 0) {
                    $scope.nowHomeWork = {
                        courseId: $scope.courseList[$scope.planIndex].Id,
                        courseName: $scope.courseList[$scope.planIndex].courseName,
                        planId: $scope.coursePlanList[index].Id,
                        planName: $scope.coursePlanList[index].name,
                        id: "",
                        title: "",
                        content: "",
                        link: ""
                    }
                }
                else {
                    //$scope.nowHomeWork = data.result.PageList[0];
                    $scope.nowHomeWork = {
                        courseId: data.result.PageList[0].courseId,
                        courseName: data.result.PageList[0].courseName,
                        planId: data.result.PageList[0].planId,
                        planName: data.result.PageList[0].planName,
                        id: data.result.PageList[0].Id,
                        title: data.result.PageList[0].title,
                        content: data.result.PageList[0].content,
                        link: data.result.PageList[0].link
                    } 
                }
                $scope.userCtrlType = 'viewHomeWork';
                $scope.loadingForm = false;
                $('#form-dialog').modal('show');
                $scope.$apply();
            }
        });
    }

    //上传作业附件按钮
    $scope.btn_uploadHomeWorkLink = "上传附件";

    //是否显示上传附件错误
    $scope.homeWork_error = false;

    //改变附件时触发
    $scope.showHomeWorkLink = function (file) {
        if (file.length == 0)
            return;
        for (var i = 0; i < file.length; i++) {
            if (file[i].size / 1024 / 1024 > 30) {
                $scope.homeWork_error = true;
                $scope.$apply();
                return;
            }
        }
        $scope.btn_uploadHomeWorkLink = "附件上传中...";
        var nowfile = {
            file: file[0],
            picName: 'homeWorkLink',
            type: 'homeWorkLink'
        }
        toolService.uploadFile(nowfile).then(function (data) {
            if (data.status == "200") {
                console.log(data.data);
                $scope.btn_uploadHomeWorkLink = "上传附件";
                $scope.nowHomeWork.link = data.data.split(";")[0];
                $scope.homeWork_error = false;
            }
        })
    }

    //当前作业是否可以提交
    $scope.homeWorkvalidate = false;

    //监听家庭作业对象是否发生了改变
    $scope.$watch("nowHomeWork", function () {
        $scope.homeWorkvalidate =
        $scope.nowHomeWork.content &&
        $scope.nowHomeWork.title;
    }, true);

    //新增或者编辑随堂作业
    $scope.addOrEditHomeWork = function () {
        if ($scope.nowHomeWork.id == '' && $scope.homeWorkvalidate) {
            homeWorkService.AddAssignment($scope.nowHomeWork).then(function (data) {
                data = JSON.parse(data);
                if (data.type == "success") {
                    $('#form-dialog').modal('hide');
                }
            });
        }
        else if ($scope.homeWorkvalidate) {
            homeWorkService.UpdateAssignment($scope.nowHomeWork).then(function (data) {
                data = JSON.parse(data);
                if (data.type == "success") {
                    $('#form-dialog').modal('hide');
                }
            });
        }
    }
});