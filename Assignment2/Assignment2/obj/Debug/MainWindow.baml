   M S B A M L   `   `   `  ����F  BAssignment2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Assignment2Assignment2  5   	       Assignment2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Assignment2     5   	     � Title$  
MainWindow��5   	   $��426.488��6   $	��525��6-   .��5	      � -   5         �Name$ 	orderList��5	      .+�5
   
   �� $��Starter��6   $
��Left=�6"   $��	11,47,0,0q�6=   $	��Top=�6P   �� 5   
   -   5         ��Name$ starterCombo��5      $
��Left=�6)   $��	11,73,0,0q�6D   $	��Top=�6W   $	��120��6o   ��5      �� 5      .R�5      �� ��6    �� *Combo+5      5      �� 5   
   $��Main Course��6   $
��Left=�6&   $��
136,47,0,0q�6A   $	��Top=�6U   �� 5   
   -   5        $ 	mainCombo��5      $
��Left=�6&   $��
136,73,0,0q�6A   $	��Top=�6U   $	��120��6m   ��5      �� 5      .R�5      �� ��6    �� *Combo+5      5      �� 5   
   $��	Beverages��6   $
��Left=�6$   $��
261,47,0,0q�6?   $	��Top=�6S   �� 5   
   -   5        $ beverageCombo��5      $
��Left=�6*   $��
261,73,0,0q�6E   $	��Top=�6Y   $	��120��6q   ��5      �� 5      .R�5       �� ��6    �� *Combo+5!      5#      �� 5%   
   $��Dessert��6   $
��Left=�6"   $��
388,47,0,0q�6=   $	��Top=�6Q   �� 5&   
   -   5        $ dessertCombo��5&      $
��Left=�6)   $��
388,73,0,0q�6D   $	��Top=�6X   $	��120��6p   ��5'      �� 5(      .R�5)      �� ��6    �� *Combo+5*      5,      �� 5.   
   -   5         ��Name$ btnAdd��5.      $	��Add��6!   $
��Left=�6/   $��
11,100,0,0q�6J   $	��Top=�6^   $��75��6v   6�   &   System.Windows.Controls.DataGrid  50   
   -   5        $��orderDg��50         AutoGenerateColumns .     SelectionMode$ Single=�6\   $
��Left=�6s   $	��169��6�   $��
11,127,0,0q�6�   $	��Top=�6�   $	��497��6�   ��6>   �� *order+   Columns 51      0  *System.Windows.Controls.DataGridTextColumn  52      ,  &System.Windows.Controls.DataGridColumn   Header$ Quantity��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *
Quantity+  53      $
 Name��6%   	   
IsReadOnly	 .  63   �� *Name+6L     54      $ Price��6%   	 .  64   �� *Price+6N   5D      �� 5E   
   -   5        $ btnClear��5E      $��Clear��6#   $
��Left=�63   $��
91,301,0,0q�6N   $	��Top=�6b   $��75��6z   6�   �� 5G   
   $��
Subtotal: ��6   $
��Left=�6%   $��388,301,0,0q�6@   $	��Top=�6U   �� 5H   
   -	   5        
 ��Name$
 subTxtB��5H      $
��Left=�6%   $��447,306,0,0q�6@   $
��Wrap=�6U   $	��Top=�6i   �� 5J   
   $��Tax: ��6   $
��Left=�6    $��388,327,0,0q�6;   $	��Top=�6P   �� 5K   
   -
   5        $
 taxTB��5K      $
��Left=�6#   $��447,332,0,0q�6>   $
��Wrap=�6S   $	��Top=�6g   �� 5M   
   $��Total: ��6   $
��Left=�6"   $��388,353,0,0q�6=   $	��Top=�6R   �� 5N   
   -   5        $
 	totalTxtB��5N      $
��Left=�6'   $��447,358,0,0q�6B   $
��Wrap=�6W   $	��Top=�6k   �� 5O   
   $
��Left=�6   $��42��6/   $	��Top=�6;   $
��1000��6S   .@�5P      �� .��5Q      �� $��Carlos Zambrano��6   5R      �� 5S      -   5        $ 	btnStatus��5S      .��5T      �� $��.\cc.png��6   5U      5V      �� 5W   
   -   5        $ 	btnRemove��5W      $��Remove��6$   $
��Left=�65   $��
11,301,0,0q�6P   $	��Top=�6d   $��75��6|   6�   �� 5X   
   -   5        $ btnClose��5X      $��Close��6#   $
��Left=�63   $��
10,358,0,0q�6N   $	��Top=�6b   $��75��6z   6�   5^      5_      