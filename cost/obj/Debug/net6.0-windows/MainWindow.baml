   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    cost   cost.MainWindow   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   S OHandyControl, Version=3.3.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5   	   Emah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	   =	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks  5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5
   	   -   5        (   "MahApps.Metro.Controls.MetroWindow   Name$  metroWindow��5         ShowIconOnTitleBar$
 True��5       � Title$ 微型不加头��5      $	��702��6   $
��1309��6'   $��18(�64   $��微软雅黑)�6B   $
��Bold"�6T    � WindowStartupLocation$ CenterScreen=�6g   ���	#FFF0F6FC � 	Resources 5         
NoReadOnly �� 
TargetType)  #HandyControl.Controls.NumericUpDown  NumericUpDownExtend �� BasedOn �� Property �� Value  BorderStyle  TextBoxExtend��%  &	        7  &	 �     7  �� 5   
   "  6#   8   .�5      ��  � ��$ 2,2,2,2q�68   �� 5       � ��
 �   �63   �� 5       � �� �	#FF50A0FF64   5      �� 5   
   " ��6$   8   .�5      ��  � ��$ 2,2,2,2q�68   5      5      .��5      �� ._�5   
   /  )HandyControl.Controls.UniformSpacingPanel  	   Spacing$	 32Q�6!   $��32,32,32,32q�6.   
   ChildWrapping$

 Wrap=�6C   .+�5      ��  �� Orientation$ Vertical=�6   $��Center=�62   $	��Top=�6O   .+�5      �� $��0q�6   $	��200��6&   (  "HandyControl.Controls.TitleElement   Title$ 型号��62      
TitleWidth$	 100 �5      +  %HandyControl.Controls.DropDownElement   ConsistentWidth$ False��68     ComboBoxExtend#��[ 5        �� SelectedIndex$ 0��6`   $
��Left=�6r   $��Stretch=�5!      $��2,2,2,2q�6M   ��5    ?   �� *
DataList+ �� Text 5!   4   �� *	Comtext+*  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5"      +  %Microsoft.Xaml.Behaviors.EventTrigger  5#         	EventName$ SelectionChanged��6)   5%      5'      �� 5(      $	��200��6   $	��Top=�6&   $
��Left=�6?   '  !HandyControl.Controls.InfoElement   Placeholder$  ��6[   $ 芯片成本��6{   #��[ 6�      	Necessary$ False��6�   $��0,16,0,0q�6�    �� 
IsReadOnly$
 True��6  ��6�   �� *Xpcost+6  �� 5)      $	��200��6   $	��Top=�6&   $
��Left=�6>   
���  ��$  ��6j   $ FA成本��6�   #��[ 6�   $ False��6�   $��0,16,0,0q�6  $
 True��6  ��6�   �� *Facost+6  �� 5*      $��点击计算FA��6   $
��Left=�6*   $��16(�6i   $��5q�6x     ButtonSuccess#��[ 6�   ��6E   �� *BtnAsynccommand+6�   �� 5+      $	��200��6   $	��Top=�6&   $
��Left=�6>   
���  ��$  ��6j   $ 单纤成本��6�   #��[ 6�   $ False��6�   $��0,16,0,0q�6  $
 True��6  ��6�   �� *	Dancost+6  �� 5,      $��点击计算单纤��6   $
��Left=�6*   $��16(�6g   $��5q�6w   #��[ 6�   ��6E   �� *ComSeleChange+6�   �� 5-      $	��200��6   $	��Top=�6'   $
��Left=�6?   
���  ��$  ��6k   $ 0.9套管成本��6�   #��[ 6�   $ False��6�   $��0,0,12,0q�6	  $��8,6,8,6q�6  $
 True��6-  ��6�   �� *	Taocost+6-  �� 5.      $��点击计算套管��6   $
��Left=�6*   $��16(�6a   $��5q�6p   #��[ 6{   ��6E   �� *	BtnGuan+6{   50      �� 52      $ Vertical=�6   $��Center=�63   $��Stretch=�6P   .+�53      �� $	��200��6   $	��Top=�6&   $
��Left=�6>   $  ��6Y   $ 钢管+堵头成本��6y   #��[ 6�   $ False��6�   $
 True��6�   $��Microsoft YaHei)�6  $
��Bold"�6%  ��6�   �� *Ggcost+6%  �� 54      $	��200��6   $	��Top=�6&   $
��Left=�6>   $  ��6Y   $ 计件人工成本��6y   #��[ 6�   $ False��6�   $
 True��6�   ��6�   �� *
Jjrgcost+6�   �� 56      $	��200��6   $	��Top=�6&   $
��Left=�6>   $  ��6Y   $ 辅料��6y   #��[ 6�   $ False��6�   $
 True��6�   ��6�   �� *Flcost+6�   �� 57      $	��200��6   $	��Top=�6&   $
��Left=�6>   $  ��6Y   $ 费用公摊��6y   #��[ 6�   $ False��6�   $
 True��6�   ��6�   �� *Gtcost+6�     58      $
��Left=�6#   $	��Top=�6>      ValueFormat$ N2��6V      Maximum$	 100Q�6g   $	��200��6�   $	 140 �6�   $  ��6�      TitlePlacement$	 Top=�6�   $ 分路器良率��6�   #��[  6  $ False��6?     	Increment$	 0.5Q�6`  
���  �����	#FF50A0FF   Value 6u   �� *Lvtext+6�  5:      �� 5;      .+�5<      �� $	��200��6   $	��Top=�6&   $
��Left=�6>   $  ��6Y   $ 包装人工费用��6y   #��[ 6�   $ False��6�   $
 True��6�   ��6�   �� *
Bzrgcost+6�   �� 5=      $	��200��6   $	��Top=�6&   $
��Left=�6>   $  ��6Y   $ 包材��6y   #��[ 6�   $ False��6�   $
 True��6�   ��6�   �� *Bccost+6�   �� 5>      $	��200��6   $	��Top=�6&   $
��Left=�6>   $  ��6Y   $ 包装均摊��6y   #��[ 6�   $ False��6�   $
 True��6�   ��6�   �� *
Bzjtcost+6�   �� 5?      $��吸塑��6   $��20(�6F   $��38��6T    d� 	IsChecked 6(   �� *	IsCheck+6T   �� 5@      $	��200��6   $	��Top=�6&   $
��Left=�6>   $  ��6Y   $ 出货成本��6y   
���  ��#��[ 6�   $ False��6�   $
 True��6  $
��Bold"�6  ��6�   �� *Chcost+6  5B      �� 5C      $ Vertical=�6   $��Center=�60   $��Center=�6M   .+�5E      �� $	��200��6   $	��Top=�6&   $
��Left=�6>   $  ��6Y   $ 原材料合计��6�   #��[ 6�   $ False��6�   $
 True��6�   ���	#FF0006FF��6y   �� *	Yclcost+6  �� 5F      $	��200��6   $	��Top=�6&   $
��Left=�6>   $  ��6Y   $ 制造成本��6�   #��[ 6�   $ False��6�   $
 True��6�   ���	#FF0300FF��6y   �� *Cbcost+6  5H      �� 5I      $	��230��6   $ Vertical=�6'   $��Center=�6>   $��Center=�6[   .+�5J      �� $	��200��6   $	��Top=�6&   $
��Left=�6>   
���  ��$  ��6j   $ 加头成本��6�   #��[ 6�   $ False��6�   $
 True��6  ��6�   �� *Jtcost+6  �� 5K      $��点击计算加头成本��6   $
��Left=�6,   $��16(�6a   $��5q�6q   #��[ 6|   ��6G   �� *BtnJT+6|   5N      �� 5O      $��设置��6   $��16(�6D   #��[ 6R   $��Stretch=�6y   $��-26,583,-29,-84q�6�   $��Stretch=�6�   ��6"   �� *btnShowConfig+6�   5Q      5S      5U      