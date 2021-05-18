using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ICreditManager
    {
        void Calculate ();
        void GetPrintouts();
    }
}
// Interface yi biz birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
