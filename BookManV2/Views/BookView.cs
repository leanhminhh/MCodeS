using BookManV2.ViewModels;

namespace BookManV2
{
    public partial class BookView : Form
    {
        BindingSource bs = new();
        BookViewModel vm = new();
        public BookView()
        {
            InitializeComponent();

            bs.DataSource = vm.Books;
            dataGridView1.DataSource = bs;

            textBoxTitle.DataBindings.Add("Text", bs, "Title");
            textBoxAuthor.DataBindings.Add("Text", bs, "Author");
            textBoxPublisher.DataBindings.Add("Text", bs, "Publisher");
            textBoxISBN.DataBindings.Add("Text", bs, "ISBN");
            numericUpDownPages.DataBindings.Add("Value", bs, "Pages");
            numericUpDownYear.DataBindings.Add("Value", bs, "Year");

            // toolStripButtonTest.Click += delegate { vm.TestMethod(); };
           toolStripButtonTest.Command = vm.AddCommand;
            dataGridView1.SelectionChanged += delegate
            {
                vm.Current = dataGridView1.CurrentRow.DataBoundItem as Models.Book;
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonTest_Click_Click(object sender, EventArgs e)
        {

        }
    }
}
