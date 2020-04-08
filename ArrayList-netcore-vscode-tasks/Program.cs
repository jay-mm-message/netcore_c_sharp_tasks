using System;
using System.Collections;

namespace ArrayList_netcore_vscode_tasks
{
    class Program
    {
        private static readonly string [] Subjects = 
        { "程式語言", "資訊數學", "計算機概論", "多媒體", "網路概論" };
        private static readonly string [] ChoiceSubject = 
        { "英文會話", "資訊數學", "網路概論" };
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            ArrayList list = new ArrayList(1);
            foreach (var item in Subjects) {
                list.Add(item);
            }

            ArrayList list2 = new ArrayList(1);
            foreach (var item in ChoiceSubject) {
                list2.Add(item);
            }

            foreach(var item in list){
                Console.Write(item);
            }
            Console.WriteLine();

            foreach(var item in list2) {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
