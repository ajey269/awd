<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calenderform.aspx.cs"
Inherits="Calenderform.Calenderform" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <title></title>
</head>
<body>
<form id="form1" runat="server">
 <div>
 <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66"
BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt"
ForeColor="#663399" Height="200px" ShowGridLines="True" Width="602px"
OnDayRender="Calendar1_DayRender" OnSelectionChanged="Calendar1_SelectionChanged"
SelectedDate="10/12/2024 12:34:57">
 <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
 <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
 <OtherMonthDayStyle ForeColor="#CC9966" />
 <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
 <SelectorStyle BackColor="#FFCC66" />
 <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
 <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
 </asp:Calendar>
 <br />
 <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
 <br />
 <br />
 <asp:Label ID="Label1" runat="server"></asp:Label>
 </div>
 </form>
</body>
</html>




Calenderform.aspx.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace Calenderform
{
 public partial class Calenderform : System.Web.UI.Page
 {
 protected void Page_Load(object sender, EventArgs e)
 {
 }
 protected void Calendar1_SelectionChanged(object sender, EventArgs e)
 {
 Calendar1.SelectedDayStyle.BackColor = System.Drawing.Color.Yellow;
 Calendar1.SelectedDayStyle.ForeColor= System.Drawing.Color.Green;
 }
 protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
 {
 if(e.Day.Date.Year==2024 && e.Day.Date.Month==8 && e.Day.Date.Day==15)
 {
 Label l1=new Label();
 l1.Text = "<br>INDEPENDENCE DAY";
 e.Cell.Controls.Add(l1);
 }
 if (e.Day.Date.Year == 2024 && e.Day.Date.Month == 10 && e.Day.Date.Day == 2)
 {
 Label l2 = new Label();
 l2.Text = "<br>MAHATNA GANDHI JAYANTI";
 e.Cell.Controls.Add(l2);
 e.Cell.BackColor= System.Drawing.Color.Red;
 }
 }
 protected void Button1_Click(object sender, EventArgs e)
 {
 Label1.Text = Calendar1.SelectedDate.ToString();
 }
 }
}
