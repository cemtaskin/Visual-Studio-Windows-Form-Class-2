using ListOfItems.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListOfItems
{
    public partial class frmStudenExamResults : Form
    {
        public Student Student { 
            get {
                Student student = new Student();
                student.Number = txtNumber.Text;
                student.NameSurname = txtNameSurname.Text;
                try
                {
                    student.MidTerm = Convert.ToDouble(txtMidTerm.Text);
                }
                catch { }
                try
                {
                    student.Final = Convert.ToDouble(txtFinal.Text);
                }
                catch { }
                return student;
            } 
            
            set {
                txtNumber.Text = value.Number;
                txtNameSurname.Text = value.NameSurname;
                txtMidTerm.Text = value.MidTerm.ToString();
                txtFinal.Text = value.Final.ToString();
            } 
        
        }
        public List<Student> Students{ get; set; }
        public frmStudenExamResults()
        {
            InitializeComponent();
            Students = Student.readData();
            loadItems();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Students.Add(Student);
            loadItems();
            Student = new Student();
            txtNumber.Focus();
        }

        private void loadItems()
        {
            grdList.Rows.Clear ();
            int orderNumber = 1; 
            foreach(Student student in Students)
            {
                grdList.Rows.Add(new object[] { orderNumber,student.Number,student.NameSurname,student.MidTerm,student.Final,student.ExamResult,student.State});
                orderNumber++;
            }
            Student.saveData(Students);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (grdList.CurrentRow == null) return;
            Students.RemoveAt(grdList.CurrentRow.Index);
            loadItems();
        }
    }
}
