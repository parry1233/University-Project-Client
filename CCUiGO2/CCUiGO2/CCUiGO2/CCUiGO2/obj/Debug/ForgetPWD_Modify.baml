   M S B A M L   `   `   `  ����B  >CCUiGO2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CCUiGO2CCUiGO2  5   	       CCUiGO2.ForgetPWD_Modify   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      !localclr-namespace:CCUiGO2  5   	     � Icon$  Icon/igo_white.png��5	       � Title$ forget_pwd_modify��5
   	   $	��400��6#   $	��480��60    � WindowState$ Normal=�6<    � WindowStyle$
 None=�6Q   ���#6E7783 � 
ResizeMode$ NoResize=�6y    � WindowStartupLocation$ CenterScreen=�6�   |�.  � 	Resources 5       �� 
TargetType   PasswordBox1 �� Property	 �� Value
 �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value  Button1 �� EndPoint �� 
StartPoint � Color � Offset'  !MaterialDesignThemes.Wpf.PackIcon  materialDesign1��%�  &	        &	 �    &	 �    �� 5   
   " G�6   .�5      ��  � ��	 �#0006+   �� 5       � ��$		 182��6&   �� 5       � ��$	 33��6'   �� 5       �@G�PasswordChar$		 ●��6-   �� 5       � ��$	 9(�6)   �� 5       � ��$	 Center=�69   �� 5       � ��	 5      �� 5      "
 G�6&   .R�5      �� $ border��6!   $ 15��5   !   ���#D8E6E7$��2q�5   !   ���#D8E6E7$��	10,0,10,0q�5   !   ._�5      �� $ PART_ContentHost��6+   |�.  $��Hidden=�6W   $��Hidden=�6~   5       5      P� 5       �@J�IsMouseOver . 5       P� 5!       �@J�	IsFocused . 5"      5$      5&      5'      �� 5)   
   " ��6   .�5*      ��  � ��$	 15(�6)   �� 5+       � ��
	 �����6+   �� 5,       � ��	 �#77AAAD6+   �� 5-       � ��$		 141��6&   �� 5.       � ��$	 33��6'   �� 5/       � ��	 50      �� 51      "
 ��6&   .R�52      �� $��PART_Background��6{   #��z��6!   $��0q�6U   $ 16��6i   ��53      �� 54   "   $	 0,1&�66   $	 0,0&�6E   .��55   &   � $ #77AAAD��63   $	 0.0Q�6C   56   #   ._�58      �� #��z��6/   $��Center=�6b   $��Center=�6   59      5:      5<      5=      �� 5?   
   "  6   .�5@      ��  � ��$	 27��6'   �� 5A       � ��$	 19��6&   �� 5B       � ��	 �#D8E6E76+   5C      5E      .��5G      � .+�5H   
   � -   5        $��25��5H      $��	0,0,0,375q�6   ���#77AAAD � Cursor$
 Hand��6Z   .+�5I      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�5J      �� -   5         ��Name$ Title��5J      ���	#FF5C99D6$��Hidden=�6A   $��25��6�   $��64��6�   ��5K      �� 5L      .R�5M      �� $ 
Horizontal=�6)   
������ 6B   5N      .@�5P      �� -   5         ��Name$ ZoomIn��5P   #   .��5Q        �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$ Minus=�62   $��15��6?   $��15��6K   ���#D8E6E76V   5R      �� 5S      -   5        $ Close��5S   #   .��5T        $ Close=�62   $��15��6?   $��15��6K   ���#D8E6E76V   5U      5V      5W      5X      � 5Z   
   $��
0,25,0,275q�6   .+�5[      �� $��62��6   $��60��6   $��0,0,0,19q�6+   $ ��Icon\igo_white_update1.png��6=   $
��Fill=�6a   $��Center=�6p   �� 5\      $��Take Care Of Your Course��6   ���#D8E6E7$��0,0,0,8q�6L   $��Center=�6]   $��Bottom=�6z   5]      � 5_   
   $��0,125,0,120q�6   .+�5`      �� $ 
Horizontal=�6   $��Center=�62   $��	0,40,0,70q�6O   .+�5a        $	 Key=�6*   $��0,13,0,0q�65   #��[ 6G   G� 5b      -   5         G�Name$ 	pw_modify��5b      #��[  61   6W   5c      �� 5d      $ 
Horizontal=�6   $��Center=�62   $��
25,90,0,20q�6O   .+�5e        $ CheckAll=�6*   $��0,13,0,0q�6:   #��[ 6L   G� 5f      -   5        $ pw_modify_recheck��5f      #��[  69   6_     5g      -   5        $��conditionIcon��5g   *   $ 	CheckBold=�6?   $��0,13,0,0q�6P   #��[ 6b   ���#8CD7906�   5h      5i      � 5k   
   $��	0,350,0,0q�6   .+�5l      �� -   5        $
��next��5l      $
��NEXT��6!   $��70��60   $��30��6;   $��	380,0,0,0q�6G   #��[ 6Z   6{   �� 5m      -	   5        $
��back��5m      $
��BACK��6!   $��70��60   $��30��6;   $��	0,0,380,0q�6G   #��[ 6Z   6{   5n      5o      5p      