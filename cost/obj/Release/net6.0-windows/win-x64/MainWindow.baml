   M S B A M L   `   `   `  ���� T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls   cost   cost.MainWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     S OHandyControl, Version=3.3.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  Emah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  =	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks  _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  -   (   "MahApps.Metro.Controls.MetroWindow   Name$  metroWindow��   ShowIconOnTitleBar$
 True�� � Title$ 微型不加头��$	��702��$
��1309��$��18(�$��微软雅黑)�$
��Bold"� � WindowStartupLocation$ CenterScreen=����	#FFF0F6FC � 	Resources    
NoReadOnly �� 
TargetType)  #HandyControl.Controls.NumericUpDown  NumericUpDownExtend �� BasedOn �� Property �� Value  BorderStyle  TextBoxExtend��%�   &	        7  &	 c     7  �� "  8   .���  � ��$ 2,2,2,2q���  � ��
 �   ���  � �� �	#FF50A0FF�� " ��8   .���  � ��$ 2,2,2,2q�.���� ._�/  )HandyControl.Controls.UniformSpacingPanel  	   Spacing$	 32Q�$��32,32,32,32q�
   ChildWrapping$

 Wrap=�.+���  �� Orientation$ Vertical=�$��Center=�$	��Top=�.+��� $��0q�$	��200��(  "HandyControl.Controls.TitleElement   Title$ 型号��   
TitleWidth$	 100 �+  %HandyControl.Controls.DropDownElement   ConsistentWidth$ False��  ComboBoxExtend#��[  �� SelectedIndex$ 0��$
��Left=�$��Stretch=�$��2,2,2,2q����� *
DataList+ �� Text �� *	Comtext+*  $Microsoft.Xaml.Behaviors.Interaction   Triggers +  %Microsoft.Xaml.Behaviors.EventTrigger     	EventName$ SelectionChanged���� $	��200��$	��Top=�$
��Left=�'  !HandyControl.Controls.InfoElement   Placeholder$  ��$ 芯片成本��#��[    	Necessary$ False��$��0,16,0,0q� �� 
IsReadOnly$
 True������ *Xpcost+�� $	��200��$	��Top=�$
��Left=�
���  ��$  ��$ FA成本��#��[ $ False��$��0,16,0,0q�$
 True������ *Facost+�� $��点击计算FA��$
��Left=�$��16(�$��5q�  ButtonSuccess#��[ ���� *BtnAsynccommand+�� $	��200��$	��Top=�$
��Left=�
���  ��$  ��$ 单纤成本��#��[ $ False��$��0,16,0,0q�$
 True������ *	Dancost+�� $��点击计算单纤��$
��Left=�$��16(�$��5q�#��[ ���� *ComSeleChange+�� $	��200��$	��Top=�$
��Left=�
���  ��$  ��$ 0.9套管成本��#��[ $ False��$��0,0,12,0q�$��8,6,8,6q�$
 True������ *	Taocost+�� $��点击计算套管��$
��Left=�$��16(�$��5q�#��[ ���� *	BtnGuan+�� $ Vertical=�$��Center=�$��Stretch=�.+��� $	��200��$	��Top=�$
��Left=�$  ��$ 钢管+堵头成本��#��[ $ False��$
 True��$��Microsoft YaHei)�$
��Bold"����� *Ggcost+�� $	��200��$	��Top=�$
��Left=�$  ��$ 计件人工成本��#��[ $ False��$
 True������ *
Jjrgcost+�� $	��200��$	��Top=�$
��Left=�$  ��$ 辅料��#��[ $ False��$
 True������ *Flcost+�� $	��200��$	��Top=�$
��Left=�$  ��$ 费用公摊��#��[ $ False��$
 True������ *Gtcost+  $
��Left=�$	��Top=�   ValueFormat$ N2��   Maximum$	 100Q�$	��200��$	 140 �$  ��   TitlePlacement$	 Top=�$ 分路器良率��#��[  $ False��   	Increment$	 0.5Q�
���  �����	#FF50A0FF   Value �� *Lvtext+�� .+��� $	��200��$	��Top=�$
��Left=�$  ��$ 包装人工费用��#��[ $ False��$
 True������ *
Bzrgcost+�� $	��200��$	��Top=�$
��Left=�$  ��$ 包材��#��[ $ False��$
 True������ *Bccost+�� $	��200��$	��Top=�$
��Left=�$  ��$ 包装均摊��#��[ $ False��$
 True������ *
Bzjtcost+�� $��吸塑��$��20(�$��38�� d� 	IsChecked �� *	IsCheck+�� $	��200��$	��Top=�$
��Left=�$  ��$ 出货成本��
���  ��#��[ $ False��$
 True��$
��Bold"����� *Chcost+�� $ Vertical=�$��Center=�$��Center=�.+��� $	��200��$	��Top=�$
��Left=�$  ��$ 原材料合计��#��[ $ False��$
 True�����	#FF0006FF���� *	Yclcost+�� $	��200��$	��Top=�$
��Left=�$  ��$ 制造成本��#��[ $ False��$
 True�����	#FF0300FF���� *Cbcost+�� $	��230��$ Vertical=�$��Center=�$��Center=�.+��� $	��200��$	��Top=�$
��Left=�
���  ��$  ��$ 加头成本��#��[ $ False��$
 True������ *Jtcost+�� $��点击计算加头成本��$
��Left=�$��16(�$��5q�#��[ ���� *BtnJT+�� $��设置��$��16(�#��[ $��Stretch=�$��-26,583,-29,-84q�$��Stretch=����� *btnShowConfig+