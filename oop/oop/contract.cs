using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class contract
    {
        public int startmoney;//初始资金
        public int remain;//剩余资金
        public int moneyKarmov;//买饲料的钱
        public int QsoldAnimaly;//卖掉数量,年轻
        public int QsoldAnimala;//卖掉数量，成年
        public int QsoldAnimalo;//卖掉数量，老年
        public int fine;//罚款
        public int pricey;//单价，年轻
        public int pricea;//单价，成年
        public int priceo;//单价，老年

        public contract(int mk,int st, int f,int ss,int sa,int py,int pa,int po,int qay,int qaa,int qao)
        {
            moneyKarmov = mk;
            startmoney = st;       
            QsoldAnimaly = qay;//卖掉的数量,年轻
            QsoldAnimala = qaa;//卖掉的数量，成年
            QsoldAnimalo = qao;//卖掉的数量，老年

            fine = f;//罚款
            pricey = py;//单价，年轻
            pricea = pa;//单价，成年
            priceo = po;//单价，老年
            
        }
        
        public int income ()//年收入
        { 
            return (QsoldAnimaly * pricey + QsoldAnimala * pricea + QsoldAnimalo * priceo) - fine - moneyKarmov;
        }

    }
}
