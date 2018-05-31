using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    class SharedContext
    {
        public static ProgramContext context = new ProgramContext();
        public static InProgress selectedProgress { get; set; }
        public static NotDelivered selectedNotDelivered;
        public static Delivered selectedDelivered;
    }
}
