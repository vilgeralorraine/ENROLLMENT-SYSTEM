﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENROLLMENT_SYSTEM_1._1
{
    internal class Name
    {
        static List<string> users = new List<string>();

        public static void StudentNumber()
        {
            users.Add("2024-00001-BN-0");
            users.Add("2024-00002-BN-0");
            users.Add("2024-00003-BN-0");
            users.Add("2024-00004-BN-0");
            users.Add("2024-00005-BN-0");
            users.Add("2024-00006-BN-0");
            users.Add("2024-00007-BN-0");
            users.Add("2024-00008-BN-0");
            users.Add("2024-00009-BN-0");
            users.Add("2024-00010-BN-0");
        }
        public static bool Continue(string con2)
        {
            StudentNumber();

            bool result = false;

            foreach (var user in users)
            {
                if (user == con2)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
