<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="Footer.ascx.vb" Inherits="Web.Footer" %>

 <!-- Footer
    ================================================== -->
 <div class="footer">
      <div class="container">
          <div class="row">
              <div class="span20" style="padding:5px;"> <asp:Literal ID="Literal1" runat="server"></asp:Literal> </div>
             
          </div>
        
         
       </div>
    </div>
<script src="Plugins/jquery.js"></script>
<script src="Plugins/ddouble-bsie/bootstrap/js/bootstrap.js"></script>
 <!--[if lte IE 6]>
  <!-- bsie js patch, it will only execute in IE6 -->
  <script type="text/javascript" src="Plugins/ddouble-bsie/bootstrap/js/bootstrap-ie.js"></script>
  <![endif]-->


<script src="Plugins/jquery.scrollUp.min.js"></script>
<script src="Plugins/jquery.unveil.min.js"></script>
<!--[if lte IE 6]>
<script src="Plugins/ddouble-bsie/bootstrap/js/bootstrap-affix.js"></script>
 <script src="Plugins/ddouble-bsie/bootstrap/js/bootstrap-alert.js"></script>
    <script src="Plugins/ddouble-bsie/bootstrap/js/bootstrap-button.js"></script>
<script src="Plugins/ddouble-bsie/bootstrap/js/bootstrap-carousel.js"></script>
<script src="Plugins/ddouble-bsie/bootstrap/js/bootstrap-collapse.js"></script>
<script src="Plugins/ddouble-bsie/bootstrap/js/bootstrap-dropdown.js"></script>
<script src="Plugins/ddouble-bsie/bootstrap/js/bootstrap-modal.js"></script>
<script src="Plugins/ddouble-bsie/bootstrap/js/bootstrap-popover.js"></script>
<script src="Plugins/ddouble-bsie/bootstrap/js/bootstrap-scrollspy.js"></script>
<script src="Plugins/ddouble-bsie/bootstrap/js/bootstrap-tab.js"></script>
<script src="Plugins/ddouble-bsie/bootstrap/js/bootstrap-tooltip.js"></script>
<script src="Plugins/ddouble-bsie/bootstrap/js/bootstrap-transition.js"></script>
    <script src="Plugins/ddouble-bsie/bootstrap/js/bootstrap-typeahead.js"></script>
  <![endif]-->
<script src="jpkc.js"></script>
    <script>
    $(function(){if($.browser.msie&&parseInt($.browser.version,10)===6){$('.row div[class^="span"]:last-child').addClass("last-child");$('[class*="span"]').addClass("margin-left-20");$(':button[class="btn"], :reset[class="btn"], :submit[class="btn"], input[type="button"]').addClass("button-reset");$(":checkbox").addClass("input-checkbox");$('[class^="icon-"], [class*=" icon-"]').addClass("icon-sprite");$(".pagination li:first-child a").addClass("pagination-first-child")}})
</script>
<script src="Plugins/jquery.lazyload.js"></script>
<script src="Plugins/autoIMG/jQuery.autoIMG.js"></script>
<script src="Plugins/slider.js"></script>
<script src="Plugins/jquery.slideBox.min.js"></script>
<script src="Plugins/jQuery.jquery-finger/js/min/modernizr-custom-v2.7.1.min.js" type="text/javascript"></script>
<script src="Plugins/jQuery.jquery-finger/js/min/jquery-finger-v0.1.0.min.js" type="text/javascript"></script>
<!--Include flickerplate-->
<link href="Plugins/jQuery.jquery-finger/css/flickerplate.css"  type="text/css" rel="stylesheet">
<script src="Plugins/jQuery.jquery-finger/js/min/flickerplate.min.js" type="text/javascript"></script>
<!--Execute flickerplate-->
<script>
    $(document).ready(function () {

        $('.flicker-example').flicker();
    });
	</script>
 <script>
     $(document).ready(function () {

         $('#myTab a').click(function (e) {
             e.preventDefault();
             $(this).tab('show');
         })
          
         $(".thumbnail").autoIMG();
         $(".thumbnails img").lazyload({
             placeholder: "images/blank.gif",
             effect: "fadeIn"
         });

         $("img.lazy").unveil();
         $('.carousel').carousel();
         $.scrollUp({
             scrollName: 'scrollUp', // Element ID
             topDistance: '300', // Distance from top before showing element (px)
             topSpeed: 300, // Speed back to top (ms)
             animation: 'fade', // Fade, slide, none
             animationInSpeed: 200, // Animation in speed (ms)
             animationOutSpeed: 200, // Animation out speed (ms)
             scrollText: '', // Text for element
             activeOverlay: false  // Set CSS color to display scrollUp active point, e.g '#00FFFF'
         });
     });
    </script>
 <script>
     $(document).ready(function () {
         $('#demo2').slideBox({
             direction: 'top',//left,top#方向
             duration: 0.3,//滚动持续时间，单位：秒
             easing: 'linear',//swing,linear//滚动特效
             delay: 5,//滚动延迟时间，单位：秒
             startIndex: 1//初始焦点顺序
         });
         //默认状态下左右滚动
         $("#s1").xslider({
             unitdisplayed: 4,
             movelength: 1,
             unitlen: 176,
             autoscroll: 3000
         });
         //默认状态下左右滚动
         $("#s2").xslider({
             unitdisplayed: 4,
             movelength: 1,
             unitlen: 176,
             autoscroll: 3000
         });

         $("#loginbt").click(function () {
             $.post("user/userlogindo.aspx",
                 { 'action': 'login', 'username': $("#Username").val(), 'pwd': $('#pwd').val() },
                 function (data) {
                     if (data.result == 'ok') {
                         window.location = "default.aspx";
                     } else {
                         alert('用户名或者密码错误！');
                     }
                 },
                 'json');
         });
         $("#searchbtn").click(function () {
             var k;
             k = $("#keywordt").val();
             if (k != "") {
                 window.location = "websearch.aspx?keyword=" + k;

             }
         }

          );
     });
 </script>