   M S B A M L   `   `   `  ����B  >CCUiGO2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CCUiGO2CCUiGO2  5   	       CCUiGO2.sign_up_info   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   J FXamlAnimatedGif, Version=1.2.2.0, Culture=neutral, PublicKeyToken=null<gif2https://github.com/XamlAnimatedGif/XamlAnimatedGif  5      !localclr-namespace:CCUiGO2  5   	     � Icon$  Icon/igo_white.png��5
   	    � Title$ sign up info��5   	   $	��400��6   $	��480��6+    � WindowState$ Normal=�67    � WindowStyle$
 None=�6L   ���#6E7783 � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�6    � 	Resources 5       �� 
TargetType   Textbox1 �� Property	 �� Value
 �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value �� 	ClickMode d� 	IsChecked �� Mode �� RelativeSource J� SnapsToDevicePixels �� Triggers J� IsHitTestVisible �� SelectionBoxItem �� SelectionBoxItemTemplate ��Name �� 
IsReadOnly � HorizontalOffset � ActualWidth �� IsDropDownOpen �� Color  K� IsItemsHost-  'System.Windows.Input.KeyboardNavigation!   DirectionalNavigation  Button1" �� EndPoint# �� 
StartPoint$ � Color% � Offset'  !MaterialDesignThemes.Wpf.PackIcon  materialDesign1��%�  &	        '�� R    &	 �	    &	     �� 5   
   " ��6   .�5      ��  � ��	 �#0006+   �� 5       � ��$		 223��6&   �� 5       � ��$	 33��6'   �� 5       � ��$	 12(�6)   �� 5       � ��	 5      �� 5      "
 ��6&   .R�5      �� $ border��6!   $ 15��5   !   ���#D8E6E7$��2q�5   !   ���#D8E6E7$��	10,0,10,0q�5   6   ._�5      �� $ PART_ContentHost��6+   |�.  $��Hidden=�6W   $��Hidden=�6~   5       5      P� 5       �@J�IsMouseOver . 5      P� 5        �@J�	IsFocused . 5!      5#      5%      5&      �� 5(   
   " ��6   .�5)      ��  � ��$	 7q�6(   �� 5*       � ��	 �#0006+   �� 5+       � ��$		 205��6&   �� 5,       � ��$	 33��6'   �� 5-       � ��	 5.      �� 5/      "
 ��6&   .R�50      �� ���#D8E6E7$��3q�68   $ 15��6L   ���#D8E6E7._�51      � .+�53   "   d� $ Press=�6/   |�.  $��2q�6�   $��0��6�   $��0��6�   $
��Auto��6�    6S   �� *IsDropDownOpen+$ TwoWay=� �� *TemplatedParent+��54   &   �� 55   *   " d�60   .�56   .   ��  � ��$	 0��6I   �� 57   .    � ��$	 0��6J   �� 58   .    � ��$
	 Auto��6F   �� 59   .    � ��$
	 Auto��6G   �� 5:   .    � ��	 �#D8E6E76K   �� 5;   .    � ��	 �#D8E6E76L   �� 5<   .    � ��$	 2q�6P   �� 5=   .    � ��	 5>   2   �� 5?   6   "
 d�6F   .R�5@   :   ]� #��z��6D   ��.   . .+�5A   >   �� $ Border��6E   #��z��6U   #��z��6�   $��Right=�6�   ._�5B   B   F� "����        ��g5  	= ���j     	#��z��6^   $��Center=�6�   $��Center=�6�   5C   ?   5D   ;    5E   :   P� 5F   >    �@d�	IsChecked$
 TrueY�6[   5G   ?   5I   7   5K   /    5L   .   P� 5M   2    � {� .  . �5N   6   ��  � ��#	 � ��6S   5O   3   5Q   +   5S   #   �� 5U   "    .  #��z 6M   #��z 6z   #��z��6�   $��Center=�6�   $��3q�6  $��Stretch=�6  �� 5V   "   $ PART_EditableTextBox��6*   $��Stretch=�6H   |�. $y�	Collapsed=�6w    .  6�   � 5X   "   $ -1��6(   #��z 6>   #��z 5Y   (   |�.  $��Slide=�6d   .��5Z   &   �  . $��Stretch=�6G   .+�5[   *   �� $��1,1,1,1q�62   
�������$��Stretch=�6_   $ 5��6}   ��5\   .   �� 5]   2   $ White��6B   5_   +   �� 5`   *    . $��Stretch=�6S   .��5a   .   ��   . $! 	Contained=�6L   $��Stretch=�6�   5b   +   5c   '   5d   #   5e      5f      5g      5i      5j      �� 5l   
   " ��6   .�5m      ��  � ��$	 15(�6)   �� 5n       � ��
	 �����6+   �� 5o       � ��	 �#77AAAD6+   �� 5p       � ��$		 141��6&   �� 5q       � ��$	 33��6'   �� 5r       � ��	 5s      �� 5t      "
 ��6&   .R�5u      �� $��PART_Background��6{   #��z��6!   $��0q�6U   $ 16��6i   ��5v      �� 5w   "   $	" 0,1&�66   $	# 0,0&�6E   .��5x   &   � $$ #77AAAD��63   $	% 0.0Q�6C   5y   #   ._�5{      �� #��z��6/   $��Center=�6b   $��Center=�6   5|      5}      5      5�      �� 5�   
   "  6   .�5�      ��  � ��$	 27��6'   �� 5�       � ��$	 19��6&   �� 5�       � ��	 �#D8E6E76+   5�      5�      .��5�      � .+�5�   
   � -   5        $��25��5�      $��	0,0,0,375q�6   ���#77AAAD& � Cursor$
& Hand��6Z   .+�5�      �� ' �� Orientation$' 
Horizontal=�6   $��Right=�62   .+�5�      �� -   5        ( ��Name$( Title��5�      ���	#FF5C99D6$��Hidden=�6A   $��25��6�   $��64��6�   ��5�      �� 5�      .R�5�      �� $' 
Horizontal=�6)   
������ 6B   5�      .@�5�      �� -   5        ) ��Name$) ZoomIn��5�   #   .��5�        �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]*   Kind$* Minus=�62   $��15��6?   $��15��6K   ���#D8E6E76V   5�      �� 5�      -   5        $) Close��5�   #   .��5�        $* Close=�62   $��15��6?   $��15��6K   ���#D8E6E76V   5�      5�      5�      5�      � 5�   
   $��
0,25,0,275q�6   .+�5�      �� $��62��6   $��60��6   $��0,0,0,19q�6+   $ ��Icon\igo_white_update1.png��6=   $
��Fill=�6a   $��Center=�6p   �� 5�      $��Take Care Of Your Course��6   ���#D8E6E7$��0,0,0,8q�6L   $��Center=�6]   $��Bottom=�6z   5�      � 5�   
   $��
0,125,0,50q�6   .+�5�      �� $' 
Horizontal=�6   $��Center=�62   $��	0,0,0,180q�6O   .+�5�        $	��0,8q�6*   $
* Face=�67   #��[ 6C   �� 5�      -   5        $ nickname��5�      $��暱稱��6,   
�������#��[  6H   $��Center=�6j   5�   9   5�      �� 5�      $' 
Horizontal=�6   $��Center=�62   $��
0,50,0,130q�6O   .+�5�        $	��0,8q�6*   $* Email=�67   #��[ 6D   �� 5�      -   5        $ email��5�      $��Email��6)   
�������#��[  6H   $��Center=�6j   5�   6   5�      �� 5�      $' 
Horizontal=�6   $��Center=�62   $��
0,100,0,80q�6O   .+�5�        $* School=�6*   $��-3,8,6,0q�68   #��[ 6J   �� 5�      -   5        $��
department��5�      $��5q�6-   + �� SelectedIndex$+ 0��68   .@�5�      �� $$��認知科學博士學位學程��6#   �� 5�      $��工學院學士班��6#   �� 5�      $��工學院碩士班��6#   �� 5�      $��	資工系��6#   �� 5�      $��	資工所��6#   �� 5�      $��	電機系��6#   �� 5�      $��	電機所��6#   �� 5�      $��	機械系��6#   �� 5�      $��	機械所��6#   �� 5�      $��	化工系��6#   �� 5�      $��	化工所��6#   �� 5�      $��	通訊系��6#   �� 5�      $��	通訊所��6#   �� 5�      $��光機電所��6#   �� 5�      $.��(前瞻製造系統碩/博士學位學程��6#   �� 5�      $$��環境智能博士學位學程��6#   �� 5�      $��經濟學系��6#   �� 5�      $��	國經所��6#   �� 5�      $��	財金系��6#   �� 5�      $��	財金所��6#   �� 5�      $��	企管系��6#   �� 5�      $��	企管所��6#   �� 5�      $��	會資系��6#   �� 5�      $��	會資所��6#   �� 5�      $��	資管系��6#   �� 5�      $��	資管所��6#   �� 5�      $$��國際財管碩士學位學程��6#   �� 5�      $��行銷管理所��6#   �� 5�      $��醫療資訊管理所��6#   �� 5�      $��法學院學士班��6#   �� 5�      $��	法律所��6#   �� 5�      $��	法學組��6#   �� 5�      $��	法制組��6#   �� 5�      $��	財法系��6#   �� 5�      $��	財法所��6#   �� 5�      $��	成教系��6#   �� 5�      $��	成教所��6#   �� 5�      $��	教育所��6#   �� 5�      $��	犯防系��6#   �� 5�      $��	犯防所��6#   �� 5�      $��休閒教育所��6#   �� 5�      $��	運競系��6#   �� 5�      $��	課研所��6#   �� 5�      $$��教育領導碩士學位學程��6#   �� 5�      $��高齡教育所��6#   5�      5�      �� 5�      $' 
Horizontal=�6   $��Center=�62   $��
0,150,0,30q�6O   .+�5�        $* BookOpenpageVariant=�6*   $��-3,8,6,0q�6E   #��[ 6W   �� 5�      -   5        , ��Name$, grade��5�      $��5q�6*   $+ 0��65   .@�5�      �� $��	一年級��6#   �� 5�      $��	二年級��6#   �� 5�      $��	三年級��6#   �� 5�      $��	四年級��6#   �� 5�      $��碩士一年級��6#   �� 5�      $��碩士二年級��6#   5�      5�      �� 5�      $' 
Horizontal=�6   $��Center=�62   $��	0,195,0,0q�6O   $	��195��6b   .+�5�        $* 	HumanMale=�6*   $��30��6;   $��25��6G   ���#D8E6E76R   	� 5�      -	   5        - 	�Name$
- male��5�      ���#D8E6E7$��60��6A   $��33��6L   $
��10,0q�6X   $��Center=�6f   ���	#FF77AAAD6�     5�      $* HumanFemale=�6*   $��30��6=   $��25��6I   ���#D8E6E76T   	� 5�      -
   5        $- female��5�      ���#D8E6E7$��60��6C   $��33��6N   $
��10,0q�6Z   $��Center=�6h   ���	#FF77AAAD6�   5�      5�      � 5�   
   $��	0,350,0,0q�6   .+�5�      �� -   5        $
��next��5�      $
��NEXT��6!   $��70��60   $��30��6;   $��	380,0,0,0q�6G   #��[ 6Z   6{   �� 5�      -   5        $
��back��5�      $
��BACK��6!   $��70��60   $��30��6;   $��	0,0,380,0q�6G   #��[ 6Z   6{   5�      5�      5�      