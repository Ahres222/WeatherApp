   M S B A M L   `   `   `  ����I  EWeatherApp_2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WeatherApp_2._0WeatherApp_2._0  5   	       WeatherApp_2._0.Options   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WeatherApp_2._0     5   	     � Title$  Optionen��5   	   $	��200��6   $	��300��6'   ���#202020
�������.��5	      �  � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Stadt��6   $��0��6!   $��0��61   $��0,20,0,0q�6>   �� 5   
   $��1��6|   $��0��6�   $��0,20,0,0q�6�   ��6   �� *
CityOption+ �� UpdateSourceTrigger$ PropertyChanged=� �� NotifyOnSourceUpdated .  �� Mode$ TwoWay=�6�   �� 5   
   $!��Speichern und Aktualisieren��6   $��0��67   $��4��6G   ��6T   �� *SaveCommand+�� 5   
   -   5        $��Zurück��5      $��1��6"   $��4��62   6?   5      5      