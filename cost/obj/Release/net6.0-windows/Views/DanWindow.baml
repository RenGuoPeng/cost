   M S B A M L   `   `   `  ���� ?  ;cost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:cost.Views
cost.Views  T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls     cost.Views.Dan   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:cost.Views     Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     S OHandyControl, Version=3.3.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol    � WindowStartupLocation$  CenterScreen=� � Title$ 单纤成本计算��$	��625��$
��1037��$��18(�$��微软雅黑)�$
��Bold"����	#FFF0F6FC � 	Resources    
NoReadOnly �� 
TargetType)  #HandyControl.Controls.NumericUpDown  NumericUpDownExtend �� BasedOn �� Property �� Value  BorderStyle  TextBoxExtend��%�   &	        7  &	 c     7  �� "  8   .���  � ��$ 2,2,2,2q���  � ��
 �   ���  � �� �	#FF50A0FF�� " ��8   .���  � ��$ 2,2,2,2q�.��/  )HandyControl.Controls.UniformSpacingPanel     Spacing$ 32Q�$��0,0,0,0q�   ChildWrapping$
 Wrap=�.+�,  &HandyControl.Controls.SimpleStackPanel  .+��� $��0,16,0,0q�$	��200��(  "HandyControl.Controls.TitleElement	   Title$	 型号��
   
TitleWidth$	
 100 �+  %HandyControl.Controls.DropDownElement   ConsistentWidth$ False��  ComboBoxExtend#��[  �� SelectedIndex$ 0��$
��Left=�$��Stretch=�$��2,2,2,2q����� *Dropproducts+ �� Text �� *
Droptext+�� $��0,16,0,0q�$	��200��$	 光纤型号��$	
 100 �$ False�� �� SelectedItem$ 0��#��[ $
��Left=�$��Stretch=�$��2,2,2,2q����� *DropXp+ �� *DropListtext+  .+��� $	��200��$	��Top=�$
��Left=�'  !HandyControl.Controls.InfoElement   Placeholder$  ��$	 光纤价格（单价）��#��[    	Necessary$ False��$��0,16,0,0q� �� 
IsReadOnly$
 True������ *Gxcost+  $
��Left=�$	��Top=�   ValueFormat$ N2��   Maximum$	 102Q�$	��200��$	
 140 �$  ��   TitlePlacement$	 Top=�$	 光纤长度��#��[ $ False��$��0,16,0,0q�   	Increment$
 0.05Q�   Minimum$ 0Q�$��2,2,2,2q�   Value �� *
Gxcdcost+  $
��Left=�$	��Top=�$ N2��$	 100Q�$	��200��$	
 140 �$  ��$	 Top=�$	 带纤数量��#��[ $ False��$��0,16,0,0q�   
IsReadOnly$
 True��$��2,2,2,2q� �� *
Gxslcost+�� $	��200��$	��Top=�$
��Left=�$  ��$	 	毛细管��#��[ $ False��$��0,16,0,0q�$
 True������ *Gbcost+  $
��Left=�$	��Top=�$ N2��$ 5Q�$	��200��$	
 140 �$  ��$	 Top=�$	 头胶+尾胶+辅料��#��[ $ False��$��0,16,0,0q�$
 0.01Q�$
 True��$��2,2,2,2q� �� *Flcost+�� $	��200��$	��Top=�$
��Left=�$  ��$	 原材料成本��#��[ $ False��$��0,16,0,0q�$
��Bold"�
���  ��$
 True������ *	Yclcost+ �� SelectionBrush Z�   .+��� $	��200��$	��Top=�$
��Left=�$  ��$	 计件人工成本��#��[ $ False��$��0,16,0,0q�$
 True������ *
Jjrgcost+�� $	��200��$	��Top=�$
��Left=�$  ��$	 水电制造��#��[ $ False��$��0,16,0,0q�$
 True������ *Gtcost+  $
��Left=�$	��Top=�$ N2��$	 100Q�$	��200��$	
 140 �$  ��$	 Top=�$	 自用良率��#��[ $ False��$��0,16,0,0q�$	 0.1Q�$��2,2,2,2q� �� *Lltext+�� $	��200��$	��Top=�$
��Left=�$  ��$	 制造成本��#��[ $ False��$��0,16,0,0q�
���  ��$
��Bold"�$
 True������ *Zzcost+  .+��� $	��200��$	��Top=�$
��Left=�$  ��$	 包装人工费用��#��[ $ False��$��0,16,0,0q�$
 True������ *
Bzrgcost+�� $	��200��$	��Top=�$
��Left=�$  ��$	 包材��#��[ $ False��$��0,16,0,0q�$
 True������ *Bccost+�� $	��200��$	��Top=�$
��Left=�$  ��$	 包装均摊��#��[ $ False��$��0,16,0,0q�$
 True������ *
Bzjtcost+�� $	��200��$	��Top=�$
��Left=�$  ��$	 出货成本��
���  ��#��[ $ False��$��0,16,0,0q�$
 True��$
��Bold"����� *Chcost+