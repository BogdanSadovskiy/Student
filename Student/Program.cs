using Student;

namespace Myspace;
class program
{
    static void Main(string[] args)
    {
        IDCreator creator = new IDCreator();
        StudentDateBase studentDate = new StudentDateBase();
        while (true)
        {
            Console.WriteLine("Add student ---- 1");
            Console.WriteLine("Select student - 2");
            Console.WriteLine("Exit ----------- e");
            string menu = Console.ReadLine();
            if (menu == "1")
            {
                Console.WriteLine("Input name");
                string name = Console.ReadLine();
                int id = creator.createID();
                Student student = new Student(name, id); 
                studentDate.Insert(student);
            }
            else if (menu == "2")
            {
                try
                {
                    Console.WriteLine("Input id to search");

                    string id = Console.ReadLine();
                    int id_ = int.Parse(id);
                }
                catch (Exception e) { 
                
                }
            }

        }



    }
}