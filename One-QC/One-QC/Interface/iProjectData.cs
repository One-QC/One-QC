using System;
using System.Collections.Generic;
using System.Text;

namespace One_QC.Interface
{
    interface iProjectData
    {
        string strProID { get; set; }
        string strProTitle { get; set; }
        DateTime datetimeProDate { get; set; }
        string strProBRD { get; set; }
        string strProSFAT { get; set; }
        string strProITRoadMap { get; set; }
        string strEmpIDBA { get; set; }
        string strEmpIDBU { get; set; }
    }
}
