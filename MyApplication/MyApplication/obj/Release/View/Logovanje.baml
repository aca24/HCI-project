   M S B A M L   `   `   `  ���� H  DMyApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:MyApplication.ValidationMyApplication.Validation  7 clr-namespace:MyApplication.HelpMyApplication.Help  "    MyApplication.View.Logovanje   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6val&clr-namespace:MyApplication.Validation     .l clr-namespace:MyApplication.Help       � Title$  	Logovanje��$	��270��$	��385�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�%   MyApplication.Help.HelpProvider   HelpKey$ 	Logovanje������  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FFC2C2C2�� � Offset$ 1Q�� $ 	#FFF1F2F6�� J� CommandBindings )  #System.Windows.Input.CommandBinding  -   	   Command$	 ApplicationCommands.Help��.��� 
 � RowDefinitions
 �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto � � ColumnDefinitions �� $
��Auto ��� .+��� $��0��$��2�� 	  title#��[  Prijavljivanje�� $��1��$��2��$	��320��$��3���� $��2��$��1��$��0,5,0,0q�$��Segoe UI Semibold)�*(Unesite Vaše korisničko ime i lozinku:�� $T��NE:\HCI\Predmetni Projekat HCI\MyApplication\MyApplication\Resources\clinic.png��$��3��$��5��$��0��$	��100��$��	20,0,30,0q��� $��3��$��1��$��Bottom=�Korisničko ime:�� -   $��txtKorisnickoIme��$��4��$��1��$	��200��$��Center=�$
��Left=� 	 field#��[ $ Logovanje#korIme��.������  �� Path$ Username� �� UpdateSourceTrigger$ PropertyChanged=� �� ValidationRules 2   ,MyApplication.Validation.LogovanjeValidacija  ,  &System.Windows.Controls.ValidationRule   ValidationStep$ CommittedValue=�.�� � ToolTip �� $
��Wrap=�$	��150��NLU ovo polje unesite Vaše korisničko ime. Ovo polje ne može ostati prazno..�� =� ErrorTemplate �� .R�� 
 �� $
��Auto ���  �� .+��� $��0��$��0���� $��1��$��0��  
validation#��[ ���� *[0].ErrorContent+.���� $��6��$��1��$	��Top=�
Lozinka:�� -   $��txtPassword��$��6��$��1��$	��200��$��	0,20,0,22q�$��Center=�$
��Left=�#��[ $0��*pack://application:,,,/Resources/#password)�$��14(�$ Logovanje#lozinka��$��2��.������ $ Password�$ PropertyChanged=� 0   *MyApplication.Validation.LozinkaValidacija  $ CommittedValue=�.�� �� $
��Wrap=�$	��150��FDU ovo polje unesite Vašu lozinku. Ovo polje ne može ostati prazno..�� �� .R�� 
 �� $
��Auto ���  �� .+��� $��0��$��0���� $��1��$��0��#��[ ���� *[0].ErrorContent+.���� $��9��$��0��$��0,10,0,0q�$��Center=�$��Center=�$��Segoe UI Semibold)� � Cursor$
 Hand��$��14(��� -    �Name$ 
RegistujSe��.�Registrujte se � ToolTip �� $
��Wrap=�$	��150��Klik na link �� .�Registruj se~| odvešće Vas na prozor za registrovanje. Ako niste registrovani, ne možete se prijaviti za rad u programu i pokrenuti ga..��� $��9��$��1�� �� Orientation$ 
Horizontal=�$��Right=�.+��� -   $��Potvrdi��$��	0,10,10,0q� �� 	IsDefault .   buttons#��[ .��
Prijavi se �� $
��Wrap=�$	��150��Klikom na dugme �� .�
Prijavi se%# prijavićete se za rad u programu.�� -   $��Napusti��$��	0,10,20,0q�#��[ .��
Odustani �� $
��Wrap=�$	��150��Klikom na dugme �� .�
Odustani:8 odustaćete od prijave i prekinuti pokretanje programa.