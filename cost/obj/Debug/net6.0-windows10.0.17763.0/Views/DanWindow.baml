   M S B A M L   `   `   `  ����?  ;cost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:cost.Views
cost.Views  5   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   
       cost.Views.Dan   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:cost.Views     5   	   Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   
   S OHandyControl, Version=3.3.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5   	   $��20(�5
         RegionBrush#���   5        � WindowStartupLocation$  CenterScreen=�5       � Title$ 单纤成本计算��5   	   $	��625��6   $
��1037��6%   .��5      /  )HandyControl.Controls.UniformSpacingPanel     Spacing$ 32Q�6   $��0,0,0,0q�6*      ChildWrapping$
 Wrap=�6;   .+�5   
   ,  &HandyControl.Controls.SimpleStackPanel  .+�5      �� $��0,16,0,0q�6   $	��200��6)   (  "HandyControl.Controls.TitleElement   Title$ 型号��65      
TitleWidth$	 100 �5      +  %HandyControl.Controls.DropDownElement   ConsistentWidth$ False��68     ComboBoxExtend#��[ 5       �� SelectedIndex$ 0��6d   $
��Left=�6v   $��Stretch=�5      ��5   ?   �� *Dropproducts+ �� Text 5   4   �� *
Droptext+5      �� 5      $��0,16,0,0q�6   $	��200��6)   $ 光纤型号��65   $	 100 �5      $ False��68   	 �� SelectedItem$	 0��6c   #��[ 5      $
��Left=�6^   $��Stretch=�5      ��5   ?   �� *DropXp+ 5   4   �� *DropListtext+5      5        5   
   .+�5       �� $	��200��6   $	��Top=�6"   $
��Left=�6:   '  !HandyControl.Controls.InfoElement
   Placeholder$
  ��6U   $ 光纤价格（单价）��6u     TextBoxExtend#��[ 6�      	Necessary$ False��6�   $��0,16,0,0q�6�    �� 
IsReadOnly$
 True��6  ��6�   �� *Gxcost+6  )  #HandyControl.Controls.NumericUpDown  5!      $
��Left=�6   $	��Top=�6:      ValueFormat$ N2��6R      Maximum$	 101Q�6c   $	��200��6q   $	 140 �6}   $
  ��6�      TitlePlacement$	 Top=�6�   $ 光纤长度��6�     NumericUpDownExtend#��[ 6  $ False��6E  $��0,16,0,0q�6f     	Increment$
 0.05Q�6x     Value 6�   �� *
Gxcdcost+6x    5"      $
��Left=�6   $	��Top=�6:   $ N2��6R   $	 100Q�6c   $	��200��6�   $	 140 �6�   $
  ��6�   $	 Top=�6�   $ 带纤数量��6�   #��[ 6  $ False��6E  $��0,16,0,0q�6f     
IsReadOnly$
 True��6x   6q   �� *
Gxslcost+6x  �� 5#      $	��200��6   $	��Top=�6"   $
��Left=�6:   $
  ��6U   $ 	毛细管��6u   #��[ 6�   $ False��6�   $��0,16,0,0q�6�   $
 True��6  ��6�   �� *Gbcost+6    5$      $
��Left=�6   $	��Top=�6:   $ N2��6R   $ 5Q�6c   $	��200��6�   $	 140 �6�   $
  ��6�   $	 Top=�6�   $ 头胶+尾胶+辅料��6�   #��[ 6  $ False��6E  $��0,16,0,0q�6f  $
 0.01Q�6x   6o   �� *Flcost+6x  �� 5%      $	��200��6   $	��Top=�6"   $
��Left=�6:   $
  ��6U   $ 原材料成本��6u   #��[ 6�   $ False��6�   $��0,16,0,0q�6�   $
��Bold"�6  
���  ��$
 True��6C  ��6�   �� *	Yclcost+ �� SelectionBrush 6  Z� 6C  5'        5(   
   .+�5)      �� $	��200��6   $	��Top=�6"   $
��Left=�6:   $
  ��6U   $ 计件人工成本��6u   #��[ 6�   $ False��6�   $��0,16,0,0q�6�   $
 True��6  ��6�   �� *
Jjrgcost+6  �� 5*      $	��200��6   $	��Top=�6"   $
��Left=�6:   $
  ��6U   $ 水电制造��6u   #��[ 6�   $ False��6�   $��0,16,0,0q�6�   $
 True��6  ��6�   �� *Gtcost+6    5+      $
��Left=�6   $	��Top=�6:   $ N2��6R   $	 100Q�6c   $	��200��6�   $	 140 �6�   $
  ��6�   $	 Top=�6�   $ 自用良率��6�   #��[ 6  $ False��6C  $��0,16,0,0q�6d  $	 0.1Q�6v   6q   �� *Lltext+6v  �� 5-      $	��200��6   $	��Top=�6"   $
��Left=�6:   $
  ��6U   $ 制造成本��6u   #��[ 6�   $ False��6�   $��0,16,0,0q�6�   
���  ��$
��Bold"�6  $
 True��6(  ��6�   �� *Zzcost+6(  5/        50   
   .+�51      �� $	��200��6   $	��Top=�6"   $
��Left=�6:   $
  ��6U   $ 包装人工费用��6u   #��[ 6�   $ False��6�   $��0,16,0,0q�6�   $
 True��6  ��6�   �� *
Bzrgcost+6  �� 52      $	��200��6   $	��Top=�6"   $
��Left=�6:   $
  ��6U   $ 包材��6u   #��[ 6�   $ False��6�   $��0,16,0,0q�6�   $
 True��6  ��6�   �� *Bccost+6  �� 53      $	��200��6   $	��Top=�6"   $
��Left=�6:   $
  ��6U   $ 包装均摊��6u   #��[ 6�   $ False��6�   $��0,16,0,0q�6�   $
 True��6  ��6�   �� *
Bzjtcost+6  �� 55      $	��200��6   $	��Top=�6"   $
��Left=�6:   $
  ��6U   $ 出货成本��6u   
���  ��#��[ 6�   $ False��6�   $��0,16,0,0q�6  $
 True��6  $
��Bold"�6&  ��6�   �� *Chcost+6&  57      58      59      