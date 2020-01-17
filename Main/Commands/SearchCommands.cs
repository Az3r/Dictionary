using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
namespace Main.Commands
{
    public class SearchCommands
    {
        private static readonly InputGesture SearchGesture = new KeyGesture(Key.Enter);
        public static RoutedUICommand Search { get; private set; } = new RoutedUICommand(
                "Search", "search",
                typeof(SearchCommands),
                new InputGestureCollection { SearchGesture }
            );
    }
}
