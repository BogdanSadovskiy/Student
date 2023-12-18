using Student;
using System.Threading;

namespace Myspace;
class program
{
    static void Main(string[] args)
    {
        IDCreator creator = new IDCreator();
        StudentDateBase studentDate = new StudentDateBase();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Add student ---- 1");
            Console.WriteLine("Select student - 2");
            Console.WriteLine("Exit ----------- e");
            string menu = Console.ReadLine();
            if (menu == "e" || menu == "E")
            {
                break;
            }
            if (menu == "1")
            {
                Console.Clear();
                Console.WriteLine("Input name");
                string name = Console.ReadLine();
                int id = creator.createID();
                Student student = new Student(name, id); 
                studentDate.Insert(student);
                Console.WriteLine("Name: " + name);
                Console.WriteLine("ID: " + id);
                Thread.Sleep(1500);

            }
            else if (menu == "2")
            {
                Console.Clear();
                int id_ = 0;
                try
                {
                    Console.WriteLine("Input id to search");

                    string id = Console.ReadLine();
                    id_ = int.Parse(id);
                }
                catch (Exception e) { 
                Console.WriteLine(e.ToString());
                }
                Student student_ = studentDate.Select(id_);
                if (student_ != null) {
                    Console.Clear();
                    Console.WriteLine("\tName: " + student_.Name);
                    Console.WriteLine("\tID: " + student_.ID+"\n");
                    Console.WriteLine("Update - 1");
                    Console.WriteLine("Remove - 2");
                    Console.WriteLine("ECS ---- e");
                    menu = Console.ReadLine();
                    if (menu == "e" || menu == "E") { continue; }
                    if (menu == "1")
                    {
                        Console.Write("Input new Name: ");
                        string Name_ = Console.ReadLine();
                        studentDate.Update(student_, Name_);
                        Console.WriteLine("Name changed");
                    }
                    else if (menu == "2")
                    {
                        Console.WriteLine("Deleted student: " + student_.Name 
                            + "(" + student_.ID + ")");
                        studentDate.Delete(student_);
                    }
                }
                else
                {
                    Console.WriteLine("There is no student with this " + id_ + " id");
                    Thread.Sleep(1500);
                }
            }

        }



    }
}