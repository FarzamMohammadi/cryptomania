   M S B A M L   `   `   `  ����H  DcryptomaniaUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:cryptomaniaUI.ViewscryptomaniaUI.Views  5      "    cryptomaniaUI.Views.CartView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:cryptomaniaUI.Views     5      .��5	      � 
�������.+�5
   
   �� $
��Cart��6   $
��Left=�6   $��
390,10,0,0q�6:   $	��Top=�6N   $��20(�6f   $��Italic$�6t   &   System.Windows.Controls.DataGrid  5   
   -   5           Name$  CartDataGrid��5      $��37,65,376,85q�6)   $��15(�6?      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ CRYPTOCURRENCY��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 250 6^   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *CurrencyName+6^     5      $	 QTY��6%   $ * 6X    62   �� *CurrencyQuantity+6X   5      �� 5   
   -   5        $��+��5      $
��Left=�6   $��
456,96,0,0q�68   $	��Top=�6L   $��34��6d   $��76��6p   6{   �� 5   
   -   5        $��-��5      $
��Left=�6   $��
632,96,0,0q�68   $	��Top=�6L   $��34��6d   $��76��6p   6{   �� 5   
   -   5        $��
Clear Cart��5      $
��Left=�6&   $��456,146,0,0q�6A   $	��Top=�6V   $��34��6n   $��76��6z   6�   �� 5   
   $6��0To modify first select the currency on the grid.��6   $
��Left=�6K   $��
456,65,0,0q�6f   $	��Top=�6z    J� RenderTransformOrigin$ 
0.446,0.99&�6�   �� 5   
   -   5        $��Back to main ��5      $
��Left=�6)   $��456,331,0,0q�6D   $	��Top=�6Y   $��34��6q   $��76��6}   6�   �� 5   
   -   5        $	��Buy��5      $
��Left=�6   $��566,289,0,0q�6:   $	��Top=�6O   $��75��6g   $	��142��6s   6   5      5      