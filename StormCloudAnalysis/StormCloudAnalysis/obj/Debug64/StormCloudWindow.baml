   M S B A M L   `   `   `  ���� E  AStormCloud, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:StormCloud
StormCloud  Z VHelixToolkit.Wpf, Version=2014.2.1.1, Culture=neutral, PublicKeyToken=52aa3500039caf0dM8clr-namespace:HelixToolkit.Wpf;assembly=HelixToolkit.WpfHelixToolkit.Wpf !    StormCloud.StormCloudWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     )convclr-namespace:StormCloud     QHelixToolkit8clr-namespace:HelixToolkit.Wpf;assembly=HelixToolkit.Wpf     -     �Name$  SCWindow�� � Title$ 
StormCloud��$
��1080��$
��1920�� � SizeToContent$ WidthAndHeight=� � 	Resources    RowLabel �� 
TargetType �� Property �� Value  BoolVisConverter��%  &	        '�� �     &	 �     �� " ��.���  � ��$ 40(���  � ��$
 Bold"���  � ��$ 	Tw Cen MT)���  � ��$ Center=���  � ��$ Center=���  �@��TextAlignment$ Center=��� " ��.���  �@��BitmapScalingMode$ HighQuality=��� .��� .+��� $;��5R. Danhaive, C. Mueller, MIT Digital Structures, 2015��$��Right=�$��Bottom=�$��32,15q�#��[  $��12(�$��Light"��� $��1,1,1,1q�
���   �$��30q� �� CornerRadius$ 3��._�� $��5q� � ColumnDefinitions �� $	��450 ��� $	��100 ��� $��* �	 � RowDefinitions	 �� $��* ��� $��80 ��� $��80 �.+��� $
��Left=�$��
stormcloud��#��[  $��Italic$�
 �� TextAlignment$

 Left=�$	��Top=�$
��10,5q����	#7F0082A5�� $��2��$��0,0,0,1q�
���   �$��0q�._�&   HelixToolkit.Wpf.HelixViewport3D  -   $��CurrentModel��$��0q�   ZoomExtentsWhenLoaded . $
��Auto��   ShowCameraInfo .  $	��756��   Children. $  HelixToolkit.Wpf.DefaultLights  g�  g� Content �� *CurrentModel+   Camera =�  � Position �� *Pos+ �� Mode$ OneWayToSource=� �� NotifyOnTargetUpdated .  � LookDirection �� *	LookDir+$ OneWayToSource=� .  � UpDirection �� *UpDir+$ OneWayToSource=� .  =� FieldOfView �� *	FieldView+$ OneWayToSource=� . �� $��2��$��Bottom=�$��Center=�#��[  $��25(����� *CurrentNormalizedScore+ �� StringFormat$ {0:0.00}��� $��1��$��2��	 �� $��* ��� $��* ��� $��* �.+��� $��0��$0��*automatically compute multiple generations��$��Center=�$	��112��$
��Wrap=�$
 Right=�$��	0,16,0,16q�#��[  $��11(�$
��Left=��� -   $��autoGenerateCheck��$��0��$��Center=�$��122,18,312,18q�$��16��$
��Left=��� -   $��autogenSlider��$��0��$��150,15,45,15q� � Minimum$ 2Q� � Maximum$ 10Q� �� TickFrequency$ 1Q� �� IsSnapToTickEnabled . {���  �� ElementName$ autoGenerateCheck�� �� Path$ 	IsChecked��� $��0��$��Center=�#��[  $��18(�$��Right=�$��40��$

 Left=�$��	0,18,0,15q����� $ autogenSlider��$ Value�y��� $ autoGenerateCheck��$ 	IsChecked� �� 	Converter# [ �� -   $	��Pop��$��1�� � Value$ 10Q�$��Center=�$��Stretch=�$��Center=�$ 5Q�$	 100Q�$��150,18,45,0q����	#FF764D4D$��0q�$��18��$	��Top=�$ 1Q� . ��Z� ��Z� �� $��1��$��generation size��$
��0,16q�#��[  $��20(�$��Center=�$
��Left=�$	��138��$
 Right=��� $��1��$��Center=�#��[  $��18(�$��Right=�$��40��$

 Left=����� $	 Pop��$ Value��� -   $	��Mut��$��2��$��150,17,45,18q�$	 0.2Q�$��Center=�$��Stretch=�$ 0Q�$ 1Q�$
 0.01Q� . �� $��2��$��mutation rate��$��	0,15,0,16q�#��[  $��20(�$��Center=�$
��Left=�$	��138��$
 Right=��� $��2��$��Center=�#��[  $��18(�$��Right=�$

 Left=�$��40������ $	 Mut��$ Value��� $��2��$��0��$��3��$��1q�
���   �$��3q�$ 2��._��� -   $��myScroll��$��Visible=�$��Visible=�.��� -   $��
DesignGrid�� � ShowGridLines .  $��5q� �� �� �� �� �� �� �� �� �� �� �� -	   $��1��$��1��$��11q�$��16(�  � ToolTip$'  !Click to generate next generation��! ^� InitialShowDelay$! 2��$��0q���Z� ��Z� ��Z� .���� $��Center=�$��Center=�.+��� $��Resources/gen_icon.png��$��4q�$��Center=�$��Center=��� -
   $��1��$��2��$��
11,0,11,11q�$��16(�$W  QLeft-click to build design in Rhino, right-click to save exploration in .csv file��$! 2��$��0q�$��58��$��Bottom=���Z� ��Z� ��Z� .���� $��Center=�$��Center=�.+��� $��Resources/wrench.png��$��4q�$��Center=�$��Center=�