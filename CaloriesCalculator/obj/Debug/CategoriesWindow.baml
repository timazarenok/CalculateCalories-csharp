   M S B A M L   `   `   `  ����M  ICaloriesCalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:CaloriesCalculatorCaloriesCalculator  5   	   )    #CaloriesCalculator.CategoriesWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:CaloriesCalculator     5   	     � Title$  Категории��5   	   $	��450��6   $	��800��6(   .��5	      � .+�5
   
   �� $��15(�6   $
��Bold"�6   $4��.Добавьте новую категорию��60   $��Center=�6S   $	��Top=�6p   $��0,5,0,0q�6�   �� 5   
   $��13(�6   $��Название ��6   $
��Left=�62   $��Center=�6M   $��
 40,0,0,50q�6h   �� 5   
   -   5         ��Name$ Content��5      $
��Left=�6#   $��Center=�6>   $	��150��6Y   $��25��6e   $��40,0,0,0q�6q   �� 5   
   -   5         ��Name$ Confirm��5      $	��100��6"   $��20��6.   $��Center=�6:   $��0,150,600,0q�6W   .��6�   Добавить6�   �� 5   
   -   5        $ Delete��5      $	��100��6!   $��20��6-   $��Center=�69   $��0,150,350,0q�6V   .��6�   Удалить6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Table��5         AutoGenerateColumns .  $	��400��6>   $��350, 50, 0, 20q�6J      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 175 67   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� 	 �� Path$
	 Name�5      5      5      