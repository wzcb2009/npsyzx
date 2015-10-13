<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="flv.aspx.vb" Inherits="Web.flv" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   	<div id="mediaplayer">JW Player goes here</div>

<script type="text/javascript" src="jwplayer.js"></script>
	<script type="text/javascript">
	    jwplayer("mediaplayer").setup({
	        flashplayer: "player.swf",
	        height: 360,
	        listbar: {
	            position: 'right',
	            size: 320
	        },
	        width: 960,
	        playlist: "http://www.wz17.net:6666/index.do?method=rss&i1=26"
	    });
	</script>   
    </form>
</body>
</html>
