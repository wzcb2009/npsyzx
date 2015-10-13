<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="NewInfoWebEdit.aspx.vb" Inherits="Web.NewInfoWebEdit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script type="text/javascript">
var UEDITOR_HOME_URL='../ueditor/',ueditor_loader={};
//编辑器同步
function editorSyn(ename) {
    $.each(ueditor_loader[ename], function (i) {
        this.sync();
    });
}
</script>



<head runat="server">
    <title></title>
     <meta http-equiv="Content-Type" content="text/html;charset=utf-8"/>
    <script type="text/javascript" charset="utf-8" src="../ueditor/ueditor.config.js"></script>
    <script type="text/javascript" charset="utf-8" src="../ueditor/ueditor.all.min.js"> </script>
    <script type="text/javascript" charset="utf-8" src="../ueditor/lang/zh-cn/zh-cn.js"></script>
    <style type="text/css">
        div{
            width:100%;
        }   </style>
</head>
    <div>
    <form id="form1" runat="server">
   <asp:hiddenfield id="Hd_action" runat="server"></asp:hiddenfield>
        <asp:hiddenfield id="hd_caseid" runat="server"></asp:hiddenfield>
        <asp:hiddenfield id="hd_id" runat="server"></asp:hiddenfield>
        <asp:hiddenfield id="hd_objid" runat="server"></asp:hiddenfield>

        <div class=" pageFormContent2" >
            <dl>
                <dt>标题：</dt>
                <dd>
                    <asp:textbox id="txt_title" runat="server" size="30" cssclass="required"></asp:textbox>
                </dd>
            </dl>
            <dl>
                <dt>
审核通过
                </dt>                <dd>
                <asp:checkbox id="chk_Status" checked="true" runat="server" text="" />
                </dd>
            </dl>
         
            <dl>
               <dt>加密</dt>
                <dd>
                <asp:checkbox id="chk_right" runat="server" text="" />

                </dd>
            </dl>
            <dl>
               <dt>推荐</dt>
                <dd>
                <asp:checkbox id="chk_cmd" runat="server" text="" />
                </dd>
            </dl>
               <dl>
                <dt>作者</dt>
                <dd>
                    <asp:textbox id="txt_author" runat="server" width="50px"></asp:textbox>
                </dd>
            </dl>
            <dl>
                <dt>浏览次数</dt>
                <dd>
                    <asp:textbox id="txt_BrowCount" runat="server" text="0" width="50px"></asp:textbox>
                </dd>
            </dl>
            <dl>
                <dt>排序</dt>
                <dd>
                    <asp:textbox id="txt_pindex" runat="server" text="1000" width="50px"></asp:textbox>
                </dd>
            </dl>
            <dl>
                <dt>上传日期</dt>
                <dd>
                    <asp:textbox id="txt_pubdate" runat="server" width="80px"></asp:textbox>
                </dd>
            </dl>
      
            <div style="clear: both"></div>
                
            <div>
 <dl>
                <dt>复制到</dt>
                <dd>

                    <asp:checkbox runat="server" id="xykx" value="107" Text=""></asp:checkbox>校园快讯
                 

                </dd>
            </dl>
       

            </div>
             
              <div style="clear: both">
                
              </div>
               <div style=" width:100%">
               <script id="editor" name="editor"    type="text/plain" style="width:1024px;height:500px;""><%=art_content%></script>
               </div>
 </div>

   <div id="filesinput">
                <asp:literal id="lt_fileinput" runat="server"></asp:literal>

            </div>
    </form>
    <script type="text/javascript">

        //实例化编辑器
        //建议使用工厂方法getEditor创建和引用编辑器实例，如果在某个闭包下引用该编辑器，直接调用UE.getEditor('editor')就能拿到相关的实例
        var ue = UE.getEditor('editor', );

      
</script>
  </div>

