using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace ControlKeys.Components
{
    /// <summary>
    /// Interação lógica para PersonButtonItem.xam
    /// </summary>
    public partial class PersonButton : UserControl
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }

        public PersonButton()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public event RoutedEventHandler Click
        {
            add { B1.AddHandler(ButtonBase.ClickEvent, value); }
            remove { B1.RemoveHandler(ButtonBase.ClickEvent, value); }
        }
    }
}
