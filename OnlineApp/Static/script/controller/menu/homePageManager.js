//define menu controller 主页管理 
OnlineApp.controller('homePageManager', function ($scope, $window) {
    $('#form-dialog').modal('show');
    $scope.$watch('$viewContentLoaded', function () {
        $('#form-dialog').modal('hide');
    }); 
});