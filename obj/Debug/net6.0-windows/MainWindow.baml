   M S B A M L   `   `   `  ????D  @TicTacToe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:TicTacToe	TicTacToe  5   	       TicTacToe.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:TicTacToe     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)    ? 	Resources 5
       ?? 
TargetType ?? Property ?? Value??%?   '??       ?? 5   
   " ??6   .?5      ??  ? ??$ 3q?6'   ?? 5       ? ??$ 48(?6)   -   5        5      5      .??5      ?  ? RowDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $	??100 ?6   .+?5   
   ? -   5         ?Name$ 	gridBoard??5      
???   ? 5      ?? 5      $??* ?6    ?? 5      $??* ?6    ?? 5      $??* ?6     ? ColumnDefinitions 5      ?? 5      $??* ?6#   ?? 5       $??* ?6#   ?? 5!      $??* ?6#   .+?5$      ?? 
 ? Tag$	 0,0??6   $??0??6   $??0??6,   ?? 5%      $	 1,0??6   $??0??6   $??1??6,   ?? 5&      $	 2,0??6   $??0??6   $??2??6,   ?? 5'      $	 0,1??6   $??1??6   $??0??6,   ?? 5(      $	 1,1??6   $??1??6   $??1??6,   ?? 5)      $	 2,1??6   $??1??6   $??2??6,   ?? 5*      $	 0,2??6   $??2??6   $??0??6,   ?? 5+      $	 1,2??6   $??2??6   $??1??6,   ?? 5,      $	 2,2??6   $??2??6   $??2??6,   5-      ?? 5/   
   -   5        	 ??Name$	 	winScreen??5/      $??Center=?6'   $??Center=?6D   $??56(?50      $
??Bold"?6"   
???????$y?	Collapsed=?6L   Player X wins52      ?? 54   
   -   5        
 ??Name$
 
btnNewGame??54      $??New Game??6%   $??Center=?68   $??Center=?6U   $??1??55      6   56      57      