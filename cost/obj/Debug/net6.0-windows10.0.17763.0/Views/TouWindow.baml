   M S B A M L   `   `   `  ����?  ;cost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:cost.Views
cost.Views  5   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	       cost.Views.TouWindow   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:cost.Views     5   	   S OHandyControl, Version=3.3.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5   	   Emah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	     � Title$  连接头成本��5	   	   $��20(�5
      $	��500��5      $	��700��5         RegionBrush#���   5   	    � WindowStartupLocation$ CenterScreen=�64   .��5      /  )HandyControl.Controls.UniformSpacingPanel     Spacing$ 32Q�6   $��0,0,0,0q�6*      ChildWrapping$
 Wrap=�6;   .+�5   
   ,  &HandyControl.Controls.SimpleStackPanel  .+�5      �� $��0,16,0,0q�6   $	��200��6)   (  "HandyControl.Controls.TitleElement   Title$ 型号��65      
TitleWidth$	 100 �5      +  %HandyControl.Controls.DropDownElement   ConsistentWidth$ False��68     ComboBoxExtend#��[ 5       �� SelectedIndex$ 0��6d   $
��Left=�6v   $��Stretch=�5      ��5   ?   �� *Dropproducts+ �� Text 5   3   �� *
Droptext+5      �� 5      $	��200��6   $	��Top=�6"   $
��Left=�6:   '  !HandyControl.Controls.InfoElement	   Placeholder$	  ��6U   $ 数量��6u     TextBoxExtend#��[ 6�   
   	Necessary$
 False��6�   $��0,16,0,0q�6�    �� 
IsReadOnly$
 True��6  ��6�   �� *Sltext+6  5        5   
   .+�5      �� $	��200��6   $	��Top=�6"   $
��Left=�6:   $	  ��6U   $ 散件��6u   #��[ 6�   $
 False��6�   $��0,16,0,0q�6�   $
 True��6  ��6�   �� *Sjcost+6  �� 5      $	��200��6   $	��Top=�6"   $
��Left=�6:   $	  ��6U   $ 插芯��6u   #��[ 6�   $
 False��6�   $��0,16,0,0q�6�   $
 True��6  ��6�   �� *Cxcost+6  �� 5      $	��200��6   $	��Top=�6"   $
��Left=�6:   $	  ��6U   $ 辅料��6u   #��[ 6�   $
 False��6�   $��0,16,0,0q�6�   $
 True��6  ��6�   �� *Flcost+6  �� 5      $	��200��6   $	��Top=�6"   $
��Left=�6:   $	  ��6U   $ 人工��6u   #��[ 6�   $
 False��6�   $��0,16,0,0q�6�   $
 True��6  ��6�   �� *Rgcost+6  �� 5       $	��200��6   $	��Top=�6"   $
��Left=�6:   $	  ��6U   $ 测试��6u   #��[ 6�   $
 False��6�   $��0,16,0,0q�6�   $
 True��6  ��6�   �� *Cscost+6  �� 5!      $	��200��6   $	��Top=�6"   $
��Left=�6:   $	  ��6U   $ 公摊��6u   #��[ 6�   $
 False��6�   $��0,16,0,0q�6�   $
 True��6  ��6�   �� *Gtcost+6  �� 5#      $	��200��6   $	��Top=�6"   $
��Left=�6:   $	  ��6U   $ 成本��6u   #��[ 6�   $
 False��6�   $��0,16,0,0q�6�   $
��Bold"�6  
���  ��$
 True��6>  ��6�   �� *Cbtext+ �� SelectionBrush 6  Z� 6>  5%      5(      5*      