using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace л7_2_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const double Offset = 20;

        public MainWindow()
        {
            InitializeComponent();

            button.MouseEnter += Button_MouseEnter;
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                var mousePosition = e.GetPosition(this);

                button.Margin = new Thickness(
                    mousePosition.X + Offset,
                    mousePosition.Y + Offset,
                    0,
                    0
                );
            }
        }
    }
}