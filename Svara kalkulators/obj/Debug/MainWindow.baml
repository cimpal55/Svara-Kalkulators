   M S B A M L   `   `   `  ����L  HSvara kalkulators, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Svara_kalkulatorsSvara_kalkulators  5   	   S.clr-namespace:Svara_kalkulators.MVVM.ViewModel Svara_kalkulators.MVVM.ViewModel  5   	   "    Svara_kalkulators.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Svara_kalkulators     5   	   D	viewModel.clr-namespace:Svara_kalkulators.MVVM.ViewModel     5   	   -   5        $	��600��5	   	   $	��920��6     � WindowStyle$
  None=�5
   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � DataContext 5      4  .Svara_kalkulators.MVVM.ViewModel.MainViewModel  5   
   .��5      �� -   5         ��Name$ 
Background��5      ���#272537 �� CornerRadius$ 15��66   ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5       � RowDefinitions 5      �� 5      $��70 �6    �� 5      .+�5!      �� $��Weight Calculator��6   $��Center=�5"      $��Center=�5#      
�������$��22(�5%      �� 5'      $��1��6   .+�5)      	� $��
Calculator��6   $��50��5*      
�������$��19(�5,         
MenuButton#��[  5-      ��5.      �� *CalculatorViewCommand+5/      �� 51      $��1��6   $��1��52      $��20q�53      ��54      �� *CurrentView+55      57      58      59      