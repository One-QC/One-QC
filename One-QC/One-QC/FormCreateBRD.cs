using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace One_QC
{
    public partial class FormCreateBRD : System.Windows.Forms.Form, Interface.iProjectData
    {
        private Presenter.PresenterProjectData presenterProjectData = null;

        public FormCreateBRD()
        {
            InitializeComponent();
            this.CenterToScreen();
            presenterProjectData = new Presenter.PresenterProjectData(this);
        }
        
        public string strEmpIDBA
        {
            get
            {
                return TextBoxBAID.Text;
            }

            set
            {
                TextBoxBAID.Text = value;
            }
        }

        public string strEmpIDBU
        {
            get
            {
                return TextBoxBUID.Text;
            }

            set
            {
                TextBoxBUID.Text = value;
            }
        }

        public string strProBRD
        {
            get
            {
                return TextBoxProBRD.Text;
            }

            set
            {
                TextBoxProBRD.Text = value;
            }
        }

        public DateTime datetimeProDate
        {
            get
            {
                return DateTimePickerProDate.Value;
            }

            set
            {
                DateTimePickerProDate.Value = value;
            }
        }

        public string strProID
        {
            get
            {
                return TextBoxProID.Text;
            }

            set
            {
                TextBoxProID.Text = value;
            }
        }

        public string strProITRoadMap
        {
            get
            {
                if (ComboBoxITRoadMap.SelectedText.Equals("Yes"))
                {
                    return TextBoxITRoadMapNo.Text;
                }
                else
                {
                    return "-1";
                }
            }

            set
            {
                if (TextBoxITRoadMapNo.Text.Trim().Equals("") || TextBoxITRoadMapNo.Text.Equals("-1"))
                {
                    ComboBoxITRoadMap.SelectedText = "No";
                }
                else
                {
                    ComboBoxITRoadMap.SelectedText = "Yes";
                }
            }
        }

        public string strProSFAT
        {
            get
            {
                return TextBoxProSFAT.Text;
            }

            set
            {
                TextBoxProSFAT.Text = value;
            }
        }

        public string strProTitle
        {
            get
            {
                return TextBoxProTitle.Text;
            }

            set
            {
                TextBoxProTitle.Text = value;
            }
        }

        private void ButtonCommit_Click(object sender, EventArgs e)
        {
            presenterProjectData.Commit();
        }
    }
}
