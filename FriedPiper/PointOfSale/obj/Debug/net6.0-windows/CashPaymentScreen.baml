   M S B A M L   `   `   `  ????Q  MFriedPiper.PointOfSale, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:FriedPiper.PointOfSaleFriedPiper.PointOfSale  5      .    (FriedPiper.PointOfSale.CashPaymentScreen   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:FriedPiper.PointOfSale     5        ? 	Resources  5	       ?? 
TargetType ?? Property ?? Value ?? 	Resources??%?  '??       ?? 5
   
   " ??6   .?5      ??  ? ?? 6+   Z? ?? 5       ? ??$ 3q?60   ?? 5       ? ??
 ?   ?6,   ?? 5       ? ??$ 18(?6)   ?? 5       ? ??$ 50??6'   ?? 5       ? ??$ 65??6&    5      ???? 5      '??       " ??6   .?5      ??  ?@??CornerRadius$ 20??65   5      5      5      5      .??5      ]? .+?5   
   ?  ? ColumnDefinitions 5      ?? 5      ?? 5       ? RowDefinitions 5       ?? 5!      ?? 5"      $	??100 ?6    .+?5$      ?? $??0??6   $??0??6&   .+?5%      /   )FriedPiper.PointOfSale.CashPaymentControl     Notes$
 $100??6+      Payed 68   ?? 	 ?? Path$	 CustomerHundreds?
 ?? Mode$
 TwoWay=?   Owed 6m   ?? $	 ChangeHundreds?  5&      $	 $50??6+    67   ?? $	 CustomerFifties?$
 TwoWay=? 6k   ?? $	 ChangeFifties?  5'      $	 $20??6+    67   ?? $	 CustomerTwenties?$
 TwoWay=? 6l   ?? $	 ChangeTwenties?  5(      $	 $10??6+    67   ?? $	 CustomerTens?$
 TwoWay=? 6h   ?? $	 
ChangeTens?  5)      $ $5??6+    66   ?? $	 CustomerFives?$
 TwoWay=? 6h   ?? $	 ChangeFives?  5*      $ $2??6+    66   ?? $	 CustomerTwos?$
 TwoWay=? 6g   ?? $	 
ChangeTwos?  5+      $ $1??6+    66   ?? $	 CustomerOnes?$
 TwoWay=? 6g   ?? $	 
ChangeOnes?5,      ?? 5-      $??0??6   $??1??6&   .+?5.        $ $1??6+    66   ?? $	 CustomerDollarCoins?$
 TwoWay=? 6n   ?? $	 ChangeDollarCoins?  5/      $	 50c??6+    67   ?? $	 CustomerHalfDollarCoins?$
 TwoWay=? 6s   ?? $	 ChangeHalfDollarCoins?  50      $	 25c??6+    67   ?? $	 CustomerQuarters?$
 TwoWay=? 6l   ?? $	 ChangeQuarters?  51      $	 10c??6+    67   ?? $	 CustomerDimes?$
 TwoWay=? 6i   ?? $	 ChangeDimes?  52      $ 5c??6+    66   ?? $	 CustomerNickles?$
 TwoWay=? 6j   ?? $	 ChangeNickles?  53      $ 1c??6+    66   ?? $	 CustomerPennies?$
 TwoWay=? 6j   ?? $	 ChangePennies?54      ]? 55      $??1??6   $??0??6&   .+?56      ?? $??Total
Sale:??6   $
??Bold"?62   $??50??6D   ?? 57      -   5        $??	totalSale??57       ?? TextAlignment$ Center=?6-   $??15(?6D   $??90??6R   $??50??6]   59      ?? 5:      $??Amount
     Due:??6   $
??Bold"?67   $??50??6I   $??80??6U   ?? 5;      -   5        $??	amountDue??5;      
???  ??$ Center=?6B   $??15(?6Y   $??90??6g   $??50??6r   ??6~   ?? $	 CustomerPayment?5=      5>      ]? 5?      $??1??6   $??1??6%   .+?5@      ?? $??Change
   Owed:??6   $
??Bold"?66   $??50??6H   ?? 5A      -   5        $??
changeOwed??5A      $ Center=?6.   $??15(?6E   
??? ? ?$??90??6f   $??50??6q   ??6}   ?? $	 
ChangeOwed?5C      ?? 5D      -   5        $??50??5D      $	??130??6%   .??6E   Finalize Sale6T   5E      5F      5G      5H      