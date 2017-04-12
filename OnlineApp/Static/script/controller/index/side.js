//define head controller
OnlineApp.controller('indexSide', function ($scope, $window, menusStore) {
    $scope.menuList = menusStore; 

    $scope.showMenu = function (menuControl) {
        $scope.menuList.nowmenu = menuControl;
    }
});