//define menu controller 课程管理
OnlineApp.controller('courseManager', function ($scope, $window, courseStore, courseService, USER_LAYERS, toolService, coursePlanService, PLAN_TYPES) {
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
        $('#form-dialog').modal('show');
        $scope.loadingForm = true;
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
        toolService.uploadFile(nowfile).then(function (data) {
            //data = JSON.parse(data);
            if (data.status == "200") {
                console.log(data.data);
                $scope.btn_upload = "浏览图片";
                $scope.newcourse.pic = data.data;
                $scope.pic_error = false;
            }
        })
    }

    //表单是否正确
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
            courseId: courseList[planIndex].Id,
            courseName: courseList[planIndex].courseName,
            name: "",
            type: "",
            video: "",
            pic: "",
            content: "",
            status: true,
            study: "", 
            test: "",
            startTime: "",
            planTime: ""
        }
    }
});


