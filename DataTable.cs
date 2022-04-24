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
  public partial class DataTable : Form {
    private System.Data.DataTable data;

    public System.Data.DataTable Data {
      get { return data; }
      set { data = value; }
    }

    public DataTable() {
      InitializeComponent();
      ValuesTable.AllowUserToAddRows = false;
      StartPosition = FormStartPosition.CenterScreen;
    }

    private void DataTable_Load(object sender, EventArgs e) {
      ValuesTable.DataSource = data;
    }
  }
}
