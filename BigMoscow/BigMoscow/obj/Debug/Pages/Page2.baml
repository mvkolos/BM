   M S B A M L   `   `   `  ����S  OBornander.UI.TabCarousel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulleHclr-namespace:Bornander.UI.TabCarousel;assembly=Bornander.UI.TabCarouselBornander.UI.TabCarousel  5      D @BigMoscow, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:BigMoscow	BigMoscow 5      ;"clr-namespace:BigMoscow.PropertiesBigMoscow.Properties 5         BigMoscow.CarouselPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ^	bornanderHclr-namespace:Bornander.UI.TabCarousel;assembly=Bornander.UI.TabCarousel     5      )localclr-namespace:BigMoscow     5      9
properties"clr-namespace:BigMoscow.Properties     5      $
��1080��5
      $
��1920��6     N� Title$  Page2��5       J� IsManipulationEnabled .  N� 
Background 5      �� 5   
   -   5        backgroundImage�� �� ImageSource$' !/UI/MainScreen/mainscreenMain.png��5   .   .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5       � ColumnDefinitions 5!   
   �� 5"      �� 5#      �� 5$      .+�5(   
   '   !Bornander.UI.TabCarousel.Carousel  -   5          Name$ 
TabControl��5(      $��0 -200 0 -200q�61      Depth$	 0.1Q�6H   $��3��6T   $��1��6h    . 5)      o� 5+   
   $��1��6   
������ $��Center=�68   $��20q�6U   .@�5-      m� -   5        $��RU��5-      $��28(�6O   ���	#FFD8D8D86]   �� 5.      $7��1/BigMoscow;component/UI/MainScreen/earth_icon.png��6   $��40��6O   m� 50      -   5        $	��ENG��50      $��28(�6S   ���	#FFD8D8D86a   53      �� 54   
   -   5        $��button_previous��54   F   
������ $
��Left=�6+   $��1��6]   $��70��6j   ���	#00707070$��65,0,0,0q�6�   .��55      �� .+�56      �� $��60��6   $#��/UI/MainScreen/arrow_left.png��6#   57      ��58      �� 59       �� 
TargetType" ��6   .�5:      �� 	 �� Property	 � ��
 �� Value

 ���� 63   �� 5;      	 � ��
 5<      �� 5=       �� 
TargetType" ��6.   .R�5>   "   �� #��z��6)   ._�5?   &   �� $��Center=�67   $��Center=�6T   5@   #   5A      5C       �� Triggers 5D      P� 5E       P� Property �@J�IsMouseOver P� Value . . �5F      �� 	 � ��

 ���� 6;   5G      5I      5K      �� 5L   
   -   5        $��button_next��5L      $��Right=�6$   $��1��6A   $��2��6N   $��70��6^   
������ $��0,0,65,0q�6�   .��5M      � .+�5N      �� $��60��6   $8��2/BigMoscow;component/UI/MainScreen/arrow_right.png��6#   $��Right=�6_   $��
0,0,0,0.31q�6{   5O      ��5P      �� 5Q      " ��6   .�5R      �� 	 � ��

 ���� 63   �� 5S      	 � ��
 5T      �� 5U      " ��6.   .R�5V   "   �� #��z��6)   ._�5W   &   �� $��Center=�67   $��Center=�6T   5X   #   5Y      5[       5\      P� 5]       �@J�IsMouseOver . . �5^      �� 	 � ��

 ���� 6;   5_      5a      5d      5f      5g      