using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_projectframeword_admin.Models
{
    public class ThuongHieu 
    {
        private int maTH;
        private string tenTH;
        public int MATH
        {
            get { return maTH; }
            set { maTH = value; }
        }
        public string TENTH
        {
            get { return tenTH; }
            set { tenTH = value; }
        }
    }
}
