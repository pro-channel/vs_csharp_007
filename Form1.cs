using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vs_csharp_007
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// formのロードイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("name");

            DataRow dr = dt.NewRow();
            dr["id"] = "10";
            dr["name"] = "肉";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["id"] = "11";
            dr["name"] = "魚";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["id"] = "12";
            dr["name"] = "野菜";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["id"] = "13";
            dr["name"] = "果物";
            dt.Rows.Add(dr);

            this.comboBox.DataSource = dt;
            this.comboBox.DisplayMember = "name";
            this.comboBox.ValueMember = "id";


        }

        /// <summary>
        /// コンボボックスの選択イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int index = this.comboBox.SelectedIndex;
            string value = this.comboBox.SelectedValue.ToString();

            return;
        }

        /// <summary>
        /// indexボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonIndex_Click(object sender, EventArgs e)
        {
            // 魚を選択
            this.comboBox.SelectedIndex = 1;
        }

        /// <summary>
        /// valueボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonValue_Click(object sender, EventArgs e)
        {
            // 果物を選択
            this.comboBox.SelectedValue = "13";
        }
    }
}
