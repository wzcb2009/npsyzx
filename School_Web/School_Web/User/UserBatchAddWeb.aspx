﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="UserBatchAddWeb.aspx.vb" Inherits="Web.UserBatchAddWeb" %>

<div class="pageContent">
	<form method="post" action="../user/UserBatchaddDo.aspx" enctype="multipart/form-data" class="pageForm required-validate" onsubmit="return iframeCallback(this);">
		<div class="pageFormContent" layoutH="56">
			<p>
				<label>Excel：</label>
				<input name="Filedata" type="file" />
			</p>
<p>
				<label>包括基本信息：</label>
    <input name="c_baseinfo" value ="1" type="checkbox" />
			</p>
            <p>
                字段包括： 用户名、姓名、部门、【岗位、性别、学位、手机全号、手机短号】
                
            </p>
            <p>

            </p>
 		</div>
		<div class="formBar">
			<ul>
                <li><div class="buttonActive"><div class="buttonContent"><a href='../user/userTempelte.xls'>模板文件下载</a>	</div></div></li>
                 	<li><div class="buttonActive"><div class="buttonContent"><button type="submit">提交</button></div></div></li>
				<li><div class="button"><div class="buttonContent"><button type="button" class="close">取消</button></div></div></li>
			</ul>
		</div>
	</form>
</div>
