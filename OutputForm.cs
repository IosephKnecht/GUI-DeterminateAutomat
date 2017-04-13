using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class out_auto : Form
    {
        private List<Link> links;

        public out_auto(List<Link> links)
        {
            InitializeComponent();
            this.links = links;
            Enter_table();
        }

        private void Enter_table()
        {
            foreach (Link link in links)
            {
                int row_num = table.Rows.Add();
                table.Rows[row_num].Cells[0].Value = link.start_node.name;
                if(link.start_node.sost) table.Rows[row_num].Cells[0].Style.Font=
                        new Font(table.DefaultCellStyle.Font, FontStyle.Bold);
                table.Rows[row_num].Cells[1].Value = link.transition;
                table.Rows[row_num].Cells[2].Value = link.final_node.name;
                if(link.final_node.sost) table.Rows[row_num].Cells[2].Style.Font=
                        new Font(table.DefaultCellStyle.Font, FontStyle.Bold);
            }
        }

        private void out_auto_Load(object sender, EventArgs e)
        {

        }
    }
}
