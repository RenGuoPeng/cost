   M S B A M L   `   `   `  ����?  ;cost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:cost.Views
cost.Views  5   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	       cost.Views.JtWindow   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:cost.Views     5   	   S OHandyControl, Version=3.3.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5   	   Emah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	     � Title$  微型加头成本��5	   	   $	��500��5
      $	��700��5      $��20(�5         RegionBrush#���   5   	    � WindowStartupLocation$ CenterScreen=�64   $��Center=�6Y   $��Center=�6t   .��5      7  1HandyControl.Controls.TransitioningContentControl  .��5   
   (  "HandyControl.Controls.ScrollViewer     IsInertiaEnabled$
 True��6   .��5      /  )HandyControl.Controls.UniformSpacingPanel     Spacing$ 32Q�6%   $��0q�62      ChildWrapping$
 Wrap=�6=   .+�5      �� .+�5      �� $��0,16,0,0q�6   $	��200��61   (  "HandyControl.Controls.TitleElement   Title$ 型号��6=      
TitleWidth$	 100 �5      +  %HandyControl.Controls.DropDownElement   ConsistentWidth$ False��68     ComboBoxExtend#��[ 5       �� SelectedIndex$ 0��6d   $
��Left=�6v   $��Stretch=�5      ��5   ?   �� *Dropproducts+	 �� Text	 5   3   �� *
Droptext+5      �� 5      $	��200��6   $	��Top=�6*   $
��Left=�6B   '  !HandyControl.Controls.InfoElement
   Placeholder$
  ��6]   $ 连接头单价��6}     TextBoxExtend#��[ 6�      	Necessary$ False��6�   $��0,16,0,0q�6�    �� 
IsReadOnly$
 True��6  ��6�   �� *	Toucost+6  �� 5      $!��点击计算连接头单价��6   $
��Left=�61   $��16(�6L   $��5q�6w     ButtonSuccess#��[ 6�   ��6[   �� *BtnTou+6�   �� 5      $	��200��6   $	��Top=�6*   $
��Left=�6B   $
  ��6]   $ 测试成本��6}   #��[ 6�   $ False��6�   $��0,16,0,0q�6�   $
 True��6  ��6�   �� *Cscost+6  5      �� 5      .+�5       �� $	��200��6   $
  ��6*   $ 微型不加头成本��6H   #��[ 6h   $ False��6�   $
 True��6�   ��6�   �� *	NJtcost+6�   )  #HandyControl.Controls.NumericUpDown  5!      $
��Left=�6'   $	��Top=�6B      ValueFormat$ N2��6Z      Maximum$ 10000Q�6k   $	��200��6{   $	 140 �6�   $
  ��6�      TitlePlacement$	 Top=�6�   $ 数量��6    NumericUpDownExtend#��[ 6  $ False��6L     Minimum$ 0Q�6m     Value 6�   �� *Sltext+6m  �� 5"      $	��200��6   $	��Top=�6*   $
��Left=�6B   $
  ��6]   $ 头数��6{   #��[ 6�   $ False��6�   $
 True��6�   ��6�   �� *Tstext+6�     5$      $
��Left=�6'   $	��Top=�6B   $ N2��6Z   $	 100Q�6k   $	��200��6�   $	 140 �6�   $
  ��6�   $	 Top=�6�   $ 良率��6  #��[ 6  $ False��6K   6y   �� *Lvtext+6K  �� 5&      $	��200��6   $	��Top=�6*   $
��Left=�6B   $
  ��6]   $ 包装人工��6{   #��[ 6�   $ False��6�   $
 True��6�   ��6�   �� *Rgcost+6�   �� 5'      $	��200��6   $	��Top=�6*   $
��Left=�6B   $
  ��6]   $ 耗材费用��6{   #��[ 6�   $ False��6�   $
 True��6�   ��6�   �� *Hccost+6�   �� 5(      $	��200��6   $	��Top=�6*   $
��Left=�6B   $
  ��6]   $ 包装公摊��6{   #��[ 6�   $ False��6�   $
 True��6�   ��6�   �� *Gtcost+6�   �� 5*      $	��200��6   $	��Top=�6*   $
��Left=�6B   $
  ��6]   $ 成本��6{   #��[ 6�   $ False��6�   $
��Bold"�6�   
���  ��$
 True��64  ��6�   �� *Cbtext+ �� SelectionBrush 6	  Z� 64  5,      5-      5/      50      51      