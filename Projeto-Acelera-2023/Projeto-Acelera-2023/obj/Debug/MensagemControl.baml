   M S B A M L   `   `   `  ����O  KProjeto-Acelera-2023, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Projeto_Acelera_2023Projeto_Acelera_2023  5      *    $Projeto_Acelera_2023.MensagemControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:Projeto_Acelera_2023     5      $��191.026��5      $��644.775��60     � 	Resources  5         FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 ButtonStyle1 �� 
TargetType �� 
TargetType ��Name	 �� CornerRadius
 ��Name �� Triggers P� Property P� Value �� 
TargetName��%k  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    &	 |    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7  7  7 	 �� 5	   
   .�5
      ��  � �� 5      �� 5      .R�5      �� $��2q�6$    . #��� ��6J   $��1��6�   $	 1 2R�6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   " ��6%   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5       � ��8  6,   �� 5       � ��# � ��6+   �� 5        � ��$ 1q�60   �� 5!       � ��$ Center=�6;   �� 5"       � ��$ Center=�69   �� 5#       � ��$ 1q�6(   �� 5$       � �� 5%      �� 5&      " ��6&   .R�5'      �� $ border��6!   $	 8��61   #��z��6B   #��z��6n   #��z��6�    . $��40��6�   $��-6,0,0,0q�6�   ._�5(      �� $
 contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5)       5*      P� 5+       �@��IsDefaulted . . �5,   "   �� $ border��6@   # � ��6T    � ��5-      P� 5.       �@J�IsMouseOver . . �5/   "   �� $ border��6?   8   � ��6S   �� 50   "   $ border��6@   8   � ��6T   51      P� 52       � �� . . �53   "   �� $ border��6?   8   � ��6S   �� 54   "   $ border��6@   8   � ��6T   55      P� 56       � {� .  . �57   "   �� $ border��6?   8   � ��6S   �� 58   "   $ border��6@   8   � ��6T   �� 59   "   $ contentPresenter��6K   8 	  � ��6i   5:      5<      5>      5?      5@      .��5A      � $��	0,0,10,10q�6   .+�5B   
   �� $��1q�6   ���	#FF0677FF$	 10��6<   $��
0,0,212,16q�6N    J� Effect 5C      3  -System.Windows.Media.Effects.DropShadowEffect  5D         Color$ Black��6#      	Direction$	 315Q�61      ShadowDepth$ 5Q�6A      Opacity$	 0.8Q�6Q      
BlurRadius$ 10Q�6_   5F      �� 5G   
   -   5         ��Name$ botaoCandidatar��5G      $��Excluir��6*   $
��Left=�6<   $��
308,70,0,0q�6W   $	��Top=�6k   $��75��6�   #��� 
 6�   $��Yu Gothic UI Semibold)�6�   
����������	#FFEC2323��6�   Z� 6   �� 5H   
   -   5         ��Name$ labelAssunto��5H      $��Label��6&   $
��Left=�66   $��	76,61,0,0q�6Q   $	��Top=�6d   
�������$��Yu Gothic UI Semibold)�6�   �� 5I   
   -   5        $ 	labelNome��5I      $��Label��6#   $
��Left=�63   $��
132,27,0,0q�6N   $	��Top=�6b   
�������$��Yu Gothic UI Semibold)�6�   �� 5J   
   -   5        $ labelNome_Copy��5J      $��Assunto:��6(   $
��Left=�6;   $��	19,61,0,0q�6V   $	��Top=�6i   
�������$��Yu Gothic UI Semibold)�6�   �� 5K   
   -   5        $ labelNome_Copy3��5K      $��
Conteúdo:��6)   $
��Left=�6=   $��	19,95,0,0q�6X   $	��Top=�6k   
�������$��Yu Gothic UI Semibold)�6�   �� 5L   
   -   5        $ labelNome_Copy4��5L      $��Nome da Empresa:��6)   $
��Left=�6D   $��	19,27,0,0q�6_   $	��Top=�6r   
�������$��Yu Gothic UI Semibold)�6�   �� 5M   
   $
��Left=�6   $��51��60   $��
91,102,0,0q�6<   $	��Top=�6P   $	��175��6h   .+�5N      �� -   5         ��Name$ labelConteudo��5N      $
��Left=�6/   $
��Wrap=�6J   $��	TextBlock��6^   $	��Top=�6o   $	��175��6�   $��51��6�   $��Yu Gothic UI Semibold)�6�   
�������6�   5O      5Q      5R      