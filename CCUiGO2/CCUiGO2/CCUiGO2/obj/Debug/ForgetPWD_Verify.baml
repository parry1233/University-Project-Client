   M S B A M L   `   `   `  ����B  >CCUiGO2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CCUiGO2CCUiGO2  5   	       CCUiGO2.ForgetPWD_Verify   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   J FXamlAnimatedGif, Version=1.2.2.0, Culture=neutral, PublicKeyToken=null<gif2https://github.com/XamlAnimatedGif/XamlAnimatedGif  5      !localclr-namespace:CCUiGO2  5   	     � Icon$  Icon/igo_white.png��5
   	    � Title$ ForgetPwVerify��5   	   $	��400��6    $	��480��6-    � WindowState$ Normal=�69    � WindowStyle$
 None=�6N   ���#6E7783 � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�6    � 	Resources 5       �� 
TargetType   Textbox1 �� Property	 �� Value
 �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value  Button1 �� EndPoint �� 
StartPoint � Color � Offset'  !MaterialDesignThemes.Wpf.PackIcon  materialDesign1��%F  &	        &	 R    &	 �    �� 5   
   " ��6   .�5      ��  � ��	 �#0006+   �� 5       � ��$		 223��6&   �� 5       � ��$	 33��6'   �� 5       � ��$	 12(�6)   �� 5       � ��	 5      �� 5      "
 ��6&   .R�5      �� $ border��6!   $ 15��5   !   ���#D8E6E7$��2q�5   !   ���#D8E6E7$��	10,0,10,0q�5   6   ._�5      �� $ PART_ContentHost��6+   |�.  $��Hidden=�6W   $��Hidden=�6~   5       5      P� 5       �@J�IsMouseOver . 5      P� 5        �@J�	IsFocused . 5!      5#      5%      5&      �� 5(   
   " ��6   .�5)      ��  � ��$	 15(�6)   �� 5*       � ��
	 �����6+   �� 5+       � ��	 �#77AAAD6+   �� 5,       � ��$		 141��6&   �� 5-       � ��$	 33��6'   �� 5.       � ��	 5/      �� 50      "
 ��6&   .R�51      �� $��PART_Background��6{   #��z��6!   $��0q�6U   $ 16��6i   ��52      �� 53   "   $	 0,1&�66   $	 0,0&�6E   .��54   &   � $ #77AAAD��63   $	 0.0Q�6C   55   #   ._�57      �� #��z��6/   $��Center=�6b   $��Center=�6   58      59      5;      5<      �� 5>   
   "  6   .�5?      ��  � ��$	 27��6'   �� 5@       � ��$	 19��6&   �� 5A       � ��	 �#D8E6E76+   5B      5C      .��5E      � .+�5F   
   � -   5        $��25��5F      $��	0,0,0,375q�6   ���#77AAAD � Cursor$
 Hand��6Z   .+�5G      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�5H      �� -   5         ��Name$ Title��5H      ���	#FF5C99D6$��Hidden=�6A   $��25��6�   $��64��6�   ��5I      �� 5J      .R�5K      �� $ 
Horizontal=�6)   
������ 6B   5L      .@�5N      �� -   5         ��Name$ ZoomIn��5N   #   .��5O        �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$ Minus=�62   $��15��6?   $��15��6K   ���#D8E6E76V   5P      �� 5Q      -   5        $ Close��5Q   #   .��5R        $ Close=�62   $��15��6?   $��15��6K   ���#D8E6E76V   5S      5T      5U      5V      � 5X   
   $��
0,25,0,275q�6   .+�5Y      �� $��62��6   $��60��6   $��0,0,0,19q�6+   $ ��Icon\igo_white_update1.png��6=   $
��Fill=�6a   $��Center=�6p   �� 5Z      $��Take Care Of Your Course��6   ���#D8E6E7$��0,0,0,8q�6L   $��Center=�6]   $��Bottom=�6z   5[      � 5]   
   $��0,125,0,120q�6   .+�5^      �� $ 
Horizontal=�6   $��Center=�62   $��	0,30,0,90q�6O   .+�5_      �� $��
驗證碼:��6   ���#D8E6E7$��16(�6<   �� 5`      -   5         ��Name$ verify_code_text��5`      #��[  64   $��center=�6V   $��輸入驗證碼��6x   
�������5a   4   �� 5b      -   5        $��ReVerifyCodeBTN��5b      $��重取驗證碼��60   $	��Top=�6@   $	��101��6X   $��34��6d   $��0,0,0,0q�6p   #��[ 6�   6�   5c      �� 5e      $E��?若未收到驗證碼信，請點選重取驗整碼的按鈕，��6   ���#D8E6E7$��	70,90,0,0q�6I    J� Opacity$	 0.6Q�6\   $
��Left=�6j   �� 5f      $6��0或返回上一步確認信箱輸入正確與否��6   ���#D8E6E7$��
70,110,0,0q�6D   $	 0.6Q�6X   $
��Left=�6f   5h      � 5j   
   $��	0,350,0,0q�6   .+�5k      �� -   5        $
��next��5k      $
��NEXT��6!   $��70��60   $��30��6;   $��	380,0,0,0q�6G   #��[ 6Z   6{   �� 5l      -   5        $
��back��5l      $
��BACK��6!   $��70��60   $��30��6;   $��	0,0,380,0q�6G   #��[ 6Z   6{   5m      5n      5o      