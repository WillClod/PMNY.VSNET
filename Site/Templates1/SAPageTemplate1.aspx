<%@ Page 
    Language="C#" 
    MasterPageFile="~/Site/Site.Master" 
    AutoEventWireup="true" 
    CodeBehind="SAPageTemplate1.aspx.cs" 
    Inherits="VSNetTemplates.Site.Templates1.SAPageTemplate1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <!-- Page Settings -->
    <title>Template1</title>  
    <link rel="shortcut icon" href="../../Images/IntelywareLogo.png" />

    <!-- Page Style -->
    <!-- <link href="~/Styles/PageMobile.css" rel="Stylesheet" type="text/css"/> -->

    <!-- JQuery -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js" type="text/javascript"></script>

    <!-- Bootstrap -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet"/>
    <link href="https://getbootstrap.com/docs/5.3/assets/css/docs.css" rel="stylesheet"/>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" type="text/javascript"></script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="divHeader" class="divHeader">
        
        <div id="divButtonsHeader">

        </div>
        
    </div>  
            
    <div id="divBody" class ="divBody">   
                
    </div>

    <div id="divFooter" class ="divFooter">

        <div id="divButtonsFooter">

            
        </div>
                
        <div id="divDataSources">


        </div>

    </div>
    
</asp:Content>

