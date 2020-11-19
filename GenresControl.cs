using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMusic {
    public partial class GenresControl : UserControl {

        [BrowsableAttribute(true)]
        [Category("Image")]
        public Genre Genre {
            get { return genreState; }
            set { genreState = value; 
                  setImageForGenreState(); 
                  Invalidate(); }
        }
        private Genre genreState;

        public event Action<Genre> UpdateGenreImageEvent;

        public GenresControl() {
            InitializeComponent();
            setImageForGenreState();
        }

        public void changeGenreImage() {
            setImageForGenreState();
            UpdateGenreImageEvent?.Invoke(Genre);
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            genreState = (Genre)(((int)genreState + 1) % 3);
            changeGenreImage();
        }

        private void setImageForGenreState() {
            switch (genreState) {
                case Genre.ROCK:
                    pictureBox1.Image = global::WindowsFormsMusic.Properties.Resources.rock;
                    break;
                case Genre.POP:
                    pictureBox1.Image = global::WindowsFormsMusic.Properties.Resources.pop;
                    break;
                case Genre.HIPHOP:
                    pictureBox1.Image = global::WindowsFormsMusic.Properties.Resources.hiphop;
                    break;
            }
        }
    }
}
