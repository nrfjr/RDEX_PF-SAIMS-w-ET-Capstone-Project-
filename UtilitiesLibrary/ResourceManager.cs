using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UtilitiesLibrary
{
    public class ResourceManager
    {
        public string ExcelFileOpener(string filter, string file)
        {
            var p = new OpenFileDialog();
            p.Filter = filter;
            p.Title = "Select Excel File";
            if (p.ShowDialog() == DialogResult.OK)
            {
                file = p.FileName;
                return file;
            }
            else
            {
                return null;
            }
        }
        public void ImageFileOpener(string filter, Label label, PictureBox pictureBox)
        {
            try
            {
                var p = new OpenFileDialog();
                p.Filter = filter;
                p.Title = "Select Image File";

                if (p.ShowDialog() == DialogResult.OK)
                {
                    label.Text = p.FileName;
                    pictureBox.Image = Image.FromStream(new FileStream(p.FileName, FileMode.Open));
                    pictureBox.ImageLocation = p.FileName;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    p.Dispose();
                }
            }
            catch
            {

            }
        }
        public Image ByteArrayToImage(byte[] byteArrayInput)
        {
            MemoryStream ms = new MemoryStream(byteArrayInput);
            Image result = Image.FromStream(ms);
            return result;
        }
        public string getUniqueFilename(string fullpath)
        {
            if (!Path.IsPathRooted(fullpath))
                fullpath = Path.GetFullPath(fullpath);
            if (File.Exists(fullpath))
            {
                string filename = Path.GetFileName(fullpath);
                string path = fullpath.Substring(0, fullpath.Length - filename.Length);
                string filenameWOExt = Path.GetFileNameWithoutExtension(fullpath);
                string ext = Path.GetExtension(fullpath);
                int version = 1;
                do
                {
                    fullpath = Path.Combine(path, string.Format("{0} ({1}){2}", filenameWOExt, (version++), ext));
                }
                while (File.Exists(fullpath));
            }
            return fullpath;
        }

        public string SQLFileFinder()
        {
            var p = new OpenFileDialog();
            p.Filter = "SQL Dumpfile | *.sql";
            p.Title = "Select SQL File";

            if (p.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(p.FileName))
            {
                return p.FileName;
            }
            else
            {
                p.Dispose();
                return null;
            }
        }
        public string FolderPathFinder()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrEmpty(fbd.SelectedPath))
                {
                    return fbd.SelectedPath.ToString().Insert(fbd.SelectedPath.Length, @"\");
                }
                else
                {
                    fbd.Dispose();
                    MessageBox.Show("No filepath has been selected", "Folder Path", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return null;
                }
            }
        }
    }
}
