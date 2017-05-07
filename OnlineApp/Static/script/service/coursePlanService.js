//define homeWork Service
OnlineApp.service('coursePlanService', function ($http) {
    //对应到 CoursePlanManage
    //查询课程计划列表
    this.GetCoursePlanPageData = function (params) {
        console.log('[Chr.OnlineApp] 查询课程计划列表 req=' + JSON.stringify(params));
        return $.get(ContextPath + '/Server/CoursePlanManage.ashx?command=GetCoursePlanPageData', params, function (resp) {
            console.log('[Chr.OnlineApp] 查询课程计划列表 resp=' + JSON.stringify(resp));
            return resp;
        });
    }

    //新增课程计划
    this.AddCoursePlan = function (params) {
        console.log('[Chr.OnlineApp] 添加课程计划 req=' + JSON.stringify(params));
        return $.post(ContextPath + '/Server/CoursePlanManage.ashx?command=AddCoursePlan', params).then(function (resp) {
            console.log('[Chr.OnlineApp] 添加课程计划信息 resp=' + JSON.stringify(resp));
            return resp;
        });
    };

    //更新课程计划
    this.UpdateCoursePlan = function (params) {
        console.log('[Chr.OnlineApp] 更新课程计划信息 req=' + JSON.stringify(params));
        return $.post(ContextPath + '/Server/CoursePlanManage.ashx?command=ModifyCoursePlan', params).then(function (resp) {
            console.log('[Chr.OnlineApp] 更新课程计划信息 resp=' + JSON.stringify(resp));
            return resp;
        });
    }

    //删除课程计划
    this.DeleteCoursePlan = function (params) {
        console.log('[Chr.OnlineApp] 删除课程计划 req={strDelete:' + params + '}');
        return $.post(ContextPath + '/Server/CoursePlanManage.ashx?command=DeleteCoursePlan', params).then(function (resp) {
            console.log('[Chr.OnlineApp] 删除课程计划信息 resp=' + JSON.stringify(resp));
            return resp;
        });
    };
});