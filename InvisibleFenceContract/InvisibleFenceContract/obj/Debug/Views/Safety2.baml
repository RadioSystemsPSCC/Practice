   M S B A M L   `   `   `  ����Q  MInvisibleFenceContract, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:InvisibleFenceContract.ViewsInvisibleFenceContract.Views  5      U/clr-namespace:InvisibleFenceContract.Viewmodels!InvisibleFenceContract.Viewmodels  5      U/clr-namespace:InvisibleFenceContract.Viewmodels!InvisibleFenceContract.Viewmodels  5      *    $InvisibleFenceContract.Views.Safety2   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:InvisibleFenceContract.Views     5      F
Viewmodels/clr-namespace:InvisibleFenceContract.Viewmodels     5      >vm/clr-namespace:InvisibleFenceContract.Viewmodels     5        � 	Resources  5      8   2InvisibleFenceContract.Viewmodels.Safety2ViewModel   safetyVm��%   &	          5   
   6   5       � DataContext 5        5   
   .��5      � $��
11,-2,9,12q�6     5   
    �� 
TargetType �� Property �� Value��%�  '��       '�� �     '	�     �� 5      " ��6   .�5      ��  � ��$/ )/InvisibleFencing;component/Fonts/#Gotham)�6/   �� 5       � ��$ 14(�6-   5      �� 5      " ��6   .�5      ��  � ��$/ )/InvisibleFencing;component/Fonts/#Gotham)�6/   5      �� 5      " 	�6   .�5      ��  � ��$/ )/InvisibleFencing;component/Fonts/#Gotham)�6/   �� 5        � ��$ 14(�6-   5!      5#       � ColumnDefinitions 5$   
   �� 5%      $	��188 �6   �� 5&      $	��400 �6   �� 5'      $	��450 �6   �� 5(      $��* �6    � RowDefinitions 5*   
   �� 5+      $
��Auto �6   �� 5,      �� 5-      $
��Auto �6   .+�50   
   �� $��0��6   $��0��6!   $��5��6.    �� Padding$ 5q�6B   ���#017EB8._�51      �� -   5         ��Name$ 	textBlock��51      $
��Wrap=�6,   $#��  CHOOSE YOUR SAFETY SOLUTION��6@   $��188,0,226,0q�6e   
�������$��16(�6�   53      	� 55   
   -   5        	 	�Name$	 
GPSPackage��55      $��
GPSPackage��6J   $M��GGPS 2.0 Wire Free Technology
GPS 2.0 Mobile Collar Unit
2-Year Warranty��6h   $��1��6�   $��1��6�   $
��Left=�6�   $��	20,43,0,0q�6�   $	��Top=�6  ��6*   �� *ViewCommand+6  	� 56   
   -   5        $	 BoundaryPackage��56      $��BoundaryPackage��6P   $z��tBoundary Plus Technology
MicroLite Plus Computer Collar Unit
Lifetime Limited Warranty
1-Year Power Cap Battery Plan��6s   $��1��6�   $
��Left=�6  $��
20,118,0,0q�6)  $��1��6=  $	��Top=�6J  ��60   �� *ViewCommand+6J  	� 57   
   -   5        $	 DigitalTechPackage��57      $��DigitalTechPackage��6R   $p��jDigital Technology
MicroLite Computer Collar Unit
Limited Lifetime Warranty
 1-Year Power Cap Battery Plan��6x   $��1��6�   $
��Left=�6	  $��
20,211,0,0q�6$  $��1��68  $	��Top=�6E  ��62   �� *ViewCommand+6E  �� 5:   
   -   5        
 ��Name$
 lblGpsPrice��5:      $��1��6%   $��1��65   $
��Left=�6_   $��	41,94,0,0q�6z   $	��Top=�6�   ���#017EB8$
��bold"�6�   $��24��6�   $��88��6�   ��6B   �� *
GPSPrice+6�   �� 5;   
   -   5        $
 lblBoundaryPrice��5;      $��1��6*   $��1��6:   $
��Left=�6m   $��
41,181,0,0q�6�   $	��Top=�6�   ���#017EB8$
��bold"�6�   $��24��6�   $��88��6�   ��6G   �� *BoundaryPlusPrice+6�   �� 5<   
   -   5        $
 lblDigitalPrice��5<      $��1��6)   $��1��69   $
��Left=�6q   $��
41,279,0,0q�6�   $	��Top=�6�   ���#017EB8$
��bold"�6�   $��24��6�   $��88��6�   ��6F   �� *DigitalTechnologyPrice+6�   �� 5?   
   -   5        $ label��5?      $��2��6#   $��1��63   $)��#Included with all Safety Solutions:��6@   $
��Left=�6k   $	��Top=�6�   $��	0,111,0,0q�6�   $��Italic$�6�   $��26��6�   $	��288��6�   $
��Bold"�6�   ���#017EB86�   �� 5@   
   -	   5        $ label1��5@      $��2��6$   $��1��64   $!��Perfect Start Plus Training��6A   $
��Left=�6d   $	��Top=�6�   $��
12,137,0,0q�6�   $��26��6�   $	��244��6�   �� 5A   
   -
   5        $ label2��5A      $��2��6$   $��1��64   $"��1-Year Performance Guarantee��6A   $
��Left=�6e   $	��Top=�6�   $��
12,163,0,0q�6�   $��26��6�   $	��244��6�   �� 5B   
   -   5        $ label3��5B      $��2��6$   $��1��64   $��1-Year Service Plan��6A   $
��Left=�6\   $��
12,189,0,0q�6w   $	��Top=�6�   $��26��6�   $	��244��6�   �� 5C   
   -   5        $ label4��5C      $��2��6$   $��1��64   $$��Battery Back-Up/Wired Solution��6A   $
��Left=�6g   $��
12,215,0,0q�6�   $	��Top=�6�   $��26��6�   $	��244��6�   �� 5D   
   -   5        $ label5��5D      $��2��6$   $��1��64   $(��"Surge Protector for wired solution��6A   $
��Left=�6k   $��
12,241,0,0q�6�   $	��Top=�6�   $��26��6�   $	��244��6�   �� 5E   
   -   5         ��Name$ submitBt��5E      $��0��6#   $��3��63   $��Submit��6G   $
��Left=�6z   $��760,550,0,0q�6�   $��1��6�   $	��Top=�6�   $��75��6�   ��6X   �� *SubmitCommand+6�   5F      5G      