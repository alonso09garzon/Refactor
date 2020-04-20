using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor.objects
{
    public class objVariablesPrint
    {
        private int ROWOFFSET_;
        private int PAGEOFFSET_;
        private int RR_;
        private int C_;
        private int CC_;
        private int PAGENUMBER_;
        
        public int ROWOFFSET
        {
            get { return ROWOFFSET_; }
            set { ROWOFFSET_ = value; }
        }

        public int PAGEOFFSET
        {
            get { return PAGEOFFSET_; }
            set { PAGEOFFSET_ = value; }
        }

        public int RR
        {
            get { return RR_; }
            set { RR_ = value; }
        }

        public int C
        {
            get { return C_; }
            set { C_ = value; }
        }

        public int CC
        {
            get { return CC_; }
            set { CC_ = value; }
        }
        
        public int PAGENUMBER
        {
            get { return PAGENUMBER_; }
            set { PAGENUMBER_ = value; }
        }

        public objVariablesPrint()
        {
            RR = 50;
            CC = 4;
            PAGEOFFSET = 1;
            PAGENUMBER = 1;
        }

    }
}
