   M S B A M L   `   `   `  ????C  ?De6Ktra2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:De6Ktra2De6Ktra2  5   	       De6Ktra2.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:De6Ktra2     5   	     ? Title$  Bài kiểm tra số 2??5   	   $	??650??6#   $	??800??60   $??20(?6<   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      $
??auto ?6   ?? 5       ? RowDefinitions 5   
   ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      .+?5   
   ?? $??0??6   $??7??6   $??2??6/   $??10q?6C   $??3q?5      
??? ? ?6%   ?? 5   
   $??0??6   $??2??6   $??Danh sách thí sinh??61    	  title#??[  6N   ?? 5   
   $??1??6   $??0??6   $??Số báo danh??6-   ?? 5   
   -   5         ??Name$ txtSBD??5      $??1??6"   $??1??6/   $	??200??6?   ?? 5!   
   $??2??6   $??0??6   $??Điểm thi??6-   ?? 5"   
   -   5        $ txtDiem??5"      $??2??6#   $??1??60   $	??150??6@   ?? 5$   
   $??3??6   $??0??6   $??Ngày sinhh??6-   (  "System.Windows.Controls.DatePicker  5%   
   -   5          Name$
 dpNS??5%      $??3??6#   $??1??60      SelectedDate 
11-29-20226@   $	??250??6Z   $??40??6f   $??10 0 0 0q?5&      $
??Left=?6'   $??Center=?6B   ?? 5)   
   $??4??6   $??2??6"   .+?5*      ?? $??Đối tượng ưu tiên??6   ?? 5+       ?? Orientation$ 
Horizontal=?6   $
??Left=?62   $??Center=?6M   .+?5,      	? -   5         	?Name$	 rd0??5,      $??Không??6+    d? 	IsChecked$
 TrueY?6;   $??	27 0 10 0q?6L   	? 5-      -   5        $	 rd1??5-      $??Ưu tiên 1??6+   $??	10 0 10 0q?6?   	? 5.      -   5        $	 rd2??5.      $??Ưu tiên 2??6+   $??	10 0 10 0q?6?   5/      50      &   System.Windows.Controls.DataGrid  52   
   -   5        	  Name$
	 dgTS??53      $??5??52      $??2??6    $??20q?64   
   AutoGenerateColumns$
 False??53         	colHeader   ColumnHeaderStyle# [ 6<      Columns 54      0  *System.Windows.Controls.DataGridTextColumn  55      ,  &System.Windows.Controls.DataGridColumn   Header$ Số báo danh??6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   ?? *SBD+  56      $ Điểm thi??6%    67   ?? *Diem+  57      $ 
Ngày sinh??6%    68   ?? *NS+  58      $ Điểm ưu tiên??6%    6;   ?? *UT+5:      ?? 5<   
   $??6??6   $??2??6"   $??10q?66   $ 
Horizontal=?5=      $??Center=?6.   $??Center=?6K   .+?5>      ?? -   5         ??Name$ btnNhap??5>      $??Nhập??67   ?? 5?      -	   5        $ btnWin??5?      $??Window 2??65   5@      5B      5C      