using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Serializable]
    public class RecordList
    {
        public string NickName { get; set; }
        public int Time { get; set; }
        public string ThemePuzzle { get; set; }
    }
}
