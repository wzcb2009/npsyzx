function tj(i) {
    $(function () {

        if (i == 1) {
            alertMsg.confirm("您确定要提交项目吗，提交后不能再修改，若您还要继续修改项目，请先保存！", {
                okCall: function () {
                    $("#prochecked", navTab.getCurrentPanel()).val("1");
                    $("#form1", navTab.getCurrentPanel()).submit();
                }

            });
        } else if (i == 0) {
            $("#prochecked", navTab.getCurrentPanel()).val(0);
            $("#form1", navTab.getCurrentPanel()).submit();
        } else {
            alertMsg.confirm("您确定要取消保存项目吗？", {
                okCall: function () {
                    navTab.closeCurrentTab();

                }

            });
        }




    });
}