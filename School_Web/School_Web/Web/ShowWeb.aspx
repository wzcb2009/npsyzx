<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ShowWeb.aspx.vb" Inherits="Web.ShowWeb" %>
<style>
  .pageContent div.newscontent, .pageContent div.newscontent p {
        line-height:120%;
        font-size:14px;
        margin:10px; 

    
    
    }
     .pageContent p.newsinfo {
        margin-left:10px;
    
    
    }
</style>
<style type="text/css" media="screen">
    .my-uploadify-button {
        background: none;
        border: none;
        text-shadow: none;
        border-radius: 0;
    }

    .uploadify:hover .my-uploadify-button {
        background: none;
        border: none;
    }

    .fileQueue {
        width: 400px;
        height: 150px;
        overflow: auto;
        border: 1px solid #E5E5E5;
        margin-bottom: 10px;
    }

    ul.filelist li:hover {
        background-color: #E5E5E5;
    }

    ul.filelist li {
        height: 46px;
        width: 600px;
        border: solid 1px #E5E5E5;
        margin: 3px;
    }

        ul.filelist li .ico {
            float: left;
            height: 40px;
            width: 40px;
            margin: 3px;
        }

        ul.filelist li .main a.title {
            display: block;
            font-size: 14px;
            line-height: 22px;
            vertical-align: middle;
            height: 22px;
            width: 500px;
        }
        ul.filelist li .main a.view {
            display: block;
            font-size: 14px;
            line-height: 22px;
            vertical-align: middle;
            height: 22px;
            width: 60px;
            float:right;
        }

        ul.filelist li .main a.del {
            display: block;
            background-image: url(../file/images/del.png);
            background-repeat: no-repeat;
            float: right;
            line-height: 22px;
            vertical-align: middle;
            height: 22px;
            width: 20px;
        }

        ul.filelist li .info {
            height: 22px;
            line-height: 22px;
            font-size: 12px;
        }
    ul.filelist li.clearbox {
        clear:both;
        height:0px;
        border:none;
    
    }

   .fileupload .left {
        width:415px;
        float:left;
        
    
    }
    .fileupload .line {
     border-left:solid;
        border-left-color:#cccccc;
        border-left-width:1px;
        height:31px;
         float:left;
         width:1px;
   }
       .fileupload .right {
        width:400px;
        float:left;
       
        
    
    }
    .clearbox {
        height: 0px;
        clear: both;
    }
</style>
<script>
     function showfile(fileid,title) {
         var options;
         options={
              width :820,
              height :550,
             max:false,
             mask:true,
             mixable:true,
             minable:true,
             resizable:true,
             drawable:true,
             fresh:true}
         $.pdialog.open("../file/fileshow.aspx?fileid=" + fileid, "filedialog", title,options );

     }

</script>

<div class="pageContent"   layoutH="0">
<h2 class="contentTitle">
<asp:literal id="lt_title" runat="server"></asp:literal></h2>
     <p class="newsinfo"><asp:literal id="lt_info" runat="server"></asp:literal></p>
   <div class="divider"></div>
    <div class="newscontent"><asp:literal id="lt_content" runat="server"></asp:literal></div>
    <%If flag Then%>
  <div class="divider"></div>

 <h2 class="contentTitle">
    
    附件：</h2>
<div style="height:60px;">
          <asp:literal id="lt_files" runat="server" EnableViewState="False"></asp:literal></div>
    <%End If%>
   	
</div>
 