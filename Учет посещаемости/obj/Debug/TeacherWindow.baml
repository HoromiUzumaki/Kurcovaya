   M S B A M L   `   `   `  ����\  XУчет посещаемости, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:Учет_посещаемости!Учет_посещаемости  5   	   5    /Учет_посещаемости.TeacherWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:Учет_посещаемости     5   	     � Title$)  #Окно преподавателя��5   	   $	��450��6$   $	��900��61   .��5	      � ���#fff6f0 � ColumnDefinitions 5
   
   �� 5      $	��200 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $
��Left=�6    $	��200��6;   $��UniformToFill=�6G   $��/фон.jpg��6_   $��Stretch=�5   	   �� 5   
   -   5         ��Name$	 Out��5      $��
Выход��6   $��16,0,0,0q�6.   $
��Left=�6@   $
��Bold"�6�   $��18(�6�   $��28��6�   $��Bottom=�6�   $��62��6�   ��6[   Z� ��6q   Z� 6�   �� 5   
   $��Меню��6   $
��Left=�6   $��	16,10,0,0q�6:   $	��Top=�6M   $
��Bold"�6e   $��18(�6w   $��34��6�   $��64��6�   �� 5   
   -   5        $
 Grup��5      $��📗 Группы��6   $
��Left=�63   $��	16,58,0,0q�6N   $	��Top=�6a   $��85��6y   $
��Bold"�6�   $��14(�6�   $��23��6�   ��6�   Z� ��6�   Z� 6�   �� 5   
   -   5        $ Attend��5      $#��📗 Посещаемость��6!   $
��Left=�6;   $��
16,104,0,0q�6V   $	��Top=�6j   $	��130��6�   $��14(�6�   $
��Bold"�6�   $��23��6�   ��6�   Z� ��6�   Z� 6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$
 grid��5      $��1��6!   $��53,104,53,87q�61   �� 5   
   $#��Просмотр данных��6   $��Center=�6*   $��0,13,0,0q�6G   $	��Top=�6Y   $
��Bold"�6q   $��24(�6�   $��42��6�   $	��236��6�   $��1��6�   �� 5   
   -   5        $ New_Pos��5      $)��#📗 Добавить запись ��6"   $
��Left=�6@   $��
16,150,0,0q�6[   $	��Top=�6o   $��40��6�   $��14(�6�   $
��Bold"�6�   $	��147��6�   ��6�   Z� ��6�   Z� 6�   �� 5   
   -   5        $ Search��5      $��1��6!   $
��🔍��61   $��	0,79,53,0q�6>   $	��Top=�6Q   $��Right=�6~   $��60��6�   �� 5   
   -   5         ��Name$ 	SearchBox��5      $��1��6%   $��53,79,113,0q�65    �� TextWrapping$
 Wrap=�6J   $	��Top=�6^   $��20��6v   �� 5   
   -   5        $ ReportToExcel��5      $��1��6(   $��Импорт в Excel��68   $��	0,0,53,40q�6Q   $
��Bold"�6d   $��42��6�   $��Bottom=�6�   $��Right=�6�   $	��129��6�   $��14(�6�   �� 5   
   -	   5        $ Delete��5      $��1��6!   $!��Удалить запись��61   $��
0,0,197,40q�6J   $��14(�6^   $
��Bold"�6l   $��Right=�6~   $	��165��6�   $��42��6�   $��Bottom=�6�   6�   5      5      