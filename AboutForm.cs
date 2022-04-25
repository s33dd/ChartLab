using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartLabFramework {
  public partial class AboutForm : Form {
    public AboutForm() {
      InitializeComponent();
    }
    private void AgreeBtn_Click(object sender, EventArgs e) {
      Close();
    }

    private void AboutForm_FormClosed(object sender, FormClosedEventArgs e) {
      Properties.Settings.Default.NotShow = NotShowingChkbx.Checked;
      Properties.Settings.Default.Save();
    }

    private void AboutForm_Load(object sender, EventArgs e) {
      NotShowingChkbx.Checked = Properties.Settings.Default.NotShow;
    }
  }
}
