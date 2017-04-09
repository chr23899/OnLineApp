//define head controller
onlineApp.controller('indexHome', function ($scope, $window, menusStore) {
    $scope.menuList = menusStore;
    
    $scope.showMenu = function (menuControl) {
        $scope.menuList.nowmenu = menuControl;
    }
});