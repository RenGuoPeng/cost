   M S B A M L   `   `   `  ����?  ;cost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:cost.Views
cost.Views  5   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   
       cost.Views.Config   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:cost.Views     5   	   Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   
   S OHandyControl, Version=3.3.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5   	   (  "MahApps.Metro.Controls.MetroWindow    ShowIconOnTitleBar$
  True��5
       � Title$ 设置��5   	   $	��450��6   $	��800��6!   $��18(�6-   $��微软雅黑)�6;    � WindowStartupLocation$ CenterScreen=�6M   $
��Bold"�6r    � 	Resources 5         
NoReadOnly �� 
TargetType)  #HandyControl.Controls.NumericUpDown  NumericUpDownExtend �� BasedOn �� Property �� Value  BorderStyle  TextBoxExtend��%  &	        7  &	 �     7  �� 5   
   "  6#   8   .�5      ��  � ��$ 2,2,2,2q�68   �� 5       � ��
 �   �63   �� 5       � �� �	#FF50A0FF64   5      �� 5   
   " ��6$   8   .�5      ��  � ��$ 2,2,2,2q�68   5      5      .��5      ,  &HandyControl.Controls.SimpleStackPanel  .+�5   
   �� $	��551��6   $	��Top=�6   $
��Left=�66   '  !HandyControl.Controls.InfoElement   Placeholder$  ��6Q   (  "HandyControl.Controls.TitleElement	   Title$	 数据库连接��6q   #��[ 6�   
   	Necessary$
 False��6�   $��0,15,0,0q�6�   ��6�   �� *Host+6�   �� 5   
   $	��214��6   $	��Top=�6   $
��Left=�66   $  ��6Q   $	 小数点位数��6q   #��[ 6�   $
 False��6�   $��0,16,0,0q�6�   ��6�   �� *Num+6�   �� 5   
   -   5         ��Name$ button��5      $��保存��6!   $��16(�6J     ButtonSuccess#��[ 6X   $
��Left=�6   $��345,184,0,0q�6�   $	��Top=�6�   $��38��6�   $��92��6�   ��6.   �� *	BtnSave+6�   5      5      