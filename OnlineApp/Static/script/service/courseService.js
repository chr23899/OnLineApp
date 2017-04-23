//define course Service
OnlineApp.service('courseService', function ($http) {

    //查询课程列表
    this.GetCoursePageData = function (params) {
        console.log('[Chr.OnlineApp] 查询课程列表 req=' + JSON.stringify(params));
        return $.get(ContextPath + '/Server/CourseManage.ashx?command=GetCoursePageData', params, function (resp) {
            console.log('[Chr.OnlineApp] 查询课程列表 resp=' + JSON.stringify(resp));
            return resp;
        });
    }

    //新增课程
    this.AddCourse = function (params) {
        console.log('[Chr.OnlineApp] 添加课程 req=' + JSON.stringify(params));
        return $.post(ContextPath + '/Server/CourseManage.ashx?command=AddCourse', params).then(function (resp) {
            console.log('[Chr.OnlineApp] 添加课程信息 resp=' + JSON.stringify(resp));
            return resp;
        });
    };

    //添加课程支持数
    this.AddCourseSupport = function (params) {
        console.log('[Chr.OnlineApp] 添加课程支持数 req={id:' + params + '}');
        return $.post(ContextPath + '/Server/CourseManage.ashx?command=AddCourseSupport', params).then(function (resp) {
            console.log('[Chr.OnlineApp] 添加课程支持数 resp=' + JSON.stringify(resp));
            return resp;
        });
    }

    //添加课程反对数
    this.AddCourseOppose = function (params) {
        console.log('[Chr.OnlineApp] 添加课程反对数 req={id:' + params + '}');
        return $.post(ContextPath + '/Server/CourseManage.ashx?command=AddCourseOppose', params).then(function (resp) {
            console.log('[Chr.OnlineApp] 添加课程反对数 resp=' + JSON.stringify(resp));
            return resp;
        });
    }

    //更新课程
    this.UpdateCourse = function (params) {
        console.log('[Chr.OnlineApp] 更新课程信息 req=' + JSON.stringify(params));
        return $.post(ContextPath + '/Server/CourseManage.ashx?command=ModifyCourse', params).then(function (resp) {
            console.log('[Chr.OnlineApp] 更新课程信息 resp=' + JSON.stringify(resp));
            return resp;
        });
    }

    //删除课程
    this.DeleteCourse = function (params) {
        console.log('[Chr.OnlineApp] 删除课程 req={strDelete:' + params + '}');
        return $.post(ContextPath + '/Server/CourseManage.ashx?command=DeleteCourse', params).then(function (resp) {
            console.log('[Chr.OnlineApp] 删除课程信息 resp=' + JSON.stringify(resp));
            return resp;
        });
    };
})