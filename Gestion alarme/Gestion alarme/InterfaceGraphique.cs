using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        #region variables
        private bool erreur = false;
        private bool alerte = false;
        Connection_db connection = new Connection_db();
        string rqSQL = "";
        string connString = "Server=localhost; Database=alarme; Uid=root; Pwd=;";
        List<String> statusInter = new List<String>();
        List<String> SDIS = new List<String>();
        #endregion variables


        /* public Requetes()
         {

         }*/

        public InterfaceGraphique()
        {
            InitializeComponent();

            #region Hover
            //met le texte en gris du champ texte SiteSinistre (comme pour un hover en html)
            SiteSinistre.ForeColor = Color.Gray;
            lstInterCourantes.ForeColor = Color.Gray;
            #endregion Hover

            #region Liste intervention
            //ajout des item dans la liste des intervention
            //TO DO : à adapter avec la DB
            lstTypeInter.Items.Add("FEU");
            lstTypeInter.Items.Add("SAU");
            lstTypeInter.Items.Add("INO");
            lstTypeInter.Items.Add("DIV");
            lstTypeInter.Items.Add("TEC");
            lstTypeInter.Items.Add("POL");
            lstTypeInter.Items.Add("REN");
            lstTypeInter.Items.Add("PIO");
            lstTypeInter.Items.Add("POL");
            lstTypeInter.Items.Add("CHI");
            lstTypeInter.Items.Add("RAD");
            #endregion Liste intervention

            //ajout des item dans la liste du status d'intervention
            //TO DO : à adapter avec la DB
            /*rqSQL = "SELECT * from alarme_status";
              //Sert à envoyer la requête voulue à la classe qui s'en occupe
              MySqlDataAdapter data = new MySqlDataAdapter(rqSQL, connection.conn);
              DataSet Ds = new DataSet();
              Ds.Reset();
              data.Fill(Ds, rqSQL);*/

            #region Status d'intervention

                rqSQL = "SELECT Status from alarme_status";
                MySqlConnection statusI = new MySqlConnection(connString);
                MySqlCommand rqStatus = new MySqlCommand(rqSQL, statusI);
                statusI.Open();
                MySqlDataReader readStatus;
                readStatus = rqStatus.ExecuteReader();
                // Always call Read before accessing data.
                while (readStatus.Read())
                {
                    statusInter.Add(readStatus.GetString(0));
                }
                // always call Close when done reading.
                readStatus.Close();
                // Close the connection when done with it.
                statusI.Close();
            

            //foreach pour entrer les valeurs pour les champs depuis la liste
            foreach(string status in statusInter)
            {
                lstInterCourantes.Items.Add(status);
            }

            #endregion Status d'intervention

            #region Liste SDIS
            //ajout des item dans la liste des SDIS
            rqSQL = "SELECT NomCaserne from caserne";
            MySqlConnection caserne = new MySqlConnection(connString);
            MySqlCommand rqCaserne = new MySqlCommand(rqSQL, caserne);
            caserne.Open();
            MySqlDataReader readCaserne;
            readCaserne = rqCaserne.ExecuteReader();
            // Appeler le reader avant d'accéder aux données.
            while (readCaserne.Read())
            {
                SDIS.Add(readCaserne.GetString(0));
            }
            // Fermer après lecture.
            readCaserne.Close();
            // Fermer la connection après utilisation.
            caserne.Close();


            //foreach pour entrer les valeurs pour les champs depuis la liste
            foreach (string nomCaserne in SDIS)
            {
                lstSDIS.Items.Add(nomCaserne);
            }

           
            #endregion Liste SDIS
        }

        private void btnQuittance_Click(object sender, EventArgs e)
        {
            #region variables local
            //met erreur à false pour vérifier par la suite si il y a des erreurs dans les champs
            erreur = false;
            string rqSQL = "";
            #endregion variables local
            /*
            //Sert à envoyer la requête voulue à la classe qui s'en occupe
            MySqlDataAdapter data = new MySqlDataAdapter(rqSQL, connection.conn);
            DataSet Ds = new DataSet();
            Ds.Reset();
            data.Fill(Ds, rqSQL);
            */
            #region Verification des champs
            //processus de vérification de tout les champs
            if (txtQui.TextLength <= 0) { MessageBox.Show("Le champ 'Qui ?' est vide !", "Erreur ! Champ vide.", MessageBoxButtons.OK, MessageBoxIcon.Error); erreur = true; }
            else if (lstTypeInter.SelectedIndex < 0) { MessageBox.Show("Aucun index n'a été selectionner dans 'Type Intervention' !", "Erreur ! Index non selectionné.", MessageBoxButtons.OK, MessageBoxIcon.Error); erreur = true; }
            else if (txtLieu.TextLength <= 0) { MessageBox.Show("Le champ 'Lieu' est vide !", "Erreur ! Champ vide.", MessageBoxButtons.OK, MessageBoxIcon.Error); erreur = true; }
            else if (txtStatus.Text == "") { MessageBox.Show("Le champ 'Status de l'intervention' est vide ! \nSelectionnez le type de status", "Erreur ! Champ vide.", MessageBoxButtons.OK, MessageBoxIcon.Error); erreur = true; }
            //si un champ est vide, demande à l'utilisateur une confirmation
            if ((SiteSinistre.TextLength <= 0 || SiteSinistre.Text == "Zone touchée") && erreur == false) {
                var SiteSinistreRep = MessageBox.Show("Le champ 'Zone touchée ?' est vide ! Voulez-vous continuez ?", "Champ vide ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (SiteSinistreRep != DialogResult.Yes) { erreur = true; }
            }
            if (rtxtRemarques.TextLength <= 0 && erreur == false)
            {
                var rtxtRemarquesRep = MessageBox.Show("Le champ 'Remarque' est vide ! Voulez-vous continuez ?", "Champ vide ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rtxtRemarquesRep != DialogResult.Yes) { erreur = true; }
            }
            #endregion Verification des champs

            #region Validation de l'alerte
            //Si il y a aucune erreur, on lance l'alerte
            if (erreur == false && alerte == false)
            {
                //Affiche le message que l'alerte à bien été envoyé
                MessageBox.Show("L'alerte a été envoyée !", "Envoyée !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                //on verrouille tous les champs necessaire qui ne doivent pas être modifier
                txtQui.Enabled = false;
                lstTypeInter.Enabled = false;
                SiteSinistre.Enabled = false;
                txtLieu.Enabled = false;
                rtxtRemarques.Enabled = false;
                lstSDIS.Enabled = false;
                btnTrain.Enabled = false;
                btnQuittance.Text = "Terminer l'intervention";
                alerte = true;

                //TO DO : mettre la requete pour la base de données
            }

            //Si l'alerte est déjà envoyé et qu'il y a aucune erreur dans les champs
            else if (erreur == false && alerte == true)
            {
                //Et si le status est défini sur Terminée ou Annulée, on reactive tout les champs et les remets à zéro pour être prêt à lancer une nouvelle alerte
                if (txtStatus.Text == "Terminée !" || txtStatus.Text == "Annulée !")
                {
                    MessageBox.Show("L'intervention sur les lieux est terminer.", "Terminer !", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtQui.Enabled = true;
                    txtQui.Text = "";
                    lstTypeInter.Enabled = true;
                    lstTypeInter.Text = "";
                    SiteSinistre.Enabled = true;
                    SiteSinistre.Text = "";
                    txtLieu.Enabled = true;
                    txtLieu.Text = "";
                    rtxtRemarques.Enabled = true;
                    rtxtRemarques.Text = "";
                    lstSDIS.Enabled = true;
                    rtxtRemarques.Text = "";
                    btnTrain.Enabled = true;
                    lstTypeInter.SelectedIndex = -1;
                    lstSDIS.SelectedIndex = -1;
                    lstEngagement.Items.Clear();
                    SiteSinistre.Text = "Zone touchée";
                    SiteSinistre.ForeColor = Color.Gray;
                    btnQuittance.Text = "Quittancer";
                    alerte = false;

                    //TO DO : mettre la requette pour la base de données
                }
                //sinon, renvoie un message d'erreur
                else
                {
                    MessageBox.Show("Le status de l'intervention n'est pas terminée ou annulée.", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            #endregion Validation de l'alerte
        }

        private void lstSDIS_SelectedIndexChanged(object sender, EventArgs e)
        {
            //afficher la liste des personnes engagées selon le SDIS sélectionné (exemple pour les 2 premiers)
            //TO DO : à adapter Avec la DB
            #region Liste des personnes des SDIS
            if (lstSDIS.SelectedIndex == 0)
            {
                lstEngagement.Items.Clear();
                lstEngagement.Items.Add("Paul Cherer");
                lstEngagement.Items.Add("Jean-Loup Ferrari");
                lstEngagement.Items.Add("Jean-jean Jean");
                lstEngagement.Items.Add("David Lafarche");
                lstEngagement.Items.Add("Pierre Terter");
                lstEngagement.Items.Add("Bidule Chose");
            }

            if (lstSDIS.SelectedIndex == 1)
            {
                lstEngagement.Items.Clear();
                lstEngagement.Items.Add("Benoit Mouttier");
                lstEngagement.Items.Add("Sacha PIEEEEEERE");
            }
            #endregion Liste des personnes des SDIS
        }

        #region Focus hover
        //Si le focus est sur SiteSinistre
        private void SiteSinistre_Enter(object sender, EventArgs e)
        {
            if (SiteSinistre.Text == "Zone touchée")
            {
                SiteSinistre.Text = "";
            }
            SiteSinistre.ForeColor = Color.Black;
        }

        //Si le focus n'est plus sur SiteSinistre
        private void SiteSinistre_Leave(object sender, EventArgs e)
        {
            //Si il n'y a rien :
            //Met du texte en gris du champ texte SiteSinistre (comme pour un hover en html)
            if (SiteSinistre.Text == "")
            {
                SiteSinistre.Text = "Zone touchée";
                SiteSinistre.ForeColor = Color.Gray;
            }
        }

        private void lstInterCourantes_Enter(object sender, EventArgs e)
        {
            if (lstInterCourantes.Text == "Status de l'intervention")
            {
                lstInterCourantes.Text = "";
            }
            lstInterCourantes.ForeColor = Color.Black;
        }
        #endregion Focus hover

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            if (lstInterCourantes.SelectedIndex >= 0)
            {
                txtStatus.Text = lstInterCourantes.SelectedItem.ToString();
                lstInterCourantes.SelectedIndex = -1;
            }
        }

        private void btnTonneP1000_Click(object sender, EventArgs e)
        {

        }
    }
}
