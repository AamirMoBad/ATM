   M S B A M L   `   `   `  ���� F  BATM_Machine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication2WpfApplication2  !    WpfApplication2.WithdrawSav   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:WpfApplication2       � Title$  
MainWindow��$	��600��$	��700��.���  � RowDefinitions �� $	��86* ��� $
��114* ��� $	��80* ��� $	��80* ��� $	��80* ��� $	��66* ��� $	��65* � � ColumnDefinitions �� $	��50* ��� $	��40* ��� $	��80* ��� $	��80* ��� $	��40* ��� $	��57* �.+��� -    ��Name$	 _20��$	��>> ��$��1��$��Center=�$��
5,18.8,5,0q�$��2��$	��Top=�$��70��$��40��$��Right=�$
��Bold"�$��22(��� -   $ button_Copy��$	��>> ��$��1��$��Center=�$��
5,18.8,5,0q�$��3��$	��Top=�$��70��$��40��$��Right=�$
��Bold"�$��22(��� -   $ button_Copy1��$	��>> ��$��1��$��Center=�$��
5,18.8,5,0q�$��4��$	��Top=�$��70��$��40��$��Right=�$
��Bold"�$��22(��� -   $ button_Copy2��$	�� <<��$��4��$��Right=�$��
0,18.8,5,0q�$��4��$	��Top=�$��70��$��40��$
��Left=�$
��Bold"�$��22(��� -   $ button_Copy3��$	�� <<��$��4��$��Right=�$��
0,18.8,5,0q�$��3��$	��Top=�$��70��$��40��$
��Left=�$
��Bold"�$��22(��� -   $ button_Copy4��$	�� <<��$��4��$��Right=�$��
0,18.8,5,0q�$��2��$	��Top=�$��70��$��40��$
��Left=�$
��Bold"�$��22(����	#FFDDDDDD�� $��2�����	#FF90F000$
��Left=�$	��240��$��0,113.4,0,0q�$��1��$��4��
���   �$	��Top=�$	��320��$��2���� $��2�����	#FF00940C$
��Left=�$��46��$��
0,79.8,0,0q�$��4��$��2��
���   �$	��Top=�$	��320��$��2���� 
���   �$��2q�$��2��$
��Left=�$��80��$��0,113.6,0,0q�$��1��$��2��$	��Top=�$	��160��._��� -    ��Name$ 
label_Copy��$	��$20��$��Center=�$��80��$��0,0,-1.6,-1.6q�$��Center=�$	��160��$��Center=�$��36(�$
��Bold"��� 
���   �$��2q�$��2��$
��Left=�$��80��$��
0,79.2,0,0q�$��2��$��2��$��Center=�$	��160��._��� -   $ label_Copy1��$	��$40��$��Center=�$��80��$��0,0,-1.6,-1.6q�$��Center=�$	��160��$��Center=�$��36(�$
��Bold"��� 
���   �$��2q�$��2��$
��Left=�$��80��$��
0,79.2,0,0q�$��3��$��2��$��Bottom=�$	��160��._��� -	   $ label_Copy2��$	��$60��$��Center=�$��80��$��0,0,-1.6,-1.6q�$��Center=�$	��160��$��Center=�$��36(�$
��Bold"��� 
���   �$��2q�$��3��$��Right=�$��80��$��
0,79.2,0,0q�$��3��$��2��$��Bottom=�$	��160��._��� -
    ��Name$ textBox�� �� TextWrapping$
 Wrap=�$��Specify Amount��
�������$��20(�$��Right=�$��Center=��� 
���   �$��2q�$��3��$��Right=�$��80��$��
0,79.2,0,0q�$��2��$��2��$��Center=�$	��160��._��� -   $ label_Copy4��$
��$100��$��Center=�$��80��$��0,0,-1.6,-1.6q�$��Center=�$	��160��$��Center=�$��36(�$
��Bold"�$��Right=��� 
���   �$��2q�$��3��$��Right=�$��80��$��0,113.6,0,0q�$��1��$��2��$	��Top=�$	��160��._��� -   $ label_Copy3��$	��$80��$��Center=�$��80��$��0,0,-1.6,-1.6q�$��Center=�$	��160��$��Center=�$��36(�$
��Bold"�$��Right=��� -   $ button_Copy5��$	��>> ��$��1��$��Center=�$��	5,3.8,5,0q�$��5��$	��Top=�$��70��$��40��$��Right=�$
��Bold"�$��22(��� -   $ label��$��Show/Hide Balance��$��2��$
��Left=�$��46��$��
0,79.8,0,0q�$��4��$��2��$	��Top=�$	��160��$��16(�$
��Bold"�$��Center=�$��Center=��� -    ��Name$ 	textBlock��$��3��$��Center=�$��32��$��30,11.8,0,0q�$��5��$
��Wrap=�$��	$ Balance��$	��130��$	��Top=�$��16(��� -   $ label1��$��2��$��Withdraw from Savings��$��2��$��Center=�$��34��$��
0,79.4,0,0q�$��1��$��Bottom=�$	��320��$��18(�$
��Bold"�$��Center=�$��Center=��� -   $ button1��$��2��$��<< Back��$
��Left=�$��40��$��20,39.4,0,0q�$��1��$	��Top=�$	��160��$��16(�$
��Bold"����	#FF3DFFEE