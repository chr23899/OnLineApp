onlineApp.factory('menusStore', function () {
    return {
        nowmenu: "homePage",
        menus: [{
            icon: "home",
            name: "主页",
            control: "homePage",
            submenus: []
        }/*, {
            icon: "class",
            name: "班级管理",
            control: "classManager",
            submenus: [{
                name: "小学班级",
                control: "primaryClass"
            }, {
                name: "中学班级",
                control: "middleClass"
            }]
        }*/, {
            icon: "people",
            name: "人员管理",
            control: "peopleManager",
            submenus: [{
                name: "学生管理",
                control: "studentManager"
            }, {
                name: "家长管理",
                control: "parentManager"
            }, {
                name: "教师管理",
                control: "teacherManager"
            }, {
                name: "管理员管理",
                control: "adminManager"
            }]
        }, {
            icon: "golf_course",
            name: "课程管理",
            control: "courseManager",
            submenus: [{
                name: "小学课程",
                control: "primaryCourse"
            }, {
                name: "中学课程",
                control: "middleCourse"
            }]
        }, {
            icon: "edit",
            name: "作业管理",
            control: "homeWorkManager",
            submenus: [{
                name: "学生管理",
                control: "primaryHomeWork"
            }, {
                name: "家长管理",
                control: "middleHomeWork"
            }]
        }, {
            icon: "comment",
            name: "评论管理",
            control: "comment",
            submenus: []
        }, {
            icon: "content_paste",
            name: "资料管理",
            control: "dataManager",
            submenus: []
        }, {
            icon: "playlist_add_check",
            name: "考试管理",
            control: "testManager",
            submenus: []
        }, {
            icon: "settings",
            name: "系统设置",
            control: "systemSetting",
            submenus: [{
                name: "分组管理",
                control: "groupManager"
            }, {
                name: "权限管理",
                control: "powerManager"
            }]
        }]
    };
});
