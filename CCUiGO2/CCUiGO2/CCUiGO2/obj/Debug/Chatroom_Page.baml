   M S B A M L   `   `   `  ����B  >CCUiGO2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CCUiGO2CCUiGO2  5          CCUiGO2.Chatroom_Page   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:CCUiGO2     5      U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� 
Background
  ����� � 	Resources 5
       �� 
TargetType   Button1 �� Property �� Value �� 
TargetType �� CornerRadius �� EndPoint �� 
StartPoint	 � Color
 � Offset  Textbox1 ��Name ��Name �� Triggers P� Property P� Value'  !MaterialDesignThemes.Wpf.PackIcon  materialDesign1��%�  &	        &	 J    &	 �    �� 5   
   " ��6   .�5      ��  � ��$ 15(�6)   �� 5       � �� �#504E636+   �� 5       � ��$	 141��6&   �� 5       � ��$ 33��6'   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��PART_Background��6{   #��z��6!   $��0q�6U   $ 16��6i   ��5      �� 5   "   $	 0,1&�66   $	 0,0&�6E   .��5   &   � $	 
WhiteSmoke��63   $	
 0.0Q�6F   5   #   ._�5      �� #��z��6/   $��Center=�6b   $��Center=�6   5      5      5      5      �� 5!   
   " ��6   .�5"      ��  � ��$ 20(�6)   �� 5#       �@��TextWrapping$
 Wrap=�6-   �� 5$       � ��$ Center=�69   �� 5%       � ��$ Center=�62   �� 5&       � ��$
 Left=�64   �� 5'       � �� �#0006+   �� 5(       � �� 5)      �� 5*      " ��6&   .R�5+      �� $ border��6!   $ 15��5,   !   
�������$��2q�5.   !   
�������$��	10,0,10,0q�5/   9   ._�50      �� $ PART_ContentHost��6+   |�.  $��Hidden=�6W   $��Hidden=�6~   51       52      P� 53       �@J�IsMouseOver . 54      P� 55       �@J�	IsFocused . 56      58      5:      5;      �� 5=   
   "  6   .�5>      ��  � ��$ 30��6'   �� 5?       � ��$ 30��6&   �� 5@       � ��
 �����6+   5A      5B      .��5D      � .+�5E   
   � $��	0,0,0,520q�6   ���#504E63.+�5F      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   $��Center=�6O   .+�5G      �� -   5        $��exitIcon��5G      $��-190,0,160,0q�6,   $��Center=�6B    � Cursor$
 Hand��6]    � ToolTip$ 離開聊天室��6k     5H      �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$ ExitRun=�6   #��[ 6.   5I      �� 5J      -   5         ��Name$ Chatroom_inName��5J      $��話題名稱��65   $��30(�6A   $	��600��6O   
�������$��0,0,0,0q�6s    �� TextAlignment$ Center=�6�   5K      5L      � 5N   
   $��	0,55,0,55q�6   .+�5O      �� $
��Auto=�6   ��. $	��430��6V   $��40,20,40,20q�6c   .��5P      �� -   5         ��Name$ ChatBox��5P      ���#CBA6C36.   5Q      5R      � 5T   
   $��	0,520,0,0q�6   ���#504E63.+�5U      �� -   5         ��Name$ SendBox��5U      $�� ��6'   $	��860��6/   $��35��6;   $��30,0,0,0q�6G   #��[ 6Y   6{   �� 5V      -   5        $��NextBTN��5V      $
��SEND��6$   $��85��63   $��35��6>   $��	880,0,0,0q�6J   #��[  6]   6~   5W      5X      5Z      