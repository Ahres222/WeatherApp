   M S B A M L   `   `   `  ����I  EWeatherApp_2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WeatherApp_2._0WeatherApp_2._0  5   	        WeatherApp_2._0.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WeatherApp_2._0     5   	     � Title$  Wetter App 2.0��5   	   $	��600��6    $	��580��6-   ���#202020
�������.��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   � $��0��6   $��0,0,0,5q�6    � ColumnDefinitions 5      �� 5      $
��auto �6#   �� 5      $
��auto �6#   �� 5      $
��auto �6#   .+�5      �� 
��� ���$��1q�6-   $��0��6A   ._�5      o� ���#202020
�������$	��300��6?   $
��Left=�6K   .@�5      m� $��Abfrage��6   ���#202020
�������.@�5      m� $��_Aktualisieren��6#   ���#202020
������� m� Command 6;   �� *DoWeatherRequest+6u   �� 5      5      m� 5      $��	_Optionen��6   ���#202020
�������.@�5      m� $��_Einstellungen��6#   ���#202020
������� 6;   �� *OpenOptions+6p   �� 5       5!      5"      5#      �� 5$      $��1��6�   ��6   �� *SelectedCityInformation+ �� UpdateSourceTrigger$ PropertyChanged=� �� NotifyOnSourceUpdated .  �� StringFormat$ Wetter in {0}��6�   �� 5%      $��2��6�   ��6   �� *SelectedCityCountry+$ PropertyChanged=� . $  in {0}��6�   5&      � 5)   
   $��1��6    5*      �� 5+      $��* �6#   �� 5,      $��* �6#   �� 5-      $��* �6#   �� 5.      $��* �6#    51      �� 52      $��20 �6    �� 53      $��25 �6    �� 54      $��25 �6    �� 55      $��* �6    �� 56      $��25 �6    �� 57      $��25 �6    �� 58      $��* �6    .+�5<      �� $��Letzte Abfrage AM/UM:��6   $��0��65   $��0��6E   �� 5=      $��1��6�   $��0��6�   ��6   �� *InfoRequestTime+$ PropertyChanged=� . $ dd-MM-yyyy // HH:mm��6�   �� 5?      $��CloudStatus :��6   $��0��6-   $��1��6=   �� 5@      $��1��6�   $��1��6�   ��6   �� *CloudStatus+$ PropertyChanged=� . $
 {0}%��6�   �� 5B      $��WindDegree :��6   $��0��6,   $��2��6<   �� 5C      $��1��6�   $��2��6�   ��6   �� *
WindDegree+$ PropertyChanged=� . $ {0}°��6�   �� 5E      $�� ��6   $��0��6    $��3��60   9� 5G      $��0��6   $��3��6'   $��2��64   .��5H      � $
��Left=�6   .+�5I      �� $7��1pack://siteoforigin:,,,/WindRichtungNeuWhilte.png��6    J� IsManipulationEnabled . $	��200��6t   $	��200��6�   5J      �� 5K      $3��-pack://siteoforigin:,,,/windRichtungPfeil.png��6    J� RenderTransformOrigin$ 0.0,0.0&�6S   $
��Fill=�6s   $	��100��6�   $	��100��6�   z�5L      V� 5M      .~�5N   "   �� �� 5O   "   �� 5S   "   	 �� CenterX$	 50Q�6�   
 �� CenterY$
 50Q�6�    �� Angle 62   ��  �� Path$ 
WindDegree�$ PropertyChanged=� �� Delay$ 5��6�   T� 5T   "   5U      5W      5X      5Y      �� 5[      $��WindSpeed :��6   $��0��6+   $��4��6;   �� 5\      $��1��6�   $��4��6�   ��6   �� *	WindSpeed+$ PropertyChanged=� . $ {0} Km/h��6�   �� 5`      $��WeatherDescription :��6   $��0��64   $��5��6D   �� 5b      $
��Left=�5c      $
��Left=�6=   ���#202020
�������$��0��6�   $��4��6�   $��6��6�   $
��auto��6�   $
��auto��6�   ��5b      �� * WeatherDiscriptionCurrentClass+ . $ PropertyChanged=���5d      �� 5e      .R�5f      ��  �� Orientation$ 
Horizontal=�6%   $	��Top=�6>   6X   5g      ��5i      �� 5j      .R�5k      �� $��Right=�6!   $	��Top=�6=   $��1q�6U   $
��auto��6i   ._�5l      � $��10,10,10,10q�6#    5n   "   �� 5o   &   $
��auto �67   �� 5p   &   $
��auto �67   .+�5s   "   �� $��50��6�   $��50��6�   $
��Left=�6�   $��0��6�   ��6(   �� $ WeatherIcon�$ PropertyChanged=� . 6�   �� 5t   "   $��1��6�   ��6,   �� $ 	StatusTxt�$ PropertyChanged=� . 6�   5v      5w      5x      5z      �� 5�      $��FeelsLikeTemp :��6   $��2��6/   $��0��6?   �� 5�      $��3��6�   $��0��6�   ��6   �� *FeelsLikeTemp+$ PropertyChanged=� . $ {0}°C��6�   �� 5�      $��
Humidity :��6   $��2��6*   $��1��6:   �� 5�      $��3��6�   $��1��6�   ��6   �� *
Humidity+$ PropertyChanged=� . $
 {0}%��6�   �� 5�      $��
Pressure :��6   $��2��6*   $��2��6:   �� 5�      $��3��6�   $��2��6�   ��6   �� *
Pressure+$ PropertyChanged=� . $ {0} hPa��6�   �� 5�      $��Temp :��6   $��2��6&   $��3��66   �� 5�      $��3��6�   $��3��6�   ��6   �� *Temp+$ PropertyChanged=� . $ {0}°C��6�   �� 5�      $��	TempMax :��6   $��2��6)   $��4��69   �� 5�      $��3��6�   $��4��6�   ��6   �� *	TempMax+$ PropertyChanged=� . $ {0}°C��6�   �� 5�      $��	TempMin :��6   $��2��6)   $��5��69   �� 5�      $��3��6�   $��5��6�   ��6   �� *	TempMin+$ PropertyChanged=� . $ {0}°C��6�   5�      9� 5�   
   $��Wetter Vorhersage��6    9� 
IsExpanded . ���#202020
�������$��2��6h   .��5�      � .+�5�      �� $��Visible=�6�   $��Hidden=�5�      $	��Top=�6O   $	��Top=�6g   $	��270��5�      $
��auto��6)   $
��Left=�66   $
��Left=�6X   ���#202020
���������5�      �� *ForecastDisplayClasses+ . $ PropertyChanged=���5�      �� 5�      .R�5�      �� $ 
Horizontal=�6)   $	��Top=�6B   6\   5�      ��5�      �� 5�      .R�5�      �  5�   "   �� 5�   &   $��50 �67   �� 5�   &   $��* �67    5�   "   �� 5�   &   $��* �64   �� 5�   &   $��* �64   �� 5�   &   $��* �64   �� 5�   &   $��* �64   �� 5�   &   $��* �64   �� 5�   &   $��* �64   �� 5�   &   $��* �64   �� 5�   &   $��* �64   �� 5�   &   $��* �64   �� 5�   &   $��* �64   �� 5�   &   $��* �64   .+�5�   "   �� $��0��6�   $��0��6�   $��2��6�   ��6,   �� $ DayOfForcast�$ PropertyChanged=� .  �� ConverterCulture$ de-DE��$ dddd dd-MM-yyyy��6�   �� 5�   "   $��
Temperatur��6,   $��0��6>   $��1��6N   $��0,10,0,0q�6[   �� 5�   "   $��1��6�   $��2��6�   ��6,   �� $ MaxDayTempValue�$ PropertyChanged=� . $ H: {0}°��6�   �� 5�   "   $��0��6�   $��2��6�   ��6,   �� $ MinDayTempValue�$ PropertyChanged=� . $ T: {0}°��6�   �� 5�   "   $��0��6�   $��3��6�   ��6,   �� $ AvrDayTempValue�$ PropertyChanged=� . $ Avg: {0:#,#.00}°��6�   �� 5�   "   $��Humidity��6,   $��0��6<   $��4��6L   $��0,10,0,0q�6Y   �� 5�   "   $��0��6�   $��5��6�   ��6,   �� $ MinHummValue�$ PropertyChanged=� . $ T: {0}%��6�   �� 5�   "   $��1��6�   $��5��6�   ��6,   �� $ MaxHummValue�$ PropertyChanged=� . $ H: {0}%��6�   �� 5�   "   $��Pressure��6,   $��0��6<   $��6��6L   $��0,10,0,0q�6Y   �� 5�   "   $��0��6�   $��7��6�   ��6,   �� $ MinPressure�$ PropertyChanged=� . $ 
T: {0} pHa��6�   �� 5�   "   $��1��6�   $��7��6�   ��6,   �� $ MaxPressure�$ PropertyChanged=� . $ 
H: {0} pHa��6�   �� 5�   "   $��Clouds��6,   $��0��6:   $��8��6J   $��0,10,0,0q�6W   �� 5�   "   $��0��6�   $��9��6�   ��6,   �� $ MinCloud�$ PropertyChanged=� . $ T: {0}%��6�   �� 5�   "   $��1��6�   $��9��6�   ��6,   �� $ MaxCloud�$ PropertyChanged=� . $ H: {0}%��6�   �� 5�   "   ���#202020
�������$��10��5�   =   $��0��6K   $��2��6[   ��5�   +   �� $$ WeatherDiscriptionCurrentClass�$ PropertyChanged=� . ��5�   &   �� 5�   *   .R�5�   .   � $
��auto��63    5�   2   �� 5�   6   $
��auto �6D   �� 5�   6   $
��auto �6D   .+�5�   2   �� $��50��6�   $��50��6�   $
��Left=�6�   $��0��6�   ��68   �� $ WeatherIcon�$ PropertyChanged=� . 6�   �� 5�   2   $��1��6�   ��6<   �� $ 	StatusTxt�$ PropertyChanged=� . 6�   5�   /   5�   +   5�   #   5�      5�      5�      5�      5�      5�      5�      