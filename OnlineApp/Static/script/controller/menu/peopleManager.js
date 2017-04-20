//define menu controller
OnlineApp.controller('peopleManager', function ($scope, userService,toolService, $window, peopleStore, USER_ROLES, USER_LAYERS) {
    //显示当前人员列表内容
    $scope.peopleList;// = peopleStore;
    //是否正在加载页面
    $scope.loadingForm = true;
    //用来保存用户角色
    $scope.userRoles = USER_ROLES;
    //用来保存用户所在层级(小学、中学)
    $scope.userLayers = USER_LAYERS;

    $('#form-dialog').modal('show');
    $scope.btn_upload = "浏览图片";
    $scope.pic_error = false;

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

    //对input为file的控件包含的文件进行清空处理
    function clearSelect() {
        var obj = document.getElementById('ImgUpload');
        obj.outerHTML = obj.outerHTML;
    }

    $scope.addMore = function () {
        for (var i = 0; i < 6 && i< peopleStore.length; i++) {
            var people = _.clone(peopleStore[i]);
            $scope.peopleList.push(people);
        }
    }

    $scope.serachData = function () {
        for (var i = 0; i < $scope.peopleList.length; i++) {
            $scope.peopleList[i].StateId = true;
            if ($scope.query.UserName != "" && $scope.peopleList[i].UserName.indexOf($scope.query.UserName) < 0) {
                $scope.peopleList[i].StateId = false;
            }
            if ($scope.query.Tel != "" && $scope.peopleList[i].Tel.indexOf($scope.query.Tel) < 0) {
                $scope.peopleList[i].StateId = false;
            }
            if ($scope.peopleList[i].Type == "11" && $scope.query.isStudent != true) {
                $scope.peopleList[i].StateId = false;
            }
            if ($scope.peopleList[i].Type == "12" && $scope.query.isParent != true) {
                $scope.peopleList[i].StateId = false;
            }
            if ($scope.peopleList[i].Type == "13" && $scope.query.isTeacher != true) {
                $scope.peopleList[i].StateId = false;
            }
            if (($scope.peopleList[i].Type == "1" || $scope.peopleList[i].Type == "2") && $scope.query.isManager != true) {
                $scope.peopleList[i].StateId = false;
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
        clearSelect();
        $scope.userCtrlType = 'add';
        $scope.pic_error = false;
        $scope.newperson = {
            UserName: "",
            Tel: "",
            Type: $scope.userRoles[11].id,
            Layer: $scope.userLayers[1].id,
            Note: "",
            content: "2017年3月27号加入",
            StateId: true,
            title: "",
            Alternate2: "",
        }
    }

    //表单是否正确
    $scope.validate = false;
    $scope.$watch("newperson", function () {
        $scope.validate =
        $scope.newperson.UserName &&
        $scope.newperson.Tel &&
        $scope.newperson.Note &&
        $scope.newperson.Alternate2 &&
        $scope.btn_upload == "浏览图片";
    }, true);

    $scope.editPersonIndex = 0;

    //改变图片时候触发
    $scope.showImg = function (file) {
        if (file.length == 0)
            return;
        if (file[0].size / 1024 > 200) {
            $scope.pic_error = true;
            $scope.$apply();
            return;
        }
        //console.log("imgUrl" + $scope.newperson);
        $scope.btn_upload = "图片上传中...";
        var nowInput = $("#ImgUpload");
        var nowfile = {
            file: file[0],
            picName: 'test',
            type: 'user'
        }
        toolService.uploadFile(nowfile).then(function (data) { 
            //data = JSON.parse(data);
            if (data.status == "200") {
                console.log(data.data);
                $scope.btn_upload = "浏览图片";
                $scope.newperson.Alternate2 = data.data;
                $scope.pic_error = false;
            }
        })
    }

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
        var strDelete = {
            strDelete: "" 
        };
        strDelete.strDelete = $scope.peopleList[$scope.delPersonIndex].UserName;
        userService.DeleteUser(strDelete).then(function (data) {
            data = JSON.parse(data);
            if (data.type == "success") {
                $scope.peopleList.splice($scope.delPersonIndex, 1);
                $scope.delPersonIndex = 0;
                $('#form-dialog').modal('hide');
                $scope.$apply();
            }
        });
    }

    $scope.showEditWnd = function (index) {
        clearSelect();
        $scope.userCtrlType = 'edit';
        $scope.editPersonIndex = index;
        $scope.newperson = {
            UserName: $scope.peopleList[index].UserName,
            Tel: $scope.peopleList[index].Tel,
            Type: +$scope.peopleList[index].Type,
            Layer: $scope.peopleList[index].Layer,
            Note: $scope.peopleList[index].Note,
            content: $scope.peopleList[index].content, 
            title: $scope.peopleList[index].title,
            Alternate2: $scope.peopleList[index].Alternate2,
            StateId: $scope.peopleList[index].StateId
        }
        /*$scope.newperson = $scope.peopleList[index];*/
        $('#form-dialog').modal('show');
    }
});