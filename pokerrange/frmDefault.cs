using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokerrange
{
    public partial class frmDefault : Form
    {

        public frmDefault()
        {
            InitializeComponent();
        }

        private void frmDefault_Load(object sender, EventArgs e)
        {
        }

        private void LoadForm(Bitmap img, string Text)
        {
            frmImage myForm = new frmImage(img);
            myForm.Text = Text;
            myForm.StartPosition = FormStartPosition.Manual;
            myForm.Location = new Point(0, 0);
            myForm.Show();
        }

        /*
         * BB
        */
        // BB vs UTG MP CO
        private void btnBBvsUTG_Click(object sender, EventArgs e)
        {
            LoadForm(Properties.Resources.BB_vs_UTG_MP_CO, "BB vs UTG/MP/CO open");

        }
        // BB vs BTN
        private void btnBBvsBTN_Click(object sender, EventArgs e)
        {
            LoadForm(Properties.Resources.BB_vs_BTN, "BB vs BTN open");
        }

        /*
         * SB
        */
        // SB vs UTG MP
        private void btnSBvsUTG_Click(object sender, EventArgs e)
        {
            LoadForm(Properties.Resources.SB_vs_UTG_MP, "SB vs UTG/MP open");
        }
        // SB vs CO
        private void btnSBvsCO_Click(object sender, EventArgs e)
        {
            LoadForm(Properties.Resources.SB_vs_CO, "SB vs CO open");
        }
        // SB VS BTN
        private void btnSBvsBTN_Click(object sender, EventArgs e)
        {
            LoadForm(Properties.Resources.SB_vs_BTN, "SB vs BTN open");
        }
        // SB VS BB
        private void btnSBvsBB_Click(object sender, EventArgs e)
        {
            LoadForm(Properties.Resources.SB_vs_BB_3bet, "SB vs BB 3bet");
        }
        /*
         * BTN
        */
        // BTN vs UTG MP
        private void btnBTNvsUTG_Click(object sender, EventArgs e)
        {
            LoadForm(Properties.Resources.BTN_vs_UTG_MP, "BTN VS UTG/MP open");
        }
        // BTN VS CO
        private void btnBTNvsCO_Click(object sender, EventArgs e)
        {
            LoadForm(Properties.Resources.BTN_vs_CO, "BTN VS CO open");
        }
        // BTN VS SB BB
        private void btnBTNvsSB_Click(object sender, EventArgs e)
        {
            LoadForm(Properties.Resources.BTN_vs_SB_BB_3bet, "BTN VS SB/BB 3bet");
        }
        /*
         * CO
        */
        // CO vs UTG MP
        private void btnCOvsUTG_Click(object sender, EventArgs e)
        {
            LoadForm(Properties.Resources.CO_vs_UTG_MP, "CO VS UTG/MP open");
        }
        // CO VS BTN SB BB
        private void btnCOvsBTN_Click(object sender, EventArgs e)
        {
            LoadForm(Properties.Resources.CO_vs_BTN_SB_BB_3bet, "CO VS BTN/SB/BB 3bet");
        }
        /*
         * MP
        */
        // MP vs UTG
        private void btnMPvsUTG_Click(object sender, EventArgs e)
        {
            LoadForm(Properties.Resources.MP_vs_UTG, "MP VS UTG open");
        }
        // MP vs CO
        private void btnMPvsCO_Click(object sender, EventArgs e)
        {
            LoadForm(Properties.Resources.MP_vs_CO_3bet, "MP VS CO 3bet");
        }
        // MP VS BTN
        private void btnMPvsBTN_Click(object sender, EventArgs e)
        {
            LoadForm(Properties.Resources.MP_vs_BTN_3bet, "MP VS BTN 3bet");
        }
        // MP VS SB BB
        private void btnMPvsSB_Click(object sender, EventArgs e)
        {
            LoadForm(Properties.Resources.MP_vs_SB_BB_3bet, "MP VS SB/BB 3bet");
        }
        /*
         * UTG
        */
        // UTG VS MP
        private void btnUTGvsMP_Click(object sender, EventArgs e)
        {
            LoadForm(Properties.Resources.UTG_vs_MP_3bet, "UTG VS MP 3bet");
        }
        // UTG VS CO
        private void btnUTGvsCO_Click(object sender, EventArgs e)
        {
            LoadForm(Properties.Resources.UTG_vs_CO_3bet, "UTG VS CO 3bet");
        }
        // UTG VS BTN
        private void btnUTGvsBTN_Click(object sender, EventArgs e)
        {
            LoadForm(Properties.Resources.UTG_vs_BTN_3bet, "UTG VS BTN 3bet");
        }
        // UTG VS SB BB
        private void btnUTGvsSB_Click(object sender, EventArgs e)
        {
            LoadForm(Properties.Resources.UTG_vs_SB_BB_3bet, "UTG VS SB/BB 3bet");
        }
    }
}
