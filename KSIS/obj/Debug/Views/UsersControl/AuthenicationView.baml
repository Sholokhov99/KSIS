   M S B A M L   `   `   `  ����?  ;KSIS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:KSIS.UsersControlKSIS.UsersControl  5      1clr-namespace:KSIS.ViewModelsKSIS.ViewModels  5      A%clr-namespace:KSIS.Views.UsersControlKSIS.Views.UsersControl  5      %    KSIS.UsersControl.Authenication   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:KSIS.UsersControl     5      4
viewmodelsclr-namespace:KSIS.ViewModels     5      >UsersControl%clr-namespace:KSIS.Views.UsersControl     5      -   5          � 	Resources  5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ /Styles/Colors.xaml?�6%   �� 5      $ /Styles/Default.xaml?�6%   �� 5      $ /Styles/Fonts.xaml?�6%   �� 5      $ /Styles/Icons.xaml?�6%   %    5       � DataContext 5      #  KSIS.ViewModels.AuthViewModel  5   
   .��5      � -   5         �Name$ GridAuth��5      .+�5   
   �� -   5         ��Name$ BorderAuthForm��5      ���	#CC000000$��2��6=   $��Stretch=�6Q   $��Stretch=�6m    �� RadiusX$ 15��6�    �� RadiusY$ 15��6�   �� 5   
   $��Center=�6   $��Center=�63   $��30,23q�6N   .+�5      � $
��17,0q�6   .+�5      �� $��Русский ��6   $
��Left=�6+   
�������6F   0   *KSIS.Views.UsersControl.SysTimeUserControl  5      -   5          Name$ TimeSys��5   2   $��Right=�6C   
�������$��0q�6r   5      �� 5       .+�5$      �� -   5        	 ��Name$	 TxtBoxLOGIN��5$      ��6/   �� *StrLoginUser+
 J� 	LostFocus
 6M   �� *LoginTextBox_LostFocus+G� 5%      -   5         G�Name$ PassBoxPASSWORD��5%       G� Password$  ��67   $
��0,17q�6C   6u   5&      � 5(      .+�5)      �� -   5         ��Name$ BtnSign��5)      $��
Войти��6*   $
��Left=�6:   $��0q�6U   �� 5*      -   5        $ 
BtnNewPass��5*      $#��Изменить пароль��6-   $��Right=�6G   $��0q�6c   6n   5+      � 5,      $��0,15,0,0q�6   .+�5-      �� -	   5        $ BtnOffPc��5-         BtnControlPCAuth#��[  6+     Fa_PowerOff#��[ 6U   �� 5.      -
   5        $ BtnRebootPc��5.      #��[  6.     Fa_RoleteLeft#��[ 6X   �� 5/      -   5        $ BtnLogOutOS��5/      #��[  6.     	Fa_SignIn#��[ 6X   �� 50      -   5        $ BtnSleepModeOS��50      #��[  61     Fa_Sleep#��[ 6[   �� 51      -   5        $ BtnSerttingForm��51      #��[  62     
Fa_Setting#��[ 6\   $��0q�6�   52      53      54      55      