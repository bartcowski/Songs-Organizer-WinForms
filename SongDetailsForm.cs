using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMusic {
    public partial class SongDetailsForm : Form {

        private Song song;
        private List<Song> songs;

        public string title {
            get { return titleTextBox.Text; }
        }

        public string author {
            get { return authorTextBox.Text; }
        }

        public DateTime releaseDate {
            get { return releaseDatePicker.Value; }
        }

        public Genre genre {
            get { return genresControl.Genre; }
        }


        public SongDetailsForm(Song song, List<Song> songs) {
            InitializeComponent();
            this.song = song;
            this.songs = songs;
        }

        private void SongDetailsForm_Load(object sender, EventArgs e) {
            //genresControl.UpdateGenreImageEvent += genresControl.genresControl_ChangeGenreImageEvent;

            if (song != null) {
                titleTextBox.Text = song.Title;
                authorTextBox.Text = song.Author;
                releaseDatePicker.Value = song.ReleaseDate;

            } else {
                releaseDatePicker.Value = new DateTime(2000, 1, 1);
            }
        }

        private void okButton_Click(object sender, EventArgs e) {
            if (ValidateChildren())
                DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void titleTextBox_Validating(object sender, CancelEventArgs e) {
            try {
                if (titleTextBox.TextLength == 0)
                    throw new Exception("You must provide a title");
            } catch (Exception exception) {
                e.Cancel = true;
                errorProvider.SetError(titleTextBox, exception.Message);
            }
        }

        private void authorTextBox_Validating(object sender, CancelEventArgs e) {
            try {
                if (authorTextBox.TextLength == 0)
                    throw new Exception("You must provide an author");
            } catch (Exception exception) {
                e.Cancel = true;
                errorProvider.SetError(authorTextBox, exception.Message);
            }
        }

        private void releaseDatePicker_Validating(object sender, CancelEventArgs e) {
            try {
                if (releaseDatePicker.Value.Date > DateTime.Now.Date)
                    throw new Exception("You cannot add songs from the future (unless you're a time traveller)");
            } catch (Exception exception) {
                e.Cancel = true;
                errorProvider.SetError(releaseDatePicker, exception.Message);
            }
        }

        private void titleTextBox_Validated(object sender, EventArgs e) {
            errorProvider.SetError(titleTextBox, "");
        }

        private void authorTextBox_Validated(object sender, EventArgs e) {
            errorProvider.SetError(authorTextBox, "");
        }

        private void releaseDatePicker_Validated(object sender, EventArgs e) {
            errorProvider.SetError(releaseDatePicker, "");
        }
    }
}
