/* Title:           Project Costing Class
 * Date:            11-13-19
 * Author:          Terry Holmes
 * 
 * Description:     This is the class where project costing will be done */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace ProjectCostingDLL
{
    public class ProjectCostingClass
    {
        //setting up the class
        EventLogClass TheEventLogClass = new EventLogClass();

        //setting up the data
        FindProjectHoursCostingDataSet aFindProjectHoursCostingDataSet;
        FindProjectHoursCostingDataSetTableAdapters.FindProjectHoursCostingTableAdapter aFindProjectHoursCostingTableAdapter;

        FindProjectMaterialCostingDataSet aFindProjectMaterialCostingDataSet;
        FindProjectMaterialCostingDataSetTableAdapters.FindProjectMaterialCostingTableAdapter aFindProjectMaterialCostingTableAdapter;

        public FindProjectMaterialCostingDataSet FindProjectMaterialCosting(string strAssignedProjectID)
        {
            try
            {
                aFindProjectMaterialCostingDataSet = new FindProjectMaterialCostingDataSet();
                aFindProjectMaterialCostingTableAdapter = new FindProjectMaterialCostingDataSetTableAdapters.FindProjectMaterialCostingTableAdapter();
                aFindProjectMaterialCostingTableAdapter.Fill(aFindProjectMaterialCostingDataSet.FindProjectMaterialCosting, strAssignedProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Costing Class // Find Project Material Costing " + Ex.Message);
            }

            return aFindProjectMaterialCostingDataSet;    
        }
        public FindProjectHoursCostingDataSet FindProjectHoursCosting(string strAssignedProjectID)
        {
            try
            {
                aFindProjectHoursCostingDataSet = new FindProjectHoursCostingDataSet();
                aFindProjectHoursCostingTableAdapter = new FindProjectHoursCostingDataSetTableAdapters.FindProjectHoursCostingTableAdapter();
                aFindProjectHoursCostingTableAdapter.Fill(aFindProjectHoursCostingDataSet.FindProjectHoursCosting, strAssignedProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Project Costing Class // Find Project Hours Costing " + Ex.Message);
            }

            return aFindProjectHoursCostingDataSet;
        }
    }
}
