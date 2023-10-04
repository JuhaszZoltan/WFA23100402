using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA231004
{
    public partial class FrmDekodolo : Form
    {
        public Label[,] LblMatrix { get; set; }

        public FrmDekodolo()
        {
            InitializeComponent();
            InitMatrix();
        }

        private void InitMatrix()
        {
            LblMatrix = new Label[7, 4];
            for (int r = 0; r < LblMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < LblMatrix.GetLength(1); c++)
                {
                    LblMatrix[r, c] = new Label()
                    {
                        AutoSize = false,
                        BackColor = Color.White,
                        Bounds = new Rectangle(
                            x: 50 * c,
                            y: 50 * r,
                            width: 50,
                            height: 50),
                        Font = new Font("Arial", 20f, FontStyle.Bold),
                        Margin = Padding.Empty,
                        Text = "0",
                        TextAlign = ContentAlignment.MiddleCenter,
                    };
                    LblMatrix[r, c].Click += LblMatrixElement_Click;
                    pnlTxtMatrix.Controls.Add(LblMatrix[r, c]);
                }
            }
        }

        private void LblMatrixElement_Click(object sender, EventArgs e)
        {
            if ((sender as Label).Text == "0")
            {
                (sender as Label).Text = "1";
                (sender as Label).BackColor = Color.LightGray;
            }
            else
            {
                (sender as Label).Text = "0";
                (sender as Label).BackColor = Color.White;
            }
        }
    }
}
