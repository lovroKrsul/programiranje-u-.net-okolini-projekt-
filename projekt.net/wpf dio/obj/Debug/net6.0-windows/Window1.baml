   M S B A M L   `   `   `  ����B  >wpf dio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:wpf_diowpf_dio  5   	       wpf_dio.Window1   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:wpf_dio     5   	     � Title$  Window1��5   	   $	��450��6   $	��800��6&   
�������
������� � 
ResizeMode$ NoResize=�6X   .��5	      � 
������� � Triggers 5   
   :� 5       :� RoutedEvent$ Loaded��6   .[�5      �� .��5      �� .��5      W�  W� From 06*   	 W� To 163    g� Duration$ 0:0:0.5D�6:    �� TargetProperty$ Opacity�6M   5      �� 5       �� From	 Black6)   		 �� To	 	LightGray66   $ 0:0:0.3D�6E   $ Background.Color�6X   6�   5      5      5      
 � ColumnDefinitions
 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       .+�5"   
   �� $��0��6   $��0��6#   .+�5#      �� $	��Ime��6   �� 5$      -   5        $��lblName��5$   (   $��	not found��6   6(   5%      �� 5'   
   $��0��6   $��1��6#   .+�5(      �� $
��broj��6   �� 5)      -   5        $��	lblNumber��5)   (   $��	not found��6   6(   5*      �� 5+   
   $��1��6   $��0��6#   $	��100��63   $	��100��6?   $��Stretch=�6L   ��5,      �� 5-       j� Stretch$ Uniform=�6   .+�5/      �� -   5        $��imgPic��5/      50      �� 51   
   $��2��6   $��0��6#   .+�52      �� $��Position��6   �� 53      -   5        $��lblPos��53   (   $��	not found��6   6(   54      �� 55   
   $��2��6   $��1��6#   .+�56      �� $��Captain��6   �� 57      -   5        $��lblCap��57   (   $��	not found��6   6(   58      �� 59   
   $��3��6   $��0��6#   .+�5:      �� $��Goals��6   �� 5;      -   5        $��lblGoal��5;   (   $��	not found��6   6(   5<      �� 5=   
   $��3��6   $��1��6#   .+�5>      �� $��Yellows��6   �� 5?      -   5        $��	lblYellow��5?   (   $��	not found��6   6(   5@      5D      5E      