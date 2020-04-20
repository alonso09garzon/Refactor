using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor.objects
{
   public class objVariablesCalculate
    {
        private int K_;
        private int M_; //= 1000;
        private int J_;
        private int SQUARE_;
        private int ORD_;
        private int None_; // = 2;
        private int ORDMAX_; // = 30;
        private int[] MULT_; //= new int[ORDMAX_ + 1];
        private Boolean JPRIME_;
        private int[] P_;  //= new int[M_ + 1];

        public int K
        {
            get { return K_; }
            set { K_ = value; }
        }

        public int M
        {
            get { return M_; }
            set { M_ = value; }
        }

        public int J
        {
            get { return J_; }
            set { J_ = value; }
        }

        public int SQUARE
        {
            get { return SQUARE_; }
            set { SQUARE_ = value; }
        }

        public int ORD
        {
            get { return ORD_; }
            set { ORD_ = value; }
        }
        
        public int None
        {
            get { return None_; }
            set { None_ = value; }
        }

        public int ORDMAX
        {
            get { return ORDMAX_; }
            set { ORDMAX_ = value; }
        }

        public int[] MULT
        {
            get { return MULT_; }
            set { MULT_ = value; }
        }

        public Boolean JPRIME
        {
            get { return JPRIME_; }
            set { JPRIME_ = value; }
        }

        public int[] P
        {
            get { return P_; }
            set { P_ = value; }
        }

        public objVariablesCalculate()
        {
            M = 1000;
            None = 2;
            ORDMAX= 30;
            MULT = new int[ORDMAX + 1];
            P = new int[M_ + 1];
            J = 1;
            K = 1;
            P[1] = 2;
            ORD = 2;
            SQUARE = 9;
        }

    }
}
