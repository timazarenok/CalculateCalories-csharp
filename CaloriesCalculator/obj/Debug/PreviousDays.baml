   M S B A M L   `   `   `  ����M  ICaloriesCalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:CaloriesCalculatorCaloriesCalculator  5   	   %    CaloriesCalculator.PreviousDays   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:CaloriesCalculator     5   	     � Title$!  Предыдущие дни��5   	   $	��450��6    $	��800��6-   .��5	      � .+�5
   
   �� -   5         ��Name$ Settings��5
      $	��200��6#   $��25��6/   $	��Top=�6;   $
��Left=�6S   $��	50,20,0,0q�6n   .��6�   -+Параметры пользователя6�   �� 5   
   -   5         ��Name$ 	Statistic��5      $	��400��6%   $��
0,50,300,0q�61   $	��350��6E   $
��Auto=�6�   ��5      �� 5      .R�5      �  � RowDefinitions 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5      �� 5      �� 5      �� 5      �� 5      �� 5      $��90 �6/   .+�5      �� $
��Bold"�6:   ���#fe145f$��0,0,0,10q�6a   ��6$   �� *Date+6a   �� 5      $��Калории: ��6$   $��2��65   $��1��6E   $��	10,0,0,10q�6R   �� 5      $��1��6>   $��3��6K   $��	10,0,0,10q�6[   ��6$   �� *
Calories+6[   �� 5       $��Белки: ��6$   $��0��63   $��1��6C   $��0,0,0,10q�6P   �� 5!      $��1��6>   $��1��6K   $��0,0,0,10q�6[   ��6$   �� *
Proteins+6[   �� 5"      $��
Жиры: ��6$   $��2��62   $��2��6B   $��	10,0,0,10q�6O   �� 5#      $��2��6:   $��3��6G   $��	10,0,0,10q�6W   ��6$   �� *Fats+6W   �� 5$      $��Углеводы: ��6$   $��0��66   $��2��6F   $��0,0,0,10q�6S   �� 5%      $��2��6C   $��1��6P   $��0,0,0,10q�6`   ��6$   �� *Carbohydrates+6`   5&      5'      5)      &   System.Windows.Controls.DataGrid  5*   
   -   5          Name$ Table��5*         AutoGenerateColumns . $	��330��6=   $��450, 40, 0, 30q�6I      Columns 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 100 67   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6C   ��  �� Path$
 Name�  5-      $ 
Белки��6%   
 64   �� $ Proteins�  5.      $ Жиры��6%   
 63   �� $
 Fats�  5/      $ Углеводы��6%   
 67   �� $ Carbohydrates�  50      $ Калории��6%   
 66   �� $ Calories�52      53      54      