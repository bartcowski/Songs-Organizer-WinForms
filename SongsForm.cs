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
    public partial class SongsForm : Form {

        private SongsRepository songsRepo;
        private string currentFilter;

        public SongsForm(SongsRepository songsRepo) {
            InitializeComponent();
            this.songsRepo = songsRepo;
            filterComboBox.Items.AddRange(new string[] { "All", "In or After year 2000", "Before year 2000" });
            filterComboBox.SelectedIndex = 0;
            currentFilter = filterComboBox.Text;
            updateItems();
        }

        private void SongsForm_Load(object sender, EventArgs e) {
            updateItems();
            songsRepo.AddSongEvent += songsRepo_AddSongEvent;
            songsRepo.EditSongEvent += songsRepo_EditSongEvent;
            songsRepo.DeleteSongEvent += songsRepo_DeleteSongEvent;
        }

        private void songsRepo_AddSongEvent(Song song) {
            if (isIncludedByFilter(song)) {
                ListViewItem item = new ListViewItem();
                item.Tag = song;
                updateItem(item);
                songsListView.Items.Add(item);
            }
        }

        private void songsRepo_EditSongEvent(Song song) {
            foreach (ListViewItem item in songsListView.Items) {
                if (item.Tag == song) {
                    if (isIncludedByFilter(song)) { 
                        updateItem(item);
                    } else {
                        songsListView.Items.Remove(item);
                        updateItemsCounter();
                    }
                    break;
                }
            }
            songsRepo_AddSongEvent(song);
            updateItemsCounter();
        }

        private void songsRepo_DeleteSongEvent(Song song) {
            foreach (ListViewItem item in songsListView.Items) {
                if (item.Tag == song) {
                    songsListView.Items.Remove(item);
                    updateItemsCounter();
                    break;
                }
            }
        }

        private void addStripButton_Click(object sender, EventArgs e) {
            SongDetailsForm songDetailsForm = new SongDetailsForm(null, songsRepo.getSongs());
            
            if (songDetailsForm.ShowDialog() == DialogResult.OK) {
                Song newSong = new Song(songDetailsForm.title, 
                                        songDetailsForm.author, 
                                        songDetailsForm.releaseDate, 
                                        songDetailsForm.genre);

                songsRepo.addSong(newSong);
           }
        }

        private void editStripButton_Click(object sender, EventArgs e) {
            if (songsListView.SelectedItems.Count == 1) {
                Song song = (Song)songsListView.SelectedItems[0].Tag;
                SongDetailsForm songDetailsForm = new SongDetailsForm(song, songsRepo.getSongs());
                
                if (songDetailsForm.ShowDialog() == DialogResult.OK) {
                    song.Title = songDetailsForm.title;
                    song.Author = songDetailsForm.author;
                    song.ReleaseDate = songDetailsForm.releaseDate;
                    song.Genre = songDetailsForm.genre;

                    songsRepo.editSong(song);
                }
            }
        }

        private void deleteStripButton_Click(object sender, EventArgs e) {
            if (songsListView.SelectedItems.Count == 1) {
                Song song = (Song)songsListView.SelectedItems[0].Tag;
                songsRepo.deleteSong(song);
            }
        }

        private void updateItem(ListViewItem item) {
            Song song = (Song)item.Tag;

            while (item.SubItems.Count < 4)
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
            item.SubItems[0].Text = song.Title;
            item.SubItems[1].Text = song.Author;
            item.SubItems[2].Text = song.ReleaseDate.ToShortDateString();
            item.SubItems[3].Text = song.Genre.ToString();
        }

        private void updateItems() {
            songsListView.Items.Clear();

            foreach (Song song in songsRepo.getSongs()) {
                if (isIncludedByFilter(song)) {
                    ListViewItem item = new ListViewItem();
                    item.Tag = song;
                    updateItem(item);
                    songsListView.Items.Add(item);
                }
            }
            updateItemsCounter();
        }

        private void SongsForm_Activated(object sender, EventArgs e) {
            ToolStripManager.Merge(toolStrip1, ((MainForm)MdiParent).toolStrip1);
            ToolStripManager.Merge(itemsCounterToolStrip, ((MainForm)MdiParent).itemsCounterToolStrip);
            updateItemsCounter();
        }

        private void SongsForm_Deactivate(object sender, EventArgs e) {
            ToolStripManager.RevertMerge(((MainForm)MdiParent).toolStrip1, toolStrip1);
            ToolStripManager.RevertMerge(((MainForm)MdiParent).itemsCounterToolStrip, itemsCounterToolStrip);
        }

        private void SongsForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (MdiParent.MdiChildren.Length == 1) {
                e.Cancel = true;
            }
        }

        private void updateItemsCounter() {
            itemsCounterToolStripLabel.Text = "Current window songs count: " + songsListView.Items.Count.ToString();
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            currentFilter = filterComboBox.Text;
            updateItems();
        }

        private bool isIncludedByFilter(Song song) {
            if (currentFilter == "In or After year 2000") {
                return song.ReleaseDate.Year >= 2000;
            } else if (currentFilter == "Before year 2000") {
                return song.ReleaseDate.Year < 2000;
            } else { //if (currentFilter == "All")
                return true;
            }
        }
    }
}
