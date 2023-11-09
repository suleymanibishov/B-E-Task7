using System;

namespace B_E_Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------Task1----------------------------
            //Console.WriteLine(IsArrayContains(new int[]{ 1,2,3,4,5,6},new int[]{ 2,3,4}));

            //-------------------------Task2----------------------------
            User[] users = new User[] { new User { Name = "Fariz", Surname = "Eliyev", UserName = "fariz_e@mail.com", Password = "1244sd" }, new Student { Name = "Sadiq", Surname = "Quliyev", UserName = "s.qulieff@mail.com", Grade = "B-", Password = "sq1234" }, new User { Name = "Ismayil", Surname = "Orucov", UserName = "orucov_i@mail.com", Password = "io44332211" }, new Student { Name = "Qasim", Surname = "Ibrahimov", UserName = "qasim_ibrahimov@mail.com", Grade = "A++", Password = "qasim123" } };
            Console.Write("User Name: ");
            string userName = Console.ReadLine();
            Console.Write("Password: ");
            string pass = Console.ReadLine();
            foreach (var u in users)
            {

                if(userName == u.UserName && pass == u.Password)
                {
                    var student = u as Student;
                    if(student != null)
                    Console.WriteLine($"Telebe {student.Name} Qiymeti: {student.Grade}");
                }

            }
        }
        static bool IsArrayContains(int[] arr1,int[] arr2)
        {

            for (int i = 0; i < arr1.Length; i++)
            {
                if(arr1[i] == arr2[0])
                {
                    if(arr2.Length <= arr1.Length - i)
                    {
                        for (int j = 0; j < arr2.Length; j++)
                        {
                            if(arr1[i++] != arr2[j])
                            {
                                return false;
                            }
                        }
                        return true;
                    }
                    return false;
                }
            }

            return false;
        }

    }
}
