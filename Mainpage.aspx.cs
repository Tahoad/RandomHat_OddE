using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RandomHat_OddE
{
    public partial class Mainpage : System.Web.UI.Page
    {
        Student stdnt = new Student();
        List<Student> lstStudent = new List<Student>();
        protected void Page_Load(object sender, EventArgs e)
        {
            //reset textbox string
            ClearTextbox();
            if (!IsPostBack)
            {
                pnlRandom.Style.Add("display", "block");
                pnlAllocated.Style.Add("display", "none");
            }
        }
        public void ClearTextbox()
        {
            txtGroup1_Member_Count.Text = String.Empty;
            txtGroup1_Member_Name.Text = String.Empty;
            txtGroup2_Member_Count.Text = String.Empty;
            txtGroup2_Member_Name.Text = String.Empty;
            txtGroup3_Member_Count.Text = String.Empty;
            txtGroup3_Member_Name.Text = String.Empty;
            txtGroup4_Member_Count.Text = String.Empty;
            txtGroup4_Member_Name.Text = String.Empty;
            txtRandomNumber.Text = String.Empty;
        }

        protected void btnRandom_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            //get random 50 student from student class
            lstStudent = stdnt.getStudent().OrderBy(x=> rnd.Next()).Take(50).ToList();
            AllocateStudent(lstStudent);
            OpenPnlAllocate();
        }
        public void OpenPnlAllocate()
        {
            pnlRandom.Style.Add("display", "none");
            pnlAllocated.Style.Add("display", "block");
        }
        private static Random random;
        private static object syncObj = new object();
        private static int GenerateRandomNumber(int min, int max)
        {
            lock (syncObj)
            {
                if (random == null)
                    random = new Random(); // Or exception...
                return random.Next(min, max);
            }
        }
        public void AllocateStudent(List<Student> lstStudent)
        {
            int GroupNumber = 0;

            //loop students in list ex : 50 students
            foreach (var i in lstStudent)
            {
                do
                {
                    //random group number
                    Random rnd = new Random(DateTime.Now.Second);
                    int RandNumber = GenerateRandomNumber(12, 50);
                    txtRandomNumber.Text += RandNumber.ToString() + "\n";
                    txtRandomNumber.Visible = false;
                    GroupNumber = (int)Math.Floor(Convert.ToDecimal(lstStudent.Count() / RandNumber));
                }
                while (IsGroupAlreadyFull(GroupNumber)); //check is group full then random new group number
                //if group is not full then add student in group
                i.GroupId = GroupNumber;

                //add name of student in text area
                switch (GroupNumber)
                {
                    case 1:
                        txtGroup1_Member_Name.Text += i.name + "\n";
                        break;
                    case 2:
                        txtGroup2_Member_Name.Text += i.name + "\n";
                        break;
                    case 3:
                        txtGroup3_Member_Name.Text += i.name + "\n";
                        break;
                    case 4:
                        txtGroup4_Member_Name.Text += i.name + "\n";
                        break;
                }
            }
            txtGroup1_Member_Count.Text = "Gryffindor Members : " + lstStudent.Count(x => x.GroupId == 1).ToString();
            txtGroup2_Member_Count.Text = "Hufflepuff Members : " + lstStudent.Count(x => x.GroupId == 2).ToString();
            txtGroup3_Member_Count.Text = "Ravenclaws Members : " + lstStudent.Count(x => x.GroupId == 3).ToString();
            txtGroup4_Member_Count.Text = "Slytherins Members : " + lstStudent.Count(x => x.GroupId == 4).ToString();
        }
        public bool IsGroupAlreadyFull(int GroupNumber)
        {
            int MaxMemberInGroup = 12;
            if (GroupNumber == 1 && lstStudent.Count(x => x.GroupId == 1) > MaxMemberInGroup)
                return true;
            if (GroupNumber == 2 && lstStudent.Count(x => x.GroupId == 2) > MaxMemberInGroup)
                return true;
            if (GroupNumber == 3 && lstStudent.Count(x => x.GroupId == 3) > MaxMemberInGroup)
                return true;
            if (GroupNumber == 4 && lstStudent.Count(x => x.GroupId == 4) > MaxMemberInGroup)
                return true;
            return false;
        }

        protected void btnClosePnlAllocated_Click(object sender, EventArgs e)
        {
            pnlAllocated.Style.Add("display", "none");
            pnlRandom.Style.Add("display", "block");
        }
    }
}