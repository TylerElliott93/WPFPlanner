   M S B A M L   `   `   `  ����E  AWPFPlanner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:WPFPlanner.User_ControlsWPFPlanner.User_Controls  5   	       WPFPlanner.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5uc&clr-namespace:WPFPlanner.User_Controls     5   	     � Title$  
MainWindow��5   	   $	��900��6   $	��800��6)   .��5	      � ���#2ed573$��1q�6     � ColumnDefinitions 5
   
   �� 5      $	��350 �6   6-   �� 5      $	��450 �6   6-    � RowDefinitions 5   
   �� 5      $��80 �6   6*   �� 5      $	��100 �6   6+   �� 5      $	��500 �6   6+   �� 5      $	��100 �6   6+   �� 5      $	��100 �6   6+   .+�5   
   )   #WPFPlanner.User_Controls.TimePicker  $��0��6   6'   �� 5   
   -   5        $��TimelineStackPanel��5      
�������$��1��6B   $��3��6O   $	��700��6`   .+�5      �� ��6   �� *TimelineItems+ �� UpdateSourceTrigger$ PropertyChanged=�6h   5        5   
   $��4��6   6'   �� 5"   
   $��0��6   $��1��6"   .+�5#      �� ��6   �� *Header+62   �� 5$      ��6   �� *	DayLength+65   5%      �� 5(   
   -   5        $��TaskInputBox��5(   D   ���#2ed573$��1��6'   $��1��64   ��6X   ��  �� Path$
 Task� �� Mode$ TwoWay=�6�   5*      5+      