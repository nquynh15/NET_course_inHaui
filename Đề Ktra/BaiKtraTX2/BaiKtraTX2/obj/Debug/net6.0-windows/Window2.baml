   M S B A M L   `   `   `  ????E  ABaiKtraTX2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:BaiKtraTX2
BaiKtraTX2  5   	       BaiKtraTX2.Window2   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:BaiKtraTX2     5   	     ? Title$  Window2??5   	   $	??450??6   $	??800??6&   .??5	      ? .+?5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgvNhanVien??5
      $??7??6(   $??2??65   $??10, 5, 10, 5q?6I      	dgvHeader   ColumnHeaderStyle# [  5         AutoGenerateColumns$ False??5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã nhân viên??6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   ?? *
MaNhanVien+  5      $ 	Họ tên??6%    66   ?? *HoTen+  5      $ Giới tính??6%    68   ?? *
GioiTinh+  5      $ 
Phòng ban??6%    68   ?? *
PhongBan+  5      $ 
Ngày sinh??6%    68   ?? *
NgaySinh+  5      $ Tuổi??6%    63   ?? *Tuoi+5      5      5      