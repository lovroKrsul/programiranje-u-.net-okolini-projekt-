   M S B A M L   `   `   `  ����B  >wpf dio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:wpf_diowpf_dio  5   	       wpf_dio.StartingWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:wpf_dio     5   	     � Title$  StartingWindow��5   	   $	��450��6    $	��800��6-   
������� � 
ResizeMode$ NoResize=�6L    � 	Resources 5	       �� 
TargetType �� Property �� Value��%V   '	�       �� 5
   
   " 	�6   .�5      ��  � ��$ Bottom=�69   5      5      .��5      �  J� RenderTransformOrigin$ 0.5,0.5&�6   .+�5   
   �� $��Center=�6   $	��Top=�63   $��0,10,0,0q�6K   .+�5      �� $��
Prventstvo��6   $��30(�6)   $
��Bold"�67   $��Center=�6I   	� 5      -   5        $��Žensko��5      $��Center=�6+   $	��Top=�6H   $��20(�6`   $��21��6n   6z   	� 5      -   5        $��Muško��5      $��Center=�6*   $	��Top=�6G   $��20(�6_   $��22��6m   6y   5      �� 5   
   $��Center=�6   $	��Top=�63   $��	0,110,0,0q�6K   .+�5      �� $��Jezik��6   $
��Left=�6$   $	��Top=�6@   $��30(�6X   $
��Bold"�6f   	� 5      -   5        $��HR��5      $
��Left=�6'   $	��Top=�6C   $��20(�6[   $��22��6i   6u   	� 5      -   5        $��EN��5      $
��Left=�6'   $	��Top=�6C   $��20(�6[   $��21��6i   6u   5      �� 5   
   $��Center=�6   $	��Top=�63   $��	0,210,0,0q�6K   .+�5       �� $��
Rezolucija��6   $��30(�6)   $
��Bold"�67   �� 5!      -   5         ��Name$ cb_resolution��5!      $��Center=�6.   $	��Top=�6L   $	��152��6d   .@�5#      �� $��
Fullscreen��6   �� 5$      $��
1920×1080��6   �� 5%      $��768x1024��6   �� 5&      $��360x800��6   5(      5)      �� 5+   
   $��Center=�6   $	��Top=�63   $��	0,310,0,0q�6K    �� Orientation$ 
Horizontal=�6^   .+�5,      �� $��Path:��6   $
��Left=�6$   $	��Top=�6?   $��15(�6W   �� 5-      -   5        	 ��Name$	 txt_path��5-      $��Center=�6(   
 �� TextWrapping$

 Wrap=�6E   $��TextBox��6Y   $	��Top=�6h   $	��120��6�   $��29��6�   $��15(�6�    �� AcceptsReturn$
 True��6�   $��30,0,0,0q�6�   5/      �� 50   
   -   5        $��Confirm��50      $��Center=�6#   $��Center=�6@   $��20(�6[   $��	0,300,0,0q�6i   ���	#FF6EAF3A6�   54      55      