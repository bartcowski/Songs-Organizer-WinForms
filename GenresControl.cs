using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Design;
using System.Windows.Forms.Design;

namespace WindowsFormsMusic {
    public partial class GenresControl : UserControl {

        [Editor(typeof(GenresControlEditor), 
         typeof(System.Drawing.Design.UITypeEditor))]
        [Browsable(true)]
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

    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    public class GenresControlEditor : System.Drawing.Design.UITypeEditor {

        public GenresControlEditor() {
        }

        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) {
            return UITypeEditorEditStyle.DropDown;
        }

        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) {
            IWindowsFormsEditorService edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
            if (edSvc != null) {
                GenresControl genresControl = new GenresControl();
                edSvc.DropDownControl(genresControl);

                return genresControl.Genre;
            }
            return value;
        }

        //public override void PaintValue(System.Drawing.Design.PaintValueEventArgs e) {
        //    // TODO
        //}

        //public override bool GetPaintValueSupported(System.ComponentModel.ITypeDescriptorContext context) {
        //    return true;
        //}

    }
}
