   M S B A M L   `   `   `  ����F  BEjercicio10, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Ejercicio10Ejercicio10  5   	       Ejercicio10.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Ejercicio10     5   	   -   5          �Name$  MaquinaCambio��5   	    � Title$ Maquina de cambio��5   	   $	��250��6#   $	��570��60   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ CambioDataGrid��5
      $
��Left=�6+   $	��160��6F   $��
386,26,0,0q�6S   $	��Top=�6g   $	��130��6     5   
   -   5        $ SaldoDataGrid��5      $
��Left=�6*   $	��160��6E   $��
202,26,0,0q�6R   $	��Top=�6f   $	��140��6~   �� 5   
   -   5         ��Name$ MonedasCantidadComboBox��5      $
��Left=�64   $��	10,25,0,0q�6O   $	��Top=�6b   $��70��6z   .@�5      �� $
��2€��6    �� 
IsSelected . 6(   �� 5      $
��1€��6   �� 5      $��50Cts��6   �� 5      $��20Cts��6   �� 5      $��10Cts��6   �� 5      $
��5Cts��6   5      �� 5   
   -   5         ��Name$ 	BotonSuma��5      $��+��6$   $
��Left=�60   $��
100,26,0,0q�6K   $	��Top=�6_   $��30��6w   6�   �� 5   
   -   5        $ 
BotonResta��5      $��-��6%   $
��Left=�61   $��
148,26,0,0q�6L   $	��Top=�6`   $��30��6x   6�   �� 5   
   -   5        $ MonedasCambioComboBox��5      $
��Left=�62   $��	10,67,0,0q�6M   $	��Top=�6`   $��70��6x   .@�5      �� $
��2€��6    . 6(   �� 5      $
��1€��6   �� 5      $��50Cts��6   �� 5      $��20Cts��6   �� 5      $��10Cts��6   �� 5      $
��5Cts��6   5      �� 5   
   -   5        $ 
BotonSaldo��5      $��Saldo��6%   $
��Left=�65   $��
10,147,0,0q�6P   $	��Top=�6d   $��75��6|    J� RenderTransformOrigin$ -1.627,-2.4&�6�   6�   �� 5   
   -	   5        $ BotonCambiar��5      $��Cambiar��6'   $
��Left=�69   $��
103,69,0,0q�6T   $	��Top=�6h   $��75��6�   6�   �� 5    
   -
   5         ��Name$ TextBlockSaldo��5       $
��Left=�6,   $��103,149,0,0q�6G   $
��Wrap=�6\   $	��Top=�6p   $��Total: 0��6�   �� 5!   
   -   5        $ SaldoTextBlock��5!      $
��Left=�6,   $��	202,5,0,0q�6G   $
��Wrap=�6Z   $��Saldo��6n   $	��Top=�6{   �� 5"   
   -   5        $ CambioTextBlock��5"      $
��Left=�6-   $��	386,5,0,0q�6H   $
��Wrap=�6[   $��Cambio��6o   $	��Top=�6}   5$      5%      