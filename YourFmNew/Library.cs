﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourFmNew
{
    public partial class Library : UserControl
    {
        Main super=null;
        public Library(Main s)
        {
            InitializeComponent();
            this.super = s;
        }

        private void loadShows()
        {
            panel1.Controls.Clear();
            int pictureSize = 200;

            for (int x = 1; x <= 15; x++)
            {
                PictureBox pb = new PictureBox();
                pb.Width = (int)pictureSize;
                pb.Height = (int)pictureSize;

                double left = (x * 20) + ((x - 1) * pictureSize);
                int top = 0;

                pb.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                pb.Location = new Point((int)left, top);
                pb.BackColor = Color.AliceBlue;
                panel1.Controls.Add(pb);
            }
        }

        private void loadStations()
        {
            panel2.Controls.Clear();
            int pictureSize = 200;

            for (int x = 1; x <= 15; x++)
            {
                PictureBox pb = new PictureBox();
                pb.Width = (int)pictureSize;
                pb.Height = (int)pictureSize;

                double left = (x * 20) + ((x - 1) * pictureSize);
                int top = 0;

                pb.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                pb.Location = new Point((int)left, top);
                pb.BackColor = Color.AliceBlue;
                panel2.Controls.Add(pb);
            }
        }

        private void loadPlaylists()
        {
            panel3.Controls.Clear();
            int pictureSize = 200;

            for (int x = 1; x <= 15; x++)
            {
                PictureBox pb = new PictureBox();
                pb.Width = (int)pictureSize;
                pb.Height = (int)pictureSize;

                double left = (x * 20) + ((x - 1) * pictureSize);
                int top = 0;

                pb.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                pb.Location = new Point((int)left, top);
                pb.BackColor = Color.AliceBlue;
                pb.Click += new EventHandler(openPlaylist);
                panel3.Controls.Add(pb);
            }
        }

        private void openPlaylist(Object sender, EventArgs e)
        {
            int id = 0;
            super.openPlaylist(id, true); // TODO: alterar isto para aceitar o id da playlist
        }

        private void Library_Load(object sender, EventArgs e)
        {
            loadShows();
            loadStations();
            loadPlaylists();
        }

        private void darkButton1_Click(object sender, EventArgs e)
        {
            super.openPlaylist_form();
        }
    }
}
