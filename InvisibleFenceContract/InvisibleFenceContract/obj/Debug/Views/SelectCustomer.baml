   M S B A M L   `   `   `  ����Q  MInvisibleFenceContract, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:InvisibleFenceContract.ViewsInvisibleFenceContract.Views  5      1    +InvisibleFenceContract.Views.SelectCustomer   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:InvisibleFenceContract.Views     5      .��5      � ���#114977  � 	Resources  5	   
    �� 
TargetType �� Property �� Value��%[  '��       '�� H     '�� �     '�� p    '�� �    �� 5      " ��6   .�5      ��  � ��$ 44 �6+   5      �� 5      " ��6   .�5      ��  � ��$ Center=�66   5      �� 5      " ��6   .�5      ��  � ��$ 22��6+   �� 5       � ��$	 Top=�66   �� 5       � ��$/ )/InvisibleFencing;component/Fonts/#Gotham)�6/   �� 5       � ��$ 12(�6-   5      �� 5      " ��6   .�5      ��  � ��$ Center=�66   5      �� 5      " ��6   .�5      ��  � ��$ 22��6+   �� 5       � ��$	 Top=�66   5       5!       � ColumnDefinitions 5#   
   �� 5$      $	��450 �6   �� 5%      $	��450 �6   �� 5&      $��* �6    � RowDefinitions 5)   
   �� 5*      $��32 �6   �� 5+      $��32 �6   �� 5-      $
��Auto �6   �� 5.      $��* �6   .+�50   
   �� $��0��6   $��0��6!    �� Padding$ 5q�6.   
�������$��3��6M   ._�51      �� $��..\Images\Logo.jpg��6   $��1��60   $��1��6@   $��2��6M   $��
0,0,-69,-5q�6a   $
��Left=�6u   $
��1363��6�   53      �� 5:   
    �� Orientation$ 
Horizontal=�6   $��5,5,0,0q�6.   $��10��6?   $��3��6T   5=      &   System.Windows.Controls.DataGrid  5>   
   -   5          Name$	 dg1��5>      	   CanUserAddRows	 .  
   CanUserDeleteRows
 .  $��15q�6�   $��Center=�6�   $
��Auto��6�   $
��Auto��6�      AutoGenerateColumns .  $��2��6$  $��2��61  ��6    �� *	c_Clients+ �� SelectedItem 6B   �� *SelectedCustomer+ �� SelectedIndex 6�   �� *SelectedIndex+   Columns 5?      0  *System.Windows.Controls.DataGridTextColumn  5A      ,  &System.Windows.Controls.DataGridColumn   Header$ Customer ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *
CustomerID+  5B      $ 
First Name��6%    69   �� *	FirstName+  5C      $ 	Last Name��6%    68   �� *
LastName+  5D      $ Address��6%    66   �� *	Address+  5E      $
 City��6%    63   �� *City+  5F      $ State��6%    64   �� *State+  5G      $	 Zip��6%    62   �� *Zip+4  .System.Windows.Controls.DataGridTemplateColumn  5H         CellTemplate 5I      �� 5J      .R�5K      �� $��Select��6%   ��66   �� *Select+5L      5N      5P      5Q      5R      