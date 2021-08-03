using System.IO;
using System.Windows;

namespace AttendanceAppUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void TextBox_PreviewDragOver(object sender, DragEventArgs e)
        {
            e.Effects = DragDropEffects.Copy;
            e.Handled = true;
        }

        private void TextBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effects = DragDropEffects.Copy;
            e.Handled = true;
        }

        private void TextBox_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string final = "Name | Email | Total Duration | Is Guest\n\n";
                string[] fileLocationsArray = (string[])e.Data.GetData(DataFormats.FileDrop);

                string filename = System.IO.Path.GetFileName(fileLocationsArray[0]);
                string[] lines = File.ReadAllLines(fileLocationsArray[0]);

                for (int i = 1; i < lines.Length; i++)
                {
                    final += $"{lines[i]}\n";
                }

                DataContext = $"{filename}\n\n{final}";
            }

        }

    }
}
