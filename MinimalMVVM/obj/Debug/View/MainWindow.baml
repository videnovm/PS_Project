   M S B A M L   `   `   `  ����F  BMinimalMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:MinimalMVVM.ViewModelMinimalMVVM.ViewModel  5   	   !    MinimalMVVM.View.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   9	viewModel#clr-namespace:MinimalMVVM.ViewModel     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��300��6)    � DataContext 5	      /   )MinimalMVVM.ViewModel.MainWindowViewModel  5
   
    J� InputBindings 5      �� 5   
   
 �� Key$ Enter��6    �� Command 6!   �� *Presenter.ConvertTextCommand+.��5      �� $	��400��6   .+�5   
   �� 
����  �$��5,5,5,0q�6"   .��63   Text To Convert6D   �� 5   
   $��5q�6[   ��6   �� *Presenter.SomeText+ �� UpdateSourceTrigger$ PropertyChanged=�6[   �� 5   
   
����  �$��5,5,5,0q�6"   .��63   	History6<   �� 5   
   $	��200��6<   $��5q�6I   ��6   �� *Presenter.History+6I   �� 5   
   $��5q�6    �� TextAlignment$ Center=�6>   ��6   �� *ConverterType+6>   �� 5   
   $��5q�6Y   $��Conversion Type��6d   ��6   �� *ChangeConverterCommand+��6<   �� 6d   �� 5   
   $��5q�6B   ��6   �� *Presenter.ConvertTextCommand+.��6M   	Convert6V   5      5      