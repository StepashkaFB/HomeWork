using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskExseptions
{
    [Serializable]
    class InvalidWorker : Exception
    {
        public int IdentifyOfWorker { get; set; }
        public InvalidWorker(): base(String.Format("Edding error"))
        {
            IdentifyOfWorker = -1;
        }
        public InvalidWorker(string message, int temp) : base(message)
        {
            IdentifyOfWorker = temp;
        }
    }
}
