namespace Student.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            User user = new User("Cavidan Mammadov ", "Cavidanbm-bp215@code.edu.az", "Cavidan666");
            user.ShowInfo();

            
            Student student1 = new Student("Cavidan Mammadov ", 100);
            Student student2 = new Student(" Xalid Memisov", 92);

            student1.StudentInfo();
            student2.StudentInfo();

       
            Group group = new Group("BP215", 20);
            group.AddStudent(student1);
            group.AddStudent(student2);

         
            Student[] students = group.GetAllStudents();
            foreach (var item in students)
            {
                if (item != null)
                    item.StudentInfo();
            }
        }

    }
}

