   M S B A M L   `   `   `  ���� D  @FraccMath, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:FraccMath	FraccMath      FraccMath.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:FraccMath     -   ���#585858  � 
ResizeMode$  CanMinimize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � Title$ 	FraccMath��$	��670��$	��360��.���� .+��  � ColumnDefinitions �� $��50 ��� $��50 ��� $��50 ��� $��50 ��� $��50 ��� $��50 ��� $��50 � � RowDefinitions �� $��25 ��� $��50 ��� $��50 ��� $��50 ��� $��50 ��� $��50 ��� $��50 ��� $��50 ��� $��50 ��� $��50 ��� $��50 ��� $��50 ��� $��50 ��� $��50 �.+��� $��	FraccMath��
���   �$��0��$��0��$��5��$��15(�$��Italic$��� -   $��cerrar��
������ 
������ $��6��$��0��|�.  $��25��$��50�� � FocusVisualStyle Z� .���� $��15��$��15��$ ��resources/images/close.png���� -   $��minimize��
������ 
������ $��5��$��0��$��25��$��50������  �� 
TargetType" �� �� Triggers P� 	 P� Property	 �@J�IsMouseOver
 P� Value
 . . ���  �� Property � �� �� Value
 ���� .���� $��20��$��50��$ ��resources/images/linea.png���� $��1��$��0��$��3��$��20(� �� TextAlignment$ Center=�
�������$��
Fraccion 1���� $��1��$��4��$��3��$ Center=�$��
Fraccion 2��
�������$��20(��� $��1��$��5��$��Fraccion Resultante��$��20(�$ Center=�
�������$��6���� -   $��txtNumFracUno��$��25(� �� TextAlignment$ Center=�$��Center=�$��1��$��2��
�������$��50��$��50��$��1,0,0,0q��� $ ��resources/images/linea.png��$��1��$��3���� $ ��resources/images/linea.png��$��5��$��3���� $ ��resources/images/linea.png��$��3��$��8���� -   $��txtDenFracUno��$��25(�$ Center=�$��Center=�$��1��$��4��
�������$��50��$��50��$��1,0,0,0q��� -   $��txtNumFracRes�� �� 
IsReadOnly . $��25(�$ Center=�$��Center=�$��3��$��7��
�������$��50��$��50��$��1,0,0,0q��� -   $��txtDenFracRes�� . $��25(�$ Center=�$��Center=�$��3��$��9��
�������$��50��$��50��$��1,0,0,0q��� -   $��txtNumFracDos��$��25(�$ Center=�$��Center=�$��5��$��2��
�������$��50��$��50��$
��Left=�$��1,0,0,0q��� -	   $��txtDenFracDos��$��25(�$ Center=�$��Center=�$��5��$��4��
�������$��50��$��50���� -
   ���#2E2E2E
����������#2E2E2E$��+��$��50��$��50��$��2��$��11���� -   ���#2E2E2E
����������#2E2E2E$��-��$��50��$��50��$��3��$��11���� -   ���#2E2E2E
����������#2E2E2E$
��Tipo��$��50��$��50��$��4��$��11���� -   ���#2E2E2E
����������#2E2E2E$��/��$��50��$��50��$��2��$��12���� -   ���#2E2E2E
����������#2E2E2E$��x��$��50��$��50��$��3��$��12���� -   ���#2E2E2E
����������#2E2E2E$��Valor��$��50��$��50��$��4��$��12��o� 
������ 
�������$��1q�
������ .@�m� $��Ayuda��$��1q�
������ .@�m� ���#2E2E2E$��1q����#2E2E2E$��Enviar Comentarios��m� ���#2E2E2E$��1q����#2E2E2E$��Comprobar Actualizaciones��