   M S B A M L   `   `   `  ????H  DDe6_Hoang_017, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:De6_Hoang_017De6_Hoang_017  5   	       De6_Hoang_017.Window2   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:De6_Hoang_017     5   	     ? Title$8  2Danh sách thí sinh có điểm tổng cao nhất??5   	   $	??600??6:   $	??700??6G   $??20(?5	   	    ? WindowStartupLocation$ CenterScreen=?6   .??5
      ? $??10q?6    ? ColumnDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5       ? RowDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   .+?5   
   ?? $??0??6   $??7??6   $??2??6/   
??? ? ?$??2q?6W   ?? 5   
   $??0??6   $??2??6   $8??2Danh sách thí sinh có điểm tổng cao nhất??61   $??30(?6d   
????  ?$??Center=?5   "   $
??Bold"?6?   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
dgvThiSinh??5      $??1??6'   $??2??64   $??10q?6H   
???????   AutoGenerateColumns$ False??5   &      
IsReadOnly$
 True??6B      dgvStyle   ColumnHeaderStyle# [  5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Số báo danh??6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6:   ?? *	SoBaoDanh+  5      $	 Điểm thi??6%   
 67   ?? *	DiemThi+  5       $	 
Ngày sinh??6%   
 68   ?? *
NgaySinh+  5!      $	 Điểm ưu tiên??6%   
 6;   ?? *
DiemUuTien+5#      5$      5%      