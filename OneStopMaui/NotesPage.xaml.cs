using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace OneStopMaui 
{

    public partial class NotesPage : ContentPage
    {
        // Observable collection to hold notes
        private ObservableCollection <string> notes;

        public NotesPage()
        {
            InitializeComponent();
            notes = new ObservableCollection <string> ();
            NotesListView.ItemsSource = notes; // Bind the ListView to the notes collection
        }

        // Event handler for saving a note
        private void OnSaveNoteClicked(object sender, EventArgs e)
        {
            var noteText = NoteEntry.Text?.Trim(); // Get the text from the Entry

            if (!string.IsNullOrEmpty(noteText))
            {
                notes.Add(noteText); // Add the note to the collection
                NoteEntry.Text = string.Empty; // Clear the Entry
            }
        }

        // Event handler for deleting a note
        private void OnDeleteNoteClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var noteToDelete = button.CommandParameter as string;

            if (noteToDelete != null)
            {
                notes.Remove(noteToDelete); // Remove the note from the collection
            }
        }
    }
}



// namespace OneStopMaui
// {
//     public partial class NotesPage : ContentPage
//     {
//         public NotesPage()
//         {
//             InitializeComponent();
//         }
//     }
// }