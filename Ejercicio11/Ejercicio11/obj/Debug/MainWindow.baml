   M S B A M L   `   `   `  ����F  BEjercicio11, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Ejercicio11Ejercicio11  5   	       Ejercicio11.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Ejercicio11     5   	   -   5          �Name$  Citas��5   	    � Title$ Citas��5   	   $	��500��6   $	��750��6$   .��5	      � $��10q�6    � ColumnDefinitions 5
   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      $��35 �6   6*   �� 5      $��35 �6   6*   �� 5      $��35 �6   6*   �� 5      $��35 �6   6*   �� 5      $��35 �6   6*   �� 5      $	��220 �6   6+   �� 5      $��35 �6   6*   .+�5   
   �� -   5         ��Name$ NombreTextBlock��5      $
��Left=�6-   $��5q�6H   $
��Wrap=�6S   $��Center=�6g   $��Nombre:��6�   $��0��6�   $��0��6�   �� 5   
   -   5         ��Name$ NombreTextBox��5      $
��Left=�6)   $��5q�6D    �� TextWrapping$
 Wrap=�6O   $��Center=�6c   $	��150��6~   $��20��6�   $��0��6�   $��2��6�   $��1��6�   �� 5   
   -   5        $ ApellidosTextBlock��5      $
��Left=�60   $��5q�6K   $
��Wrap=�6V   $��Center=�6j   $��
Apellidos:��6�   $��1��6�   $��0��6�   �� 5   
   -   5        $ ApellidosTextBox��5      $
��Left=�6,   $��5q�6G   $
 Wrap=�6R   $��Center=�6f   $	��150��6�   $��20��6�   $��1��6�   $��2��6�   $��1��6�   �� 5!   
   -   5        $ HoraTextBlock��5!      $
��Left=�6+   $��5q�6F   $
��Wrap=�6Q   $��Center=�6e   $��Hora:��6�   $��2��6�   $��0��6�   �� 5"   
   -   5        $ HoraTextBox��5"      $
��Left=�6'   $��5q�6B   $
 Wrap=�6M   $��Center=�6a   $	��150��6|   $��20��6�   $��2��6�   $��2��6�   $��1��6�   �� 5$   
   -   5        $ MinutosTextBlock��5$      $
��Left=�6.   $��5q�6I   $
��Wrap=�6T   $��Center=�6h   $��Minutos:��6�   $��3��6�   $��0��6�   �� 5%   
   -	   5        $ MinutosTextBox��5%      $
��Left=�6*   $��5q�6E   $
 Wrap=�6P   $��Center=�6d   $	��150��6   $��20��6�   $��3��6�   $��2��6�   $��1��6�   �� 5'   
   -
   5        $ FechaTextBlock��5'      $
��Left=�6,   $��5q�6G   $
��Wrap=�6R   $��Center=�6f   $��Fecha:��6�   $��4��6�   $��0��6�   (  "System.Windows.Controls.DatePicker  5(   
   -   5          Name$ FechaDataPicker��5(      $
��Left=�6.   $��5q�6I   $��Center=�6T   $	��150��6o   $��4��6{   $��2��6�   $��1��6�   �� 5*   
   -   5         ��Name$ VaciarBoton��5*      $��Vaciar��6&   $��Right=�67   $��5q�6S   $��Center=�6^   $��75��6y   $��4��6�   $��2��6�   6�   &   System.Windows.Controls.DataGrid  5,   
   -   5        	  Name$	 DatosDataGrid��5,      $
��Left=�6*   $��5q�6E   $��Center=�6P   $	��200��6k   $	��700��6x   $��5��6�   $��5��6�   $��0��6�   
   AutoGenerateColumns
 .     Columns 5-      0  *System.Windows.Controls.DataGridTextColumn  5.      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre y apellidos��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *NombreCompleto+  5/      $ Día de la semana��6%    6?   �� *Dia+  50      $ Fecha��6%    64   �� *	FechaCita+ �� StringFormat$ {0:MM/dd/yyyy}��  51      $ Hora y minutos��6%    6=   �� *	Horario+53      � 55   
   $��7��6   $��5��6!   $��0��65   .+�56      �� -   5        $ ConsultarBoton��56      $��	Consultar��6-   $
��Left=�6A   $��5q�6\   $��Center=�6g   $��75��6�   6�   �� 57      -   5        $ BuscarBoton��57      $��Buscar��6*   $
��Left=�6;   $��5q�6V   $��Center=�6a   $��75��6|   6�   �� 58      -   5        $ AnadirBoton��58      $��Añadir��6*   $
��Left=�6;   $��5q�6V   $��Center=�6a   $��75��6|   6�   �� 59      -   5        $ ModificarBoton��59      $��	Modificar��6-   $
��Left=�6A   $��5q�6\   $��Center=�6g   $��75��6�   6�   �� 5:      -   5        $ EliminarBoton��5:      $��Eliminar��6,   $
��Left=�6?   $��5q�6Z   $��Center=�6e   $��75��6�   6�   5;      5=      5>      