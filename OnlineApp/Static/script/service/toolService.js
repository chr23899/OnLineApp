//define tool Service
OnlineApp.service('toolService', function ($rootScope, $http, Upload) {
    //对应到 工具类 UploadHandler

    //上传文件,支持多个文件同时上传
    this.uploadFile = function (params) { 
        return Upload.upload({
            url: 'Server/UploadHandler.ashx',
            data: {
                file: params["file"],
                'command': 'UploadFile',
                'picName': params["picName"],
                'type': params["type"]
            }
        }).then(function (resp) {
            //console.log('Success ' + resp.config.data.file.name + 'uploaded. Response: ' + resp.data);
            return resp;
        }, function (resp) {
            //console.log('Error status: ' + resp.status);
            return resp;
        }, function (evt) {
            var progressPercentage = parseInt(100.0 * evt.loaded / evt.total);
            console.log('progress: ' + progressPercentage + '% ' + evt.config.data.file.name);
            $rootScope.$broadcast("Process->Index", "文件: " + evt.config.data.file.name + " 上传进度" + progressPercentage + "%");
            //$rootScope.processData = "文件: " + evt.config.data.file.name + " 上传进度" + progressPercentage;
        });
    }

    //上传图片
    this.uploadImg = function (params) {
        return Upload.upload({
            url: 'Server/UploadHandler.ashx',
            data: {
                file: params["file"],
                'command': 'UploadImg',
                'picName': params["picName"],
                'type': params["type"]
            }
        }).then(function (resp) {
            //console.log('Success ' + resp.config.data.file.name + 'uploaded. Response: ' + resp.data);
            return resp;
        }, function (resp) {
            //console.log('Error status: ' + resp.status);
            return resp;
        }, function (evt) {
            var progressPercentage = parseInt(100.0 * evt.loaded / evt.total);
            console.log('progress: ' + progressPercentage + '% ' + evt.config.data.file.name);
        });
    }
});