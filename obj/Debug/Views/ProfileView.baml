   M S B A M L   `   `   `  ����F  BTestProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TestProject.ViewsTestProject.Views  5      #    TestProject.Views.ProfileView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:TestProject.Views     5        N� Title$  ProfileView��5	       N� 
Background �#F0F0F0.��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      .+�5   
   �� $��0��6   $��20q�6%   .+�5      �� $	��100��62   $	��100��6>   $��0,0,0,10q�6K   ��6   �� *
AvatarPath+6K   5      �� 5   
   $��1��6   $��20q�6%   $��center=�61   .+�5      �� $
��Bold"�63   $��18(�6E   ��6   �� *	FirstName+�� 6T    � Language$ ru-ru�6X   $�Имя��6i   6w   �� 5       $
��Bold"�62   $��18(�6D   ��6   �� *
LastName+�� 6S   $ ru-ru�6W   $�Фамилия��6h   6z   �� 5!      $��0,0,0,10q�63   ��6   �� *	BirthDate+�� 6F   $ ru-ru�6J   $�
12.12.2001��6[   6p   �� 5"      $��Medium"�6.   $��16(�6B   ��6   �� *Role+�� 6Q   $ ru-ru�6U   $�Пользователь��6f   6}   5#      �� 5&   
   $��0��6   $��2��6%   $��center=�62   .+�5'      �� -   5        $��Товары��5'      ���#CD5C5C���#ffffff$	��100��6P   $��30��6\   $��Comic Sans MS)�6   5(      �� 5)   
   $��1��6   $��2��6%   $��center=�62   .+�5*      �� -   5        $��Сотрудники��5*      ���#CD5C5C���#ffffff$	��100��6T   $��30��6`   $��Comic Sans MS)�6�   5+      �� 5,   
   $��2��6   $��2��6%   $��center=�62   .+�5-      �� -   5        $��
Смена��5-      ���#CD5C5C���#ffffff$	��100��6O   $��30��6[   $��Comic Sans MS)�6~   5.      5/      50      