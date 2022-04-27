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
        List<Student> lstGroup1 = new List<Student>();
        List<Student> lstGroup2 = new List<Student>();
        List<Student> lstGroup3 = new List<Student>();
        List<Student> lstGroup4 = new List<Student>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                pnlRandom.Style.Add("display", "block");
                pnlAllocated.Style.Add("display", "none");
            }
        }

        protected void btnRandom_Click(object sender, EventArgs e)
        {
            lstStudent = stdnt.getStudent().Take(50).ToList();
            AllocateStudent(lstStudent);
            OpenPnlAllocate();
        }
        public void OpenPnlAllocate()
        {
            pnlRandom.Style.Add("display", "none");
            pnlAllocated.Style.Add("display", "block");
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
                    Random rnd = new Random();
                    int RandNumber = rnd.Next(12, 50);
                    GroupNumber = (int)Math.Floor(Convert.ToDecimal(lstStudent.Count() / RandNumber));
                }
                while (IsGroupAlreadyFull(GroupNumber)); //check is group full then random new group number

                //if group is not full then add student in group
                i.GroupId = GroupNumber;
                //switch (GroupNumber)
                //{
                //    case 1:
                //        {
                //            lstGroup1.Add(i);
                //        }
                //        break;
                //    case 2:
                //        {
                //            lstGroup2.Add(i);
                //        }
                //        break;
                //    case 3:
                //        {
                //            lstGroup3.Add(i);
                //        }
                //        break;
                //    case 4:
                //        {
                //            lstGroup4.Add(i);
                //        }
                //        break;
                //}
            }
            //txtGroup1_Gryffindor.Text = lstGroup1.Count.ToString();
            //txtGroup2_Hufflepuff.Text = lstGroup2.Count.ToString();
            //txtGroup3_Ravenclaw.Text = lstGroup3.Count.ToString();
            //txtGroup4_Slytherin.Text = lstGroup4.Count.ToString();
            txtGroup1_Gryffindor.Text = lstStudent.Count(x => x.GroupId == 1).ToString();
            txtGroup2_Hufflepuff.Text = lstStudent.Count(x => x.GroupId == 2).ToString();
            txtGroup3_Ravenclaw.Text = lstStudent.Count(x => x.GroupId == 3).ToString();
            txtGroup4_Slytherin.Text = lstStudent.Count(x => x.GroupId == 4).ToString();
        }
        public bool IsGroupAlreadyFull(int GroupNumber)
        {
            int MaxMemberInGroup = 15;
            if (GroupNumber == 1 && lstGroup1.Count() > MaxMemberInGroup)
                return true;
            if (GroupNumber == 2 && lstGroup2.Count() > MaxMemberInGroup)
                return true;
            if (GroupNumber == 3 && lstGroup3.Count() > MaxMemberInGroup)
                return true;
            if (GroupNumber == 4 && lstGroup4.Count() > MaxMemberInGroup)
                return true;
            return false;
        }
    }
}