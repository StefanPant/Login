   M S B A M L   `   `   `  ����B  >Zadatak, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ZadatakZadatak  5   	       Zadatak.AddEditUser   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Zadatak     5   	     � Title$  Add Edit User��5   	   $	��450��6   $	��800��6,   .��5	      � -   5        $��grdMainGrid��5	       � DataContext 6   �� .+�5
   
   ��  �� IsCancel . $��Cancel��6!   $
��Left=�62   $��663,322,0,0q�6M   $	��Top=�6b   $��75��6z   �� 5   
   -   5        $��btnSave��5      $
��Save��6@   $
��Left=�6O   $��496,322,0,0q�6j   $	��Top=�6   $��75��6�   ��6    �� *SaveCommand+6�   �� 5   
   -   5        $��tbxName��5      $
��Left=�6G   $��30��6b   $��167,113,0,0q�6n    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��133��6�   ��6!   �� *CurrentUser.UserName+6�   �� 5   
   $��	User Name��6   $
��Left=�6$   $��
60,113,0,0q�6?   $	��Top=�6S   �� 5   
   $��Password��6   $
��Left=�6#   $��
60,174,0,0q�6>   $	��Top=�6R   $��69��6j   �� 5   
   -   5        $��tbxPass��5      $
��Left=�6G   $��26��6b   $��167,174,0,0q�6n   $
 Wrap=�6�   $	��Top=�6�   $	��133��6�   ��6!   �� *CurrentUser.Password+6�   �� 5   
   $��Is Admin��6   $
��Left=�6#   $��
60,248,0,0q�6>   $	��Top=�6R    J� RenderTransformOrigin$ 0.5,0.5&�6j   $��30��6�   $��60��6�   6�   �� 5   
   -   5        $��checkBox��5   e   $
��Left=�6u   $��167,251,0,0q�6�   $	��Top=�6�   $��70��6�   ��6   �� *CurrentUser.IsAdmin+ d� 	IsChecked 6;   �� *CurrentUser.IsAdmin+6�   5      5      