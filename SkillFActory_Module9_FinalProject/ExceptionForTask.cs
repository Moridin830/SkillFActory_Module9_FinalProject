using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFActory_Module9_FinalProject
{
    public class ExceptionForTask : Exception
    {
        public ExceptionForTask()
        {

        }

        public ExceptionForTask(string Message) : base(Message)
        {
            
        }
    }
}
