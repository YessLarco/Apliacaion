using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAAR.Negocio;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = new Size(750, 330);
            /* ::::::::::Importante:::::::::::::::::::::
             * consultar como realizar esto con funciones 
             */
            tabControl1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.None;
            calendar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.None;
            monthView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.None;
            btbPrueba.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.None;
            btnPrueba2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.None;
            btnPrueba3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.None;
            cmbAreasComunes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.None;
            btnPrueba4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.None;
            

        }
        

        clcActivo ConAct = new clcActivo();
   
   

        private void monthView1_SelectionChanged_1(object sender, EventArgs e)
        {
            calendar1.SetViewRange(monthView1.SelectionStart, monthView1.SelectionEnd);
            
        }

        private void btnPrueba2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ConAct.ConsultarActivo(10));
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }









 
    }
}
