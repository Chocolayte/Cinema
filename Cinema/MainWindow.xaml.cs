using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Cinema
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var dialog = new System.Windows.Forms.FolderBrowserDialog();
            System.Windows.Forms.DialogResult result = dialog.ShowDialog();

            if (!Directory.Exists(dialog.SelectedPath))
                return;

            var exts = new[] { "avi", "mkv", "mp4" };
            
            var files = Directory.EnumerateFiles(dialog.SelectedPath, "*.*")
                                 .Where(file => exts.Any(x => file.EndsWith(x, StringComparison.OrdinalIgnoreCase)) && file != "." && file != "..");


        }
    }
}
