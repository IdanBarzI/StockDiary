   M S B A M L   `   `   `  ????E  AStockDiary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:StockDiary.ViewsStockDiary.Views  5      J FPasswordBoxMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null`Aclr-namespace:PasswordBoxMVVM.Components;assembly=PasswordBoxMVVMPasswordBoxMVVM.Components 6;        StockDiary.Views.LoginView   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:StockDiary.Views     5      X
componentsAclr-namespace:PasswordBoxMVVM.Components;assembly=PasswordBoxMVVM     6;   .??5
      ? $	??500??6   $??25q?6     ? RowDefinitions  5   
   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   .+?5   
   ?? $??0??6   $??32(?6!   $??Login??6/   ? 5   
   $??1??6   $??0 20 0 0q?6     5      ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    .+?5      ?? $??0??6   .+?5      ?? $??Email??6   ?? 5      ??6   ?? *Email+ ?? UpdateSourceTrigger$ PropertyChanged=?5      ?? 5       $??1??6   $??0 10 0 0q?6'   .+?5!      ?? $??Password??6   4  .PasswordBoxMVVM.Components.BindablePasswordBox  5"         Password 61   ?? *
Password+$ PropertyChanged=?5#      ?? 5%      $??2??6   $??Submit??6"   $??0 20 0 0q?64   ??6F   ?? *SubmitCommand+?? 5'      $??3??6   $$??Dont have an account? Register??6"   $??0 10 0 0q?6L   ??6^   ?? *NavigateRegisterCommand+5(      5)      5*      