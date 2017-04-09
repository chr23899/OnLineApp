<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/header.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="OnlineApp.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>主页 —— 我的E伙伴</title>

    
    <!-- inital the angulr app -->
    <script src="/Static/script/app/onlineApp.js"></script>
    <!-- inital the store of system-->
    <script src="/Static/script/factory/index/noticesStore.js"></script>
    <script src="/Static/script/factory/index/menusStore.js"></script>
    <script src="/Static/script/factory/index/peopleStore.js"></script>
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


    
</asp:Content>
