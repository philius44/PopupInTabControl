   M S B A M L   `   `   `  ����L  HPopupInTabControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullk:clr-namespace:WuH.ServiceTool.Core.Presentation.Converters,WuH.ServiceTool.Core.Presentation.Converters  5      5clr-namespace:PopupInTabControlPopupInTabControl  5      %    PopupInTabControl.DeviceTabView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      Q
converters:clr-namespace:WuH.ServiceTool.Core.Presentation.Converters     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      +localclr-namespace:PopupInTabControl  5        � 	Resources  5      O   IWuH.ServiceTool.Core.Presentation.Converters.BooleanToVisibilityConverter    BooleanToVisibilityConverterQ   KWuH.ServiceTool.Core.Presentation.Converters.BooleanToNoVisibilityConverter " BooleanToNoVisibilityConverterF   @WuH.ServiceTool.Core.Presentation.Converters.InvertBoolConverter  InvertBoolConverterV   PWuH.ServiceTool.Core.Presentation.Converters.MultiOrBooleanToVisibilityConverter ' #MultiOrBooleanToVisibilityConverterX   RWuH.ServiceTool.Core.Presentation.Converters.MultiOrBooleanToNoVisibilityConverter ) %MultiOrBooleanToNoVisibilityConverterT   NWuH.ServiceTool.Core.Presentation.Converters.MultiBooleanToVisibilityConverter % !MultiBooleanToVisibilityConverter �� 
TargetType  CloseTabButton �� Property �� Value � RowDefinitions �� Padding �� Orientation)  #MaterialDesignThemes.Wpf.DialogHost   CloseDialogCommand �� 
TargetType	 �� RelativeSource
 �� AncestorType �� Path �� 	Converter  WuHPalette800Brush'  !MaterialDesignThemes.Wpf.PackIcon�	  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=null]] 	  Kind  UserMenuIconForegroundBrush 	 myStyle��%'
  &	        &	      &	 &     &	 9     &	 L     &	 _     &	 r     7   7  7  7  &		 #      5   
   62     5   
   64     5   
   6)     5   
   69     5   
   6;     5   
   67   �� 5�   
   " ��6   .�5�      ��  � �� 5�      � 5�      $��10q�6   $	��300��5�      $	��150��5�       5�      �� 5�      $��30 �6,   �� 5�      $��70 �6,   �� 5�      $��50 �6,   .+�5�      �� $��0��6$   $ 5q�5�   $   $��RemoveProductTab��5�   $   $��16(�5�   $   $
��Bold"�5�   $   �� 5�      $��1��6%   .+�5�      �� $
��Wrap=�6(   $ 5q�5�   (   �� 5�   "   $�RemoveProductTabPrompt}��6&    �� 5�   "   $�ProductName��6&    �� 5�   "   $� RemoveProductTabPrompt2��6&   5�      5�      �� 5�      $��2��6%   $ 
Horizontal=�5�   %   $��Right=�5�   %   .+�5�      �� 
�������
���   �$��5q�5�   %   $��Cancel��5�   %   #��Z 5�   %   �� 5�      $��5q�6%   $��OkayButtonText��5�   %   ��5�   %   �� *RemoveSelectedTabCommand+5�      5      5     �� 5      � �� 5     �� 5     " ��6&   .R�5     �� .+�5     � $��0q�5  #   $��14��5	  #   $��14��5
  #   $��Center=�5  #   $��Center=�5  #   y�5  #   �� 	 �� *FindAncestor+"
 ��$ IsMouseOver�8   .+�5  "   A� 8�� $��0 0 0 0q�5  *     5  "   $��12��6:   $��12��5  :   $ Close=�5  :   $��Center=�5  :   $��Center=�5  :   
�������5  :   5     � 5     $��0q�5  #   $��14��5  #   $��14��5  #   $��Center=�5  #   $��Center=�5  #   y�5  #   �� 	 �� *FindAncestor+"
 ��$ IsMouseOver�8  .+�5  "   A� 
������ 6*     5  "   $��12��6:   $��12��5  :   $ Close=�5  :   $��Center=�5   :   $��Center=�5!  :   8�� 5"  :   5#     5$     5%     5'     5(     �� 5*  
   "  6    .�5+     ��  � ��$ Center=�64   �� 5,      � ��$ Center=�62   �� 5-      � �� 5.     �� 5/     "  6&   .R�50     �� .+�51     � $��0q�52  '   $��16��53  '   $��16��54  '   $��Center=�55  '   $��Center=�56  '   .+�57  "   A� $��0 0 0 0q�58  .   ��57  *   �� 	 �� *TemplatedParent+$ 
Background�58  .     59  "   $��12��6:   $��12��5:  >   $��Center=�5=  >   $��Center=�5>  >    5;  >   �� 	 �� *TemplatedParent+$
 Kind���5<  >   �� 	 �� *TemplatedParent+$ 
Foreground�5>  >   5?     5@     5A     5C     5E     5G     .��5H     � .+�5I  
   �� .@�5�     �� $��header��6   .��5�     �� .u�5�     )
   #PopupInTabControl.DeviceContentView
  5�     5�     �� 5�     $��header1��6   .��5�     �� .u�5�     
  5�     5�     �� 5�     $��header2��6   .��5�     �� .u�5�     
  5�     5�     �� 5�     $��header3��6   .��5�     �� .u�5�     
  5�     5�     5�     5�     5�     