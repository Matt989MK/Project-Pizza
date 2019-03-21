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
        internal string FindID(Int32 iD) // cant be letters
        {
            if (iD != null)
            {
                return "";
            }
            else
                return "ID cannot be blank";
        }
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
            mThisOrder.OrderNo = 0;
            return mThisOrder.OrderNo;
        }

        internal int Delete()
        {

            mThisOrder.OrderNo = 1;
            return mThisOrder.OrderNo;
        }
    }
}
