namespace InternshipTest.Person
{
    public class Student
    {
        string name;
        Knowledge knowledge;
        public Student(string name, Knowledge knowledge)
        {
            this.name = name;
            this.knowledge = knowledge;
        }
        public Student(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Knowledge Knowledge
        {
            get
            {
                return knowledge;
            }
            set
            {
                knowledge = value;
            }

        }

        public void SetKnowledge(Knowledge knowledge) // we can set knowlege with this function after object creation
        {
            this.knowledge = knowledge;
        }


    }
}