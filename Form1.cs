namespace FrmRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfoClass.FirstName = firstName.Text;
            StudentInfoClass.MiddleName = middleName.Text;
            StudentInfoClass.LastName = lastName.Text;
            StudentInfoClass.Address = address.Text;
            StudentInfoClass.Program = program.Text;
            StudentInfoClass.Age = Convert.ToInt64(age.Text);
            StudentInfoClass.ContactNo = Convert.ToInt64(contactNo.Text);
            StudentInfoClass.StudentNo = Convert.ToInt64(studentNo.Text);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}