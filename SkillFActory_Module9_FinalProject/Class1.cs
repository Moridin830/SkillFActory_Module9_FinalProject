using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFActory_Module9_FinalProject
{
    public class SortList
    {
        static public List<string> NameList { get; set; }

        public static void InputNames()
        {
            for(byte NameIndex = 0; NameIndex < 5; NameIndex++)
            {
                Console.WriteLine("Input name #1:");
                try
                {
                    string CurrentName = Console.ReadLine();
                    if (CurrentName.Length == 0)
                    {
                        throw new ExceptionForTask("The name cannot be empty");
                    }
                    NameList.Add(CurrentName);
                }
                catch(Exception ex) when (ex is ExceptionForTask)
                {
                    NameIndex--;
                }
            }
        }

    }
}
