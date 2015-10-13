function strToJson(str) {
    var json = eval('(' + str + ')');
    return json;
}
function uploadifyComplete(event, queueId, fileObj, response, data) {
    var s, t;
    var file = DWZ.jsonEval(response);

    s = "<li id='file" + file.fileid + "'>";

    s = s + "<div class='ico'><img src='../file/images/" + file.ext + ".jpg'/></div>";

    s = s + "<div class='main'><a class='title' href='../file/filedown.aspx?fileid=" + file.fileid + "'>" + fileObj.name + "</a><a class='del' onclick='delfile(" + file.fileid + ")'></a><div class='info'> 上传时间：" + file.pubdate + "</div></div>";
    s = s + "</li><li class='clearbox'></li>";
    t = "<input name='fileid' value='" + file.fileid + "' type='hidden' />";
    $("#filesinput", navTab.getCurrentPanel()).append(t);
    $(".filelist", navTab.getCurrentPanel()).append(s);
    // DWZ.ajaxDone(DWZ.jsonEval(response));
}
function uploadifyComplete31(event, queueId, fileObj, response, data) {
    var s, t;
    var file = strToJson(response);
    alert(data);
    s = "<li id='file" + file.fileid + "'>";

    s = s + "<div class='ico'><img src='../file/images/" + file.ext + ".jpg'/></div>";

    s = s + "<div class='main'><a class='title' href='../file/filedown.aspx?fileid=" + file.fileid + "'>" + fileObj.name + "</a><a class='del' onclick='delfile(" + file.fileid + ")'></a><div class='info'> 上传时间：" + file.pubdate + "</div></div>";
    s = s + "</li><li class='clearbox'></li>";
    t = "<input name='fileid' value='" + file.fileid + "' type='hidden' />";
    $("#filesinput").append(t);
    $(".filelist").append(s);
    // DWZ.ajaxDone(DWZ.jsonEval(response));
}

function uploadifyComplete(fileObj, data, response) {
   
    var s, t;
    var file = DWZ.jsonEval(response);
       DWZ.ajaxDone(file);
       if (file.statusCode == DWZ.statusCode.ok) {
        
 s = "<li id='file" + file.fileid + "'>";

    s = s + "<div class='ico'><img src='../file/images/" + file.ext + ".jpg'/></div>";

    s = s + "<div class='main'><a class='title'  href='../file/filedown.aspx?fileid=" + file.fileid + "'>" + fileObj.name + "</a><a class='del' onclick='delfile(" + file.fileid + ")'></a><div class='info'> 上传时间：" + file.pubdate + "</div></div>";
    s = s + "</li><li class='clearbox'></li>";
    t = "<input name='fileid' value='" + file.fileid + "' type='hidden' />";
    $("#filesinput", navTab.getCurrentPanel()).append(t);
    $(".filelist", navTab.getCurrentPanel()).append(s);
    }

   
}
function uploadifyComplete2(fileObj, data, response) {

    var s, t;
    var file = DWZ.jsonEval(data);
     if (file.statusCode == DWZ.statusCode.ok) {


        $("#userFace", navTab.getCurrentPanel()).attr("src", file.filepath);
        $("#userFaceFileid", navTab.getCurrentPanel()).val(file.fileid);
    }


}
function uploadifyComplete3(fileObj, data, response) {

    var s, t;
    var file = strToJson(data);
   
     if (file.statusCode == 200) {


        s = "<li id='file" + file.fileid + "'>";

        s = s + "<div class='ico'><img src='../file/images/" + file.ext + ".jpg'/></div>";

        s = s + "<div class='main'><a class='title' href='../file/filedown.aspx?fileid=" + file.fileid + "'>" + fileObj.name + "</a><a class='del' onclick='delfile2(" + file.fileid + ")'></a><div class='info'> 上传时间：" + file.pubdate + "</div></div>";
        s = s + "</li><li class='clearbox'></li>";
        t = "<input name='fileid' value='" + file.fileid + "' type='hidden' />";
        $("#filesinput").append(t);
        $("#filelist2").append(s);
     } else if (file.statusCode == 301) {
         alert("登陆超时");
         window.location = "loginweb.aspx";
     
     }


}
function delfile(fileid) {
    $(function () {
        alertMsg.confirm("您确认要删除该文件吗？", {

            okCall: function () {

                $.post("../file/filedel.aspx", { "fileid": fileid }, DWZ.ajaxDone, "json");
                $("#file" + fileid, navTab.getCurrentPanel()).slideUp(500, function () {
                    $(this).remove();
                });
                $("input[value='" + fileid + "']", navTab.getCurrentPanel()).remove();

            }

        });


    });
}
function delfile2(fileid) {
    $(function () {
        if (confirm("您确认要删除该文件吗？")){
            $.post("../file/filedel.aspx", { "fileid": fileid }, function (data) {
  $("#file" + fileid ).slideUp(500, function () {
                    $(this).remove();
                });
                $("input[value='" + fileid + "']" ).remove();
            }, "json");
              
        } 


    });
}

