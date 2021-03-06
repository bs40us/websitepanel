<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebSitesEditVirtualDir.ascx.cs" Inherits="WebsitePanel.Portal.WebSitesEditVirtualDir" %>
<%@ Register Src="WebSitesExtensionsControl.ascx" TagName="WebSitesExtensionsControl" TagPrefix="uc6" %>
<%@ Register Src="WebSitesCustomErrorsControl.ascx" TagName="WebSitesCustomErrorsControl" TagPrefix="uc4" %>
<%@ Register Src="WebSitesMimeTypesControl.ascx" TagName="WebSitesMimeTypesControl" TagPrefix="uc5" %>
<%@ Register Src="WebSitesHomeFolderControl.ascx" TagName="WebSitesHomeFolderControl" TagPrefix="uc1" %>
<%@ Register Src="WebSitesCustomHeadersControl.ascx" TagName="WebSitesCustomHeadersControl" TagPrefix="uc6" %>
<%@ Register Src="UserControls/EnableAsyncTasksSupport.ascx" TagName="EnableAsyncTasksSupport" TagPrefix="wsp" %>

<wsp:EnableAsyncTasksSupport id="asyncTasks" runat="server"/>

<div class="FormBody">
<table width="100%">
    <tr>
        <td width="100%" valign="top">
            <table>
                <tr>
                    <td class="Big">
                        <asp:HyperLink ID="lnkSiteName" runat="server" NavigateUrl="#" Target="_blank">domain.com/vdir</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
            <table width="100%" cellpadding="0" cellspacing="1">
                <tr>
                    <td class="Tabs">
                        &nbsp;&nbsp;
                        <asp:DataList ID="dlTabs" runat="server" RepeatDirection="Horizontal"
                            OnSelectedIndexChanged="dlTabs_SelectedIndexChanged" RepeatLayout="Flow">
                            <ItemStyle Wrap="False" />
                            <ItemTemplate>
                                <asp:LinkButton ID="cmdSelectTab" runat="server" CommandName="select" CssClass="Tab">
                                    <%# Eval("Name") %>
                                </asp:LinkButton>
                            </ItemTemplate>
                            <SelectedItemStyle Wrap="False" />
                            <SelectedItemTemplate>
                                <asp:LinkButton ID="cmdSelectTab" runat="server" CommandName="select" CssClass="ActiveTab">
                                    <%# Eval("Name") %>
                                </asp:LinkButton>
                            </SelectedItemTemplate>
                        </asp:DataList>
                    </td>
                </tr>
            </table>
            <div class="FormBody">
               <asp:MultiView ID="tabs" runat="server" ActiveViewIndex="0">
                <asp:View ID="tabHomeFolder" runat="server">
                    <uc1:WebSitesHomeFolderControl ID="webSitesHomeFolderControl" runat="server" IsVirtualDirectory="true" />
                </asp:View>
                
                <asp:View ID="tabExtensions" runat="server">
                    <uc6:WebSitesExtensionsControl ID="webSitesExtensionsControl" runat="server" IsVirtualDirectory="true" />
                </asp:View>
                
                <asp:View ID="tabErrors" runat="server">
                    <uc4:WebSitesCustomErrorsControl ID="webSitesCustomErrorsControl" runat="server" />
                </asp:View>
                
                <asp:View ID="tabHeaders" runat="server">
                    <uc6:WebSitesCustomHeadersControl ID="webSitesCustomHeadersControl" runat="server" />
                </asp:View>
                
                <asp:View ID="tabMimes" runat="server">
                    <uc5:WebSitesMimeTypesControl ID="webSitesMimeTypesControl" runat="server" />
                </asp:View>
                
               </asp:MultiView>
            </div>
        </td>
    </tr>
</table>
</div>
<div class="FormFooter">
    <asp:Button ID="btnUpdate" runat="server" Text="Update" meta:resourcekey="btnUpdate" CssClass="Button1"
        OnClick="btnUpdate_Click"
        OnClientClick="ShowProgressDialog('Updating virtual directory...');" />
    <asp:Button ID="btnCancel" runat="server" Text="Cancel" meta:resourcekey="btnCancel" CssClass="Button1"
        CausesValidation="false" OnClick="btnCancel_Click" />
    <asp:Button ID="btnDelete" runat="server" Text="Delete" meta:resourcekey="btnDelete" CssClass="Button1"
        CausesValidation="false" OnClientClick="return confirm('Delete this virtual directory?');" OnClick="btnDelete_Click" />
</div>