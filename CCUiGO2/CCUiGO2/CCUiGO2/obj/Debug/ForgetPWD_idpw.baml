   M S B A M L   `   `   `  ����B  >CCUiGO2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CCUiGO2CCUiGO2  5   	       CCUiGO2.ForgetPWD_idpw   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      !localclr-namespace:CCUiGO2  5   	     � Icon$  Icon/igo_white.png��5	       � Title$ ForgetPWD_idpw��5
      $	��400��6   $	��480��6%    � WindowState$ Normal=�61    � WindowStyle$
 None=�6F   ���#6E7783 � 
ResizeMode$ NoResize=�6n    � WindowStartupLocation$ CenterScreen=�6�   |�.  � 	Resources 6�    �� 
TargetType   Textbox1 �� Property	 �� Value
 �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value  Button1 �� EndPoint �� 
StartPoint � Color � Offset'  !MaterialDesignThemes.Wpf.PackIcon  materialDesign1��%F  &	        &	 R    &	 �    �� 5   
   " ��6   .�5      ��  � ��	 �#0006+   �� 5       � ��$		 223��6&   �� 5       � ��$	 33��6'   �� 5       � ��$	 12(�6)   �� 5       � ��	 5      �� 5      "
 ��6&   .R�5      �� $ border��6!   $ 15��5   !   ���#D8E6E7$��2q�5   !   ���#D8E6E7$��	10,0,10,0q�5   6   ._�5      �� $ PART_ContentHost��6+   |�.  $��Hidden=�6W   $��Hidden=�6~   5       5      P� 5       �@J�IsMouseOver . 5      P� 5       �@J�	IsFocused . 5      5       5"      5#      �� 5%   
   " ��6   .�5&      ��  � ��$	 15(�6    �� 5'       � ��
	 �����6"   �� 5(       � ��	 �#77AAAD6"   �� 5)       � ��$		 141��6   �� 5*       � ��$	 33��6   �� 5+       � ��	 5,      �� 5-      "
 ��6   .R�5.      �� $��PART_Background��6i   #��z��6   $��0q�6C   $ 16��6W   ��5/   	   �� 50   
   $	 0,1&�6   $	 0,0&�6-   .��51      � $ #77AAAD��6   $	 0.0Q�6(   52      ._�54   	   �� #��z��6   $��Center=�6M   $��Center=�6j   55   	   56      58      59      �� 5;      "  6
   .�5<      ��  � ��$	 27��6   �� 5=       � ��$	 19��6   �� 5>       � ��	 �#D8E6E76"   5?      5A      .��5B      � .+�5C   
   � -   5        $��25��5C      $��	0,0,0,375q�6   ���#77AAAD � Cursor$
 Hand��6Z   .+�5D      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�5E      �� -   5         ��Name$ Title��5E      ���	#FF5C99D6$��Hidden=�6A   $��25��6�   $��64��6�   ��5F      �� 5G      .R�5H      �� $ 
Horizontal=�6)   
������ 6B   5I      .@�5K      �� -   5         ��Name$ ZoomIn��5K   #   .��5L        �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$ Minus=�62   $��15��6?   $��15��6K   ���#D8E6E76V   5M      �� 5N      -   5        $ Close��5N   #   .��5O        $ Close=�62   $��15��6?   $��15��6K   ���#D8E6E76V   5P      5Q      5R      5S      � 5U   
   $��
0,25,0,275q�6   .+�5V      �� $��62��6   $��60��6   $��0,0,0,19q�6+   $ ��Icon\igo_white_update1.png��6=   $
��Fill=�6a   $��Center=�6p   �� 5W      $��Take Care Of Your Course��6   ���#D8E6E7$��0,0,0,8q�6L   $��Center=�6]   $��Bottom=�6z   5X      � 5Z   
   $��0,125,0,120q�6   .+�5[      �� $ 
Horizontal=�6   $��Center=�62   $��	0,40,0,70q�6O   .+�5\        $ Account=�6*   $��0,7,0,0q�69   #��[ 6J   �� 5]      -   5         ��Name$ 
id_textbox��5]      #��[  6.   5^      �� 5_      $ 
Horizontal=�6   $��Center=�62   $��	0,90,0,20q�6O   .+�5`        $ Email=�6*   $��0,7,0,0q�67   #��[ 6H   �� 5a      -   5        $ email_textbox��5a      #��[  61   5b      5c      � 5e      $��	0,350,0,0q�6	   .+�5f      �� -   5        $
��next��5f      $
��NEXT��6!   $��70��60   $��30��6;   $��	380,0,0,0q�6G   #��[ 6Z   6{   �� 5g      -   5        $
��back��5g      $
��BACK��6!   $��70��60   $��30��6;   $��	0,0,380,0q�6G   #��[ 6Z   6{   5h      5i      5j      