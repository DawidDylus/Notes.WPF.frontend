using Notes.WPF.frontend.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.WPF.frontend.MVVM.ModelView
{
    class MainViewModel : ObservableObject
    {

        public RelayCommand IndexViewCommand { get; set; }
        public RelayCommand AddNoteViewCommand { get; set; }

        public AddNoteViewModel AddNoteVM { get; set; }
        public IndexViewModel IndexVM { get; set; }

        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }



        public MainViewModel()
        {
            IndexVM = new IndexViewModel();
            AddNoteVM = new AddNoteViewModel();

            CurrentView = IndexVM;

            IndexViewCommand = new RelayCommand(o =>
            {
               CurrentView = IndexVM;
            });

            AddNoteViewCommand = new RelayCommand(o =>
            {
                CurrentView = AddNoteVM;
            });

        }

    }
}
