using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiLibrary;

namespace Notes.WPF.frontend.MVVM.ModelView
{
    class IndexViewModel
    {

        public BindableCollection<NotesModel> Notes { get; set; }

        private async void LoadNotesToViewModel()
        {
            var notes = await NotesProcessor.LoadNotes();
        }


        public IndexViewModel()
        {
            LoadNotesToViewModel();
        }


    }
}
