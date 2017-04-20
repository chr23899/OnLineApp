//define homeWork Service
OnlineApp.service('homeWorkService', function ($http) {
    //对应到 AssignmentManage
    //查询作业列表
    this.GetAssignmentPageData = function (params) {
        console.log('[Chr.OnlineApp] 查询作业列表 req=' + JSON.stringify(params));
        return $.get(ContextPath + '/Server/AssignmentManage.ashx?command=GetAssignmentPageData', params, function (resp) {
            console.log('[Chr.OnlineApp] 查询作业列表 resp=' + JSON.stringify(resp));
            return resp;
        });
    }

    //新增作业
    this.AddAssignment = function (params) {
        console.log('[Chr.OnlineApp] 添加作业 req=' + JSON.stringify(params));
        return $.post(ContextPath + '/Server/AssignmentManage.ashx?command=AddAssignment', params).then(function (resp) {
            console.log('[Chr.OnlineApp] 添加作业信息 resp=' + JSON.stringify(resp));
            return resp;
        });
    };

    //更新作业
    this.UpdateAssignment = function (params) {
        console.log('[Chr.OnlineApp] 更新作业信息 req=' + JSON.stringify(params));
        return $.post(ContextPath + '/Server/AssignmentManage.ashx?command=ModifyAssignment', params).then(function (resp) {
            console.log('[Chr.OnlineApp] 更新作业信息 resp=' + JSON.stringify(resp));
            return resp;
        });
    }

    //删除作业
    this.DeleteAssignment = function (params) {
        console.log('[Chr.OnlineApp] 删除作业 req={strDelete:' + params + '}');
        return $.post(ContextPath + '/Server/AssignmentManage.ashx?command=DeleteAssignment', params).then(function (resp) {
            console.log('[Chr.OnlineApp] 删除作业信息 resp=' + JSON.stringify(resp));
            return resp;
        });
    };
});