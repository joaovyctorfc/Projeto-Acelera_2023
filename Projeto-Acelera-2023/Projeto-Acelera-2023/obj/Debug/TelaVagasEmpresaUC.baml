   M S B A M L   `   `   `  ����O  KProjeto-Acelera-2023, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Projeto_Acelera_2023Projeto_Acelera_2023  5      -    'Projeto_Acelera_2023.TelaVagasEmpresaUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:Projeto_Acelera_2023     5        � 	Resources  5	         FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 
botaoLogin �� 
TargetType �� 
TargetType ��Name	 �� CornerRadius
 ��Name �� Triggers P� Property P� Value �� 
TargetName��%J  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    &	 |    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7  7  7 	 �� 5
   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$    . #��� ��6J   $��1��6�   $	 1 2R�6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   " ��6#   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5       � ��8  6,   �� 5        � ��# � ��6+   �� 5!       � ��$ 1q�60   �� 5"       � ��$ Center=�6;   �� 5#       � ��$ Center=�69   �� 5$       � ��$ 1q�6(   �� 5%       � �� 5&      �� 5'      " ��6&   .R�5(      �� $ border��6!   $	 10��61   #��z��6C   #��z��6o   #��z��6�    . ._�5)      �� $
 contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5*       5+      P� 5,       �@��IsDefaulted . . �5-   "   �� $ border��6@   # � ��6T    � ��5.      P� 5/       �@J�IsMouseOver . . �50   "   �� $ border��6?   8   � ��6S   �� 51   "   $ border��6@   8   � ��6T   52      P� 53       � �� . . �54   "   �� $ border��6?   8   � ��6S   �� 55   "   $ border��6@   8   � ��6T   56      P� 57       � {� .  . �58   "   �� $ border��6?   8   � ��6S   �� 59   "   $ border��6@   8   � ��6T   �� 5:   "   $ contentPresenter��6K   8 	  � ��6i   5;      5=      5?      5@      5A      .��5B      � -   5         �Name$ mainGrid��5B      .+�5C   
   &   System.Windows.Controls.DataGrid  -   5          Name$ tabelaEmpresa��5C         AutoGenerateColumns .  $��1q�6F      GridLinesVisibility$	 All=�6Z   $��10q�6t   $��	0,0,10,10q�6�   ��6�   �� *
ListaVagas+  5E      =  7System.Windows.Controls.Primitives.DataGridColumnHeader��%V   '        �� 5F      "  6   .�5G      ��  � ��$ Center=�6C   5H      5I         Columns 5K      0  *System.Windows.Controls.DataGridTextColumn  5L      ,  &System.Windows.Controls.DataGridColumn   Header$
 Nome��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Nome+6M     5M      $ Área��6%   $ * 6M    63   �� *Area+6M     5N      $ Salário��6%   $ * 6R    66   �� *	Salario+   ElementStyle 5O      �� 5P      " ��6    .�5Q      ��  � ��$ Center=�6D   �� 5R       � ��$ Center=�6B   5S      5U        5V      $ Descrição��6%   $ * 6V    68   �� *	Descricao+6V     5W      $ Formato��6%   $ * 6R    66   �� *	Formato+6R     5X      $ Status��6%   $ * 6S    65   �� *	Aprovacao+6S   4  .System.Windows.Controls.DataGridTemplateColumn  5Y      $ 
Candidatos��6)      CellTemplate 5Z      �� 5[      .R�5\      �� -   5        
�����@�$
��📑��5\   <   #��[
 6n   5^      5_      5a        5b      $ Excluir��6)    5c      �� 5d      .R�5e      �� -   5        
���  ��$	��❌��5e   6   #��[
 6[   5g      5h      5j      5l      �� 5m   
   -   5         ��Name$ stackPanelCandidatos��5m      $
��Left=�63   $	��200��6N   $��0,0,0,0q�6[   $	��Top=�6l   $	��650��6�   $y�	Collapsed=�6�   .+�5n        -   5        $ tabelaCandidatos��5n       .  $��1q�6M   $	 All=�6a   $��10q�6{   $��	0,0,10,10q�6�   ��6�   �� *ListaCandidatos+ 5p        5q      $
 Nome��6)   $ * 6P    67   �� *Nome+6P     5r      $ Curso��6)   $ * 6R    68   �� *Curso+6R     5s      $ Semestre��6)   $ * 6X    6;   �� *
Semestre+6X     5t      $ Aprovação��6)   $ * 6Z    6<   �� *	Aprovacao+6Z     5u       5v      �� 5w       �� Orientation$ 
Horizontal=�6)   .+�5x   "   �� $
��Chat��6,   $��0,0,5,0q�68   5y       5{      �� 5|      .R�5}   "   �� -   5        $
��📧��5}   )   
�����@�#��[
 6c   5~   #   5      5�      5�      5�      5�      5�      