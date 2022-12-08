
using ArchApp.Models;

namespace ArchApp
{
    public partial class Form1 : Form
    {
        public ArchDbContext Context { get; }

        public Form1()
        {
            Context = new ArchDbContext();
            InitializeComponent();
        }

        private void BtnViewFile_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();

            txtFilePath.Text = ofd.FileName;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFile();

            MessageBox.Show("Êã ÇáÍÝÙ ÈäÌÇÍ");
        }

        private void SaveFile()
        {
            if (ofd == null && string.IsNullOrWhiteSpace(ofd?.FileName)) return;
            var store = new Store()
            {
                TheFileName = Path.GetFileNameWithoutExtension(ofd.FileName),
                FileEx = Path.GetExtension(ofd.FileName),
                FileData = FileService.DatabaseFileInsert(ofd.FileName)
            };

            Context.Stores.Add(store);
            Context.SaveChanges();
        }

        private void BtnGetFile_Click(object sender, EventArgs e)
        {
            var data = Context.Stores.FirstOrDefault(x => x.Id == 2);

            if (data == null) return;

            var fullName = string.Concat(data?.TheFileName, data?.FileEx);

            var name = FileService.DatabaseFileRead(fullName , data?.FileData);

            GetTempFile(name);
        }

        private static void GetTempFile(string filename)
        {
            if (File.Exists(filename))
                File.Delete(filename);
        }
    }
}