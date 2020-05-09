using System.Windows.Input;

namespace MyApplication.Controller
{
    public static class RoutedCommands
    {
        public static readonly RoutedUICommand OdjaviSe = new RoutedUICommand(
            "Odjavi se",
            "OdjaviSe",
            typeof(RoutedCommands),
            new InputGestureCollection()
            {
                new KeyGesture(Key.Q, ModifierKeys.Control),
            }
            );

        public static readonly RoutedUICommand KreirajGuest = new RoutedUICommand(
            "Kreiraj guest",
            "KreirajGuest",
            typeof(RoutedCommands),
            new InputGestureCollection()
            {
                new KeyGesture(Key.U, ModifierKeys.Control),
            }
            );

    }
}
