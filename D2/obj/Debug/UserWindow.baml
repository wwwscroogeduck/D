   M S B A M L   `   `   `  ����=  9D2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:D2D2  5   	       D2.UserWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:D2     5   	     � Title$  
UserWindow��5   	   $	��450��6   $	��800��6)    � 
ResizeMode$ NoResize=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ UserWindowGrid��5         AutoGenerateColumns .  ���	#FF407BAF   
IsReadOnly . $��10,144,229,31q�6p      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        ID��,  &System.Windows.Controls.DataGridColumn   Header$ ID��5   1      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6Y   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6=   �� *	id_user+6Y     5      -   5        Name��$ Имя��5   3   $ * 6_   	 6@   �� *
first_name+6_     5      -   5        
Fimale��$ Фамилия��5   5   $ * 6f   	 6F   �� *second_name+6f     5      -   5        	Email��$ 
Почта��5   4   $ * 6]   	 6C   �� *email+6]   5      �� 5   
   -   5        $��Удалить��5      $
��Left=�6#   $��596,165,0,0q�6>   $	��Top=�6S   $��52��6k   $	��159��6w   6�   �� 5   
   -   5        $��Изменить��5      $
��Left=�6$   $��596,243,0,0q�6?   $	��Top=�6T   $��52��6l   $	��159��6x   6�   �� 5   
   -   5        $��Создать��5      $
��Left=�6#   $��596,315,0,0q�6>   $	��Top=�6S   $��52��6k   $	��159��6w   6�   5      5      