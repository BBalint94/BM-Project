   M S B A M L   `   `   `  ���� C  ?Raetreon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:RaetreonRaetreon      Raetreon.Harcter   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:Raetreon       � Title$  Harcter��$	��700��$
��1000��.��� ����  �� ImageSource$% Images/Background/csateter.jpeg�� � ColumnDefinitions �� �� $
��0.3* ���  � RowDefinitions �� �� $
��0.3* �.+��� $��0��$��0�� �� Orientation$ Vertical=�.+��� -    ��Name$ karakternev��$��Játékosnév��   jatekosnevek#��[  $��10q��� -    ��Name$ kepunk��$$��Images/Karakterek/noavatar.png��$	��250���� $ 
Horizontal=�.+��� $��
Életerő:��  
textstatok#��[ $��	30 0 10 0q��� $
��1000��#��[ $��0 00 0 0q��� $��/��#��[ $��5 0 0 0q��� -   $ jatekoseletero��$
��1000��  labelstatok#��[ $��0 -4 0 0q��� $ 
Horizontal=�.+��� $��Kaszt:��#��[ $��	30 0 10 0q��� -   $ 
jatkasztja��$��-��#��[ $��0 -5 0 0q��� $ 
Horizontal=�.+��� $��Fegyver:��#��[ $��	30 0 10 0q��� -   $ jatfegyvere��$��-��#��[ $��0 -5 0 0q��� $��2��$��0��$ Vertical=�.+��� -   $ ellennev��$��Ellenségnév��#��[  $��Right=�$��10q��� -   $ ellenkep��$$��Images/Karakterek/noavatar.png��$	��250���� $ 
Horizontal=�$��Right=�.+��� $��
Életerő:��#��[ $��	30 0 10 0q��� $
��1000��#��[ $��0 0 0 0q��� $��/��#��[ $��5 0 0 0q��� -   $ ellensegeletero��$
��1000��#��[ $��	0 -5 30 0q��� $ 
Horizontal=�$��Right=�.+��� $��Kaszt:��#��[ $��0 0 10 0q��� -	   $ ellenkasztja��$��-��#��[ $��	0 -5 30 0q��� $ 
Horizontal=�$��Right=�.+��� $��Fegyver:��#��[ $��0 0 10 0q��� -
   $ ellenfegyvere��$��-��#��[ $��	0 -5 30 0q��� $��1��$��0��$ Vertical=�$��Center=�.+��� -    ��Name$ tamadas��$	��120��$��60��
������ 
������ .���� $"��Images/Components/Attack.png��$	��100��$��10q��� $��2��$��1��$ Vertical=�.+���   esemenyborder#��[ $	��155��._��� .+��� -   $ 	kovetkezo��$��Következő ellenfél��$	��220��$��40��$��Andalus)�$��25(�$��	0 20 0 10q�$y�Visible=��� -   $ kilepes��$��	Kilépés��$	��100��$��40��$��Andalus)�$��25(�$��	0 10 0 54q�$��Center=�$��Center=��� $��0��$��2��$��1��$ Vertical=�.+��� #��[ $	��155��._��� .+��� $��Események:��  
alapszoveg#��[ $��15 0 0 0q��� -    ��Name$ 	esemenyek��	 �� 
IsReadOnly	 . 
�������
�������
 �� TextWrapping$

 Wrap=�$	��100��$��5q�