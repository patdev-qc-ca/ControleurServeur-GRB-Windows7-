<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .auto-style13 {
            text-align: center;
        }
        .auto-style23 {
            height: 64px;
        }
        .auto-style24 {
            height: 167px;
        }
    </style>
</head>
<body>
    <script>
        function Imprimer()
        {
            var pane = document.getElementById("<%= Impression.ClientID %>");
            var MainWindow = window.open('', '', 'Width=1280px height=768px');
            MainWindow.document.write('<html><head><title>');
            MainWindow.document.write(document.title);
            MainWindow.document.write('</title > ');
            MainWindow.document.write('</head><body>');
            MainWindow.document.write(pane.innerHTML);
            MainWindow.document.write('</body></html>');
            MainWindow.document.close();
            setTimeout(function () {
            MainWindow.print();
            }, 500);
            return false;
        }
    </script>
    <form id="form1" runat="server">
        <header>
            <H1><%=AutoGRB.Noyau.appTitre %></H1><asp:Button ID="Button2" runat="server" OnClientClick="return Imprimer();" Text="Imprimer" style="text-align: right" />
        </header>
        <div>
            <asp:Panel ID="Impression" runat="server" GroupingText="Fabrication - Fermeture Mécanique" Width="881px">
                <table width="100%">
                    <tr>
                        <td colspan="2"><H2><%= Impression.GroupingText %></H2></td>
                        <td style="width:33%; text-align:right;">
                            <img src="images/logo GRB-inc.2.bmp" class="auto-style23" />
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td></td>
                        <td>149, rue Pierre Paradis<br />St-Alphonse-de-Granby, QC J0E 2A4</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td></td>
                        <td>Tel: (450) 372-0021  <br />Fax: (450) 372-3860</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>

                <!-- entete -->

                <table border="1" width="100%">
                    <tr>
                        <td class="auto-style13">
                            <asp:Label ID="Label17" runat="server" Text="Dessins Mécaniques"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style24">
                            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None" Width="100%">
                                <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                                <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                                <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                                <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#594B9C" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#33276A" />
                            </asp:GridView>
                        </td>
                    </tr>
                </table>

                <table>
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Font-Size="X-Large" Font-Underline="True" Text=" "></asp:Label>
                        </td>
                    </tr>
                    <tr align="center">
                        <td>
                            <asp:Label ID="Label18" runat="server" Text="#" Width="50px"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label30" runat="server" Text="Type" Width="100px"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label31" runat="server" Text="Dessins" Width="200px"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label32" runat="server" Text="No" Width="100px"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label27" runat="server" Text="Date" Width="100px"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label28" runat="server" Text="Nbre de page" Width="150px"></asp:Label>
                        </td>
                    </tr>
                </table>
                <hr />
                Détails (Section1)
                <hr />
                Pied d'état (Section5)
                <hr />

            </asp:Panel>
        </div>
    </form>
</body>
</html>
