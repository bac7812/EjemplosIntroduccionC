   M S B A M L   `   `   `  ����F  BEjercicio12, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Ejercicio12Ejercicio12  5   	       Ejercicio12.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Ejercicio12     5   	   -   5          �Name$  JornadasLiga��5   	    � Title$ Jornadas de Liga��5   	   $	��368��6"   $	��525��6/    � 
ResizeMode$ NoResize=�6;   .��5	      � $��10q�6    � ColumnDefinitions 5
   
   �� 5      6!   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      $��35 �6   6*   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� -   5         ��Name$ equipoLocalTextBlock��5      $
��Left=�62   $��5q�6M   $
��Wrap=�6X   $��Equipo local:��6l   $��Center=�6�   $��0��6�   $��0��6�   �� 5   
   -   5         ��Name$ equipoLocalListBox��5      $
��Left=�6.   $	��250��6I   $��5q�6V   $��Center=�6a   $	��150��6|   $��1��6�   $��3��6�   $��0��6�   �� 5   
   -   5        $ equipoVisitanteTextBlock��5      $
��Left=�66   $��5q�6Q   $
��Wrap=�6\   $��Equipo visitante:��6p   $��Center=�6�   $��0��6�   $��1��6�   �� 5   
   -   5        $ equipoVisitanteListBox��5      $
��Left=�62   $	��250��6M   $��5q�6Z   $��Center=�6e   $	��150��6�   $��1��6�   $��3��6�   $��1��6�   �� 5   
   -   5        $ JornadaTextBlock��5      $��Center=�6.   $��5q�6K   $
��Wrap=�6V   $��Jornada:��6j   $��Bottom=�6z   $��16(�6�   $��1��6�   $��2��6�   �� 5   
   -   5        $ NumeroJornadaTextBlock��5      $��Center=�64   $��5q�6Q   $
��Wrap=�6\   $��0��6p   $	��Top=�6y   $��16(�6�   $��2��6�   $��2��6�   �� 5   
   -   5         ��Name$ siguienteBoton��5      $��	Siguiente��6)   $��Center=�6=   $��5q�6Z   $	��Top=�6e   $	��100��6}   $��40��6�   $��3��6�   $��2��6�   6�   5!      5"      