﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker
{
    public partial class IssueList : Form
    {
        public IssueList()
        {
            InitializeComponent();
        }

        private void issueDataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.issueDataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.issueDateDataSet);

        }

        private void IssueList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'issueDateDataSet.issueData' table. You can move, or remove it, as needed.
            this.issueDataTableAdapter.Fill(this.issueDateDataSet.issueData);

        }

        private void AddIssue_Click(object sender, EventArgs e)
        {
            new mainPage().Show();
        }
    }
}
