   M S B A M L   `   `   `  ����?  ;cost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:cost.Views
cost.Views  5   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	       cost.Views.TaoWindow   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:cost.Views     5   	   S OHandyControl, Version=3.3.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5   	   Emah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	     � Title$  套管成本��5	   	   $��18(�5
      $	��500��5      $	��700��5      $��微软雅黑)�5      $
��Bold"�6$      RegionBrush#���   5   	    � WindowStartupLocation$ CenterScreen=�64    � 	Resources 5        
NoReadOnly �� 
TargetType)  #HandyControl.Controls.NumericUpDown  NumericUpDownExtend �� BasedOn �� Property �� Value  BorderStyle  TextBoxExtend��%  &	       7  &	 �     7  �� 5   
   "  6#   8   .�5      ��  � ��$ 2,2,2,2q�68   �� 5       � ��
 �   �63   �� 5       � �� �	#FF50A0FF64   5      �� 5   
   " ��6$   8   .�5      ��  � ��$ 2,2,2,2q�68   5      5      .��5      /  )HandyControl.Controls.UniformSpacingPanel     Spacing$ 32Q�6   $��0,0,0,0q�6*      ChildWrapping$
 Wrap=�6;   .+�5   
   ,  &HandyControl.Controls.SimpleStackPanel  .+�5      �� $��0,16,0,0q�6   $	��200��6)   (  "HandyControl.Controls.TitleElement	   Title$	 型号��65   
   
TitleWidth$	
 100 �5      +  %HandyControl.Controls.DropDownElement   ConsistentWidth$ False��68     ComboBoxExtend#��[ 5        �� SelectedIndex$ 0��6d   $
��Left=�6v   $��Stretch=�5!      $��2,2,2,2q�6M   ��5    ?   �� *Dropproducts+ �� Text 5!   3   �� *
Droptext+5#      5&        5(   
   .+�5)      �� $	��200��6   $	��Top=�6"   $
��Left=�6:   '  !HandyControl.Controls.InfoElement   Placeholder$  ��6U   $	 单价��6u   #��[ 6�      	Necessary$ False��6�   $��0,16,0,0q�6�    �� 
IsReadOnly$
 True��6�   ��6�   �� *Djcost+6�     5*      $
��Left=�6   $	��Top=�6:      ValueFormat$ N2��6R      Maximum$ 10000Q�6c   $	��200��6s   $	
 140 �6   $  ��6�      TitlePlacement$	 Top=�6�   $	 数量��6�   #��[ 6  $ False��6C  $��0,16,0,0q�6d     Minimum$ 0Q�6v     
IsReadOnly$
 True��6�  $��2,2,2,2q�6�     Value 6�   �� *Sltext+6�    5,      $
��Left=�6   $	��Top=�6:   $ N2��6R   $ 10000Q�6c   $	��200��6s   $	
 140 �6   $  ��6�   $	 Top=�6�   $	 输入长度��6�   #��[ 6  $ False��6E  $��0,16,0,0q�6f     	Increment$
 0.01Q�6x  $��2,2,2,2q�6�   6�   �� *Cdtext+6�    5-      $
��Left=�6   $	��Top=�6:   $ N2��6R   $ 10000Q�6c   $	��200��6�   $	
 140 �6�   $  ��6�   $	 Top=�6�   $	 输出长度��6�   #��[ 6  $ False��6F  $��0,16,0,0q�6g  $
 0.01Q�6y  $��2,2,2,2q�6�   6s   �� *	Cd2text+6�  �� 5.      $	��200��6   $	��Top=�6"   $
��Left=�6:   $  ��6U   $	 成本��6u   #��[ 6�   $ False��6�   $��0,16,0,0q�6�   $
��Bold"�6�   
���  ��$
 True��6<  ��6�   �� *Cbtext+ �� SelectionBrush 6  Z� 6<  50      53      55      