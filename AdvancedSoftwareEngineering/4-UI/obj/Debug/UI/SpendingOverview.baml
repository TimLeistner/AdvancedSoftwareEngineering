   M S B A M L   `   `   `  ����?  ;4-UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:_4_UI.UI_4_UI.UI  5          _4_UI.UI.SpendingOverview   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:_4_UI.UI     5        N� Title$  SpendingOverview��5	      .��5      � $��
10,0,10,10q�6    � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      $	��100 �6   .+�5   
   �� $��0��6   $��1��6    $��Center=�6-   $	��Top=�6J   $��	0,130,0,0q�6b   $��20(�6u   .��6�   Choose a Category5      �� 5   
   -   5         ��Name$ categoryComboBox��5   �   $��0��6   $��1��6#   $��Center=�60   $	��Top=�6N   $��	0,165,0,0q�6f   $	��100��6y   $��25��6�   6�   �� 5   
   $��0��6   $��1��6    $��Center=�6-   $	��Top=�6J   $��	0,205,0,0q�6b   $��20(�6u   .��6�   
Start Date5      (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ startDatePicker��5   �   $��0��6   $��1��6%   $��Center=�62   $	��Top=�6O   $��	0,245,0,0q�6g   6�   �� 5   
   $��0��6   $��1��6    $��Center=�6-   $	��Top=�6J   $��	0,275,0,0q�6b   $��20(�6u   .��6�   
End Date5         5!   
   -   5        $ endDatePicker��5!   �   $��0��6   $��1��6%   $��Center=�62   $	��Top=�6O   $��	0,315,0,0q�6g   6�   �� 5"   
   -   5         ��Name$ dateErrorLabel��5"   �   $��0��6   $��1��6    $��Center=�6-   $	��Top=�6J   $��	0,355,0,0q�6b   $��16(�6u   
���  ��6�   �� 5%   
   $��1��6   $��1��6    $��Center=�6-   $	��Top=�6J   $��20(�6b   $��0,20,0,0q�6p   .��6�   Spending Overview6�   �� 5&   
   -   5         ��Name$ spendingsScrollView��5'   R   $��1��5&      $��0��6'   $��Center=�64   $	��Top=�6Q   $��0,80,0,0q�6i   $	��300��6{   $	��400��6�   $��2��5'      $��1q�6(   
���  ��6R   �� 5)   
   -   5        $��1��5)      $��2��6!   $��	0,10,10,0q�6.   $	��125��6A   $��25��6M   $��Right=�6Y   .��6�   Home5+      5,      5-      