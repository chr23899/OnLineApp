/**
    add by chr 20170325
*/
var OnlineApp = angular.module('OnlineApp', ['ngRoute', 'ngMessages', 'ngFileUpload']);
OnlineApp.config(function ($routeProvider, $locationProvider) {
    $routeProvider.when('/', {
        templateUrl: ContextPath + '/index.aspx'
    })
    $routeProvider.when('/ktcx', {
        templateUrl: ContextPath + '/index.aspx'
    })
    .otherwise('/');
});
OnlineApp.filter("trustUrl", ['$sce', function ($sce) {
    return function (recordingUrl) {
        return $sce.trustAsResourceUrl(recordingUrl);
    };
}]);