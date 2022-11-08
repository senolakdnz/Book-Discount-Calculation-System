namespace kitap_indirimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int books;
            double sum;

            books = Convert.ToInt16(textBox1.Text);

            if (books <= 5)
            {
                sum = books * 5;
                label3.Text = sum + " $";
            }
            if (books >= 6 && books <= 10)
            {
                sum = (books * 5) - (books * 5 * 0.10);
                label3.Text = sum + " $";
            }
            if (books >= 11 && books <= 30)
            {
                sum = (books * 5) - (books * 5 * 0.25);
                label3.Text = sum + " $";
            }
            if (books >=31)
            {
                sum = (books * 5) - (books * 5 * 0.40);
                label3.Text = sum + " $";
            }

        }
    }
}