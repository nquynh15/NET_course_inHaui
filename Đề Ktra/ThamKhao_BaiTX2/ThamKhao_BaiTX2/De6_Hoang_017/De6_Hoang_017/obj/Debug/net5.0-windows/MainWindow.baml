   M S B A M L   `   `   `  ????H  DDe6_Hoang_017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:De6_Hoang_017De6_Hoang_017  5   	       De6_Hoang_017.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:De6_Hoang_017     5   	   -   5          ? Title$  Danh sách thí sinh??5   	   $	??600??6$   $	??700??61   $??20(?5	   	    ? WindowStartupLocation$ CenterScreen=?6   .??5
      ? $??10q?6    ? ColumnDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5       ? RowDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      ?? 5      $
??auto ?6   .+?5   
   ?? $??0??6   $??7??6   $??2??6/   
??? ? ?$??2q?6W   ?? 5   
   $??0??6   $??2??6   $??Danh sách thí sinh??61   $??30(?6N   
????  ?$??Center=?5   "   $
??Bold"?6?   ?? 5   
   $??1??6   $??0??6   $??Số báo danh??6-   $??10q?6C   ?? 5    
   -   5         ??Name$ txtSBD??5       $??1??6"   $??1??6/   $	??150??6?      txtStyle#??[  6K   ?? 5"   
   $??2??6   $??0??6   $??Điểm thi??6-   $??10q?6@   ?? 5#   
   -   5        $ 
txtDiemThi??5#      $??2??6&   $??1??63   $	??100??6C   #??[  6O   ?? 5%   
   $??3??6   $??0??6   $??
Ngày sinh??6-   $??10q?6A   (  "System.Windows.Controls.DatePicker  5&   
   -   5          Name$ dtpNgaySinh??5&      $??3??6*   $??1??67   $	??200??6G   $??30??6S   $
??Left=?5'      $??10,0,0,0q?60      SelectedDate 
10-10-20026B   ?? 5)   
   $??4??6   $??2??6"   $??10q?66    ?? Orientation$ Vertical=?6B   .+?5*      ?? $??Đối tượng ưu tiên??6   $??20,0,0,0q?60   ?? 5+      $ 
Horizontal=?6   $??40,0,0,0q?62   .+?5,      	? -   5         	?Name$ radKhong??5,      $??Không??60   	 d? 	IsChecked$
	 TrueY?6@     radStyle#??[ 5-      	? 5.      -   5        $ 
radUuTien1??5.      $??Ưu tiên 1??62   #??[ 6F   	? 5/      -   5        $ 
radUuTien2??5/      $??Ưu tiên 2??62   #??[ 6F   50      51      &   System.Windows.Controls.DataGrid  53   
   -   5        
  Name$
 
dgvThiSinh??53      $??5??6'   $??2??64   $??10q?6H   
???????   AutoGenerateColumns$ False??54   &     dgvStyle   ColumnHeaderStyle# [ 6B      Columns 55      0  *System.Windows.Controls.DataGridTextColumn  56      ,  &System.Windows.Controls.DataGridColumn   Header$ Số báo danh??6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   ?? *	SoBaoDanh+  57      $ Điểm thi??6%    67   ?? *	DiemThi+  58      $ 
Ngày sinh??6%    68   ?? *
NgaySinh+  59      $ Điểm ưu tiên??6%    6;   ?? *
DiemUuTien+5;      ?? 5=   
   $??6??6   $??2??6"   $??10q?66   $ 
Horizontal=?6B   $??Center=?5>      .+?5?      ?? -	   5         ??Name$ btnNhap??5?      $??Nhập??6&   $??10q?65   $	??120??6A   $??30??6M   5@      ?? 5A      -
   5        $ 
btnWindow2??5A      $??Window 2??6)   $??10q?6<   $	??120??6H   $??30??6T   5B      5C      5D      5E      