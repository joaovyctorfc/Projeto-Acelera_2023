   M S B A M L   `   `   `  ����O  KProjeto-Acelera-2023, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Projeto_Acelera_2023Projeto_Acelera_2023  5   	   -    'Projeto_Acelera_2023.TelaRedefinirSenha   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Projeto_Acelera_2023     5   	     � Title$  TelaRedefinirSenha��5   	   $	��450��6$   $	��800��61    � 	Resources 5	         FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 botaoRedefinir �� 
TargetType �� 
TargetType	 ��Name
 �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName  botaoEnviar  TextBox.Static.Border  TextBox.MouseOver.Border  TextBox.Focus.Border  boxEmail-  'System.Windows.Input.KeyboardNavigation ��Name �� Triggers ]� 
Conditions �� Property �� Value  boxSenha  	boxCodigo  PasswordBoxStyle1��%p!  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    &	 |    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7  7  7 	 &	 �    7   7  7  7  7  7  7  7  7  7 	 &	 �    &	 �    &	 �    &	 �    7  7  7  &	 �    7  7  7  &	 �    7  7  7  &	 �    7  7  7  �� 5
   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$    . #��� ��6J   $��1��6�   $	 1 2R�6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   " ��6'   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5       � ��8  6,   �� 5        � ��# � ��6+   �� 5!       � ��$ 1q�60   �� 5"       � ��$ Center=�6;   �� 5#       � ��$ Center=�69   �� 5$       � ��$ 1q�6(   �� 5%       � �� 5&      �� 5'      " ��6&   .R�5(      �� $	 border��6!   $
 10��61   #��z��6C   #��z��6o   #��z��6�    . ._�5)      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5*       5+      P� 5,       �@��IsDefaulted . . �5-   "   �� $ border��6@   # � ��6T    � ��5.      P� 5/       �@J�IsMouseOver . . �50   "   �� $ border��6?   8   � ��6S   �� 51   "   $ border��6@   8   � ��6T   52      P� 53       � �� . . �54   "   �� $ border��6?   8   � ��6S   �� 55   "   $ border��6@   8   � ��6T   56      P� 57       � {� .  . �58   "   �� $ border��6?   8   � ��6S   �� 59   "   $ border��6@   8   � ��6T   �� 5:   "   $ contentPresenter��6K   8 	  � ��6i   5;      5=      5?      5@      �� 5A   
   " ��6$   .�5B      ��  �@�FocusVisualStyle8   61   �� 5C       � ��8  6+   �� 5D       � ��8  6,   �� 5E       � ��# � ��6+   �� 5F       � ��$ 1q�60   �� 5G       � ��$ Center=�6;   �� 5H       � ��$ Center=�69   �� 5I       � ��$ 1q�6(   �� 5J       � �� 5K      �� 5L      " ��6&   .R�5M      �� $	 border��6!   $
 10��61   #��z��6C   #��z��6o   #��z��6�    . ._�5N      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5O       5P      P� 5Q       �@��IsDefaulted . . �5R   "   �� $ border��6@   # � ��6T    � ��5S      P� 5T       �@J�IsMouseOver . . �5U   "   �� $ border��6?   8   � ��6S   �� 5V   "   $ border��6@   8   � ��6T   5W      P� 5X       � �� . . �5Y   "   �� $ border��6?   8   � ��6S   �� 5Z   "   $ border��6@   8   � ��6T   5[      P� 5\       � {� .  . �5]   "   �� $ border��6?   8   � ��6S   �� 5^   "   $ border��6@   8   � ��6T   �� 5_   "   $ contentPresenter��6K   8 	  � ��6i   5`      5b      5d      5e      �� 5f   
   $ 	#FFABAdB3��68   �� 5g   
   $ 	#FF7EB4EA��6;   �� 5h   
   $ 	#FF569DE5��67   �� 5i   
   " ��6!   .�5j      ��  � ��# � ��6+   �� 5k       � ��8   6,   �� 5l       � ��# � ��6+   �� 5m       � ��$ 1q�60   �� 5n       �@ TabNavigation$
 None=�6A   �� 5o       � ��$
 Left=�6;   �� 5p       �@�FocusVisualStyle 61   Z� �� 5q       �@J�	AllowDrop . 6*   �� 5r       �@��PanningMode$ VerticalFirst=�69   �� 5s       �@��IsFlicksEnabled .  67   �� 5t       � �� 5u      �� 5v      " ��6&   .R�5w      �� $	 border��6!   $
 6��61   #��z��6B   #��z��6n   #��z��6�    . ._�5x      �� $ PART_ContentHost��6+   |�.  $��Hidden=�6W   $��Hidden=�6~   5y       5z      P� 5{       � {� .  . �5|   "   �� $ border��6<    �@J�Opacity$
 0.56Q�6P   5}      P� 5~       �@J�IsMouseOver . . �5   "   �� $ border��6@   8   � ��6T   5�      P� 5�       �@J�IsKeyboardFocused . . �5�   "   �� $ border��6@   8   � ��6T   5�      5�      5�       5�      ]� 5�       5�      �� 5�      + �@��#IsInactiveSelectionHighlightEnabled . 6S   �� 5�       �@��IsSelectionActive .  6A   ./�5�      ��  �@��SelectionBrush# � /�67   5�      5�      �� 5�   
   " ��6!   .�5�      ��  � ��# � ��6+   �� 5�       � ��8   6,   �� 5�       � ��# � ��6+   �� 5�       � ��$ 1q�60   �� 5�       �@ TabNavigation$
 None=�6A   �� 5�       � ��$
 Left=�6;   �� 5�       �@�FocusVisualStyle 61   Z� �� 5�       �@J�	AllowDrop . 6*   �� 5�       �@��PanningMode$ VerticalFirst=�69   �� 5�       �@��IsFlicksEnabled .  67   �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      �� $	 border��6!   $
 6��61   #��z��6B   #��z��6n   #��z��6�    . ._�5�      �� $ PART_ContentHost��6+   |�.  $��Hidden=�6W   $��Hidden=�6~   5�       5�      P� 5�       � {� .  . �5�   "   �� $ border��6<    �@J�Opacity$
 0.56Q�6P   5�      P� 5�       �@J�IsMouseOver . . �5�   "   �� $ border��6@   8   � ��6T   5�      P� 5�       �@J�IsKeyboardFocused . . �5�   "   �� $ border��6@   8   � ��6T   5�      5�      5�       5�      ]� 5�       5�      �� 5�      + �@��#IsInactiveSelectionHighlightEnabled . 6S   �� 5�       �@��IsSelectionActive .  6A   ./�5�      ��  �@��SelectionBrush# � /�67   5�      5�      �� 5�   
   " ��6"   .�5�      ��  � ��# � ��6+   �� 5�       � ��8   6,   �� 5�       � ��# � ��6+   �� 5�       � ��$ 1q�60   �� 5�       �@ TabNavigation$
 None=�6A   �� 5�       � ��$
 Left=�6;   �� 5�       �@�FocusVisualStyle 61   Z� �� 5�       �@J�	AllowDrop . 6*   �� 5�       �@��PanningMode$ VerticalFirst=�69   �� 5�       �@��IsFlicksEnabled .  67   �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      �� $	 border��6!   $
 6��61   #��z��6B   #��z��6n   #��z��6�    . ._�5�      �� $ PART_ContentHost��6+   |�.  $��Hidden=�6W   $��Hidden=�6~   5�       5�      P� 5�       � {� .  . �5�   "   �� $ border��6<    �@J�Opacity$
 0.56Q�6P   5�      P� 5�       �@J�IsMouseOver . . �5�   "   �� $ border��6@   8   � ��6T   5�      P� 5�       �@J�IsKeyboardFocused . . �5�   "   �� $ border��6@   8   � ��6T   5�      5�      5�       5�      ]� 5�       5�      �� 5�      + �@��#IsInactiveSelectionHighlightEnabled . 6S   �� 5�       �@��IsSelectionActive .  6A   ./�5�      ��  �@��SelectionBrush# � /�67   5�      5�      �� 5�   
   " G�6*   .�5�      ��  �@G�PasswordChar$	 ●��6-   �� 5�       � ��# � ��6+   �� 5�       � ��8   6,   �� 5�       � ��# � ��6+   �� 5�       � ��$ 1q�60   �� 5�       �@ TabNavigation$
 None=�6A   �� 5�       � ��$
 Left=�6;   �� 5�       �@�FocusVisualStyle 61   Z� �� 5�       �@J�	AllowDrop . 6*   �� 5�       �@��PanningMode$ VerticalFirst=�69   �� 5�       �@��IsFlicksEnabled .  67   �� 5�       � �� 5�      �� 5�      " G�6&   .R�5�      �� $	 border��6!   $
 6��61   #��z��6B   #��z��6n   #��z��6�    . ._�5�      �� $ PART_ContentHost��6+   |�.  $��Hidden=�6W   $��Hidden=�6~   5�       5�      P� 5�       � {� .  . �5�   "   �� $ border��6<    �@J�Opacity$
 0.56Q�6P   5�      P� 5�       �@J�IsMouseOver . . �5�   "   �� $ border��6@   8   � ��6T   5�      P� 5�       �@J�IsKeyboardFocused . . �5�   "   �� $ border��6@   8   � ��6T   5�      5     5      5     ]� 5      5     �� 5     + �@G�#IsInactiveSelectionHighlightEnabled . 6S   �� 5      �@G�IsSelectionActive .  6A   ./�5
     ��  �@G�SelectionBrush# � /�67   5     5     5     .��5     � .+�5  
   �� -   5         ��Name$ botaoRedefinir��5     $��4��6)   $��	Redefinir��66   $
��Left=�6J   $��338,290,0,0q�6e   $	��Top=�6z   $	��147��6�   $��40��6�   #��� 
 6�   $��Yu Gothic UI Semibold)�6�   ���	#FF018CFF
���������6=  Z� �� 5  
   -   5        $ botaoEnviarCodigo��5     $��3��6,   $��Enviar��69   $
��Left=�6J   $��505,180,0,0q�6e   $	��Top=�6z   $	��147��6�   $��40��6�   #���  6�   $��Yu Gothic UI Semibold)�6�   
����������	#FF018CFF��6  Z� 6=  �� 5  
   -   5         ��Name$ 
campoEmail��5     $��0��6&   $
��Left=�63   $��29��6N   $��338,136,0,0q�6Z    �� TextWrapping$
 Wrap=�6o   $	��Top=�6�   $	��147��6�   $��Yu Gothic UI Semibold)�6�   #���  6�   
���������6�   Z� 6  �� 5  
   -   5        $ campoCodigo��5     $��1��6'   $
��Left=�64   $��30��6O   $��338,186,0,0q�6[   $
 Wrap=�6p   $	��Top=�6�   $	��147��6�   $��Yu Gothic UI Semibold)�6�   #���  6�   
���������6�   Z� 6  �� 5  
   $��E-mail��6   $
��Left=�6!   $��277,136,0,0q�6<   $	��Top=�6Q   $��Yu Gothic UI Semibold)�6i   �� 5  
   $��Código��6   $
��Left=�6!   $��272,180,0,0q�6<   $	��Top=�6Q   $��Yu Gothic UI Semibold)�6i   �� 5  
   $��
Nova Senha��6   $
��Left=�6%   $��246,235,0,0q�6@   $	��Top=�6U   $��Yu Gothic UI Semibold)�6m   �� 5  
   -   5         ��Name$ linkCadastrar��5     $
��Left=�6+   $��418,350,0,0q�6F   $
��Wrap=�6[   $	��Top=�6p   ���	#FF0A15F5$��Yu Gothic UI Semibold)�6�   �� 5     -   5        .�5  8   Não possui conta? Cria conta5     5     �� 5  
   -   5        $ 	linkLogin��5     $
��Left=�6'   $��277,350,0,0q�6B   $
��Wrap=�6W   $	��Top=�6k   ���	#FF0A15F5$��Yu Gothic UI Semibold)�6�   �� 5     -   5        .�5  4   Ir para a tela de Login5     5      �� 5!  
   $��Redefinir Senha��6   $
��Left=�6*   $��
290,35,0,0q�6E   $	��Top=�6Y   $	��250��6q   $��54��6}   $��30(�6�   ���	#FF018CFF$��Yu Gothic UI Semibold)�6�   G� 5"  
   -	   5         G�Name$ 
campoSenha��5"     $��2��6*   $
��Left=�67   $��339,235,0,0q�6R   $	��Top=�6g   $��29��6   $	��146��6�   #���  6�   
���������6�   Z� 6�   5%     5&     