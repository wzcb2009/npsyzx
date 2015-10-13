<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="Header2.ascx.vb" Inherits="Web.Header2" %>
  <style>
          body {
   
     background-image:url(images/body_bg2.png);
    background-repeat:no-repeat;
    background-position:center 0px ;
  }
  </style>
  <div class="masthead" style="margin-top:20px">
         <div class="row" style="margin-bottom:20px;">
            <div class="span10  ">
              <img src="images/logo4.png" />

            </div>
              <div class="span7 pull-right  " style="margin-top:20px;">
              
                   <input type="text" placeholder="请输入关键字" class="keywords" id="keywordt"><img id="searchbtn" src="images/search_btn_blue.png" />
                  
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
              <img src="images/top2.jpg" width="980" />
               

            </div>
        </div>
      </div>
 






  
  