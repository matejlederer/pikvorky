   M S B A M L   `   `   `  ����C  ?maturita, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:maturitamaturita  5   	       maturita.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:maturita     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � -   5         �Name$ MyGrid��5	       � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� -   5        $��0��5      $��0��6   6.   �� 5   
   -   5        $��0��5      $��1��6   6.   �� 5   
   -   5        $��0��5      $��2��6   6.   �� 5   
   -   5        $��1��5      $��0��6   6.   �� 5   
   -   5        $��1��5      $��1��6   6.   �� 5   
   -   5        $��1��5      $��2��6   6.   �� 5   
   -   5        $��2��5      $��0��6   6.   �� 5    
   -	   5        $��2��5       $��1��6   6.   �� 5!   
   -
   5        $��2��5!      $��2��6   6.   �� 5$   
   -   5         ��Name$ Player1ScoreLabel��5$      $��3��6+   $��0��68   $��0��6H   $��20(�6T   $��Center=�6b   $��Center=�6   �� 5%   
   -   5        $ PlayerLabel��5%      $��3��6%   $��1��62   $��Hraje hráč: X��6B   $��20(�6Z   $��Center=�6h   $��Center=�6�   �� 5&   
   -   5        $ Player2ScoreLabel��5&      $��3��6+   $��2��68   $��0��6H   $��20(�6T   $��Center=�6b   $��Center=�6   5'      5(      