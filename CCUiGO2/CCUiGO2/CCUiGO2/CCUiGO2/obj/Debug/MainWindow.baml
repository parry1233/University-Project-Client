   M S B A M L   `   `   `  ����B  >CCUiGO2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CCUiGO2CCUiGO2  5   	       CCUiGO2.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   J FXamlAnimatedGif, Version=1.2.2.0, Culture=neutral, PublicKeyToken=null<gif2https://github.com/XamlAnimatedGif/XamlAnimatedGif  5      !localclr-namespace:CCUiGO2  5   	     � Icon$  Icon/igo_white.png��5
   	    � Title$ 
MainWindow��5   	   $	��400��6   $	��480��6)    � WindowState$ Normal=�65    � WindowStyle$
 None=�6J   ���#6E7783 � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�6    � 	Resources 5       �� 
TargetType   Textbox1 �� Property	 �� Value
 �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value  PasswordBox1  Button1 �� EndPoint �� 
StartPoint � Color � Offset'  !MaterialDesignThemes.Wpf.PackIcon  materialDesign1 
 label1��%�  &	        &	 y    &	 $    &	 d    &	 �    �� 5   
   " ��6   .�5      ��  � ��
	 �   �6+   �� 5       � ��$		 182��6&   �� 5       � ��$	 33��6'   �� 5       � ��$	 12(�6)   �� 5       � ��$	 Center=�69   �� 5       � ��	 5      �� 5      "
 ��6&   .R�5      �� $ border��6!   $ 15��5   !   ���#D8E6E7$��2q�5   !   ���#D8E6E7$��	10,0,10,0q�5   6   ._�5      �� $ PART_ContentHost��6+   |�.  $��Hidden=�6W   $��Hidden=�6~   5       5      P� 5       �@J�IsMouseOver . 5       P� 5!       �@J�	IsFocused . 5"      5$      5&      5'      �� 5)   
   " G�6   .�5*      ��  � ��	 �#0006+   �� 5+       � ��$		 182��6&   �� 5,       � ��$	 33��6'   �� 5-       � ��$	 9(�6)   �� 5.       �@G�PasswordChar$		 ●��6-   �� 5/       � ��$	 Center=�69   �� 50       � ��	 51      �� 52      "
 G�6&   .R�53      �� $ border��6!   $ 15��54   !   ���#D8E6E7$��2q�56   !   ���#D8E6E7$��	10,0,10,0q�57   6   ._�58      �� $ PART_ContentHost��6+   |�.  $��Hidden=�6W   $��Hidden=�6~   59       5:      P� 5;       �@J�IsMouseOver . 5<      P� 5=       �@J�	IsFocused . 5>      5@      5B      5C      �� 5E   
   " ��6   .�5F      ��  � ��$	 15(�6)   �� 5G       � ��
	 �����6+   �� 5H       � ��	 �#77AAAD6+   �� 5I       � ��$		 141��6&   �� 5J       � ��$	 33��6'   �� 5K       � ��	 5L      �� 5M      "
 ��6&   .R�5N      �� $��PART_Background��6{   #��z��6!   $��0q�6U   $ 16��6i   ��5O      �� 5P   "   $	 0,1&�66   $	 0,0&�6E   .��5Q   &   � $ #77AAAD��63   $	 0.0Q�6C   5R   #   ._�5T      �� #��z��6/   $��Center=�6b   $��Center=�6   5U      5V      5X      5Y      �� 5[   
   "  6   .�5\      ��  � ��$	 25��6'   �� 5]       � ��$	 25��6&   �� 5^       � ��	 �#D8E6E76+   5_      �� 5a   
   " ��6   .�5b      ��  � ��$	 23(�6)   �� 5c       � ��	 �#D8E6E76+   5d      5e      .��5g      � .+�5h   
   � -   5        $��25��5h      $��	0,0,0,375q�6   ���#77AAAD � Cursor$
 Hand��6Z   .+�5i      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�5j      �� -   5         ��Name$ Title��5j      ���	#FF5C99D6$��Hidden=�6A   $��25��6�   $��64��6�   ��5k      �� 5l      .R�5m      �� $ 
Horizontal=�6)   
������ 6B   5n      .@�5p      �� -   5         ��Name$ ZoomIn��5p   #   .��5q        �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$ Minus=�62   $��15��6?   $��15��6K   ���#D8E6E76V   5r      �� 5s      -   5        $ Close��5s   #   .��5t        $ Close=�62   $��15��6?   $��15��6K   ���#D8E6E76V   5u      5v      5w      5x      � 5z   
   $��
0,25,0,275q�6   .+�5{      �� $��62��6   $��60��6   $��0,0,0,19q�6+   $ ��Icon\igo_white_update1.png��6=   $
��Fill=�6a   $��Center=�6p   �� 5|      $��Take Care Of Your Course��6   ���#D8E6E7$��0,0,0,8q�6L   $��Center=�6]   $��Bottom=�6z   5}       � 5   
   -   5          �Name$ frame��5      $	��480��6   $��	0,125,0,0q�6+     � NavigationUIVisibility$ Hidden=�6>   5�      5�      