   M S B A M L   `   `   `  ����  WPFMitsuControls    WPFMitsuControls.BookPage   5      \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      -   5        
���  ��$��1q�5   )   .��5      � -   5          �Name$  mainGrid��5   	   .+�5
      �� -   5         ��Name$ page2��5
      �� 5      -   5         ��Name$ nextPageShadowCanvas��5       J� Opacity$ 1Q�6   $y�Hidden=�67   ��5      �� 5   
   -   5        nextPageShadow�� �� 
StartPoint$	 0 0&�5   6    �� EndPoint$	 0 0&�6G   .��5      �  � Color$ Transparent��6    � Offset$ 0Q�6-   � 5      -   5        nextPageShadowCanvasOffset1��$ Black��5   >   $ 0Q�6L   � 5      -   5        nextPageShadowCanvasOffset2��$ Transparent��5   >   $ 1Q�6R   � 5      $ Transparent��6   $ 1Q�6-   5      5      � 5       J� Clip 5      �� 5   
   -   5        clippingPage0��	 �� GeometryCombineMode$	 Exclude=�5   2   
 �� 	Geometry1
 5      �� 5       �� 	Geometry2 5      B� 5      .��5   	   E�  E� IsClosed . 6   5   	   5!      .+�5$      �� -	   5        $ page0��5$      5&      �� 5'      -
   5        $ 
gridShadow��5'      $ 1Q�6   $y�Hidden=�6-   ��5(      �� 5)      -   5        
pageShadow��$	 0 0&�5)   .   $	 0 0&�6?   .��5*      � $ Transparent��6   $ 0Q�6-   � 5+      $ Black��6   $ 0Q�6'   � 5,      $ Transparent��6   $ 1Q�6(   5-      5/      � 50      -   5        $  rectangleVisible��50      z�51      V� 52   
   .~�53      T� -   5        rectangleTranslate��53      �� 54      -   5        rectangleRotate��54      55       57      B� 58   
   -   5        clippingFigure��.��59      E�  . 6   5:      .+�5=      �� -   5        $ page1��5=      �� 5?      -   5        $ canvasReflection��5?      $	 0.7Q�6   $y�Hidden=�67   ��5@   
   �� 5A      -   5        pageReflection��$	 0 0&�5A   8   $	 0 0&�6I   .��5B      � $ Black��6   $ 0Q�6)   � 5C      $ White��6   $
 0.35Q�6)   � 5D      $ Transparent��6   $ 1Q�6/   5E      5G   	   5H      5I      5J      