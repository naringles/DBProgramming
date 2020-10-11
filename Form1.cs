using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfo
{
    public partial class Form1 : Form
    {
        protected int numberofstudent = 0;
        protected int student1 = 0;
        protected int student2 = 0;
        protected int student3 = 0;
        protected int firstrun = -2;

        public Form1()
        {
            InitializeComponent();
            InitVariables();
        }

        private void InitVariables()
        {
            comboBoxGender2.Items.Clear();
            comboBoxGender2.Items.Add("남자");
            comboBoxGender2.Items.Add("여자");

            string[] genderData = { "남자", "여자" };
            comboBoxGender3.Items.Clear();
            comboBoxGender3.Items.AddRange(genderData);

            comboBoxGender1.SelectedIndex = 0;
            comboBoxGender2.SelectedIndex = 0;
            comboBoxGender3.SelectedIndex = 0;

            FileInfo file = new FileInfo("autoload.dat");
            if(file.Exists) {
        StreamReader sr = new StreamReader(new FileStream("autoload.dat", FileMode.Open));
                int i = Convert.ToInt32(sr.ReadLine());
            
                if (i == 1)
                {
                    LoadStudent();
                    checkBoxAutoLoading.Checked = true;
                }

                sr.Close();
            }
            firstrun = 1;
        }

        private void UpdateNumberofStudent()
        {

           if (textBoxName1.Text == "학생정보 없음")
                student1 = 0;
            else
                student1 = 1;
            if (textBoxName2.Text == "학생정보 없음")
                student2 = 0;
            else
                student2 = 1;
            if (textBoxName3.Text == "학생정보 없음")
                student3 = 0;
            else
                student3 = 1;

            numberofstudent = student1 + student2 + student3;

            labelCorrentStdNum.Text = "현재 저장된 학생 수 : " + numberofstudent;
        }

        private void ButtonLoadInfo_Click(object sender, EventArgs e)
        {
            LoadStudent();
            UpdateNumberofStudent();
        }

        private void SaveStudent()
        {
            StreamWriter sw = new StreamWriter(new FileStream("student.stu", FileMode.Create));

            StreamWriter sw1 = new StreamWriter(new FileStream("studentMemo1.memo", FileMode.Create));
            StreamWriter sw2 = new StreamWriter(new FileStream("studentMemo2.memo", FileMode.Create));
            StreamWriter sw3 = new StreamWriter(new FileStream("studentMemo3.memo", FileMode.Create));

            sw.WriteLine(textBoxName1.Text);
            sw.WriteLine(textBoxNumber1.Text);
            sw.WriteLine(comboBoxGender1.SelectedItem);
            sw1.WriteLine(textBoxMemo1.Text);


            sw.WriteLine(textBoxName2.Text);
            sw.WriteLine(textBoxNumber2.Text);
            sw.WriteLine(comboBoxGender2.SelectedItem);
            sw2.WriteLine(textBoxMemo2.Text);

            sw.WriteLine(textBoxName3.Text);
            sw.WriteLine(textBoxNumber3.Text);
            sw.WriteLine(comboBoxGender3.SelectedItem);
            sw3.WriteLine(textBoxMemo3.Text);

            sw.Close();
            sw1.Close();
            sw2.Close();
            sw3.Close();
            UpdateNumberofStudent();
        }

        private void LoadStudent()
        {
            string getmemo = "";
            StreamReader sr = new StreamReader(new FileStream("student.stu", FileMode.Open));

            StreamReader sr1 = new StreamReader(new FileStream("studentMemo1.memo", FileMode.Open));
            StreamReader sr2 = new StreamReader(new FileStream("studentMemo2.memo", FileMode.Open));
            StreamReader sr3 = new StreamReader(new FileStream("studentMemo3.memo", FileMode.Open));

            string student1Name = sr.ReadLine();
            string student1Number = sr.ReadLine();
            string student1Gender = sr.ReadLine(); 

            string student2Name = sr.ReadLine();
            string student2Number = sr.ReadLine();
            string student2Gender = sr.ReadLine();

            string student3Name = sr.ReadLine();
            string student3Number = sr.ReadLine();
            string student3Gender = sr.ReadLine();

            textBoxName1.Text = student1Name;
            textBoxNumber1.Text = student1Number;
            comboBoxGender1.SelectedItem = student1Gender;
            textBoxMemo1.Text = "";
            while (sr1.EndOfStream == false)
            {
                getmemo = sr1.ReadLine();
                textBoxMemo1.Text += getmemo + "\r\n";
            }

            textBoxName2.Text = student2Name;
            textBoxNumber2.Text = student2Number;
            comboBoxGender2.SelectedItem = student2Gender;
            textBoxMemo2.Text = "";
            while (sr2.EndOfStream == false)
            {
                getmemo = sr2.ReadLine();
                textBoxMemo2.Text += getmemo + "\r\n";
            }

            textBoxName3.Text = student3Name;
            textBoxNumber3.Text = student3Number;
            comboBoxGender3.SelectedItem = student3Gender;
            textBoxMemo3.Text = "";
            while (sr3.EndOfStream == false)
            {
                getmemo = sr3.ReadLine();
                textBoxMemo3.Text += getmemo + "\r\n";
            }

            sr.Close();
            sr1.Close();
            sr2.Close();
            sr3.Close();
            UpdateNumberofStudent();
        }

        #region student1

        private void ButtonSave1_Click(object sender, EventArgs e)
        {
            SaveStudent();
        }

        private void ButtonDelete1_Click(object sender, EventArgs e)
        {
            textBoxName1.Text = "학생정보 없음";
            textBoxNumber1.Text = "";
            comboBoxGender1.SelectedItem = "남자";
            textBoxMemo1.Text = "";
            SaveStudent();
        }
        #endregion

        #region student2

        private void ButtonSave2_Click(object sender, EventArgs e)
        {
            SaveStudent();
        }

        private void ButtonDelete2_Click(object sender, EventArgs e)
        {
            textBoxName2.Text = "학생정보 없음";
            textBoxNumber2.Text = "";
            comboBoxGender2.SelectedItem = "남자";
            textBoxMemo2.Text = "";
            SaveStudent();
        }
        #endregion

        #region student3

        private void ButtonSave3_Click(object sender, EventArgs e)
        {
            SaveStudent();
        }

        private void ButtonDelete3_Click(object sender, EventArgs e)
        {
            textBoxName3.Text = "학생정보 없음";
            textBoxNumber3.Text = "";
            comboBoxGender3.SelectedItem = "남자";
            textBoxMemo3.Text = "";
            SaveStudent();
        }
        #endregion

        private void CheckBoxAutoLoading_CheckedChanged(object sender, EventArgs e)
        {
            if (firstrun == 0) {
                firstrun = 1;
                return;
            }

            StreamWriter sw = new StreamWriter(new FileStream("autoload.dat", FileMode.Create));

            if (checkBoxAutoLoading.Checked)
                sw.Write(1);
            else
                sw.Write(0);

            sw.Close();
        }


    }
}
