   M S B A M L   `   `   `  ����O  KProjeto-Acelera-2023, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Projeto_Acelera_2023Projeto_Acelera_2023  5      6    0Projeto_Acelera_2023.TelaCandidatosCoordenadorUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:Projeto_Acelera_2023     5      .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5           Name$  tabelaCoordenador��5
         AutoGenerateColumns .  $��1q�6J      GridLinesVisibility$	 All=�6^   $��10q�6x   $��	0,0,10,10q�6�    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%V   '        �� 5      "  6   .�5      ��  � ��$ Center=�6C   5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Nome��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6L   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 63   �� *Nome+6L     5      $ Curso��6%   $	 * 6N   
 64   �� *Curso+6N     5      $ Empresa��6%   $	 * 6R   
 66   �� *	Empresa+6R     5      $
 Vaga��6%   $	 * 6L   
 63   �� *Vaga+6L     5      $ Salário��6%   $	 * 6R   
 66   �� *	Salario+   ElementStyle 5      �� 5      " ��6    .�5      ��  � ��$ Center=�6D   5      5        5      $ Formato��6%   $	 * 6R   
 66   �� *	Formato+6R     5      $ Aprovação��6%   $	 * 6V   
 68   �� *	Aprovacao+6V     5       $ Descrição��6%   $	 * 6V   
 68   �� *	Descricao+6V   5#      5$      5%      