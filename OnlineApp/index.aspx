<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/header.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Chr.OnlineApp.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>主页 —— 我的E伙伴</title>

    
    <!-- inital the angulr app -->
    <script src="/Static/script/app/onlineApp.js"></script>

    <!-- inital the constant of system-->
    <script src="/Static/script/constants.js"></script>

    <!-- inital the store of system-->
    <script src="/Static/script/factory/index/noticesStore.js"></script>
    <script src="/Static/script/factory/index/menusStore.js"></script>
    <script src="/Static/script/factory/index/peopleStore.js"></script>
    <script src="/Static/script/factory/index/courseStore.js"></script>
    <script src="/Static/script/factory/index/homeWorkStore.js"></script>
    <script src="/Static/script/factory/index/commentStore.js"></script>
    <!-- load the service of angularjs-->
    <script src="/Static/script/service/userService.js"></script>
    <script src="/Static/script/service/toolService.js"></script>
    <script src="/Static/script/service/homeWorkService.js"></script>
    <script src="/Static/script/service/courseService.js"></script>
    <script src="/Static/script/service/coursePlanService.js"></script>

    <!-- load the angularjs javascript-->
    <script src="/Static/script/controller/index/head.js"></script>
    <script src="/Static/script/controller/index/side.js"></script>
    <script src="/Static/script/controller/index/home.js"></script>
    <script src="/Static/script/controller/menu/classManager.js"></script>
    <script src="/Static/script/controller/menu/peopleManager.js"></script>
    <script src="/Static/script/controller/menu/courseManager.js"></script>
    <script src="/Static/script/controller/menu/homeWorkManager.js"></script>
    <script src="/Static/script/controller/menu/comment.js"></script>
    <script src="/Static/script/controller/menu/dataManager.js"></script>
    <script src="/Static/script/controller/menu/testManager.js"></script>
    <script src="/Static/script/controller/menu/systemSetting.js"></script>
    <script src="/Static/script/controller/menu/homePageManager.js"></script>    
    
    <!-- load the  third party elements -->
    <script type="text/javascript" src="/UI/components/datetimepicker/js/moment-with-locales.js"></script>
    <script type="text/javascript" src="/UI/components/datetimepicker/js/bootstrap-datetimepicker.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <form id="home_index" runat="server" ng-controller="indexHome">
        <!-- Header Starts -->
        <!--#include file="Static/html/comon/head.html" -->
        <!-- Header Ends -->
        <!-- Sidebar Starts -->
        <!--#include file="Static/html/comon/sidebar.html" -->
        <!-- Sidebar Ends -->

        <!--content area start-->
        <!--#include file="Static/html/homepage/index.html" -->
        <!-- include file="Static/html/class/index.html" -->
        <!--#include file="Static/html/people/index.html" -->
        <!--#include file="Static/html/course/index.html" -->
        <!--#include file="Static/html/homework/index.html" -->
        <!--#include file="Static/html/comment/index.html" -->
        <!--#include file="Static/html/datamanage/index.html" -->
        <!--#include file="Static/html/testmanage/index.html" -->
        <!--#include file="Static/html/setting/index.html" -->
        <!--end content area-->

        <!-- Footer Starts -->
        <!--#include file="Static/html/comon/footer.html" -->
        <!-- Footer Ends -->
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
    <script>
        var ContextPath = "<%=nowPath%>";
        var nowUserNickName = "<%=pTUsers.Nickname%>";
        var nowUserLayer = "<%=pTUsers.Layer%>";
        var nowUserPict = "<%=pTUsers.Alternate2.Replace("\\","\\\\")%>";
    </script>
    <script>
        $(document).ready(function () {
            var sPath = window.location.pathname;
            var sPage = sPath.substring(sPath.lastIndexOf('/') + 1);
            $(".pmd-sidebar-nav").each(function () {
                $(this).find("a[href='" + sPage + "']").parents(".dropdown").addClass("open");
                $(this).find("a[href='" + sPage + "']").parents(".dropdown").find('.dropdown-menu').css("display", "block");
                $(this).find("a[href='" + sPage + "']").parents(".dropdown").find('a.dropdown-toggle').addClass("active");
                $(this).find("a[href='" + sPage + "']").addClass("active");
            });
        });
    </script>
    <script src="UI/components/card/js/jquery.masonry.min.js"></script>
    <script>
        $(document).ready(function () {
            $(".bar").remove();
            $(".pmd-textfield .form-control").after('');

            $('.pmd-textfield input').each(function () {
                if ($(this).val() != "") {
                    $(this).closest('.pmd-textfield').addClass("pmd-textfield-floating-label-completed");
                }
            });

            $(".pmd-textfield .form-control").focus(function () {
                $(this).closest('.pmd-textfield').addClass("pmd-textfield-floating-label-active pmd-textfield-floating-label-completed");
            });

            $(".pmd-textfield .form-control").focusout(function () {
                if ($(this).val() === "") {
                    $(this).closest('.pmd-textfield').removeClass("pmd-textfield-floating-label-completed");
                }
                $(this).closest('.pmd-textfield').removeClass("pmd-textfield-floating-label-active");
            });

            // Masonary
            function cardMasonry() {
                setTimeout(function () {
                    $('#card-masonry').masonry({

                        itemSelector: '#card-masonry > div',
                        //isAnimated: true,
                    });
                    $('#card-masonry').css({ "opacity": "1" });
                }, 1000);
            };
            $(window).resize(function () {
                $('#card-masonry').masonry({
                    itemSelector: '#card-masonry > div',
                    //isAnimated: true,
                });
                cardMasonry();
            });
            $(function () {
                $('#tabs').bind('click', function (e) {
                    $('#card-masonry').masonry({
                        itemSelector: '#card-masonry > div',
                    });
                });
            });
            cardMasonry();

        });
    </script>
    <script>
        (function (i, s, o, g, r, a, m) {
            i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {
                (i[r].q = i[r].q || []).push(arguments)
            }, i[r].l = 1 * new Date(); a = s.createElement(o),
            m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g; m.parentNode.insertBefore(a, m)
        })(window, document, 'script', 'https://www.google-analytics.com/analytics.js', 'ga');

        ga('create', 'UA-124615-22', 'auto');
        ga('send', 'pageview');
    </script>     
</asp:Content>
