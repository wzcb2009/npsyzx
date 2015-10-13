<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="UserLoginWeb.aspx.vb" Inherits="Web.UserLoginWeb" %>
<script>
    $(function () {
        $("#loginSubmit").click(function () {
            var username, pwd;
            username = $("input[name='username']").val();
            pwd = $("input[name='pwd']").val();
            if (username==""|| pwd==""){
                return false;
            }else{
                $.post("../user/UserLogindo.aspx?action=ajaxlogin",
                     { "username": username, "pwd": pwd },
                     function (data) {

                         navTabAjaxDone(data);

                     } ,"json");
            }
        });
    });
    function navTabAjaxDone(json) {
       
        DWZ.ajaxDone(json);

        if (json.statusCode == DWZ.statusCode.ok) {

           




            if ("closeCurrent" == json.callbackType) {

                setTimeout(function () { $.pdialog.closeCurrent(); }, 100);

            } 

        }

    }



</script>
<div class="pageContent">
	
	<form method="post" action="../user/UserLogindo.aspx?action=ajaxlogin" class="pageForm" onsubmit="return validateCallback(this, dialogAjaxDone)">
		<div class="pageFormContent" layoutH="58">
			<div class="unit">
				<label>用户名：</label>
				<input type="text" name="username" size="30" value="admin1" class="required"/>
			</div>
			<div class="unit">
				<label>密码：</label>
				<input type="password" name="pwd" size="30" value="jxk403"  class="required"/>
			</div>
		</div>
		<div class="formBar">
			<ul>
				<li><div class="buttonActive"><div class="buttonContent"><button type="button" id="loginSubmit">提交</button></div></div></li>
				<li><div class="button"><div class="buttonContent"><button type="button" class="close">取消</button></div></div></li>
			</ul>
		</div>
	</form>
	
</div>

