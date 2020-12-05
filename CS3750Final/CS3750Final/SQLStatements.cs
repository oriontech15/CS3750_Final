using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;

namespace CS3750Final
{
    public class SQLStatements
    {
        //insert a line to the dbo.Final table
        public string InsertLine(String userName, String salt, String hast, String group, String startTime, String endTime, int totalTime)
        {
            try
            {
                string sSQL = "Insert into dbo.Final(userName, salt, hast, group, startTime, endTime, totalTime) " +
                    "Values('" + userName + "', '" + salt + "', '" + hast + "', '" + group + "', '" + startTime + "', '" + endTime + "', " + totalTime + ")";
                return sSQL;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + "->" + ex.Message);
            }
        }

    }
}
