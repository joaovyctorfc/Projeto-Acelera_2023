   M S B A M L   `   `   `  ����O  KProjeto-Acelera-2023, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Projeto_Acelera_2023Projeto_Acelera_2023  5      2    ,Projeto_Acelera_2023.TelaCandidatosEmpresaUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:Projeto_Acelera_2023     5      .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5           Name$  tabelaEmpresa��5
         AutoGenerateColumns .  $��1q�6F      GridLinesVisibility$	 All=�6Z   $��10q�6t   $��	0,0,10,10q�6�    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%V   '        �� 5      "  6   .�5      ��  � ��$ Center=�6C   5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Nome��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6L   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 63   �� *Nome+6L     5      $ Curso��6%   $	 * 6N   
 64   �� *Curso+6N     5      $ Semestre��6%   $	 * 6T   
 67   �� *
Semestre+   ElementStyle 5      �� 5      " ��6    .�5      ��  � ��$ Center=�6D   5      5        5      $ Descrição��6%   $	 * 6V   
 68   �� *	Descricao+6V     5      $ Formato��6%   $	 * 6R   
 66   �� *	Formato+6R     5      $ Salário��6%   $	 * 6R   
 66   �� *	Salario+ 5      �� 5       " ��6    .�5!      ��  � ��$ Center=�6D   5"      5$        5%      $ Status��6%   $	 * 6S   
 65   �� *	Aprovacao+6S   4  .System.Windows.Controls.DataGridTemplateColumn  5&      $ Aprovar��6)   $	 * 6:      CellTemplate 5'      �� 5(      .R�5)      �� -   5        
��� � �$	��✔��5)   8   
 � Tag 6Z   �� 5*      5,        5.      $ Reprovar��6)   $	 * 6;    5/      �� 50      .R�51      �� -   5        
���  ��$	��❌��51   6    6Y   �� 52      54      56      58      59      