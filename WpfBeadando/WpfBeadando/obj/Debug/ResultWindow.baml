   M S B A M L   `   `   `  ����  WpfBeadando    WpfBeadando.ResultWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Quiz Results��5   	   $	��500��6   $	��700��6+   ���#F0F8FF � 	Resources 5         StyledButton �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value��%a  &	        �� 5   
   " ��6%   .�5      ��  � ��
 ��d�6+   �� 5       � ��
 �����6+   �� 5	       � ��$ 16(�6)   �� 5
       � ��$
 Bold"�6+   �� 5       � ��$
 10,5q�6(   �� 5       � ��$
 0,10q�6'   �� 5       � ��
 ��d�6,   �� 5       � ��$ 2q�60   �� 5       � ��$	 150��6&   �� 5       � ��$ 40��6'   �� 5       �@�Cursor$
 Hand��6'    5      P� 5       �@J�IsMouseOver . . �5      ��  � �� �#1E90FF63   �� 5       � ��
 �����63   5      5      5      .��5      � $��10q�6   .+�5   
   �� .+�5      �� 
����d� �� Padding$ 10q�61   	 �� CornerRadius$	 10��6>   ._�5      �� $��Quiz Results��6   $��26(�60   $
��Bold"�6>   
�������
 �� TextAlignment$
 Center=�6c   5      �� 5!      $��10��6    J� Opacity$ 0Q�6$   �� 5#      
����d�$��2q�62   $	 5��6F   $ 5q�6W   ._�5$      &   System.Windows.Controls.DataGrid  -   5          Name$ ResultsDataGrid��5$         AutoGenerateColumns .     
IsReadOnly . $��0,0,0,20q�6b      AlternatingRowBackground
 ��ح� �� AlternationCount$ 2��5%   @      Columns 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Header$ Question��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6\   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *
Question+6\     5(      $ Your Answer��6-   $	 150 6a    6B   �� *
UserAnswer+6a     5)      $ Correct Answer��6-   $	 150 6g    6E   �� *CorrectAnswer+6g   5+      5,      �� 5.      -   5         ��Name$ FinalScoreText��5.      $��20(�60   $
��Bold"�6>   $
 Center=�6P   
��� � �$
��0,10q�5/   +   �� 51      -   5        $��
Retry Quiz��51      $��Center=�6*   #��[  6G   6m   52      53      54      