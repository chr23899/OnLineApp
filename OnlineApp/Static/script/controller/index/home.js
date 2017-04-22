//define head controller
OnlineApp.controller('indexHome', function ($scope, $window, menusStore) {
    $scope.menuList = menusStore;

    $('#form-dialog').modal('show');
    $scope.showMenu = function (menuControl) {
        $scope.menuList.nowmenu = menuControl;
    }
});