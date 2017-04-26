//define head controller
OnlineApp.controller('indexHome', function ($scope, $window, menusStore) {
    $scope.menuList = menusStore;

    $('#form-dialog').modal('show');
    $scope.showMenu = function (menuControl) {
        $scope.menuList.nowmenu = menuControl;
    }

    //更新上传信息
    $scope.$on("Process->Index", function (evt, dat) {
        $scope.$broadcast("Index->UpdateProcess", dat);
    })
});