using DOAAn.DTA;
using PhanQuyen.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAAn.DAO
{
   public class RightDAO
    {
        private static RightDAO instance;

        public static RightDAO Instance
        {
            get
            {
                if (instance == null) { instance = new RightDAO(); }
                return instance;
            }
            set { instance = value; }
        }
        private RightDAO() { }

        public Right GetQuyen(string userName,string pass)
        {
           
            DataTable result = DataProvider.Instance.ExecuteQuery("exec CheckTk @name , @pass ",new object[] {userName,pass} );
            if (result.Rows.Count > 0)
            {
                Right right = new Right(result.Rows[0]);
                  
            }
            Right temp = new Right("-1",-1);
            return temp;
        }

        
    }
}
