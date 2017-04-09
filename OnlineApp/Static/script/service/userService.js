//define user Service
onlineApp.service('userService', function ($http) {

    //查询用户列表
    this.GetUserPageData = function (params) {
        console.log('[onlineApp] 查询用户列表 req=' + JSON.stringify(params));
        return $.get(ContextPath + '/Server/UserManage.ashx?command=GetUserPageData', params, function (resp) { 
            console.log('[onlineApp] 查询用户列表 resp=' + JSON.stringify(resp));
            return resp;
        });
    }
})