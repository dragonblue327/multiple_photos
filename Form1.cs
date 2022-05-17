namespace manipulate_images
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Row(string[] files)
        {

            int x = 0;
            int y = 0;
            int MaxHight = -1;
            foreach (string filename in files)
            {
                PictureBox pb = new PictureBox();
                var photo = Image.FromFile(filename);
                pb.Image = photo;
                pb.Location = new Point(x, y);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                int width = pictureBoxRow.Width / 3;
                int height = pictureBoxRow.Height /3;
                pb.Size = new Size(width,height);
                x += pb.Width + 5;
                MaxHight = Math.Max(pb.Height, MaxHight);
                if (x > this.pictureBoxRow.Width - 50)
                {
                    x = 10;
                    y += MaxHight + 10;

                }

                this.pictureBoxRow.Controls.Add(pb);
            }
        }
        private void Col(string[] files)
        {
            int x = 0;
            int y = 0;
            int MaxHight = -1;
            foreach (string filename in files)
            {
                PictureBox pb = new PictureBox();
                var photo = Image.FromFile(filename);
                pb.Image = photo;
                pb.Location = new Point(x, y);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                int height = pictureBox1.Height;
                int width = (pictureBox1.Width-pictureBoxRow.Width)/2;
                pb.Size = new Size(width, height);
                x += pb.Width + pictureBoxRow.Width;
                MaxHight = Math.Max(pb.Height, MaxHight);
                int secound = pb.Width + pictureBoxRow.Width;

                if (x > this.pictureBox1.Width - 50)
                {
                    x = pictureBoxRow.Width;
                    y += MaxHight + 10;

                }

                this.pictureBox1.Controls.Add(pb);
            }
        }
        private void AddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "JPG|*.jpg|JPEG|*jpeg|GIF|*.gif|PNG|*.png";
            DialogResult result = ofd.ShowDialog();
            string[] files = ofd.FileNames;
            if (result == DialogResult.OK && radioRow.Checked ==true )
            {
              Row(files);
            }
            if (result == DialogResult.OK && radioCol.Checked == true)
            {
              Col(files);
            }

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Controls.Clear();
            this.pictureBoxRow.Controls.Clear();
        }
    }
}