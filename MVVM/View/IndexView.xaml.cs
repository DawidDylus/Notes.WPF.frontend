using ApiLibrary;
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

namespace Notes.WPF.frontend.MVVM.View
{
    /// <summary>
    /// Interaction logic for IndexView.xaml
    /// </summary>
    public partial class IndexView : UserControl
    {

        public IndexView()
        {
            InitializeComponent();
        }

        private async Task GetNotes()
        {
            var notes = await NotesProcessor.LoadNotes();

        }

        private async void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
          await GetNotes();
        }
    }
}
