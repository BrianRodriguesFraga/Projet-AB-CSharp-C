using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestion_alarme
{
    public partial class InterfaceGraphique : Form
    {

        Connection_db connection = new Connection_db();

        public InterfaceGraphique()
        {
            InitializeComponent();
        }

        private void btnQuittance_Click(object sender, EventArgs e)
        {

            string rqSQL = "";
            //Sert à envoyer la requête voulue à la classe qui s'en occupe
            MySqlDataAdapter data = new MySqlDataAdapter(rqSQL, connection.conn);
            DataSet Ds = new DataSet();
            Ds.Reset();
            data.Fill(Ds, rqSQL);
        }
    }
}
