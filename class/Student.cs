using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RandomHat_OddE
{

    public class Student
    {
        public string name { get; set; }
        public string email { get; set; }
        public int GroupId { get; set; }
        public List<Student> getStudent()
        {
            List<Student> lstStudent = new List<Student>()
                {
                    new Student{
        name = "Channing Barnett",
        email = "laoreet.lectus@icloud.net"
    },
    new Student{
        name = "Allen Lindsay",
        email = "ligula@outlook.couk"
    },
    new Student{
        name = "Nelle Navarro",
        email = "mauris.sapien@outlook.com"
    },
    new Student{
        name = "Zelda Carroll",
        email = "lacus.etiam@outlook.edu"
    },
    new Student{
        name = "Aaron Nichols",
        email = "enim.nisl@aol.edu"
    },
    new Student{
        name = "Leila Quinn",
        email = "augue.malesuada@protonmail.edu"
    },
    new Student{
        name = "Gavin Holman",
        email = "nonummy@yahoo.ca"
    },
    new Student{
        name = "Jade Herring",
        email = "dolor.sit@protonmail.com"
    },
    new Student{
        name = "Mark Huff",
        email = "pede.et.risus@protonmail.com"
    },
    new Student{
        name = "Garrett Glass",
        email = "tempor.bibendum@outlook.ca"
    },
    new Student{
        name = "Vaughan Roman",
        email = "nunc.ac@protonmail.net"
    },
    new Student{
        name = "Leonard Wooten",
        email = "elementum@outlook.org"
    },
    new Student{
        name = "Isabelle Rojas",
        email = "vitae.aliquam@aol.com"
    },
    new Student{
        name = "Orla Austin",
        email = "habitant.morbi@protonmail.edu"
    },
    new Student{
        name = "Zahir Harding",
        email = "laoreet.libero@aol.net"
    },
    new Student{
        name = "Abbot Blevins",
        email = "ipsum.nunc@aol.com"
    },
    new Student{
        name = "Todd Mcmahon",
        email = "venenatis.vel@hotmail.org"
    },
    new Student{
        name = "Theodore Lambert",
        email = "cras.dictum@yahoo.couk"
    },
    new Student{
        name = "Martena Terry",
        email = "ultricies.ornare.elit@protonmail.org"
    },
    new Student{
        name = "Zelenia Holder",
        email = "mollis.lectus@google.couk"
    },
    new Student{
        name = "Craig Henson",
        email = "cum.sociis@aol.org"
    },
    new Student{
        name = "Mercedes Salas",
        email = "per.inceptos@hotmail.couk"
    },
    new Student{
        name = "Kalia Wise",
        email = "ac@aol.net"
    },
    new Student{
        name = "Hiram Ratliff",
        email = "tempor.augue@yahoo.com"
    },
    new Student{
        name = "Lara Faulkner",
        email = "nulla.semper@icloud.couk"
    },
    new Student{
        name = "Megan Holcomb",
        email = "ante@outlook.com"
    },
    new Student{
        name = "Jana Jefferson",
        email = "sociis.natoque@protonmail.edu"
    },
    new Student{
        name = "Lunea Riddle",
        email = "nulla.integer.urna@google.org"
    },
    new Student{
        name = "Aristotle Hardin",
        email = "nulla@outlook.com"
    },
    new Student{
        name = "Brody Rhodes",
        email = "eget.lacus@hotmail.org"
    },
    new Student{
        name = "Lucy Ortiz",
        email = "quam.dignissim@hotmail.com"
    },
    new Student{
        name = "Hayley Mccarthy",
        email = "urna.nec@aol.org"
    },
    new Student{
        name = "Steel Carter",
        email = "praesent@google.com"
    },
    new Student{
        name = "Dante Sutton",
        email = "donec@hotmail.org"
    },
    new Student{
        name = "Tucker Marks",
        email = "ac@yahoo.couk"
    },
    new Student{
        name = "Leo Edwards",
        email = "vitae.aliquam.eros@google.couk"
    },
    new Student{
        name = "Quin Andrews",
        email = "phasellus.ornare.fusce@protonmail.ca"
    },
    new Student{
        name = "Liberty Mckinney",
        email = "elit.dictum@hotmail.ca"
    },
    new Student{
        name = "Quentin Cline",
        email = "sed.pede@icloud.ca"
    },
    new Student{
        name = "Kimberley Hutchinson",
        email = "torquent.per.conubia@outlook.ca"
    },
    new Student{
        name = "Carter Wilson",
        email = "nullam.ut.nisi@protonmail.org"
    },
    new Student{
        name = "Ocean Lambert",
        email = "quam.elementum@icloud.net"
    },
    new Student{
        name = "Ahmed Harmon",
        email = "dui.cum@outlook.ca"
    },
    new Student{
        name = "Faith Trujillo",
        email = "nulla.facilisis@protonmail.ca"
    },
    new Student{
        name = "Gail Hardy",
        email = "ac.metus.vitae@yahoo.ca"
    },
    new Student{
        name = "Fuller Fitzpatrick",
        email = "augue.porttitor@outlook.com"
    },
    new Student{
        name = "Abraham Carter",
        email = "rhoncus@yahoo.org"
    },
    new Student{
        name = "Kareem Hyde",
        email = "a@google.net"
    },
    new Student{
        name = "Sarah Pate",
        email = "sed.pede@aol.com"
    },
    new Student{
        name = "Marsden Best",
        email = "sit.amet@protonmail.org"
    },
    new Student{
        name = "Yen Cooke",
        email = "penatibus@google.com"
    },
    new Student{
        name = "Tad Gardner",
        email = "ante.dictum@yahoo.edu"
    },
    new Student{
        name = "Channing Morin",
        email = "sapien.molestie@protonmail.org"
    },
    new Student{
        name = "Denise Boyd",
        email = "nascetur@yahoo.org"
    },
    new Student{
        name = "Shaine Ward",
        email = "donec@outlook.org"
    },
    new Student{
        name = "Hiroko Welch",
        email = "dui.lectus.rutrum@protonmail.ca"
    },
    new Student{
        name = "Wanda Thornton",
        email = "phasellus.libero@icloud.ca"
    },
    new Student{
        name = "Aristotle Harrell",
        email = "in@hotmail.edu"
    },
    new Student{
        name = "Camden David",
        email = "nisi.magna.sed@protonmail.ca"
    },
    new Student{
        name = "Fay Peterson",
        email = "tortor.nibh.sit@protonmail.com"
    },
    new Student{
        name = "Alma Benson",
        email = "eu@hotmail.net"
    },
    new Student{
        name = "Xyla Church",
        email = "eu.placerat.eget@hotmail.com"
    },
    new Student{
        name = "Basil Bradley",
        email = "varius@google.couk"
    },
    new Student{
        name = "Charlotte Frye",
        email = "sed.pede@hotmail.com"
    },
    new Student{
        name = "Mary Burnett",
        email = "tristique.aliquet.phasellus@outlook.ca"
    },
    new Student{
        name = "Joel Greene",
        email = "nascetur.ridiculus@hotmail.net"
    },
    new Student{
        name = "Hashim Gallegos",
        email = "laoreet.posuere@hotmail.ca"
    },
    new Student{
        name = "Lesley Black",
        email = "neque.in@outlook.ca"
    },
    new Student{
        name = "Cole Benson",
        email = "in.faucibus@outlook.ca"
    },
    new Student{
        name = "Flavia Valencia",
        email = "suspendisse.dui.fusce@protonmail.ca"
    },
    new Student{
        name = "Kuame Beasley",
        email = "duis@aol.net"
    },
    new Student{
        name = "Arthur Nguyen",
        email = "mauris.suspendisse@protonmail.ca"
    },
    new Student{
        name = "Reed Morin",
        email = "aliquam.rutrum@icloud.edu"
    },
    new Student{
        name = "Indigo Church",
        email = "erat@icloud.ca"
    },
    new Student{
        name = "Wyatt Mullins",
        email = "tristique.senectus@yahoo.edu"
    },
    new Student{
        name = "Camden Delaney",
        email = "massa.lobortis.ultrices@yahoo.ca"
    },
    new Student{
        name = "Meredith Gonzales",
        email = "etiam.laoreet@aol.edu"
    },
    new Student{
        name = "Tanya Atkins",
        email = "egestas.hendrerit@google.com"
    },
    new Student{
        name = "Rama Hood",
        email = "metus.vivamus.euismod@aol.couk"
    },
    new Student{
        name = "Zephania Thomas",
        email = "tellus.id.nunc@google.couk"
    },
    new Student{
        name = "Camden Frank",
        email = "nam.ligula@aol.couk"
    },
    new Student{
        name = "Irma Shaffer",
        email = "id@google.org"
    },
    new Student{
        name = "Ebony Mcdowell",
        email = "quis.arcu.vel@outlook.couk"
    },
    new Student{
        name = "Micah Humphrey",
        email = "orci@hotmail.edu"
    },
    new Student{
        name = "Glenna Santana",
        email = "diam.nunc@hotmail.edu"
    },
    new Student{
        name = "Gwendolyn Hickman",
        email = "vel@yahoo.couk"
    },
    new Student{
        name = "Leilani Oliver",
        email = "lobortis.tellus.justo@google.net"
    },
    new Student{
        name = "Clarke Serrano",
        email = "auctor.non@hotmail.edu"
    },
    new Student{
        name = "Neville Sawyer",
        email = "scelerisque.neque@protonmail.couk"
    },
    new Student{
        name = "Samantha Vinson",
        email = "blandit@hotmail.org"
    },
    new Student{
        name = "Timon Stephenson",
        email = "ut.sagittis@yahoo.net"
    },
    new Student{
        name = "Lani Hopkins",
        email = "faucibus.morbi@protonmail.com"
    },
    new Student{
        name = "Maile Rivers",
        email = "mollis.dui@protonmail.ca"
    },
    new Student{
        name = "Ferdinand Coffey",
        email = "nonummy@outlook.couk"
    },
    new Student{
        name = "Orson Farley",
        email = "eget.metus@outlook.net"
    },
    new Student{
        name = "Keelie Olson",
        email = "mauris@google.org"
    },
    new Student{
        name = "Camille Giles",
        email = "quisque.imperdiet@yahoo.org"
    },
    new Student{
        name = "Madeson Strong",
        email = "vulputate.dui@protonmail.ca"
    },
    new Student{
        name = "Ray Melendez",
        email = "suspendisse@google.org"
    },
    new Student{
        name = "Linus Parsons",
        email = "enim.etiam@hotmail.couk"
    }
                };
            return lstStudent;
        }
    }
}