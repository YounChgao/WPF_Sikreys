   M S B A M L   `   `   `  ����F  BProject.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Project.WPF.ViewProject.WPF.View  5          Project.WPF.View.ChatPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Project.WPF.View     5        N� Title$  ChatPage��5
       N� 
Background
 �����.��5      � -   5         � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $��50 �6   �� 5      �� 5      $��50 �6   �� 5      $��10 �6    � ColumnDefinitions 5   
   �� 5      $��10 �6   �� 5      �� 5      $��10 �6   .+�5   
   �� $��1��6   $��2��6"   
�������$��Disabled=�6k   ��6/   �� *	chatItems+��5      �� 5      .R�5         Project.WPF.View.ChatItem  6'   5      ��5      �� 5      .R�5       �� 5!      5$      �� 5%   
   $��1��6   $��3��6!      	EnterText#��[  6.   ._�5&      � .+�5'      �� -   5         ��Name$ textBox��5'      
�������
���   �5)      �� 5,      -   5        $��Right=�5,      $��50��5-      ���	#FF57B6FF
������� � Cursor$
 Hand��50      .��52      �� $!��/Resources/SendMessage2.png��6   $��Center=�53      $��Center=�54      55      56      57      59      5:      