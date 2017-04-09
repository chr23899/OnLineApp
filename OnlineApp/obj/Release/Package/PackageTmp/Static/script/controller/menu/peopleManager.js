//define menu controller
onlineApp.controller('peopleManager', function ($scope, $window, peopleStore) {
    //显示当前人员列表内容
    $scope.peopleList = peopleStore;

    $scope.query = {
        userName: "",
        phone: "",
        isParent: true,
        isTeacher: true,
        isStudent: true,
        isManager: true
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
            if ($scope.query.userName != "" && $scope.peopleList[i].userName.indexOf($scope.query.userName) < 0) {
                $scope.peopleList[i].show = false;
            }
            if ($scope.query.phone != "" && $scope.peopleList[i].phone.indexOf($scope.query.phone) < 0) {
                $scope.peopleList[i].show = false;
            }
            if ($scope.peopleList[i].type == "student" && $scope.query.isStudent != true) {
                $scope.peopleList[i].show = false;
            }
            if ($scope.peopleList[i].type == "teacher" && $scope.query.isTeacher != true) {
                $scope.peopleList[i].show = false;
            }
            if ($scope.peopleList[i].type == "parent" && $scope.query.isParent != true) {
                $scope.peopleList[i].show = false;
            }
            if ($scope.peopleList[i].type == "manager" && $scope.query.isManager != true) {
                $scope.peopleList[i].show = false;
            }
        }
    }

    $scope.newperson = {
        userName: "",
        phone: "",
        type: "学生",
        layerType: "中学",
        note: "",
        content: "2017年3月27号加入",
        show: true,
        title: "",
        imageUrl: "UI/themes/images/male.png",
    }
     
    $scope.userCtrlType = "add";
    $scope.showAddPerson = function () {
        $scope.userCtrlType = 'add';
        $scope.newperson = {
            userName: "",
            phone: "",
            type: "学生",
            layerType: "中学",
            note: "",
            content: "2017年3月27号加入",
            show: true,
            title: "",
            imageUrl: "UI/themes/images/male.png",
        }
    }

    //表单是否正确
    $scope.validate = false;
    $scope.$watch("newperson", function () {
        $scope.validate =
        $scope.newperson.userName &&
        $scope.newperson.phone &&
        $scope.newperson.note;
    }, true);

    $scope.editPersonIndex = 0;

    $scope.addNewPerson = function () {
        if ($scope.userCtrlType == 'add' && $scope.validate) {
            $scope.newperson.title = $scope.newperson.layerType + $scope.newperson.type;
            $scope.peopleList.push($scope.newperson);
            $('#form-dialog').modal('hide');
        }
        else if ($scope.userCtrlType == 'edit' && $scope.validate) {
            $scope.peopleList[$scope.editPersonIndex] = $scope.newperson;
            $('#form-dialog').modal('hide');
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
            userName: $scope.peopleList[index].userName,
            phone: $scope.peopleList[index].phone,
            type: $scope.peopleList[index].type,
            layerType: $scope.peopleList[index].layerType,
            note: $scope.peopleList[index].note,
            content: $scope.peopleList[index].content,
            show: $scope.peopleList[index].show,
            title: $scope.peopleList[index].title,
            imageUrl: $scope.peopleList[index].imageUrl,
        }
        /*$scope.newperson = $scope.peopleList[index];*/
        $('#form-dialog').modal('show');
    }
});