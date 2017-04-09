/**
    add by chr 20170325
*/
var onlineApp = angular.module('onlineApp', ['ngRoute', 'ngMessages']);
onlineApp.config(function ($routeProvider, $locationProvider) {
    $routeProvider.when('/', {
        templateUrl: ContextPath + '/index.aspx'
    })
    $routeProvider.when('/ktcx', {
        templateUrl: ContextPath + '/index.aspx'
    })
    .otherwise('/');
});