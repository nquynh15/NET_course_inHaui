   M S B A M L   `   `   `  ????E  ADe3KtraTX2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:De3KtraTX2
De3KtraTX2  5   	       De3KtraTX2.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:De3KtraTX2     5   	   -   5          ? Title$  Bài kiểm tra số 2??5   	   $	??450??6#   $	??800??60   $??20(?6<   .??5
      ?  ? ColumnDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5       ? RowDefinitions 5   
   ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      .+?5   
   ?? $??0??6   $??7??6   $??2??6/   
??? ???$??2q?6X   $??5q?5      
???????6   ?? 5   
   $??0??6   $??2??6   $??Quản lý nhân viên??61   $??Center=?5      $??Center=?6-    	  title#??[  6H   ?? 5   
   $??1??6   $??0??6   $??Họ tên nhân viên: ??6-   ?? 5    
   -   5         ??Name$ txtHoTen??5       $??1??6$   $??1??61   $	??250??6A   $??40??6M   $??10 5 5 5q?5!      $
??Left=?6$   $??Center=?6?   ?? 5#   
   $??2??6   $??0??6   $??Loại nhân viên: ??6-   ?? 5$   
   $??2??6   $??1??6    $	??200??61   $??40??6=   $??10 5 5 5q?5%      $
??Left=?6$   $??Center=?6?   .@?5&      ?? -   5        $??cbCoHuu??5&      $??	Cơ hữu??6*   ?? 5'      -   5        $??	cbHopDong??5'      $??Hợp đồng??6,   ?? 5(      -   5        $??cbCTV??5(      $??Cộng tác viên??6(   5)      ?? 5+   
   $??3??6   $??0??6   $??Ngày sinh: ??6-   (  "System.Windows.Controls.DatePicker  5,   
   -   5          Name$ 
dtNgaySinh??5,      $??3??6)   $??1??66      SelectedDate 
11/29/20006F   $	??200??5-      $??40??6!   $??10 5 5 5q?6-   $
??Left=?5.      $??Center=?60   ?? 50   
   $??4??6   $??0??6   $??Số tiền bán hàng: ??6-   ?? 51   
   -   5        $ 	txtSoTien??51      $??4??6%   $??1??62   $	??200??6B   $??40??6N   $??10 5 5 5q?52      $
??Left=?6$   $??Center=?6?   &   System.Windows.Controls.DataGrid  54   
   -   5          Name$
 dgNV??54   5   $??5??6   $??2??6!   $??10q?6C     ColumnHeader   ColumnHeaderStyle# [ 55         AutoGenerateColumns$ False??56      	   Columns	 57      0  *System.Windows.Controls.DataGridTextColumn  58      ,  &System.Windows.Controls.DataGridColumn
   Header$
 	Họ tên??6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   ?? *HoTen+  59      $
 Loại nhân viên??6%    6=   ?? *LoaiNV+  5:      $
 
Ngày sinh??6%    68   ?? *
NgaySinh+  5;      $
 Số tiền bán hàng??6%    6?   ?? *SoTien+  5<      $
 Tiền Hoa Hồng??6%    6<   ?? *TienHH+5>      ?? 5@   
   $??6??6   $??2??6#   $??10q?67    ?? Orientation$ 
Horizontal=?6C   $??Center=?6\   .+?5A      ?? -	   5         ??Name$ btnNhap??5A      $??Nhập??67   $??0 3 10 3q?6F   ?? 5B      -
   5        $ btnWin??5B      $??Window 2??65   $??10 3 0 3q?6H   5C      5E      5F      