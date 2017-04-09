//define menu controller
onlineApp.controller('peopleManager', function ($scope, userService, $window, peopleStore, USER_ROLES, USER_LAYERS) {
    //显示当前人员列表内容
    $scope.peopleList;// = peopleStore;
    //是否正在加载页面
    $scope.loadingForm = true;
    //用来保存用户角色
    $scope.userRoles = USER_ROLES;
    //用来保存用户所在层级(小学、中学)
    $scope.userLayers = USER_LAYERS;

    $('#form-dialog').modal('show');

    $scope.query = {
        UserName: "",
        Tel: "",
        isParent: true,
        isTeacher: true,
        isStudent: true,
        isManager: true,
        PageSize: 10,
        CurPage: 1
    }

    initList();
    function initList() {
        userService.GetUserPageData($scope.query).then(function (data) {
            data = JSON.parse(data);
            if (data.type == "success") {
                //console.log(data);
                $scope.peopleList = data.result.PageList;
                $scope.$apply();
                $('#form-dialog').modal('hide');
                $scope.loadingForm = false;
            }
        });
    }

    $scope.addMore = function () {
        for (var i = 0; i < 6 && i< peopleStore.length; i++) {
            var people = _.clone(peopleStore[i]);
            $scope.peopleList.push(people);
        }
    }

    $scope.serachData = function () {
        for (var i = 0; i < $scope.peopleList.length; i++) {
            $scope.peopleList[i].show = true;
            if ($scope.query.UserName != "" && $scope.peopleList[i].UserName.indexOf($scope.query.UserName) < 0) {
                $scope.peopleList[i].show = false;
            }
            if ($scope.query.Tel != "" && $scope.peopleList[i].Tel.indexOf($scope.query.Tel) < 0) {
                $scope.peopleList[i].show = false;
            }
            if ($scope.peopleList[i].Type == "student" && $scope.query.isStudent != true) {
                $scope.peopleList[i].show = false;
            }
            if ($scope.peopleList[i].Type == "teacher" && $scope.query.isTeacher != true) {
                $scope.peopleList[i].show = false;
            }
            if ($scope.peopleList[i].Type == "parent" && $scope.query.isParent != true) {
                $scope.peopleList[i].show = false;
            }
            if ($scope.peopleList[i].Type == "manager" && $scope.query.isManager != true) {
                $scope.peopleList[i].show = false;
            }
        }
    }

    $scope.newperson = {
        UserName: "",
        Tel: "",
        Type: $scope.userRoles[11].id,
        Layer: $scope.userLayers[1].id,
        Note: "",
        content: "2017年3月27号加入",
        StateId: true,
        title: "",
        Alternate2: "male.png",
    }
     
    $scope.userCtrlType = "add";
    $scope.showAddPerson = function () {
        $scope.userCtrlType = 'add';
        $scope.newperson = {
            UserName: "",
            Tel: "",
            Type: $scope.userRoles[11].id,
            Layer: $scope.userLayers[1].id,
            Note: "",
            content: "2017年3月27号加入",
            StateId: true,
            title: "",
            Alternate2: "male.png",
        }
    }

    //表单是否正确
    $scope.validate = false;
    $scope.$watch("newperson", function () {
        $scope.validate =
        $scope.newperson.UserName &&
        $scope.newperson.Tel &&
        $scope.newperson.Note;
    }, true);

    $scope.editPersonIndex = 0;

    $scope.addNewPerson = function () {
        if ($scope.userCtrlType == 'add' && $scope.validate) {
            userService.AddUser($scope.newperson).then(function (data) {
                data = JSON.parse(data);
                if (data.type == "success") {
                    $scope.peopleList.push($scope.newperson);
                    $('#form-dialog').modal('hide');
                    $scope.$apply();
                }
            });
        }
        else if ($scope.userCtrlType == 'edit' && $scope.validate) {
            userService.UpdateUser($scope.newperson).then(function (data) {
                data = JSON.parse(data);
                if (data.type == "success") {
                    $scope.peopleList[$scope.editPersonIndex] = $scope.newperson;
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

    $scope.delPersonIndex = 0;

    $scope.delPerson = function (index) {
        $scope.userCtrlType = 'delete';
        $scope.delPersonIndex = index;
        $('#form-dialog').modal('show');
    }

    $scope.confirmDel = function () {
        $scope.peopleList.splice($scope.delPersonIndex, 1);
        $scope.delPersonIndex = 0;
        $('#form-dialog').modal('hide');
    }

    $scope.showEditWnd = function (index) {
        $scope.userCtrlType = 'edit';
        $scope.editPersonIndex = index;
        $scope.newperson = {
            UserName: $scope.peopleList[index].UserName,
            Tel: $scope.peopleList[index].Tel,
            Type: +$scope.peopleList[index].Type,
            Layer: $scope.peopleList[index].Layer,
            Note: $scope.peopleList[index].Note,
            content: $scope.peopleList[index].content,
            show: $scope.peopleList[index].show,
            title: $scope.peopleList[index].title,
            Alternate2: $scope.peopleList[index].Alternate2,
            StateId: $scope.peopleList[index].StateId
        }
        /*$scope.newperson = $scope.peopleList[index];*/
        $('#form-dialog').modal('show');
    }
});