using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_QC.Presenter
{
    class PresenterLogin
    {
        private Model.ModelLogin mLogin = null;
        private Interface.iLogin iLogin = null;

        public PresenterLogin(Interface.iLogin intLogin)
        {
            this.mLogin = new Model.ModelLogin();
            this.iLogin = intLogin;
        }


        public DataSet loginAuthentication()
        {
            String userID = iLogin.userID;
            String userPass = iLogin.password;
            DataSet ds = new DataSet();
            ds= mLogin.loginAuthentication(userID, userPass);
            
            return ds;

        }
    }
}
