   M S B A M L   `   `   `  ����M  ICaloriesCalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:CaloriesCalculatorCaloriesCalculator  5   	   *    $CaloriesCalculator.DishesIngredients   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:CaloriesCalculator     5   	     � Title$,  &Ингредиенты для блюд��5   	   $	��450��6&   $	��800��63   .��5	      � .+�5
   
   �� $��15(�6   $
��Bold"�6   $,��&Добавьте новое блюдо��60   $��Center=�6O   $	��Top=�6l   $��0,5,0,0q�6�   �� 5   
   $��
100,50,0,0q�6   $
��Left=�6)   $	��150��6D   .+�5      �� $��13(�6   $��Игредиент ��6"   $
��Left=�67   $��Center=�6R   $��
 30,0,0,10q�6m   �� 5      -   5         ��Name$ Ingredients��5      �� 5      $��13(�6   $��Блюдо ��6"   $
��Left=�63   $��Center=�6N   $��
 30,0,0,10q�6i   �� 5      -   5        $ Dishes��5      5      �� 5   
   -   5         ��Name$ Confirm��5      $	��100��6"   $��20��6.   $��Center=�6:   $��
0,50,600,0q�6W   .��6�   Добавить6�   �� 5   
   -   5        $ Delete��5      $	��100��6!   $��20��6-   $��Center=�69   $��
0,50,350,0q�6V   .��6   Удалить6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Table��5         AutoGenerateColumns .  $	��400��6>   $��350, 50, 0, 20q�6J      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   ��  �� Path$
 Name�  5      $ Категория��6%    68   �� $ Category�  5      $ Калории��6%    66   �� $ Calories�  5      $ 
Белки��6%    64   �� $ Proteins�  5      $ Жиры��6%    63   �� $
 Fats�  5      $ Углеводы��6%    67   �� $ Carbohydrates�5      5      5      