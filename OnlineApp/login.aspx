<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/header.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="OnlineApp.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>登录 - 我的E伙伴</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <div class="logincard">
        <div class="pmd-card card-default pmd-z-depth">
            <form id="lo_form" runat="server">
                <div class="login-card">
                    <div class="pmd-card-title card-header-border text-center">
                        <div class="loginlogo">
                            <a href="javascript:void(0);">
                                <img src="UI/themes/images/logo-icon.png" alt="Logo"></a>
                        </div>
                        <h3>登录<span>到 <strong>我的E伙伴</strong></span></h3>
                    </div>

                    <div class="pmd-card-body">
                         <div id="error_note" runat="server" class="alert alert-danger" style="display:normal !important;" role="alert"> 您输入的 <a href="javascript:void(0);" class="alert-link">账号和密码</a> 有问题哦！ </div>
                         <div class="form-group pmd-textfield pmd-textfield-floating-label">
                            <label for="inputError1" class="control-label pmd-input-group-label">用户名</label>
                            <div class="input-group">
                                <div class="input-group-addon"><i class="material-icons md-dark pmd-sm">perm_identity</i></div>
                                <input type="text" class="form-control" id="txt_login_userName" runat="server">
                            </div>
                        </div>

                        <div class="form-group pmd-textfield pmd-textfield-floating-label">
                            <label for="inputError1" class="control-label pmd-input-group-label">密码</label>
                            <div class="input-group">
                                <div class="input-group-addon"><i class="material-icons md-dark pmd-sm">lock_outline</i></div>
                                <input type="password" class="form-control" id="txt_login_passWord" runat="server">
                            </div>
                        </div>
                    </div>
                    <div class="pmd-card-footer card-footer-no-border card-footer-p16 text-center">
                        <div class="form-group clearfix">
                            <div class="checkbox pull-left">
                                <label class="pmd-checkbox checkbox-pmd-ripple-effect">
                                    <input type="checkbox" checked="" value="">
                                    <span class="pmd-checkbox">记住账号</span>
                                </label>
                            </div>
                            <span class="pull-right forgot-password">
                                <a href="javascript:void(0);">忘记密码?</a>
                            </span>
                        </div>
                        <asp:Button ID="butn_login" runat="server" CssClass="btn pmd-ripple-effect btn-primary btn-block" Text="登录" OnClick="butn_login_Click" />
                         <p class="redirection-link">还没有账号? <a href="javascript:void(0);" class="login-register">注册</a>. </p>
                    </div> 
                </div>

                <div class="register-card">
                    <div class="pmd-card-title card-header-border text-center">
                        <div class="loginlogo">
                            <a href="javascript:void(0);">
                                <img src="UI/themes/images/logo-icon.png" alt="Logo"></a>
                        </div>
                        <h3>注册 <span>到 <strong>我的E伙伴</strong></span></h3>
                    </div>
                    <div class="pmd-card-body">
                        <div class="form-group pmd-textfield pmd-textfield-floating-label">
                            <label for="inputError1" class="control-label pmd-input-group-label">用户名</label>
                            <div class="input-group">
                                <div class="input-group-addon"><i class="material-icons md-dark pmd-sm">perm_identity</i></div>
                                <input type="text" class="form-control" id="txt_register_userName" runat="server">
                            </div>
                        </div>

                        <div class="form-group pmd-textfield pmd-textfield-floating-label">
                            <label for="inputError1" class="control-label pmd-input-group-label">邮箱</label>
                            <div class="input-group">
                                <div class="input-group-addon"><i class="material-icons md-dark pmd-sm">email</i></div>
                                <input type="text" class="form-control" id="txt_register_email" runat="server">
                            </div>
                        </div>

                        <div class="form-group pmd-textfield pmd-textfield-floating-label">
                            <label for="inputError1" class="control-label pmd-input-group-label">密码</label>
                            <div class="input-group">
                                <div class="input-group-addon"><i class="material-icons md-dark pmd-sm">lock_outline</i></div>
                                <input type="text" class="form-control" id="txt_register_passWord" runat="server">
                            </div>
                        </div>
                    </div>

                    <div class="pmd-card-footer card-footer-no-border card-footer-p16 text-center">
                        <asp:Button ID="butn_register" runat="server" CssClass="btn pmd-ripple-effect btn-primary btn-block" Text="注册" OnClick="butn_register_Click" />
                        <p class="redirection-link">已经有了一个账号了? <a href="javascript:void(0);" class="register-login">登录</a>. </p>
                    </div>
                </div>

                <div class="forgot-password-card">
                    <div class="pmd-card-title card-header-border text-center">
                        <div class="loginlogo">
                            <a href="javascript:void(0);">
                                <img src="UI/themes/images/logo-icon.png" alt="Logo"></a>
                        </div>
                        <h3>忘记密码?<br>
                            <span>提交你的邮箱地址，我们会给你发一个重置密码的链接.</span></h3>
                    </div>
                    <div class="pmd-card-body">
                        <div class="form-group pmd-textfield pmd-textfield-floating-label">
                            <label for="inputError1" class="control-label pmd-input-group-label">邮箱地址</label>
                            <div class="input-group">
                                <div class="input-group-addon"><i class="material-icons md-dark pmd-sm">email</i></div>
                                <input type="text" class="form-control" id="txt_find_email" runat="server">
                            </div>
                        </div>
                    </div>
                    <div class="pmd-card-footer card-footer-no-border card-footer-p16 text-center">
                        <asp:Button ID="butn_find" runat="server" CssClass="btn pmd-ripple-effect btn-primary btn-block" Text="找回密码" OnClick="butn_find_Click" />
                        <p class="redirection-link">已经注册过了? <a href="javascript:void(0);" class="register-login">登录</a></p>
                    </div>
                </div>
            </form>
        </div>
    </div>

    <!-- Scripts Ends -->
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">

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
    <!-- login page sections show hide -->
    <script type="text/javascript">
        $(document).ready(function () {
            $('.app-list-icon li a').addClass("active");
            $(".login-for").click(function () {
                $('.login-card').hide()
                $('.forgot-password-card').show();
            });
            $(".signin").click(function () {
                $('.login-card').show()
                $('.forgot-password-card').hide();
            });
        });
    </script>
    <script type="text/javascript">
        $(document).ready(function () {
            $(".login-register").click(function () {
                $('.login-card').hide()
                $('.forgot-password-card').hide();
                $('.register-card').show();
            });

            $(".register-login").click(function () {
                $('.register-card').hide()
                $('.forgot-password-card').hide();
                $('.login-card').show();
            });
            $(".forgot-password").click(function () {
                $('.login-card').hide()
                $('.register-card').hide()
                $('.forgot-password-card').show();
            });
        });
    </script>
    <script>
        var ContextPath = "<%=nowPath%>";
    </script>   
    <script src="/Static/script/app/onlineApp.js"></script>
</asp:Content>
