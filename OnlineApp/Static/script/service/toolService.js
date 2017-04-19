//define tool Service
OnlineApp.service('toolService', function ($http) {
    //对应到 工具类 UploadHandler

    //查询课程列表
    this.GetCoursePageData = function (params) {
        console.log('[Chr.OnlineApp] 查询课程列表 req=' + JSON.stringify(params));
        return $.get(ContextPath + '/Server/CourseManage.ashx?command=GetCoursePageData', params, function (resp) {
            console.log('[Chr.OnlineApp] 查询课程列表 resp=' + JSON.stringify(resp));
            return resp;
        });
    }
});