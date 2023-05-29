using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymRPG.Library.Service
{
    public class CharService
    {
        public static CharService _instance;


        public CharService()
        {

        }

        public static CharService Current
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CharService();
                }
                return _instance;
            }
        }
    }
}
