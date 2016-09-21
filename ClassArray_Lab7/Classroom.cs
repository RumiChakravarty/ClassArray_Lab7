using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassArray_Lab7
{
    public class Classroom
    {
        private Student[] netStudent = new Student[8];
        public Classroom()
        {
            for (int i = 0; i < netStudent.Length; i++)
            {
                netStudent[i] = new Student();

            }
            netStudent[0].name = "Mo";
            netStudent[0].homeTown = "Detroit";
            netStudent[0].favouriteFood = "Sushi";
            netStudent[1].name = "Mike";
            netStudent[1].homeTown = "Detroit";
            netStudent[1].favouriteFood = "Sub";
            netStudent[2].name = "Adi";
            netStudent[2].homeTown = "Troy";
            netStudent[2].favouriteFood = "Pizza";
            netStudent[3].name = "Riddhi";
            netStudent[3].homeTown = "Royal Oak";
            netStudent[3].favouriteFood = "Pizza";
            netStudent[4].name = "Afrin";
            netStudent[4].homeTown = "Detroit";
            netStudent[4].favouriteFood = "Pizza";
            netStudent[5].name = "Rumi";
            netStudent[5].homeTown = "Troy";
            netStudent[5].favouriteFood = "rice";
            netStudent[6].name = "Alex";
            netStudent[6].homeTown = "Novi";
            netStudent[6].favouriteFood = "Pizza";
            netStudent[7].name = "Rumi";
            netStudent[7].homeTown = "Troy";
            netStudent[7].favouriteFood = "rice";

        }
        //   public string ClassroomName = "Homeroom";

        public Student[] studentNETC
        {
            get { return netStudent; }
        }
       // public Student[] studentJava = new Student[3];
    }
}
