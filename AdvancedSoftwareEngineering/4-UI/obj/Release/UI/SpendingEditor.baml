   M S B A M L   `   `   `  ���� ?  ;4-UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:_4_UI.UI_4_UI.UI      _4_UI.UI.SpendingEditor   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     (localclr-namespace:_4_UI.UI       N� Title$  SpendingEditor��.��� -    �Name$ myGrid��$��
10,0,10,10q� � ColumnDefinitions �� $	��250 ���  � RowDefinitions �� �� $	��100 �.+��� $��0��$��0��$��20(�$��	0,0,0,125q�$��Center=�$��Center=�.��What do you want to do?�� -   $��0��$��0��$��0,0,0,40q�$	��125��$��25��$��Center=�.��Add new Spendings�� -   $��1��$��2��$��	0,10,10,0q�$	��125��$��25��$��Right=�.��Home�� $��1��$��0��$��20(�$��0,20,0,0q�$��Center=�$	��Top=�.��Spending Editor�� -    ��Name$ categoryLabel��$��1��$��0��$��16(�$��
25,0,0,165q�$
��Left=�$��Center=�.��Choose a category�� $��1��$��0��$��16(�$��200,0,0,165q�$
��Left=�$��Center=�.��
Currency�� -   $ currencyLabel��$��1��$��0��$��16(�$��200,0,0,100q�$
��Left=�$��Center=��� -    ��Name$ categoryComboBox��$��1��$��0��$��
25,0,0,100q�$	��100��$��25��$
��Left=�$��Center=��� $��1��$��0��$��16(�$��	20,0,0,15q�$
��Left=�$��Center=�.��Amount�� -    ��Name$ moneyTextBox��$��1��$��0��$��	25,50,0,0q�$	��100��$��25��$
��Left=�$��Center=�(  "System.Windows.Controls.DatePicker  -     Name$ spendingDatePicker��$��1��$��0��$��16(�$��
270,50,0,0q�$
��Left=�$��Center=��� $��1��$��0��$��16(�$��20,222,0,88q�$
��Left=�$��Center=�.��Description�� -	   $ descriptionTextBox��$��1��$��0��$��
25,225,0,0q�$	��200��$��50��$
��Left=�$��Center=��� -
   $ 
errorLabel��$��1��$��2��$��16(�$��20,350,0,88q�$
��Left=�$��Center=�
���  ���� -    ��Name$ addSpendingButton��$��1��$��0��$��0,225,100,0q�$	��125��$��25��$��Right=�.��Add spending