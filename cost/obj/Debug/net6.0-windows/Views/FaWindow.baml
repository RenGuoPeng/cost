   M S B A M L   `   `   `  ����?  ;cost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:cost.Views
cost.Views  5   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   
       cost.Views.FA   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:cost.Views     5   	   S OHandyControl, Version=3.3.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5   	   Emah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   
   $��18(�5
      $��微软雅黑)�5      $
��Bold"�5         RegionBrush#���   5        � WindowStartupLocation$  CenterScreen=�5       � Title$ FA成本计算��5   	   $	��625��6   $
��1037��6%    � 	Resources 5        
NoReadOnly �� 
TargetType)  #HandyControl.Controls.NumericUpDown  NumericUpDownExtend �� BasedOn �� Property �� Value  BorderStyle  TextBoxExtend��%  &	       7  &	 �     7  �� 5   
   "  6#   8   .�5      ��  � ��$ 2,2,2,2q�68   �� 5       � ��
 �   �63   �� 5       � �� �	#FF50A0FF64   5      �� 5   
   " ��6$   8   .�5      ��  � ��$ 2,2,2,2q�68   5      5      .��5      /  )HandyControl.Controls.UniformSpacingPanel     Spacing$ 32Q�6   $��0,0,0,0q�6*      ChildWrapping$
 Wrap=�6;   .+�5   
   ,  &HandyControl.Controls.SimpleStackPanel  .+�5       �� $��0,16,0,0q�6   $	��200��6)   (  "HandyControl.Controls.TitleElement	   Title$	 型号��65   
   
TitleWidth$	
 100 �5!      +  %HandyControl.Controls.DropDownElement   ConsistentWidth$ False��68     ComboBoxExtend#��[ 5"       �� SelectedIndex$ 0��6d   $
��Left=�6v   $��Stretch=�5#      $��2,2,2,2q�6N   ��5"   ?   �� *Dropproducts+ �� Text 5#   4   �� *
Droptext+5%      �� 5&      $��0,16,0,0q�6   $	��200��6)   $	 光纤型号��65   $	
 100 �5'      $ False��68    �� SelectedItem$ 0��6c   #��[ 5(      $
��Left=�6^   $��Stretch=�5)      $��2,2,2,2q�6R   ��5(   ?   �� *DropXp+ 5)   4   �� *DropListtext+5+      5-        5/   
   .+�50      �� $	��200��6   $	��Top=�6"   $
��Left=�6:   '  !HandyControl.Controls.InfoElement   Placeholder$  ��6U   $	 光纤价格（单价）��6u   #��[ 6�      	Necessary$ False��6�   $��0,16,0,0q�6�    �� 
IsReadOnly$
 True��6  ��6�   �� *Gxcost+6    51      $
��Left=�6   $	��Top=�6:      ValueFormat$ N2��6R   $	��200��6c   $	
 140 �6o   $  ��6�      TitlePlacement$	 Top=�6�   $	 光纤长度��6�   #��[ 6
  $ False��67  $��0,16,0,0q�6X     	Increment$
 0.05Q�6j     Minimum$ 0Q�6{  $��2,2,2,2q�6�     Value 6�   �� *
Gxcdcost+6�    52      $
��Left=�6   $	��Top=�6:   $ N2��6R      Maximum$	 100Q�6c   $	��200��6�   $	
 140 �6�   $  ��6�   $	 Top=�6�   $	 带纤数量��6�   #��[ 6  $ False��6E  $��0,16,0,0q�6f     
IsReadOnly$
 True��6x  $��2,2,2,2q�6�   6q   �� *
Gxslcost+6�  �� 53      $	��200��6   $	��Top=�6"   $
��Left=�6:   $  ��6U   $	 V槽+盖板��6u   #��[ 6�   $ False��6�   $��0,16,0,0q�6�   $
 True��6  ��6�   �� *myFa.盖板+6    54      $
��Left=�6   $	��Top=�6:   $	��200��6k   $	
 140 �6w   $  ��6�   $	 Top=�6�   $	 头胶+尾胶+辅料��6�   #��[ 6�   $ False��6(  $��0,16,0,0q�6I  $
 True��6\  $��2,2,2,2q�6n   6R   �� *Flcost+6n  �� 55      $	��200��6   $	��Top=�6"   $
��Left=�6:   $  ��6U   $	 原材料成本��6u   #��[ 6�   $ False��6�   $��0,16,0,0q�6�   $
��Bold"�6  
���  ��$
 True��6A  ��6�   �� *	Yclcost+ �� SelectionBrush 6  Z� 6A  57        58   
   .+�59      �� $	��200��6   $	��Top=�6"   $
��Left=�6:   $  ��6U   $	 计件人工成本��6u   #��[ 6�   $ False��6�   $��0,16,0,0q�6�   $
 True��6  ��6�   �� *
Jjrgcost+6  �� 5:      $	��200��6   $	��Top=�6"   $
��Left=�6:   $  ��6U   $	 水电制造��6u   #��[ 6�   $ False��6�   $��0,16,0,0q�6�   $
 True��6  ��6�   �� *Gtcost+6    5;      $
��Left=�6   $	��Top=�6:   $ N2��6R   $	 100Q�6c   $	��200��6�   $	
 140 �6�   $  ��6�   $	 Top=�6�   $	 自用良率��6�   #��[ 6  $ False��6C  $��0,16,0,0q�6d  $	 0.1Q�6v  $��2,2,2,2q�6�   6q   �� *Lltext+6�  �� 5=      $	��200��6   $	��Top=�6"   $
��Left=�6:   $  ��6U   $	 制造成本��6u   #��[ 6�   $ False��6�   $��0,16,0,0q�6�   
���  ��$
��Bold"�6  $
 True��6&  ��6�   �� *Zzcost+6&  5?        5@   
   .+�5A      �� $	��200��6   $	��Top=�6"   $
��Left=�6:   $  ��6U   $	 包装人工费用��6u   #��[ 6�   $ False��6�   $��0,16,0,0q�6�   $
 True��6  ��6�   �� *
Bzrgcost+6  �� 5B      $	��200��6   $	��Top=�6"   $
��Left=�6:   $  ��6U   $	 包材��6u   #��[ 6�   $ False��6�   $��0,16,0,0q�6�   $
 True��6�   ��6�   �� *Bccost+6�   �� 5C      $	��200��6   $	��Top=�6"   $
��Left=�6:   $  ��6U   $	 包装均摊��6u   #��[ 6�   $ False��6�   $��0,16,0,0q�6�   $
 True��6  ��6�   �� *
Bzjtcost+6  �� 5E      $	��200��6   $	��Top=�6"   $
��Left=�6:   $  ��6U   $	 出货成本��6u   
���  ��#��[ 6�   $ False��6�   $��0,16,0,0q�6   $
 True��6  $
��Bold"�6$  ��6�   �� *Chcost+6$  5G      5H      5I      