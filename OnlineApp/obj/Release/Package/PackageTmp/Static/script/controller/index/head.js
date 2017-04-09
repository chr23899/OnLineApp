//define head controller
onlineApp.controller('indexHead', function ($scope, $window, noticesStore) {
    $scope.noticeList = noticesStore;

    $scope.readMessage = function (sno) {
        $scope.noticeList[sno].read = true;
    }
});