using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor
{
    class Process
    {
        public objects.objVariablesCalculate Calculate()
        {
            objects.objVariablesCalculate VariablesCalculate = new objects.objVariablesCalculate();

            while (VariablesCalculate.K < VariablesCalculate.M)
            {
                do
                {
                    VariablesCalculate.J += 2;
                 
                    if (VariablesCalculate.J == VariablesCalculate.SQUARE)
                    {
                        VariablesCalculate.ORD++;
                        VariablesCalculate.SQUARE = VariablesCalculate.P[VariablesCalculate.ORD] * VariablesCalculate.P[VariablesCalculate.ORD];
                        VariablesCalculate.MULT[VariablesCalculate.ORD - 1] = VariablesCalculate.J;
                    }
                    VariablesCalculate.None = 2;
                    VariablesCalculate.JPRIME = true;
                    while (VariablesCalculate.None < VariablesCalculate.ORD && VariablesCalculate.JPRIME)
                    {
                        while (VariablesCalculate.MULT[VariablesCalculate.None] < VariablesCalculate.J)
                        {
                            VariablesCalculate.MULT[VariablesCalculate.None] += VariablesCalculate.P[VariablesCalculate.None] + VariablesCalculate.P[VariablesCalculate.None];
                        }
                        if (VariablesCalculate.MULT[VariablesCalculate.None] == VariablesCalculate.J)
                        {
                            VariablesCalculate.JPRIME = false;
                        }
                        VariablesCalculate.None++;
                    }


                } while (!VariablesCalculate.JPRIME);
                VariablesCalculate.K++;
                VariablesCalculate.P[VariablesCalculate.K] = VariablesCalculate.J;
            }

            return VariablesCalculate;
        }

        public void Print(objects.objVariablesCalculate VariablesCalculate)
        {
            objects.objVariablesPrint VariablesPrint = new objects.objVariablesPrint();

            while (VariablesPrint.PAGEOFFSET <= VariablesCalculate.M)
            {
                Console.Write("The First ");
                Console.Write(VariablesCalculate.M.ToString());
                Console.Write(" Prime Numbers === Page ");
                Console.Write(VariablesPrint.PAGENUMBER.ToString());
                Console.WriteLine("\n");
                for (VariablesPrint.ROWOFFSET = VariablesPrint.PAGEOFFSET; VariablesPrint.ROWOFFSET <= VariablesPrint.PAGEOFFSET + VariablesPrint.RR - 1; VariablesPrint.ROWOFFSET++)
                {
                    for (VariablesPrint.C = 0; VariablesPrint.C <= VariablesPrint.CC - 1; VariablesPrint.C++)
                    {
                        if (VariablesPrint.ROWOFFSET + VariablesPrint.C * VariablesPrint.RR <= VariablesCalculate.M)
                        {
                            Console.Write(string.Format("{0,10:G}",
                            VariablesCalculate.P[VariablesPrint.ROWOFFSET + VariablesPrint.C * VariablesPrint.RR].ToString()));
                        }
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("\n");
                VariablesPrint.PAGENUMBER++;
                VariablesPrint.PAGEOFFSET += VariablesPrint.RR * VariablesPrint.CC;
            }
            Console.ReadKey();
        } 
    }
}
