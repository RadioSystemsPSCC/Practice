   M S B A M L   `   `   `  ����Q  MInvisibleFenceContract, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:InvisibleFenceContractInvisibleFenceContract  5   	   U/clr-namespace:InvisibleFenceContract.Viewmodels!InvisibleFenceContract.Viewmodels  5   	   K*clr-namespace:InvisibleFenceContract.ViewsInvisibleFenceContract.Views  5   	   '    !InvisibleFenceContract.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:InvisibleFenceContract     5   	   >vm/clr-namespace:InvisibleFenceContract.Viewmodels     5   	   8v*clr-namespace:InvisibleFenceContract.Views     5   	     � Icon$  /Images/blueshouse2.ico��5
   	    � Title$ Invisible Fence - Home��5   
   $	��768��6)   $
��1266��66   $��50q�6C    � DataContext 5      ;  5InvisibleFenceContract.Viewmodels.MainWindowViewModel  5   
    � 	Resources 5       �� DataType6  0InvisibleFenceContract.Viewmodels.StartViewModel(   "InvisibleFenceContract.Views.Start?   9InvisibleFenceContract.Viewmodels.SelectCustomerViewModel1   +InvisibleFenceContract.Views.SelectCustomer9  3InvisibleFenceContract.Viewmodels.Contact1ViewModel+   %InvisibleFenceContract.Views.Contact18   2InvisibleFenceContract.Viewmodels.Safety2ViewModel*	   $InvisibleFenceContract.Views.Safety2<
  6InvisibleFenceContract.Viewmodels.Protection3ViewModel.   (InvisibleFenceContract.Views.Protection39  3InvisibleFenceContract.Viewmodels.Freedom4ViewModel+   %InvisibleFenceContract.Views.Freedom4;  5InvisibleFenceContract.Viewmodels.Solutions5ViewModel-   'InvisibleFenceContract.Views.Solutions5>  8InvisibleFenceContract.Viewmodels.Installation6ViewModel0   *InvisibleFenceContract.Views.Installation6;  5InvisibleFenceContract.Viewmodels.Signature7ViewModel-   'InvisibleFenceContract.Views.Signature7>  8InvisibleFenceContract.Viewmodels.ProductLookupViewModel0   *InvisibleFenceContract.Views.ProductLookup��%�  (��       5      *, +)(�� 2     5      *, +)(�� d     5      *, +)(�� �     5      *, +)(�� �     5!      *,
 +)(�� �     5%      *, +)(�� ,    5)      *, +)(�� ^    5-      *, +)(�� �    51      *, +)(�� �    54      *, +)�� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5      	  5      �� 5!   
   " 
 6   .R�5"        5#      �� 5%   
   "  6   .R�5&        5'      �� 5)   
   "  6   .R�5*        5+      �� 5-   
   "  6   .R�5.        5/      �� 51   
   "  6   .R�52        53      �� 54   
   "  6   .R�55        56      58      .��5:      � 
������� � RowDefinitions 5;   
   �� 5=      $��30 �6   �� 5>      $
��Auto �6   �� 5?      $��* �6   .+�5B   
   � -   5         �Name$ NavBar��5B      $��0��6"   $y�Visible=�63   ���#114977$��3��6]    5C       �� 
TargetType �� Property	 �� Value��%y   '�       �� 5D      " �6   .�5E      ��  � ��$		 188��6.   �� 5F       � ��$
	 Left=�6<   5G      5H       5I      �� 5J      $��28 �6    �� 5K      $��28 �6    �� 5L      $��28 �6    �� 5M      $��28 �6    �� 5N      $��28 �6    �� 5O      $��28 �6    �� 5P      $��28 �6    �� 5Q      $��28 �6    �� 5R      $��28 �6    �� 5S      $��28 �6    �� 5T      $��28 �6    �� 5U      $��28 �6    �� 5V      $��28 �6    �� 5W      $��28 �6    �� 5X      $��* �6    
 � ColumnDefinitions
 5[      �� 5\      $	��180 �6#   .+�5_      �� $��X��6   $��collapse��5a      $��0��5b      $��0��6   $��Right=�5c      $��27��5d      $��0,0,-7,0q�6   
���   �
���������5`      �� *
Collapse+5e       �� 5g      $��Select Customer��6   $��selectCustomer��5i      $��0��5j      $��2��6   ��5h      �� *
NavCommand+5j      �� 5l      $��Contact��6   $��contact��5n      $��0��5o      $��3��6   ��5m      �� *
NavCommand+5o      �� 5q      $��Safety��6   ���#017EB8$��safety��5t      $��0��5u      $��4��5v      ��5r      �� *
NavCommand+5v      �� 5x      $��
Protection��6   ���#A6D473$��
protection��5{      $��0��5|      $��5��5}      ��5y      �� *
NavCommand+5}      �� 5      $��Freedom��6   ���#E96C2D$��freedom��5�      $��0��5�      $��6��5�      ��5�      �� *
NavCommand+5�      �� 5�      $��	Solutions��6   $��	solutions��5�      $��0��5�      $��7��5�      ��5�      �� *
NavCommand+5�      �� 5�      $��Installation��6   $��installation��5�      $��0��5�      $��8��5�      ��5�      �� *
NavCommand+5�      �� 5�      $��	Signature��6   $��	signature��5�      $��0��5�      $��9��5�      ��5�      �� *
NavCommand+5�      �� 5�      $��Admin:��6   
�������$��0��5�      $��11��5�      �� 5�      $��Start��6   $��start��5�      $��0��5�      $��12��6   ��5�      �� *
NavCommand+5�      �� 5�      $��Product Lookup��6   $��productLookup��5�      $��0��5�      $��13��6   ��5�      �� *
NavCommand+5�      5�      �� 5�   
    �� Orientation$  Horizontal=�6   $��191,8,-1168,-510q�6/   $��9��6I   .+�5�      �� $��1��6D   ��6   �� *CurrentViewModel+6D   5�      5�      5�      