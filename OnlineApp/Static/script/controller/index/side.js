//define head controller
OnlineApp.controller('indexSide', function ($scope, $window, menusStore) {
    $scope.menuList = menusStore; 
    $scope.nowUserName = nowUserNickName;
    $scope.nowUserPic = nowUserPict;

    $scope.showMenu = function (menuControl) {
        $scope.menuList.nowmenu = menuControl;
    }
});