<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm2.aspx.vb" Inherits="Web.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
       <script type="text/javascript" charset="utf-8">
           window.UEDITOR_HOME_URL = "../Plugins/ueditor/";
    </script>
    <script src="../Plugins/ueditor/editor_config.js"></script>
    <script src="../Plugins/ueditor/editor_all.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <script  id="editor" name="editor" type="text/plain">这里可以书写，编辑器的初始内容</script>
     <script>
        //实例化编辑器
        var ue = UE.getEditor('editor');

        ue.addListener('ready', function () {
            this.focus()
        });
    </script>
       <input id="Button1" type="submit" value="button" />
    </div>
    </form>
</body>
</html>
