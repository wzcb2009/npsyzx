<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="Header.ascx.vb" Inherits="Web.Header" %>
 <style>
    body {
   
     background-image:url(images/body_bg.png);
    background-repeat:no-repeat;
    background-position:center -20px ;
  }
    .tzgg .hd{
        font-size:14px;
        height:30px;
        line-height:30px;
        vertical-align:middle;
        font-weight:bold;
        padding-left:20px;
        height:28px;
    }
    .tzgg .bd .dateinfo{
        width:60px;
        height:50px;
        float:left;
    }
    .tzgg .bd .dateinfo .title{
        font-size:20px;
  }
        .tzgg .bd .dateinfo .d{
        font-size:14px;
        width:50px;
        display:block;
        height:30px;
        text-align:center;
        color:#a00606;
    }
        .tzgg .bd .dateinfo .ym{
        font-size:13px;
         display:block;
        height:30px;
         text-align:center;
         color:#808080;
    
  }
  .tzgg .bd .title  {
        font-size:14px;
             float:left;
        width:170px;
        padding-left:5px;
        border-left:1px solid #e5e5e5;
        
  }

</style>




  <div class="masthead" style="margin-top:20px">
         <div class="row" style="margin-bottom:20px;">
            <div class="span10  ">
              <img src="images/logo4.png" />

            </div>
              <div class="span7 pull-right  " style="margin-top:20px;">
              
                   <input type="text" id="keywordt" placeholder="请输入关键字" class="keywords"><img id="searchbtn" src="images/search_btn_blue.png" />
                  
            </div>
        </div>
     
         <div class="navbar">
          <div class="navbar-inner">
            <div class="container">
       <button type="button" class="btn btn-navbar" data-toggle="collapse" data-target=".nav-collapse">
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
          </button>
                 <div class="nav-collapse collapse navbar-responsive-collapse">
                      <ul class="nav">
               <asp:Literal ID="lt_menu" runat="server"></asp:Literal>
                          </ul>

                   
                             <div class="navbar-search pull-right input-append">
 
   
    </div>
                    
                   
                 
                     </div>
            </div>
          </div>
        </div><!-- /.navbar -->
       <div class="row">
            <div class="span20 logobg" style="position:relative">
                <!--Basic example-->
<div class="flicker-example" data-block-text="false">
  <ul>
    <li data-background="images/1.jpg">
      
    </li>
    <li data-background="images/2.jpg">
    
    </li>
    <li data-background="images/3.jpg">
   
    </li>
  </ul>
</div>
             
                <div class="tzgg">
                    <div class="hd">
                        周行事历
                    </div>
                    <div class="bd">
                    <asp:Literal ID="lt_xsl" runat="server"></asp:Literal>

                    </div>
                </div>
            </div>
        </div>
      </div>
 



  
  