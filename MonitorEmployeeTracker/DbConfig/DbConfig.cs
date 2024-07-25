using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorEmployeeTracker
{
    /// <summary>
    /// Database config class
    /// </summary>
    public static class DbConfig
    {
        #region Public Member
        public static string DataSource { get; set; }
        #endregion

        #region Public Method
        /// <summary>
        /// Method to read from our db
        /// </summary>
        /// <param name="path">path to read our file</param>
        /// <returns></returns>
        public static string GetInfoFromDataBaseConfig(string path = "DbConfig.txt")
        {
            //Read our dbconfig.txt
            using (StreamReader reader = new StreamReader(path))
            {
                DataSource = reader.ReadToEnd();
            }

            return DataSource;

        } 
        #endregion
    }
}
