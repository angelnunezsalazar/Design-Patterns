namespace MVP
{
    using System.Windows.Forms;

    public class OpenFileDialogWrapper : IOpenFileDialog
    {
        private readonly OpenFileDialog dialog;

        public OpenFileDialogWrapper()
        {
            this.dialog = new OpenFileDialog();
        }

        public string Filter
        {
            get { return this.dialog.Filter; }
            set { this.dialog.Filter = value; }
        }

        public string FileName
        {
            get { return this.dialog.FileName; }
        }

        public DialogResult ShowDialog()
        {
            return this.dialog.ShowDialog();
        }
    }
}