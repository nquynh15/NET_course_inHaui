   M S B A M L   `   `   `  ????G  CDe3_Khai_298, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:De3_Khai_298De3_Khai_298  5   	       De3_Khai_298.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:De3_Khai_298     5   	   -   5          ? Title$  Bài Kiểm Tra Số 2??5   	   $
??auto??6#   $	??800??61   $??20(?5	   	    ? WindowStartupLocation$ CenterScreen=?5
   	   .??5      ?  ? RowDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      ?? 5      $
??auto ?6    ? ColumnDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      .+?5   
   ?? $??2??6   $??7??6%   $??2q?66   
??? ???
???????6_   ?? 5   
   $??0??6   $??2??6   $??Quản lý nhân viên??61   $??Center=?6M   $??30(?6q   $??DemiBold"?6   
????  ?$??10q?6?   $??Times New Roman)?6?   ?? 5   
   $??1??6   $??0??6   $??Họ tên nhân viên??6-   $??10q?6H   ?? 5   
   -   5         ??Name$ txtTen??5      $??1??6"   $??1??6/   $??30??6?   $	??180??6K   $??10q?6W   $
??Left=?5         txtStyle#??[  5      ?? 5    
   $??2??6   $??0??6   $??Loại nhân viên??6-   $??10q?6F   ?? 5!   
   -   5         ??Name$ cbLoaiNV??5!      $??2??6%   $??1??62   $??30??6B   $	??150??6N   $??10q?6Z   $
??Left=?6f   .@?5"      ?? $??	Cơ hữu??6   ?? 5#      $??Hợp đồng??6   ?? 5$      $??Cộng tác viên??6   5%      ?? 5&   
   $??3??6   $??0??6   $??
Ngày sinh??6-   $??10q?6A   (  "System.Windows.Controls.DatePicker  5'   
   -   5          Name$ 
dpNgaySinh??5'      $??3??6)   $??1??66   $??30??6F   $	??180??6R   $??10q?6^   $
??Left=?6j   ?? 5(   
   $??4??6   $??0??6   $??Số tiền bán hàng??6-   $??10q?6H   ?? 5)   
   -   5        $ txtTien??5)      $??4??6#   $??1??60   $??30??6@   $	??150??6L   $??10q?6X   $
??Left=?5*      #??[  5+      &   System.Windows.Controls.DataGrid  5,   
   -   5          Name$ dgvNV??5,      $??5??6"   $??2??6/     headerStyle   ColumnHeaderStyle# [ 6C   $	??150??6t   	   AutoGenerateColumns$	 False??6?   $??10q?6?   
   Columns
 5-      0  *System.Windows.Controls.DataGridTextColumn  5.      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Họ tên??6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   ?? *HoTen+  5/      $ Loại??6%    63   ?? *LoaiNV+  50      $ 
Ngày sinh??6%    68   ?? *
NgaySinh+  51      $ Số tiền bán hàng??6%    6?   ?? *
SoTienBH+  52      $ Tiền hoa hồng??6%    6<   ?? *TienHoaHong+54      ?? 55   
   $??6??6   $??2??6"    ?? Orientation$ 
Horizontal=?66   $??Center=?6O   .+?56      ?? -   5         ??Name$ 	submitBtn??56      $	??120??6(   $??30??64   $??20q?6@   $??Nhập??6L   6[   ?? 57      -   5        $ 	windowBtn??57      $	??120??6(   $??30??64   $??20q?6@   $??Window 2??6L   6_   58      59      5:      