using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FrmRegistration.StudentInfoClass;

namespace FrmRegistration
{
    public partial class FrmConfirm : Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        public FrmConfirm()
        {
            InitializeComponent();
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            address.Text = DelAddress(StudentInfoClass.Address);
            firstName.Text = DelFirstName(StudentInfoClass.FirstName);
            middleName.Text = DelMiddleName(StudentInfoClass.MiddleName);
            lastName.Text = DelLastName(StudentInfoClass.LastName);
            program.Text = DelProgram(StudentInfoClass.Program);

            age.Text = DelNumAge(StudentInfoClass.Age);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
