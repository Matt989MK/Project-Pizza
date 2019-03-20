using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaProjectTesting
{
    class clstOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();
        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }

        public int OrderNo { get; internal set; }
       
        internal int Add()
        {
            mThisOrder.OrderNo = 2;
            return mThisOrder.OrderNo;
        }

        internal int Delete()
        {
            throw new NotImplementedException();
        }
    }
}
