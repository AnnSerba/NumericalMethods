   M S B A M L   `   `   `  ����  WpfApplication2     WpfApplication2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6F     � Title$  
MainWindow��5   	   $	��402��6   $	��581��6)   .��5      � $��0q�6    � RowDefinitions 5      �� 5      $	��20* �6   �� 5	      $
��160* �6   �� 5
      $
��159* �6   �� 5      $	��33* �6    � ColumnDefinitions 5      �� 5      .+�5      �� $
��Wrap=�6   $E��?Решение систем линейных уравнений��6"   $��	181.293,0q�6K   $��Center=�6^    � IsSharedSizeScope . 6{   � 5       J� RenderTransformOrigin$ 0.489,0.646&�6	   $��0q�6-   $��1��68    .  5      �� 5      $
��364* �6   �� 5      $
��209* �6   .+�5      �� $+��%Расширенная матрица��6   $��Right=�6+   $��Center=�6N    . .��5      � $��0q�6    .  5      �� 5      $
��254* �6   �� 5      $	��99* �6   .+�5      &   System.Windows.Controls.DataGrid  $��Stretch=�6   ��.   . $��Stretch=�6w      Columns 5      4  .System.Windows.Controls.DataGridCheckBoxColumn  5   	   ,  &System.Windows.Controls.DataGridColumn   Header$ A[1][i]��6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6    Z�    ClipboardContentBinding 63   Z� 6V     5   	   $ A[2][i]��6V    6    Z�  63   Z� 6V   5!        5"      $��Stretch=�6   $��Stretch=�65    . ��.  $��1��6�    5#      0  *System.Windows.Controls.DataGridTextColumn  5$   	   $
 B[i]��6R    6   Z�  6/   Z� 6R   5&      5'      5(      � 5)      $��1��6
    5*      �� 5+      $
��103* �6   �� 5,      $	��57* �6   .+�5.      �� $=��7Изменение и параметры матрицы��6   $��Stretch=�66   $��Stretch=�6[   .��5/      �� 	 �� Orientation$	 Vertical=�6   $��0q�6)   .+�50      �� $4��.Увеличить размер матрицы��6   �� 51      $4��.Уменьшить размер матрицы��6   �� 52      $��Решить��6   $��Stretch=�6    53      54      �� 55      -   5        
 ��Name$
 Точность��55      $��Точность��6!   $��1��63   $��2��6@   .��56      ��  �� TextWrapping$
 Wrap=�6   $��0.0001��6#   57      58      59      �� 5:      $��Методы��6   $��0q�6   $��Stretch=�6(   $��Stretch=�6M   $��2��6p    . .��5;      � $��0q�6
    5<      �� 5=      $
��292* �6   �� 5>      $
��269* �6   .+�5@      �� $��Линейные��6   $��
0,0,0,-0.8q�6!   .��5A      �� $��0q�6   $	��Top=�6   .@�5B      ��  d� 	IsChecked$
 TrueY�6   $��Метод Гаусса��6"   �� 5C      $
 TrueY�6   $,��&Метод Гаусса-Жордана��6"   �� 5D      $
 TrueY�6   $Q��KКомпактная схема Гаусса. Схема Холецкого��6"   �� 5E      $!��Метод прогонки��6   5F      5G      �� 5H      $��Итерационные��6   $��0q�6%   $��1��60   .��5I      �� $��0q�6   $	��Top=�6   .@�5J      �� $
 TrueY�6   $0��*Метод простой итерации��6"   �� 5K      $��Метод Зейделя��6   $
 TrueY�6)   5L      5M      5N      5O      �� 5P      $
��Wrap=�6    �� TextAlignment$ Center=�6"   $��3��69   $��0q�6F    . �� 6p   $�Серба А.В.��6t   �� 6�   $$� Малиновский А.А.��6�   �� 6�   �� 6�   $�Версия 1.1.��6�   6�   5Q      5R      