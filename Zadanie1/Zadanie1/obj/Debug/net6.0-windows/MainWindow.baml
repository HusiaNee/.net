   M S B A M L   `   `   `  ����  Zadanie1    Zadanie1.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��600��6)    � 	Resources 5         SpecialLabelColor �� Color  ButtonMouseOverBackground  ButtonPressedBackground  WrapPanelBackground  StackPanelBackground  
LabelStyle �� 
TargetType �� Property �� Value  SpecialLabelStyle �� BasedOn  ButtonStyle �� 
TargetType �� Padding  WrapPanelButtonStyle	 �� Triggers
 P� Property P� Value��%�  &	        &	      &	 <     &	 [     &	 |     &	 �     &	     7  7   &	 T    &	 �    7  7  7  �� 5   
   $
 #900��64   �� 5   
   $
 lime��6<   �� 5   
   $ green��6:   �� 5	   
   $ #F5F5F5��66   �� 5
   
   $ #EFEFEF��67   �� 5   
   " ��6#   .�5      ��  � ��$
 Bold"�6+   �� 5       � ��$ 24(�6)   5      �� 5   
   " ��6*   8   .�5      ��  � ��8  6+   5      �� 5   
   " ��6$   .�5      ��  � ��$ 20(�6)   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   #��z��5   !   $��1q�5   !   $	��3 0q�5   !   $	 5 1q�5   !   ._�5      �� $��Center=�6/   $��Center=�6L   5       5!      5#      5$      �� 5&   
   " ��6-   8   	 5'      P� 5(      
 �@J�IsMouseOver$
 True��61   . �5)      ��  � ��8  63   5*      P� 5+      
 � ��$
 True��6/   . �5,      ��  � ��8  63   5-      5/      50      .��52      �  � RowDefinitions 53   
   �� 54      $
��Auto �6   �� 55      $��* �6    � ColumnDefinitions 57   
   �� 58      $
��Auto �6   �� 59      $��* �6   .+�5<   
   � $��1��6   $��1��6!    � Orientation$ 
Horizontal=�61   $��Bottom=�6J   $��Center=�6e   #��[ 6�   .+�5=      �� #��[ 6   $��Button 1��6C   �� 5>      #��[ 6   $��Button 2��6C   �� 5?      #��[ 6   $��Button 3��6C   5@      �� 5B   
   $��0��6   $��1��6"    �� Orientation$ Vertical=�62   $	��Top=�6I   $��Right=�6a   #��[ 6}   .+�5C      �� #��[ 6   $��Grupa 1��68   $��Right=�6J   �� 5D      #��[ 6   $��Grupa Specjalna��6?   $��Right=�6Y   �� 5E      #��[ 6   $��Grupa 2��68   $��Right=�6J   5F      5G      5H      