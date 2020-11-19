using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMusic
{
    public partial class MainForm : Form {

        SongsRepository songsRepo = new SongsRepository();

        public MainForm() {
            InitializeComponent();
            IsMdiContainer = true;

            // One window/form is always opened
            SongsForm songsForm = new SongsForm(songsRepo);
            songsForm.MdiParent = this;
            songsForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e) {

        }

        private void newWindowStripButton_Click(object sender, EventArgs e) {
            SongsForm songsForm = new SongsForm(songsRepo);
            songsForm.MdiParent = this;
            songsForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            // necessary for not allowing last interior window to close 
            // but at the same time being able to close the whole app
            e.Cancel = false;
        }
    }
}
