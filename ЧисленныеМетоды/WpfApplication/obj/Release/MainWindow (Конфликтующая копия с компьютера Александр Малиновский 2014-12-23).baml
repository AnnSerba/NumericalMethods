   M S B A M L   `   `   `  ����   WpfApplication    WpfApplication.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  
MainWindow��$	��370��$	��525�� � 	Resources  �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius ��Name �� Triggers	 P� Property
 P� Value��%�  '��       �� " ��.���  � ��
 ��ح���  � ��$ 2q���  � ��$ 20����  � �� �� " ��.R��� $ 4��#��z��._�� .+��� $ MyContentPresenter��#��z��$��Center=�$��Center=�$��0,0,0,0q� P� 	 �@J�IsMouseOver
 . . ���  � �� �#E59400��  � ��
 �����P� 	 � ��
 . . ���  � ��
 � E����  � ��
 �����.��� $��0q� � ColumnDefinitions �� $��3* ��� $
��Auto � � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� -    ��Name$ 	textBlock��$��2��$��0q�$��14(�$��Center=� � IsSharedSizeScope . $E��?Решение систем линейных уравнений��$
��Wrap=� � Cursor$
 None�� �� TextEffects z�  z� PositionCount$ 10������ " �� �� Triggers :�  :� RoutedEvent$ UIElement.MouseEnter��.[��� .���� .��W�  g� Duration$ 	0:0:0.300D� �� TargetProperty$ FontSize�	 W� To$ 28X�:� $ UIElement.MouseLeave��.[��� .���� .��W� $ 	0:0:0.800D�$ FontSize�$ 14X��� $��1��$��0q�$��Right=�$��Center=� . $+��%Расширенная матрица��.��� $��0q� .  ��  �� $��3* ��� .+�&   System.Windows.Controls.DataGrid  -     Name$ dataGridViewAij�� J� IsManipulationEnabled . $	��240��$��90��$��Stretch=�$��Stretch=�$   HorizontalScrollBarVisibility$ Disabled=�"   VerticalScrollBarVisibility$ Disabled=�   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ 80    AutoGenerateColumns .     MinRowHeight$ 22Q� �� ItemBindingGroup &   System.Windows.Data.BindingGroup     SharesProposedValues .     Columns  0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn!   Header$! A[i][1]��"   Width$" 80 1  +System.Windows.Controls.DataGridBoundColumn#   Binding# �� *Ai1+  $! A[i][2]��$" 80 # �� *Ai2+  $! A[i][3]��$" 80 # �� *Ai3+  -   $ dataGridViewBi��$��1��$��Stretch=�$��Stretch=� . ��.   .  $��80��$��90��$ Disabled=�$ Disabled=�$ 22Q�    $
! B[i]��$" 80 # �� *Bi+� $��1��$��1��$��0q� .  �� $
��103* ��� $	��57* �.+��� $��Stretch=�$��Stretch=�$'��!Изменение матрицы��$��1��.���� $��0q�$ �� Orientation$$ Vertical=�.+��� -   % ��Name$4% .Увеличить_размер_матрицы��$��Center=�$��Center=�$4��.Увеличить размер матрицы�� . $
��Auto=�& � UseLayoutRounding& .  �� -   $4% .Уменьшить_размер_матрицы��$��Center=�$��Center=�$4��.Уменьшить размер матрицы���� -   $% Решить��$��Center=�$��Center=�$��Решить���� -   ' ��Name$' Точность��$��1��$��2��$��Точность��.���� -   ( ��Name$( textBoxТочность��$��0,0001��) �� TextWrapping$
) Wrap=��� $��2��$��2��$��0q�$��Stretch=�$��Stretch=� . $��Методы��.��� $��0q� �� $
��292* ��� $
��269* �.+��� $��
0,0,0,-0.8q�$��Линейные��.���� -	   * ��Name$* listBoxЛинейные��$��0q�$	��Top=�.@��� -
   + ��Name$$+ checkBoxМетодГаусса��$��Метод Гаусса��, d� 	IsChecked$
, TrueY��� -   $2+ ,checkBoxМетодГауссаЖордана��$,��&Метод Гаусса-Жордана��$
, TrueY��� -   $*+ $checkBoxСхемаХолецкого��$Q��KКомпактная схема Гаусса. Схема Холецкого��$
, TrueY��� -   $(+ "checkBoxМетодПрогонки��$!��Метод прогонки���� $��1��$��0q�$��Итерационные��.���� -   $%* listBoxИтерационные��$��0q�$	��Top=�.@��� -   $6+ 0checkBoxМетодПростойИтерации��$0��*Метод простой итерации��$
, TrueY��� -   $&+  checkBoxМетодЗейделя��$��Метод Зейделя��$
, TrueY��� $��3��$��2��$��0q� . - �� TextAlignment$- Center=�$
��Wrap=��� $�Серба А.В.���� $$� Малиновский А.А.���� �� $�Версия 1.1.��