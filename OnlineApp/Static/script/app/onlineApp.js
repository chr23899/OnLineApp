﻿/**
    add by chr 20170325
*/
var OnlineApp= angular.module('OnlineApp', ['ngRoute', 'ngMessages']);
OnlineApp.config(function ($routeProvider, $locationProvider) {
    $routeProvider.when('/', {
        templateUrl: ContextPath + '/index.aspx'
    })
    $routeProvider.when('/ktcx', {
        templateUrl: ContextPath + '/index.aspx'
    })
    .otherwise('/');
});