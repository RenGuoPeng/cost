   M S B A M L   `   `   `  ���� ?  ;cost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:cost.Views
cost.Views  T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls     cost.Views.TaoWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:cost.Views     S OHandyControl, Version=3.3.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  Emah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro    � Title$  套管成本��$��18(�$	��500��$	��700��$��微软雅黑)�$
��Bold"�   RegionBrush#���    � WindowStartupLocation$ CenterScreen=� � 	Resources   
NoReadOnly �� 
TargetType)  #HandyControl.Controls.NumericUpDown  NumericUpDownExtend �� BasedOn �� Property �� Value  BorderStyle  TextBoxExtend��%�   &	       7  &	 c     7  �� "  8   .���  � ��$ 2,2,2,2q���  � ��
 �   ���  � �� �	#FF50A0FF�� " ��8   .���  � ��$ 2,2,2,2q�.��/  )HandyControl.Controls.UniformSpacingPanel     Spacing$ 32Q�$��0,0,0,0q�   ChildWrapping$
 Wrap=�.+�,  &HandyControl.Controls.SimpleStackPanel  .+��� $��0,16,0,0q�$	��200��(  "HandyControl.Controls.TitleElement	   Title$	 型号��
   
TitleWidth$	
 100 �+  %HandyControl.Controls.DropDownElement   ConsistentWidth$ False��  ComboBoxExtend#��[  �� SelectedIndex$ 0��$
��Left=�$��Stretch=�$��2,2,2,2q����� *Dropproducts+ �� Text �� *
Droptext+  .+��� $	��200��$	��Top=�$
��Left=�'  !HandyControl.Controls.InfoElement   Placeholder$  ��$	 单价��#��[    	Necessary$ False��$��0,16,0,0q� �� 
IsReadOnly$
 True������ *Djcost+  $
��Left=�$	��Top=�   ValueFormat$ N2��   Maximum$ 10000Q�$	��200��$	
 140 �$  ��   TitlePlacement$	 Top=�$	 数量��#��[ $ False��$��0,16,0,0q�   Minimum$ 0Q�   
IsReadOnly$
 True��$��2,2,2,2q�   Value �� *Sltext+  $
��Left=�$	��Top=�$ N2��$ 10000Q�$	��200��$	
 140 �$  ��$	 Top=�$	 输入长度��#��[ $ False��$��0,16,0,0q�   	Increment$
 0.01Q�$��2,2,2,2q� �� *Cdtext+  $
��Left=�$	��Top=�$ N2��$ 10000Q�$	��200��$	
 140 �$  ��$	 Top=�$	 输出长度��#��[ $ False��$��0,16,0,0q�$
 0.01Q�$��2,2,2,2q� �� *	Cd2text+�� $	��200��$	��Top=�$
��Left=�$  ��$	 成本��#��[ $ False��$��0,16,0,0q�$
��Bold"�
���  ��$
 True������ *Cbtext+ �� SelectionBrush Z� 