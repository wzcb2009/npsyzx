function initEnv() {
    $("body").append(DWZ.frag["dwzFrag"]);

    if ($.browser.msie && /6.0/.test(navigator.userAgent)) {
        try {
            document.execCommand("BackgroundImageCache", false, true);
        } catch (e) { }
    }
    //清理浏览器内存,只对IE起效
    if ($.browser.msie) {
        window.setInterval("CollectGarbage();", 10000);
    }

    $(window).resize(function () {
        initLayout();
        $(this).trigger(DWZ.eventType.resizeGrid);
    });

    var ajaxbg = $("#background,#progressBar");
    ajaxbg.hide();
    $(document).ajaxStart(function () {
        ajaxbg.show();
    }).ajaxStop(function () {
        ajaxbg.hide();
    });

    $("#leftside").jBar({ minW: 150, maxW: 700 });

    if ($.taskBar) $.taskBar.init();
    navTab.init();
    if ($.fn.switchEnv) $("#switchEnvBox").switchEnv();
    if ($.fn.navMenu) $("#navMenu").navMenu();

    setTimeout(function () {
        initLayout();
        initUI();

        // navTab styles
        var jTabsPH = $("div.tabsPageHeader");
        jTabsPH.find(".tabsLeft").hoverClass("tabsLeftHover");
        jTabsPH.find(".tabsRight").hoverClass("tabsRightHover");
        jTabsPH.find(".tabsMore").hoverClass("tabsMoreHover");

    }, 10);

}
function initLayout() {
    var iContentW = $(window).width() - (DWZ.ui.sbar ? $("#sidebar").width() + 10 : 34) - 5;
    var iContentH = $(window).height() - $("#header").height() - 34;

    $("#container").width(iContentW);
    $("#container .tabsPageContent").height(iContentH - 34).find("[layoutH]").layoutH();
    $("#sidebar, #sidebar_s .collapse, #splitBar, #splitBarProxy").height(iContentH - 5);
    $("#taskbar").css({ top: iContentH + $("#header").height() + 5, width: $(window).width() });
}

function initUI(_box) {
    var $p = $(_box || document);

    $("div.panel", $p).jPanel();

    //tables
    $("table.table", $p).jTable();

    // css tables
    $('table.list', $p).cssTable();

    //auto bind tabs
    $("div.tabs", $p).each(function () {
        var $this = $(this);
        var options = {};
        options.currentIndex = $this.attr("currentIndex") || 0;
        options.eventType = $this.attr("eventType") || "click";
        $this.tabs(options);
    });

    $("ul.tree", $p).jTree();
    $('div.accordion', $p).each(function () {
        var $this = $(this);
        $this.accordion({ fillSpace: $this.attr("fillSpace"), alwaysOpen: true, active: 0 });
    });

    $(":button.checkboxCtrl, :checkbox.checkboxCtrl", $p).checkboxCtrl($p);

    if ($.fn.combox) $("select.combox", $p).combox();
    //编辑器加载更换到百毒编辑器 fix:corz
    if ($.Autocompleter) {
        $("input.autocomplete", $p).each(function () {

            var $this = $(this);

            var pk = $this.attr("pk");
            var thisname = $this.attr("name");

            var op = {
                max: 50,
                scroll: true,
                width: 262
            }
            var url = $this.attr("autourl");
            $this.autocomplete(url, op);


        });
        $("input.autocomplete2", $p).each(function () {

            var $this = $(this);

            var pk = $this.attr("pk");
            var thisname = $this.attr("name");

            var op = {
                max: 50,
                scroll: true,
                width: 262,
                formatItem: function (row, i, max) {
                    var obj = eval("(" + row + ")"); //转换成js对象 
                    return obj.title + '[' + obj.barcode + ']';
                },
                formatMatch: function (row, i, max) {
                    var obj = eval("(" + row + ")"); //转换成js对象 
                    return obj.title + obj.barcode;
                },
                formatResult: function (row) {
                    var obj = eval("(" + row + ")"); //转换成js对象 
                    var a = thisname.split(".");

                    var pkval;
                    pkval = eval("obj." + a[a.length - 1]);
                    return pkval;
                }
            }
            var url = $this.attr("autourl");
            $this.autocomplete(url, op).result(function (event, item) {
                var obj = eval("(" + item + ")"); //转换成js对象 
                var thisname = $this.attr("name");
                var a = thisname.split(".");

                if (pk) {
                    if (pk.indexOf(",") >= 0) {
                        var pks = pk.split(",");
                        for (var n = 0; n < pks.length; n++) {
                            var pkname;
                            pkname = thisname.replace(a[a.length - 1], pks[n]);
                            var pkval;
                            pkval = eval("obj." + pks[n]);

                            $("input[name='" + pkname + "']").val(pkval);

                        }
                    } else {
                        var pkname;
                        pkname = thisname.replace(a[a.length - 1], pk);
                        var pkval;
                        pkval = eval("obj." + pk);

                        $("input[name='" + pkname + "']").val(pkval);
                    }


                }


            });
        });
        $("input.autocomplete3", $p).each(function () {

            var $this = $(this);

            var pk = $this.attr("pk");

            var thisname = $this.attr("name");
            var suggestFields = $this.attr("AsuggestFields");
            var suggestField = suggestFields.split(",")
            var op = {
                max: 50,
                scroll: true,
                width: 262,
                formatItem: function (row, i, max) {
                    var obj = eval("(" + row + ")"); //转换成js对象 
                    return eval('obj.' + suggestField[0]) + ' ' + eval('obj.' + suggestField[1]);
                },
                formatMatch: function (row, i, max) {
                    var obj = eval("(" + row + ")"); //转换成js对象 
                    return eval('obj.' + suggestField[0]) + eval('obj.' + suggestField[1]);
                },
                formatResult: function (row) {
                    var obj = eval("(" + row + ")"); //转换成js对象 
                    var a = thisname.split(".");

                    var pkval;
                    pkval = eval("obj." + suggestField[1]);
                    return pkval;
                }

            }
            var url = $this.attr("autourl");
            $this.autocomplete(url, op).result(function (event, item) {
                var obj = eval("(" + item + ")"); //转换成js对象 
                var thisname = $this.attr("name");


                if (pk) {
                    var pks;
                    if (pk.indexOf(",") >= 0) {
                        pks = pk.split(",")
                        var pkval;
                        pkval = eval("obj." + pks[1]);

                        $("input[name='" + pks[0] + "']").val(pkval);

                    } else {

                        var pkval;
                        pkval = eval("obj." + suggestField[0]);

                        $("input[name='" + pk + "']").val(pkval);
                    }

                }


            });
        });

    }


    //	if ($.fn.xheditor) {
    //		$("textarea.editor", $p).each(function(){
    //			var $this = $(this);
    //			var op = {html5Upload:false, skin: 'vista',tools: $this.attr("tools") || 'full'};
    //			var upAttrs = [
    //				["upLinkUrl", "upLinkExt", "zip,rar,txt"],
    //				["upImgUrl","upImgExt","jpg,jpeg,gif,png"],
    //				["upFlashUrl","upFlashExt","swf"],
    //				["upMediaUrl","upMediaExt","avi"]
    //			];
    //			
    //			$(upAttrs).each(function(i){
    //				var urlAttr = upAttrs[i][0];
    //				var extAttr = upAttrs[i][1];
    //				
    //				if ($this.attr(urlAttr)) {
    //					op[urlAttr] = $this.attr(urlAttr);
    //					op[extAttr] = $this.attr(extAttr) || upAttrs[i][2];
    //				}
    //			});
    //			
    //			$this.xheditor(op);
    //		});
    //	}

    //kindeditor
    if ($.fn.xheditor) {
        $("textarea.kindeditor", $p).each(function () {
            $.getScript('../kindeditor/kindeditor-min.js', function () {
                KindEditor.basePath = '../kindeditor/';
                var editor = KindEditor.create('textarea[name="content"]', {
                    uploadJson: '../kindeditor/asp.net/upload_json.ashx',
                    fileManagerJson: '../kindeditor/asp.net/file_manager_json.ashx',
                    allowFileManager: true,
                    afterBlur: function () { editor.sync(); },
                    afterCreate: function () {
                        var self = this;
                        KindEditor.ctrl(document, 13, function () {
                            self.sync();
                            K('form[name=form1]')[0].submit();
                        });
                        KindEditor.ctrl(self.edit.doc, 13, function () {
                            self.sync();
                            KindEditor('form[name=form1]')[0].submit();
                        });
                    }
                });
            });
        });
    }
    //百度
//    if ($.fn.xheditor) {
//        if ($("textarea.editor", $p).length > 0) {
//            var module = $("textarea.editor", $p).attr('module');
//            ueditor_loader[module] = {};
//            $("textarea.editor", $p).each(function (i) {
//                var $this = $(this);
//                var module = $this.attr('module');
//                var thisid = module + '_' + i;
//                $this.attr('id', thisid);
//                var uplink = $this.attr('upLink');
//                var session = $this.attr('session');
//                var ifheight = $this.attr('height') ? $this.attr('height') : 320;
//                //var thisname=$this.attr('name');
//                ueditor_loader[module][i] = new baidu.editor.ui.Editor({
//                    minFrameHeight: ifheight
//, imageUrl: uplink + 'image_upload'
//                    //,snapscreenServerUrl:uplink+'image_upload'
//, fileUrl: uplink + 'file_upload?' + session
//, catcherUrl: uplink + 'get_remote_image'
//, imageManagerUrl: uplink + 'image_manager'
//, wordImageUrl: uplink + 'image_upload'
//, getMovieUrl: uplink + 'get_movie'
//                    //,textarea:thisname
//                });
//                ueditor_loader[module][i].render($this[0]);
//            });
//        }
//    }

    if ($.fn.uploadify) {
        $(":file[uploader]", $p).each(function () {
            var $this = $(this);
            var options = {
                uploader: $this.attr("uploader"),
                script: $this.attr("script"),
                buttonImg: $this.attr("buttonImg"),
                cancelImg: $this.attr("cancelImg"),
                queueID: $this.attr("fileQueue") || "fileQueue",
                fileDesc: $this.attr("fileDesc"),
                fileExt: $this.attr("fileExt"),
                folder: $this.attr("folder"),
                fileDataName: $this.attr("name") || "file",
                auto: $this.attr("auto") || false,
                multi: true,
                onError: uploadifyError,
                onComplete: uploadifyComplete,
                onAllComplete: uploadifyAllComplete
            };
            if ($this.attr("onComplete")) {
                options.onComplete = DWZ.jsonEval($this.attr("onComplete"));
            }
            if ($this.attr("onAllComplete")) {
                options.onAllComplete = DWZ.jsonEval($this.attr("onAllComplete"));
            }
            if ($this.attr("scriptData")) {
                options.scriptData = DWZ.jsonEval($this.attr("scriptData"));
            }
            $this.uploadify(options);
        });
    }

    // init styles
    $("input[type=text], input[type=password], textarea", $p).addClass("textInput").focusClass("focus");

    $("input[readonly], textarea[readonly]", $p).addClass("readonly");
    $("input[disabled=true], textarea[disabled=true]", $p).addClass("disabled");

    $("input[type=text]", $p).not("div.tabs input[type=text]", $p).filter("[alt]").inputAlert();

    //Grid ToolBar
    $("div.panelBar li, div.panelBar", $p).hoverClass("hover");

    //Button
    $("div.button", $p).hoverClass("buttonHover");
    $("div.buttonActive", $p).hoverClass("buttonActiveHover");

    //tabsPageHeader
    $("div.tabsHeader li, div.tabsPageHeader li, div.accordionHeader, div.accordion", $p).hoverClass("hover");

    //validate form
    $("form.required-validate", $p).each(function () {
        var $form = $(this);
        $form.validate({
            onsubmit: false,
            focusInvalid: false,
            focusCleanup: true,
            errorElement: "span",
            ignore: ".ignore",
            invalidHandler: function (form, validator) {
                var errors = validator.numberOfInvalids();
                if (errors) {
                    var message = DWZ.msg("validateFormError", [errors]);
                    alertMsg.error(message);
                }
            }
        });

        $form.find('input[customvalid]').each(function () {
            var $input = $(this);
            $input.rules("add", {
                customvalid: $input.attr("customvalid")
            })
        });
    });

    if ($.fn.datepicker) {
        $('input.date', $p).each(function () {
            var $this = $(this);
            var opts = {};
            if ($this.attr("dateFmt")) opts.pattern = $this.attr("dateFmt");
            if ($this.attr("minDate")) opts.minDate = $this.attr("minDate");
            if ($this.attr("maxDate")) opts.maxDate = $this.attr("maxDate");
            if ($this.attr("mmStep")) opts.mmStep = $this.attr("mmStep");
            if ($this.attr("ssStep")) opts.ssStep = $this.attr("ssStep");
            $this.datepicker(opts);
        });
    }

    // navTab
    $("a[target=navTab]", $p).each(function () {
        $(this).click(function (event) {
            var $this = $(this);
            var title = $this.attr("title") || $this.text();
            var tabid = $this.attr("rel") || "_blank";
            var fresh = eval($this.attr("fresh") || "true");
            var external = eval($this.attr("external") || "false");
            var url = unescape($this.attr("href")).replaceTmById($(event.target).parents(".unitBox:first"));
            DWZ.debug(url);
            if (!url.isFinishedTm()) {
                alertMsg.error($this.attr("warn") || DWZ.msg("alertSelectMsg"));
                return false;
            }
            navTab.openTab(tabid, url, { title: title, fresh: fresh, external: external });

            event.preventDefault();
        });
    });

    //dialogs
    $("a[target=dialog]", $p).each(function () {
        $(this).click(function (event) {
            var $this = $(this);
            var title = $this.attr("title") || $this.text();
            var rel = $this.attr("rel") || "_blank";
            var options = {};
            var w = $this.attr("width");
            var h = $this.attr("height");
            if (w) options.width = w;
            if (h) options.height = h;
            options.max = eval($this.attr("max") || "false");
            options.mask = eval($this.attr("mask") || "false");
            options.maxable = eval($this.attr("maxable") || "true");
            options.minable = eval($this.attr("minable") || "true");
            options.fresh = eval($this.attr("fresh") || "true");
            options.resizable = eval($this.attr("resizable") || "true");
            options.drawable = eval($this.attr("drawable") || "true");
            options.close = eval($this.attr("close") || "");
            options.param = $this.attr("param") || "";

            var url = unescape($this.attr("href")).replaceTmById($(event.target).parents(".unitBox:first"));
            DWZ.debug(url);
            if (!url.isFinishedTm()) {
                alertMsg.error($this.attr("warn") || DWZ.msg("alertSelectMsg"));
                return false;
            }
            $.pdialog.open(url, rel, title, options);

            return false;
        });
    });
    $("a[target=selecteddialog]", $p).each(function () {
        var $this = $(this);
        var selectedIds = $this.attr("rel") || "ids";
        var postType = $this.attr("postType") || "map";
        function _getIds(selectedIds, targetType) {
            var ids = "";
            var $box = targetType == "dialog" ? $.pdialog.getCurrent() : navTab.getCurrentPanel();
            $box.find("input:checked").filter("[name='" + selectedIds + "']").each(function (i) {
                var val = $(this).val();
                ids += i == 0 ? val : "," + val;
            });
            return ids;
        }
        $(this).click(function (event) {
            var $this = $(this);
            var targetType = $this.attr("targetType");
            var ids = _getIds(selectedIds, targetType);
            if (!ids) {
                alertMsg.error($this.attr("warn") || DWZ.msg("alertSelectMsg"));
                return false;

            }
            var title = $this.attr("title") || $this.text();
            var rel = $this.attr("rel") || "_blank";
            var options = {};
            var w = $this.attr("width");
            var h = $this.attr("height");
            if (w) options.width = w;
            if (h) options.height = h;
            options.max = eval($this.attr("max") || "false");
            options.mask = eval($this.attr("mask") || "false");
            options.maxable = eval($this.attr("maxable") || "true");
            options.minable = eval($this.attr("minable") || "true");
            options.fresh = eval($this.attr("fresh") || "true");
            options.resizable = eval($this.attr("resizable") || "true");
            options.drawable = eval($this.attr("drawable") || "true");
            options.close = eval($this.attr("close") || "");
            options.param = $this.attr("param") || "";

            var url = unescape($this.attr("href") + "&ids=" + ids);
            DWZ.debug(url);
            if (!url.isFinishedTm()) {
                alertMsg.error($this.attr("warn") || DWZ.msg("alertSelectMsg"));
                return false;
            }
            $.pdialog.open(url, rel, title, options);

            return false;
        });
    });
    $("a[target=ajax]", $p).each(function () {
        $(this).click(function (event) {
            var $this = $(this);
            var rel = $this.attr("rel");
            if (rel) {
                var $rel = $("#" + rel);
                $rel.loadUrl($this.attr("href"), {}, function () {
                    $rel.find("[layoutH]").layoutH();
                });
            }

            event.preventDefault();
        });
    });

    $("div.pagination", $p).each(function () {
        var $this = $(this);
        $this.pagination({
            targetType: $this.attr("targetType"),
            rel: $this.attr("rel"),
            totalCount: $this.attr("totalCount"),
            numPerPage: $this.attr("numPerPage"),
            pageNumShown: $this.attr("pageNumShown"),
            currentPage: $this.attr("currentPage")
        });
    });

    if ($.fn.sortDrag) $("div.sortDrag", $p).sortDrag();

    // dwz.ajax.js
    if ($.fn.ajaxTodo) $("a[target=ajaxTodo]", $p).ajaxTodo();
    if ($.fn.ajaxTodoReflesh) $("a[target=ajaxTodoReflesh]", $p).ajaxTodoReflesh();
    if ($.fn.dwzExport) $("a[target=dwzExport]", $p).dwzExport();

    if ($.fn.lookup) $("a[lookupGroup]", $p).lookup();
    if ($.fn.multLookup) $("[multLookup]:button", $p).multLookup();
    if ($.fn.suggest) $("input[suggestFields]", $p).suggest();
    if ($.fn.itemDetail) $("table.itemDetail", $p).itemDetail();
    if ($.fn.selectedTodo) $("a[target=selectedTodo]", $p).selectedTodo();
    if ($.fn.selectedToDialog) $("a[target=selectedToDialog]", $p).selectedToDialog();
    if ($.fn.pagerForm) $("form[rel=pagerForm]", $p).pagerForm({ parentBox: $p });

    // 这里放其他第三方jQuery插件...
    //treetables
    $("table.treetable", $p).treetable({ expandable: false });
    //$("table.tablednd", $p).tableDnD({
    //    onDrop: function (table, row) {
    //        alert($(row).attr("rel"));

    //        var rows = table.tBodies[0].rows;
    //        var debugStr = "Row dropped was " + row.rel + ". New order: ";
    //        for (var i=0; i<rows.length; i++) {
    //           // debugStr += rows[i].rel + " ";
    //        }
    //       // alert(debugStr);

    //    },
    //    onDragStart: function(table, row) {
    //        //$(#debugArea).html("Started dragging row "+row.id);
    //    }
    //});
}


