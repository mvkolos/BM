   M S B A M L   `   `   `  ����D  @BigMoscow, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:BigMoscow	BigMoscow  5      ;"clr-namespace:BigMoscow.PropertiesBigMoscow.Properties  5          BigMoscow.Pages.PageSend   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:BigMoscow     5      9
properties"clr-namespace:BigMoscow.Properties     5      -   5          N� Title$  PageSend��5
       N� 
Background 5      �� 5   
    �� ImageSource$; 5/BigMoscow;component/UI/MainScreen/mainscreenMain.png��6   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��660 �6   �� 5      $	��600 �6   �� 5      $	��660 �6    � RowDefinitions 5   
   �� 5      �� 5      $	��302 �6   �� 5      .+�5   
   �� $$��/UI/MainScreen/send_paddle.png��6   $��1��68   $��1��6H   o� 5   
   $��1��6   
������ $��Center=�68   $��20q�6U   .@�5      m� -   5        $��RU��5      $��28(�64   ���	#FFD8D8D86B   �� 5      $7��1/BigMoscow;component/UI/MainScreen/earth_icon.png��6   $��40��6O   m� 5!      -   5        $	��ENG��5!      $��28(�66   ���	#FFD8D8D86D   5$      �� 5%   
   -   5         ��Name$ magazines_back_button��5%      $��Right=�60   $	��Top=�6L   $��0 30 0 0q�6d   $��1��6v   $��74��5&      $	��100��6   ���	#00707070��5'      �� 5(      $( "/UI/MainScreen/mag_back_button.png��6   ��5*      �� 5+       �� 
TargetType" ��6   .�5,      ��  �� Property � �� �� Value
 ���� 63   �� 5-       � �� 5.      �� 5/      	 �� 
TargetType"	 ��6.   .R�50   "   �� #��z��6)   ._�51   &   �� $��Center=�67   $��Center=�6T   52   #   53      55      
 �� Triggers
 56      P� 57       P� Property �@J�IsMouseOver P� Value . . �58      ��  � ��
 ���� 6;   59      5;      5=      �� 5G   
   $��1��6   $��1��6!   $	��100��6.   $	��Top=�6;   $   BigMoscow.Properties.Resources   SendPageText#��Z 6S   $��28(�6�   
�������$��Center=�6�   $��0 30 0 0q�6�   �� 5I      -   5        $��textbox_Email��5I   :    �� TextAlignment$ Center=�6   $��10q�6-   $��65��6O   $	��500��6[    J� Opacity$	 0.7Q�6g   $��	0 20 0 30q�6u   $��1��6�   $��1��6�   $��Center=�5J      $��28(�6P   6^   �� 5K   
   -   5        $��button_send_smth��5K   L      button_send_smth#��Z 6   $��60��6d   $	��240��6p   $��Bottom=�6|   $��0 0 0 30q�6�   $��28(�5L   0   ���	#00707070���	#FFE21414$��SegoeUI)�6m   $��1��6�   $��1��6�   ��5M      �� 5N      " ��6   .�5O      ��  � ��
 ���� 67   �� 5P       � �� 5Q      �� 5R   "   "	 ��62   .R�5S   &   �� #��z��6-   ._�5T   *   �� $��Center=�6;   $��Center=�6X   5U   '   5V   #   5X      
 5Y      P� 5Z       �@J�IsMouseOver . . �5[   "   ��  � ��
 ���� 6?   5\      5^      5`      5b      5c      