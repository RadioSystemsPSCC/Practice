   M S B A M L   `   `   `  ����Q  MInvisibleFenceContract, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:InvisibleFenceContract.ViewsInvisibleFenceContract.Views  5      +    %InvisibleFenceContract.Views.Contact1   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:InvisibleFenceContract.Views     5      .��5      � $��
11,-2,9,12q�6   .+�5      �   � 	Resources  5       �� 
TargetType �� Property �� Value��%[  '��       '�� H     '�� �     '�� p    '�� �    �� 5      " ��6$   .�5   "   ��  � ��$ 44 �6;   5      �� 5      " ��6$   .�5   "   ��  � ��$ Center=�6F   5      �� 5!      " ��6$   .�5"   "   ��  � ��$ 22��6;   �� 5#   "    � ��$	 Top=�6F   �� 5$   "    � ��$/ )/InvisibleFencing;component/Fonts/#Gotham)�6?   �� 5%   "    � ��$ 12(�6=   5&      �� 5'      " ��6$   .�5(   "   ��  � ��$ Center=�6F   5*      �� 5+      " ��6$   .�5,   "   ��  � ��$ 22��6;   �� 5-   "    � ��$	 Top=�6F   5.      5/       � ColumnDefinitions 51      �� 52      $��94 �6/   �� 53      $��90 �6/   �� 54      $	��180 �6/   �� 55      $��90 �6/   �� 56      $	��180 �6/   �� 57      $��90 �6/   �� 58      $	��180 �6/   �� 59      $��* �6/    � RowDefinitions 5<      �� 5=      $��32 �6,   �� 5>      $��32 �6,   �� 5?      �� 5@      �� 5A      �� 5B      �� 5C      �� 5D      �� 5E      �� 5F      $��* �6,   .+�5J      �� $��..\Images\Logo.jpg��6    $��1��6<   $��1��6L   $��2��6Y   �� 5L      -   5         ��Name$ headerPhone��5L   $   $��1��69   $��2��6I   $
��Wrap=�6V   ���#0067b1$��800-578-DOGS��6   �� 5M      -   5        $ headerPhone2��5M   $   $��1��6:   $��2��6J   $
��Wrap=�6W   ���#0067b1$��84 0 0 0q�6�   $��(3657)��6�   $��2��6�   �� 5N      -   5        $ headerEmail��5N   $   $��2��69   $��2��6I   ���#0067b1$��InvisibleFence.com��6l   $��Right=�6�   �� 5R      -   5        $ 	FirstName��5R   $   $��1��67   $��3��6G   $��First Name:��6T   $
��Left=�6h   �� 5S      -   5         ��Name$ txtFirstName��5S   "   $��1��68   $��3��6H   $
��Left=�6V   $	��179��6�   $��2��6�   $��62,0,0,0q�6�   ��6r   �� *	FirstName+ �� Mode$ TwoWay=�6�   �� 5T      -   5        $ LastName��5T   $   $��3��66   $��3��6F   $
��Left=�6S   $��
Last Name:��6n   �� 5U      -   5        $ txtLastName��5U   "   $��4��67   $��3��6G   $
��Left=�6T   $	��150��6�   ��6o   �� *
LastName+$ TwoWay=�6�   �� 5W      -   5        $ 
ReferredBy��5W   $   $��5��68   $��3��6H   $��Referred by:��6U   $
��Left=�6i   �� 5X      -	   5        $ txtReferredBy��5X   "   $��6��69   $��3��6I   	 �� 	MaxLength$	 20��6V   $
��Left=�6�   ��6g   �� *
ReferredBy+$ TwoWay=�6�   �� 5]      -
   5        $ StreetAddress��5]   $   $��1��6;   $��4��6K   $��Address:��6X   $
��Left=�6j   �� 5_      -   5        $ txtStreetAddress��5_   "   $��1��6<   $��4��6L   $	 75��6Z   $
��Left=�6i   $	��204��6�   $��2��6�   $��62,0,0,0q�6�   ��6�   �� *	Address+$ TwoWay=��� 5b      $��3��6$   $��4��64   $��	City:    ��6A   $��Right=�6R   $��55��6n   �� 5c      -   5        $ txtCity��5c   "   $��4��64   $��4��6A   $��0,0,31,0q�6R   ��6d   �� *City+$ TwoWay=��� 5f      $��5��6$   $��4��64   $��State:��6A   $
��Left=�6Q   �� 5g      -   5        $ txtState��5g   "   $��5��64   $��4��6D   $��Right=�6u   $��40��6�   ��6Q   �� *State+$ TwoWay=�6�   �� 5j      $��6��6$   $��4��64   $
��Zip:��6A   $��48 0 0 0q�6M   $
��Left=�6_   �� 5k      -   5        $ txtZip��5k   "   $��6��62   $��4��6B   $��Right=�6O   $��80��6l   ��6w   �� *Zip+$ TwoWay=��� 5p      $��1��6$   $��5��64   $��Home Phone:��6A   $
��Wrap=�6T   $
��Left=�6h   $��64��6�   $��35��6�   �� 5q      -   5        $ txtHomePhone��5q   "   $��1��68   $��5��6H   $
��Left=�6U   $	��153��6p   $��2��6|   $��62,0,0,0q�6�   ��6�   �� *	HomePhone+$ TwoWay=��� 5s      $��3��6$   $��5��64   $��Cell Phone:��6A   $
��Left=�6T   $��64��6o   �� 5t      -   5        $ txtCellPhone��5t   "   $��4��68   $��5��6H   $
��Left=�6U   $	��125��6p   ��6|   �� *	CellPhone+$ TwoWay=��� 5v      $��5��6$   $��5��64   $��Email: ��6A   $
��Left=�6P   $��55��6l   �� 5w      -   5        $ txtEmail��5w   "   $��6��64   $��5��6D   $
��Left=�6R   $	��180��6m   ��6y   �� *Email+$ TwoWay=��� 5y      $��1��6%   $��6��65   $��2��6B   $��Center=�6V   $��
0,11,11,11q�6q   ,*My property contains unmarked underground:6�   �� 5z      -   5        
 ��Name$
 ckboxLighting��5z   $   $��3��6;   $��6��6K   $��2��6X   $��Landscape Lighting��6l   $
��Left=�6�   $	��140��6�   $��	0,10,0,19q�6�   �� 5{      -   5        $
 ckBoxSprinklers��5{   #   $��4��6<   $��6��6L   $��
Sprinklers��6Y   $��Right=�6n   $��	0,10,0,19q�6�   &   System.Windows.Controls.DataGrid  5~         AutoGenerateColumns .  $��1��6^   $��7��6n   $��2��6{   $��3��6�   $��88��6�   $	��Top=�6�   ��6#   �� *c_Pets+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5�   "   ,  &System.Windows.Controls.DataGridColumn   Header$ Pet Name��65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6G   �� *	PetName+  5�   "   $ Pet Birthday��65    6K   �� *PetBirthday+4  .System.Windows.Controls.DataGridComboBoxColumn  5�   "   -   5        ComboBoxColumn��$ Breed��5�   Q      SelectedItemBinding 6a   �� *
PetBreed+5�      �� 5�      -   5        $ textBlockSensitive��5�   $   $��6��6@   $��7��6P   $
��Left=�6]   $
��Wrap=�6y   $"��Pre-existing Sensitivities: ��6�   $	��Top=�6�   $��67��6�   $��31��6�   �� 5�      -   5        $
 sensitivitiesYes1��5�   #   $	��Yes��6>   $��6��6L   $��Right=�6\   $��	0,0,68,26q�6x   $��7��6�   $��45��6�   $��18��6�   �� 5�      -   5        $
 sensitivitiesNo1��5�   #   $��No��6=   $��6��6J   $
��Left=�6Z   $��
125,0,0,26q�6u   $��7��6�   $��45��6�   $��18��6�   �� 5�      -   5        $ sensitiveNotes��5�   "   $��5��6:   $��2��6J   $��8��6^   $��2��6k   $
��Left=�6|   $	��270��6�   $��40��6�    �� TextWrapping$
 Wrap=�6�   $y�Visible=�6�   $��Sensitivities Notes:��6�   5�      5�      5�      