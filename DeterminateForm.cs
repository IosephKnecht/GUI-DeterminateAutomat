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
    public partial class DeterminateForm : Form
    {
        private SettingsForm set_form;

        private List<Node> nodes;
        private List<string> transitions;
        private List<Link> links;


        public DeterminateForm(SettingsForm set_form)
        {
            InitializeComponent();
            this.set_form = set_form;
            set_form.OK_event += Set_form_OK_event;
            links = new List<Link>();
        }

        private void Enter_nodes_comboBox()
        {
            start_comboBox.Items.Clear();
            final_comboBox.Items.Clear();

            foreach (var node in nodes)
            {
                start_comboBox.Items.Add(node.name);
                final_comboBox.Items.Add(node.name);
            }
        }

        private void Enter_transitions_comboBox()
        {
            trans_comboBox.Items.Clear();

            foreach (var trans in transitions)
            {
                trans_comboBox.Items.Add(trans);
            }
        }

        private bool Search_node(string name)
        {
            foreach (var node in nodes)
            {
                if (node.name == name) return node.sost;
            }
            return false;
        }

        private void Set_form_OK_event(object conv_nodes, object conv_transitions)
        {
            nodes = (List<Node>)conv_nodes;
            transitions = (List<string>)conv_transitions;
            Enter_nodes_comboBox();
            Enter_transitions_comboBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void set_button_Click(object sender, EventArgs e)
        {
            set_form.ShowDialog();
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            if (start_comboBox.SelectedIndex != -1 &&
                trans_comboBox.SelectedIndex != -1 &&
                final_comboBox.SelectedIndex != -1)
            {
                int row_num = table.Rows.Add();
                string start_node = start_comboBox.SelectedItem.ToString();
                string transition= trans_comboBox.SelectedItem.ToString();
                string final_node= final_comboBox.SelectedItem.ToString();

                table.Rows[row_num].Cells[0].Value = start_comboBox.SelectedItem;
                if(Search_node(start_comboBox.SelectedItem.ToString()))
                    table.Rows[row_num].Cells[0].Style.Font= new Font(table.DefaultCellStyle.Font, FontStyle.Bold);

                table.Rows[row_num].Cells[1].Value = trans_comboBox.SelectedItem;

                table.Rows[row_num].Cells[2].Value = final_comboBox.SelectedItem;
                if (Search_node(final_comboBox.SelectedItem.ToString()))
                    table.Rows[row_num].Cells[2].Style.Font = new Font(table.DefaultCellStyle.Font, FontStyle.Bold);

                links.Add(new Link(new Node(start_node, Search_node(start_node)), transition, new Node(final_node, Search_node(final_node))));
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (table.Rows.Count > 0)
            {
                table.Rows.RemoveAt(table.Rows.GetLastRow(DataGridViewElementStates.None));
                links.RemoveAt(links.Count - 1);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();
            links.Clear();
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            Determinate det = new Determinate(links, transitions);
            out_auto out_form=new out_auto( det.Det());
            out_form.ShowDialog();
        }
    }
}
