using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWatcher_Git.Data_Structure
{
    class DDirectory
    {
        public string dir;
        
        public List<string> file;

        public DDirectory(string d)
        {
            dir = d;
            file = new List<string>();
        }
    }
}
