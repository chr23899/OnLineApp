﻿//define menu controller 作业管理
OnlineApp.controller('homeWorkManager', function ($scope, $window, homeWorkService, homeWorkStore, USER_LAYERS) {
    //显示当前作业列表内容
    $scope.homeWorkList = homeWorkStore;
    $scope.loadingForm = true;
    $scope.userLayers = USER_LAYERS;
    $('#form-dialog').modal('show');

    $scope.query = {
        userName: "",
        homeWorkTask: "",
        inClass: true,
        afterClass: true,
        PageSize: 10,
        CurPage: 1
    }
    
    initList();
    function initList() {
        $scope.loadingForm = true;
        homeWorkService.GetAssignmentPageData($scope.query).then(function (data) {
            if (data == "") {
                $('#form-dialog').modal('hide');
                $scope.loadingForm = false;
                return;
            }
            data = JSON.parse(data);
            if (data.type == "success") {
                $scope.homeWorkList = data.result.PageList;
                $scope.$apply();
                $('#form-dialog').modal('hide');
                $scope.loadingForm = false;
            }
        });
    }

    $scope.addMore = function () {
        for (var i = 0; i < 3 && i < homeWorkStore.length; i++) {
            var homeWork = _.clone(homeWorkStore[i]);
            $scope.homeWorkList.push(homeWork);
        }
    }

   

    $scope.serachData = function () {
        for (var i = 0; i < $scope.homeWorkList.length; i++) {
            $scope.homeWorkList[i].show = true;
            if ($scope.query.userName != "" && $scope.homeWorkList[i].userName.indexOf($scope.query.userName) < 0) {
                $scope.homeWorkList[i].show = false;
            }
            if ($scope.query.homeWorkTask != "" && $scope.homeWorkList[i].task.indexOf($scope.query.homeWorkTask) < 0) {
                $scope.homeWorkList[i].show = false;
            }
            if ($scope.homeWorkList[i].layerType == "课堂" && $scope.query.inClass != true) {
                $scope.homeWorkList[i].show = false;
            }
            if ($scope.homeWorkList[i].layerType == "课后" && $scope.query.afterClass != true) {
                $scope.homeWorkList[i].show = false;
            }

        }
    }

    $scope.newHomeWork = {
        homeWorkTask: "",
        courseName: "",
        userName: "",
        layerType: "课堂",
        note: "",
        content: "",
        show: true,
        title: "",
    }

    $scope.userCtrlType = "add";
    $scope.showAddHomeWork = function () {
        $scope.userCtrlType = 'add';
        $scope.newHomeWork = {
            homeWorkTask: "",
            courseName: "",
            userName: "",
            layerType: "课堂",
            note: "",
            content: "",
            show: true,
            title: "",
        }
    }

    //表单是否正确
    $scope.validate = false;
    $scope.$watch("newHomeWork", function () {
        $scope.validate =
        $scope.newHomeWork.homeWorkTask &&
        $scope.newHomeWork.courseName &&
        $scope.newHomeWork.content;
    }, true);

    $scope.editHomeWorkIndex = 0;

    $scope.addNewHomeWork = function () {
        if ($scope.userCtrlType == 'add' && $scope.validate) {
            homeWorkService.AddAssignment($scope.newHomeWork).then(function (data) {
                if (data == "") {
                    $('#form-dialog').modal('hide');
                    $scope.loadingForm = false;
                    return;
                }
                data = JSON.parse(data);
                if (data.type == "success") {
                   $scope.homeWorkList.push($scope.newHomeWork);
                   $scope.newHomeWork.title = $scope.newHomeWork.layerType;
                    $('#form-dialog').modal('hide');
                    $scope.$apply();
                   // initList();
                }
            });
           
        }
        else if ($scope.userCtrlType == 'edit' && $scope.validate) {
            userService.UpdateAssignment($scope.newHomeWork).then(function (data) {
                data = JSON.parse(data);
                if (data.type == "success") {
                    $scope.homeWorkList[$scope.editHomeWorkIndex] = $scope.newHomeWork;
                    $('#form-dialog').modal('hide');
                    $scope.$apply();
                    //initList();
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

    $scope.delHomeWorkIndex = 0;

    $scope.delHomeWork = function (index) {
        $scope.userCtrlType = 'delete';
        $scope.delHomeWorkIndex = index;
        $('#form-dialog').modal('show');
    }

   
    
    $scope.confirmDel = function () {
        var strDelete = {
            strDelete: ""
        };
        strDelete.strDelete = $scope.homeWorkList[$scope.delHomeWorkIndex].Id;
        homeWorkService.DeleteAssignment(strDelete).then(function (data) {          
            data = JSON.parse(data);
            if (data.type == "success") {
                $scope.homeWorkList.splice($scope.delHomeWorkIndex, 1);
                $scope.delHomeWorkIndex = 0;
                $('#form-dialog').modal('hide');
                $scope.$apply();
            }
        });
    }
   

    $scope.showEditWnd = function (index) {
        $scope.userCtrlType = 'edit';
        $scope.editHomeWorkIndex = index;
        $scope.newHomeWork = {
            id:$scope.homeWorkList[index].Id,
            homeWorkTask: $scope.homeWorkList[index].task,
            courseName: $scope.homeWorkList[index].courseName,
            layerType: $scope.homeWorkList[index].layerType,
            note: $scope.homeWorkList[index].note,
            content: $scope.homeWorkList[index].content,
            show: $scope.homeWorkList[index].show,
            title: $scope.homeWorkList[index].title,
        }
        /*$scope.newHomeWork = $scope.homeWorkList[index];*/
        $('#form-dialog').modal('show');
    }
});


