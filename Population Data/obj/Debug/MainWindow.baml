   M S B A M L   `   `   `  ����J  FPopulation Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Population_DataPopulation_Data  5   	        Population_Data.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Population_Data     5   	     � Title$  Population Data��5   	   $	��450��6!   $	��800��6.   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $	��.5* �6   �� 5      $��* �6   .+�5   
   �� $��30(�6   $��0��6    $��0��60   ��6=   �� *Populations+��5      �� 5      .R�5      ]� .+�5      �� 
���   �$��Bottom=�6.   $	��1px��6F   	 �� X1$ 0��6\   	 �� Y1$ 5��6c   	 �� X2$	 340��5      	 �� Y2$ 5��6#   �� 5      $��25(�6    ��6.   �� *Value+5      5      5      �� 5    
   $��1��6   $��15(�6   $��120 10 400 10q�6-   
���   �$��1q�6X   ��6l   �� *NumberOfYear+�� 5"   
   -   5        $��BtnShow��5"      $��1��6   $
��Show��6-   $
��bold"�6<   $��15(�6N   $��500 10 200 10q�6\   6s   �� 5#   
   -   5        $��BtnClear��5#      $��1��6   $��Clear��6.   $
��bold"�6>   $��15(�6P   $��650 10 50 10q�6^   6t   �� 5%   
   $��2��6   .+�5&      �� $��Avergae annual change��6   $��15(�64   $��50 20 500 10q�6B   �� 5'      $��50 10 550 10q�6   $��20(�6*   ��68   �� *	AvgChange+5(      �� 5)   
   $��2��6   .+�5*      �� $)��#The year with the greatest increase��6   $��15(�6B   $��265 20 270 10q�6P   �� 5+      $��265 10 300 10q�6   $��20(�6,   ��6:   �� *MaxIncreaseYear+5,      �� 5-   
   $��2��6   .+�5.      �� $&�� The year with the least increase��6   $��15(�6?   $��550 20 10 10q�6M   �� 5/      $��550 10 10 10q�6   $��20(�6+   ��69   �� *MinIncreaseYear+50      51      52      