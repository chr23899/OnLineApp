//define menu controller 课程管理
OnlineApp.controller('courseManager', function ($scope, $window, courseStore, courseService, USER_LAYERS) {
    //显示当前课程列表内容
    $scope.courseList = courseStore;
    //是否正在加载页面
    $scope.loadingForm = true;
    //用来保存用户所在层级(小学、中学)
    $scope.userLayers = USER_LAYERS;


    $('#form-dialog').modal('show');
    $scope.btn_upload = "浏览图片";
    $scope.pic_error = false;

    $scope.query = {
        userName: "",
        courseName: "",
        isPrimary: true,
        isMiddle: true,
        PageSize: 10,
        CurPage: 1
    }

    initList();
    function initList() {
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

    $scope.addMore = function () {
        for (var i = 0; i < 3 && i < courseStore.length; i++) {
            var course = _.clone(courseStore[i]);
            $scope.courseList.push(course);
        }
    }

    $scope.serachData = function () {
        for (var i = 0; i < $scope.courseList.length; i++) {
            $scope.courseList[i].show = true;
            if ($scope.query.userName != "" && $scope.courseList[i].userName.indexOf($scope.query.userName) < 0) {
                $scope.courseList[i].show = false;
            }
            if ($scope.query.courseName != "" && $scope.courseList[i].courseName.indexOf($scope.query.courseName) < 0) {
                $scope.courseList[i].show = false;
            }
            if ($scope.courseList[i].layerType == "小学" && $scope.query.isPrimary != true) {
                $scope.courseList[i].show = false;
            }
            if ($scope.courseList[i].layerType == "中学" && $scope.query.isMiddle != true) {
                $scope.courseList[i].show = false;
            }

        }
    }

    $scope.newcourse = {
        courseName: "",
        userName: "",
        layerType: "中学",
        note: "",
        content: "",
        show: true,
        title: "",
        imageUrl: "UI/themes/images/course_teach.jpg",
    }

    $scope.userCtrlType = "add";
    $scope.showAddCourse = function () {
        $scope.userCtrlType = 'add';
        $scope.newcourse = {
            courseName: "",
            userName: "",
            layerType: "中学",
            note: "",
            content: "",
            show: true,
            title: "",
            imageUrl: "UI/themes/images/course_teach.jpg",
        }
    }

    //表单是否正确
    $scope.validate = false;
    $scope.$watch("newcourse", function () {
        $scope.validate =
        $scope.newcourse.courseName &&
        $scope.newcourse.userName &&
        $scope.newcourse.note;
    }, true);

    $scope.editCourseIndex = 0;

    $scope.addNewCourse = function () {
        if ($scope.userCtrlType == 'add' && $scope.validate) {
            courseService.AddCourse($scope.newcourse).then(function (data) {
                data = JSON.parse(data);
                if (data.type == "success") {
                    $scope.courseList.push($scope.newcourse);
                    $('#form-dialog').modal('hide');
                    $scope.$apply();
                }
            });
        }
        else if ($scope.userCtrlType == 'edit' && $scope.validate) {
            courseService.UpdateCourse($scope.newcourse).then(function (data) {
                data = JSON.parse(data);
                if (data.type == "success") {
                    $scope.courseList[$scope.editPersonIndex] = $scope.newcourse;
                    $('#form-dialog').modal('hide');
                    $scope.$apply();
                }
            });
        } 
    }

    $scope.nowindex = 0;

    $scope.showDeatil = function (index) {
        $scope.userCtrlType = 'view';
        $scope.nowindex = index;
        $('#form-dialog').modal('show');
    }

    $scope.delCourseIndex = 0;

    $scope.delCourse = function (index) {
        $scope.userCtrlType = 'delete';
        $scope.delCourseIndex = index;
        $('#form-dialog').modal('show');
    }

    $scope.confirmDel = function () {
        $scope.courseList.splice($scope.delCourseIndex, 1);
        $scope.delCourseIndex = 0;
        $('#form-dialog').modal('hide');
    }

    $scope.showEditWnd = function (index) {
        $scope.userCtrlType = 'edit';
        $scope.editCourseIndex = index;
        $scope.newcourse = {
            courseName: $scope.courseList[index].courseName,
            userName: $scope.courseList[index].userName,
            layerType: $scope.courseList[index].layerType,
            note: $scope.courseList[index].note,
            content: $scope.courseList[index].content,
            show: $scope.courseList[index].show,
            title: $scope.courseList[index].title,
            imageUrl: $scope.courseList[index].imageUrl,
        }
        /*$scope.newcourse = $scope.courseList[index];*/
        $('#form-dialog').modal('show');
    }
});


