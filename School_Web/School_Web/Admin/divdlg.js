/*********************************************************************
* 对话框层的定义，适用于IE和FireFox
* 
* zyl 2008-10-30 
*

**********************************************************************
用法：

页面只需要引用这个文件，就可以使用以下接口：
openDialog: 打开对话框
hideDialog: 关闭对话框
onDialogCallBack: 对话框的回调函数，关闭对话框时会调用


*********************************************************************/




/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// 以下为实现(接口定义在最后)

//
// 调用这个方法来生成对话框的必要元素
//
createDlg();


// 对话框配置的，全局变量
var cfgObj = null;

// 事件变量
var isDragBegin = false;
var beginDragX = 0;
var beginDragY = 0;

//
// 对话框配置类的定义
//
var cfgClass = function(sUrl, sTitle, callBack, nDlgWidth, nDlgHeight)
{
    this.url = sUrl;
    this.title = sTitle;
    this.width = nDlgWidth;
    this.height = nDlgHeight;
    this.callBack = callBack;
}

//
//生成对话框html
//
function createDlg()
{
// 遮罩层
document.write('<div id="divDialogOuter"  style="filter:alpha(opacity=30);-moz-opacity:0.3;opacity:0.3;background-color:#000;width:100%;height:100%;z-index:1000;position: absolute;left:0;top:0;display:none;overflow: hidden;">\n');
document.write('    <iframe width="100%" height="100%" frameborder="0" scroll="none"></iframe>\n');
document.write('</div>\n');


// 对话框层
document.write('<div id="divDialogInner" style="border:solid 1px #709CD2;background:#A1C2E5;padding:0px;width:780px;z-index:1001; position: absolute; display:none;top:15%; left:25%;>\n');
document.write('	<div style="padding:2px 2px 2px 2px;text-align:center;vertical-align:middle;">\n');


// 标题定义
document.write('	    <div id="divdlgTitle" style="width:100%; hight: 40px; background: #A1C2E5; padding: 5 5 5 5;">\n');
document.write('            <span style="float:left" id="dlgTitle"></span>\n');
document.write('            <span style="float:right; cursor:pointer;" onclick="javascript:hideDialog();"><img src="images/close1.gif" /></span>\n');
document.write('	    </div>\n');

// 内容定义
document.write('	    <div align="center" style="width:100%; height:100%; background: #A1C2E5;">\n');
document.write('            <iframe width="99%" height="99%" frameborder="0" id="iframeDlg" scroll="auto"></iframe>\n');
document.write('	    </div>\n');

// END 
document.write('	</div>\n');
document.write('</div>\n');

// 事件绑定
var oTitle = document.getElementById("divdlgTitle");
if(false && window.addEventListener)
{
    oTitle.addEventListener("mousedown",    dlgTitle_mousedown, false);
    oTitle.addEventListener("mouseup",      dlgTitle_mouseup,   false);
    oTitle.addEventListener("mousemove",    dlgTitle_mousemove, false);
}
else if(false && window.attachEvent)
{
    oTitle.attachEvent("onmousedown",       dlgTitle_mousedown);
    oTitle.attachEvent("onmouseup",         dlgTitle_mouseup);
    oTitle.attachEvent("onmousemove",       dlgTitle_mousemove);
}


}


function dlgTitle_mousedown(e)
{
    isDragBegin = true;
    if(!e) e = window.event;
    beginDragX = e.clientX;
    endDragY = e.clientY;
}

function dlgTitle_mouseup(e)
{
    if(!e) e = window.event;
    isDragBegin = false;
}

function dlgTitle_mousemove(e)
{
    if( ! isDragBegin) return;
    
    if(!e) e = window.event;    
    // move
    var xoff = e.clientX - beginDragX;
    var yoff = e.clientY - beginDragY;
    
    if(xoff == 0 && yoff == 0) 
        return;
    
    var dlg = document.getElementById("divDialogInner");
    dlg.clientX = dlg.clientX + xoff;
    dlg.clientY = dlg.clientY + yoff;
    
    beginDragX = e.clientX;
    endDragY = e.clientY; 
}


//
// 将设置的对话框应用到对话框中
//
function implyCfg()
{
    $("#divDialogInner").width(cfgObj.width);
    $("#divDialogInner").height(cfgObj.height);
    $("#dlgTitle").html(cfgObj.title);
    $("#iframeDlg").attr("src", cfgObj.url);
}

// 无用
function ShowNo()                        //隐藏两个层
{
    hideDialog();
    $("#iframeDlg").attr("src", "");
}

// 显示
function showFloat()                    //根据屏幕的大小显示两个层
{
    var range = getRange();
    $('#divDialogOuter').width(range.width);
    $('#divDialogOuter').height(range.height);
    $('#divDialogOuter').show();
    $('#divDialogInner').show();
}


function getRange()                      //得到屏幕的大小
{
      var top     = document.body.scrollTop;
      var left    = document.body.scrollLeft;
      var height  = document.body.clientHeight;
      var width   = document.body.clientWidth;

      if (top==0 && left==0 && height==0 && width==0)
      {
        top     = document.documentElement.scrollTop;
        left    = document.documentElement.scrollLeft;
        height  = document.documentElement.clientHeight;
        width   = document.documentElement.clientWidth;
      }
      return  {top:top ,left:left ,height:height ,width:width } ;
}




///////////////////////////////////////////////////////////////////////////////////////////////////////

//
// 接口：打开对话框
//
document.openDialog = function(sUrl, sTitle, callBack, nDlgWidth, nDlgHeight)
{
    if(typeof(nDlgWidth) == "undefined")
        nDlgWidth = 500;
    if(typeof(nDlgHeight) == "undefined")
        nDlgHeight = 300;
    
    if(cfgObj == null)
    {
        cfgObj = new cfgClass(sUrl, sTitle, callBack, nDlgWidth, nDlgHeight);
    }
    else
    {
        cfgObj.url = sUrl;
        cfgObj.title = sTitle;
        cfgObj.width = nDlgWidth;
        cfgObj.height = nDlgHeight;
        cfgObj.callBack = callBack;
    }
    
    implyCfg();
    showFloat();
}

//
// 接口：关闭对话框
// 
document.hideDialog = function()
{
    $("#divDialogOuter").hide();
    $("#divDialogInner").hide();
    
    //if(cfgObj.callBack)
    //    cfgObj.callBack("0");
}


//
// 接口：定义页面回调事件
//
document.onDialogCallBack = function(type, key, value)
{
	document.hideDialog();
    
    // 其它操作
    if(cfgObj != null && cfgObj.callBack)
    {
        cfgObj.callBack(type, key, value);
    }
}



