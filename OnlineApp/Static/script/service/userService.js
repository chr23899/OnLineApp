﻿//define user Service
OnlineApp.service('userService', function ($http) {

    //查询用户列表
    this.GetUserPageData = function (params) {
        console.log('[Chr.OnlineApp] 查询用户列表 req=' + JSON.stringify(params));
        return $.get(ContextPath + '/Server/UserManage.ashx?command=GetUserPageData', params, function (resp) { 
            console.log('[Chr.OnlineApp] 查询用户列表 resp=' + JSON.stringify(resp));
            return resp;
        });
    }

    //新增用户
    this.AddUser = function (params){
        console.log('[Chr.OnlineApp] 添加用户 req=' + JSON.stringify(params));
        return $.post(ContextPath + '/Server/UserManage.ashx?command=AddUser', params).then(function (resp) {
            console.log('[Chr.OnlineApp] 添加用户信息 resp=' + JSON.stringify(resp));
            return resp;
        });
    };

    //更新用户
    this.UpdateUser = function (params) {
        console.log('[Chr.OnlineApp] 更新用户信息 req=' + JSON.stringify(params));
        return $.post(ContextPath + '/Server/UserManage.ashx?command=ModifyUser', params).then(function (resp) {
            console.log('[Chr.OnlineApp] 更新用户信息 resp=' + JSON.stringify(resp));
            return resp;
        });
    }

    //删除用户
    this.DeleteUser = function (params) {
        console.log('[Chr.OnlineApp] 删除用户 req={strDelete:' + params + '}');
        return $.post(ContextPath + '/Server/UserManage.ashx?command=DeleteUser', params).then(function (resp) {
            console.log('[Chr.OnlineApp] 删除用户信息 resp=' + JSON.stringify(resp));
            return resp;
        }); 
    };
})