   M S B A M L   `   `   `  ����M  ICaloriesCalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:CaloriesCalculatorCaloriesCalculator  5   	   *    $CaloriesCalculator.IngredientsWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:CaloriesCalculator     5   	     � Title$  Ингредиенты��5   	   $	��450��6   $	��800��6*   .��5	      � .+�5
   
   �� $��15(�6   $
��Bold"�6   $6��0Добавьте новый ингредиент��60   $��Center=�6T   $	��Top=�6q   $��0,5,0,0q�6�   �� 5   
   $��
20,0,0,100q�6   $
��Left=�6)   $	��150��6D   $	��150��6P   .+�5      �� $��13(�6   $��Название ��6"   $
��Left=�66   $��Center=�6Q   $��
 30,0,0,10q�6l   �� 5      -   5         ��Name$ Content��5      $
��Left=�6'   $��Center=�6B   $	��150��6]   $��20��6i   �� 5      $��13(�6   $��Вес ��6"   $
��Left=�61   $��Center=�6L   $��
 30,0,0,10q�6g   �� 5      -   5        $ Weight��5      $
��Left=�6&   $��Center=�6A   $	��150��6\   $��20��6h   5      �� 5   
   $��200,0,0,100q�6   $
��Left=�6*   $	��150��6E   $	��200��6Q   .+�5      �� $��13(�6   $��Белки ��6"   $
��Left=�63   $��Center=�6N   $��
 30,0,0,10q�6i   �� 5      -   5        $ Proteins��5      $
��Left=�6(   $��Center=�6C   $	��150��6^   $��20��6j   �� 5      $��13(�6   $��	Жиры ��6"   $
��Left=�62   $��Center=�6M   $��
 30,0,0,10q�6h   �� 5      -   5        $
 Fats��5      $
��Left=�6$   $��Center=�6?   $	��150��6Z   $��20��6f   �� 5      $��13(�6   $��Углеводы ��6"   $
��Left=�66   $��Center=�6Q   $��
 30,0,0,10q�6l   �� 5      -   5        $ Carbohydrates��5      $
��Left=�6-   $��Center=�6H   $	��150��6c   $��20��6o   5      �� 5   
   -   5         ��Name$ Confirm��5      $	��100��6"   $��20��6.   $��Center=�6:   $��0,150,600,0q�6W   .��6�   Добавить6�   �� 5   
   -   5        $ Delete��5      $	��100��6!   $��20��6-   $��Center=�69   $��0,150,350,0q�6V   .��6�   Удалить6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Table��5         AutoGenerateColumns .  $	��400��6>   $��350, 50, 0, 20q�6J      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Ингредиент��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 175 69   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6E   �� 	 �� Path$
	 Name�  5      $ Вес��6%    62   �� $	 Weight�  5      $ 
Белки��6%    64   �� $	 Proteins�  5       $ Жиры��6%    63   �� $
	 Fats�  5!      $ Углеводы��6%    67   �� $	 Carbohydrates�5#      5$      5%      