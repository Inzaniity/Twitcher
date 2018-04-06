using MahApps.Metro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Twitcher_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private string[] colors = new string[] { "Red", "Green", "Blue", "Purple", "Orange", "Lime", "Emerald", "Teal", "Cyan", "Cobalt", "Indigo", "Violet", "Pink", "Magenta", "Crimson", "Amber", "Yellow", "Brown", "Olive", "Steel", "Mauve", "Taupe", "Sienna" };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            applyTheme();

            foreach (string s in colors)
            {
                colorComboBox.Items.Add(s);
            }

            foreach (string s in colorComboBox.Items)
            {
                Console.WriteLine(s);
                if (s == Properties.Settings.Default.color)
                {
                    colorComboBox.SelectedItem = s;
                }
            }

            if (Properties.Settings.Default.theme == "BaseDark") { themeToggleSwitch.IsChecked = true; } else { themeToggleSwitch.IsChecked = false; }
        }

        private void applyTheme()
        {
            Tuple<AppTheme, Accent> appStyle = ThemeManager.DetectAppStyle(Application.Current);
            ThemeManager.ChangeAppStyle(Application.Current, ThemeManager.GetAccent(Properties.Settings.Default.color), ThemeManager.GetAppTheme(Properties.Settings.Default.theme));
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Properties.Settings.Default.color = colorComboBox.SelectedValue.ToString();
            Properties.Settings.Default.Save();
            applyTheme();
        }

        private void themeToggleSwitch_IsCheckedChanged(object sender, EventArgs e)
        {
            if (themeToggleSwitch.IsChecked == true)
            {
                Properties.Settings.Default.theme = "BaseDark";
            }
            else
            {
                Properties.Settings.Default.theme = "BaseLight";
            }
            Properties.Settings.Default.Save();
            applyTheme();
        }
    }
}