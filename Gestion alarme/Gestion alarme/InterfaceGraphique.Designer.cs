namespace Gestion_alarme
{
    partial class InterfaceGraphique
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfaceGraphique));
            this.txtQui = new System.Windows.Forms.TextBox();
            this.lblQui = new System.Windows.Forms.Label();
            this.lblTypeInter = new System.Windows.Forms.Label();
            this.lstTypeInter = new System.Windows.Forms.ComboBox();
            this.lblLieu = new System.Windows.Forms.Label();
            this.SiteSinistre = new System.Windows.Forms.TextBox();
            this.txtLieu = new System.Windows.Forms.TextBox();
            this.lblRemarques = new System.Windows.Forms.Label();
            this.rtxtRemarques = new System.Windows.Forms.RichTextBox();
            this.lstInterCourantes = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.lblAlarmeSDIS = new System.Windows.Forms.Label();
            this.lstSDIS = new System.Windows.Forms.ComboBox();
            this.lstEngagement = new System.Windows.Forms.ListBox();
            this.grpMoyens = new System.Windows.Forms.GroupBox();
            this.btnVMSR = new System.Windows.Forms.Button();
            this.btnVOfficier = new System.Windows.Forms.Button();
            this.btnVEchelle30D = new System.Windows.Forms.Button();
            this.btnVEchelle25S = new System.Windows.Forms.Button();
            this.btnVTransportPM = new System.Windows.Forms.Button();
            this.btnVTonneP6000 = new System.Windows.Forms.Button();
            this.btnVTonneP2000 = new System.Windows.Forms.Button();
            this.btnVTonneP1000 = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnQuittance = new System.Windows.Forms.Button();
            this.grpMoyens.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQui
            // 
            this.txtQui.Location = new System.Drawing.Point(118, 44);
            this.txtQui.Name = "txtQui";
            this.txtQui.Size = new System.Drawing.Size(136, 20);
            this.txtQui.TabIndex = 0;
            // 
            // lblQui
            // 
            this.lblQui.AutoSize = true;
            this.lblQui.Location = new System.Drawing.Point(80, 47);
            this.lblQui.Name = "lblQui";
            this.lblQui.Size = new System.Drawing.Size(32, 13);
            this.lblQui.TabIndex = 1;
            this.lblQui.Text = "Qui ?";
            // 
            // lblTypeInter
            // 
            this.lblTypeInter.AutoSize = true;
            this.lblTypeInter.Location = new System.Drawing.Point(15, 93);
            this.lblTypeInter.Name = "lblTypeInter";
            this.lblTypeInter.Size = new System.Drawing.Size(97, 13);
            this.lblTypeInter.TabIndex = 2;
            this.lblTypeInter.Text = "Type d\'intervention";
            // 
            // lstTypeInter
            // 
            this.lstTypeInter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTypeInter.FormattingEnabled = true;
            this.lstTypeInter.Location = new System.Drawing.Point(118, 90);
            this.lstTypeInter.Name = "lstTypeInter";
            this.lstTypeInter.Size = new System.Drawing.Size(136, 21);
            this.lstTypeInter.TabIndex = 3;
            // 
            // lblLieu
            // 
            this.lblLieu.AutoSize = true;
            this.lblLieu.Location = new System.Drawing.Point(85, 141);
            this.lblLieu.Name = "lblLieu";
            this.lblLieu.Size = new System.Drawing.Size(27, 13);
            this.lblLieu.TabIndex = 4;
            this.lblLieu.Text = "Lieu";
            // 
            // SiteSinistre
            // 
            this.SiteSinistre.Location = new System.Drawing.Point(260, 91);
            this.SiteSinistre.Name = "SiteSinistre";
            this.SiteSinistre.Size = new System.Drawing.Size(114, 20);
            this.SiteSinistre.TabIndex = 5;
            this.SiteSinistre.Text = "Zone touchée";
            this.SiteSinistre.Enter += new System.EventHandler(this.SiteSinistre_Enter);
            this.SiteSinistre.Leave += new System.EventHandler(this.SiteSinistre_Leave);
            // 
            // txtLieu
            // 
            this.txtLieu.Location = new System.Drawing.Point(118, 138);
            this.txtLieu.Name = "txtLieu";
            this.txtLieu.Size = new System.Drawing.Size(228, 20);
            this.txtLieu.TabIndex = 6;
            // 
            // lblRemarques
            // 
            this.lblRemarques.AutoSize = true;
            this.lblRemarques.Location = new System.Drawing.Point(51, 191);
            this.lblRemarques.Name = "lblRemarques";
            this.lblRemarques.Size = new System.Drawing.Size(61, 13);
            this.lblRemarques.TabIndex = 7;
            this.lblRemarques.Text = "Remarques";
            // 
            // rtxtRemarques
            // 
            this.rtxtRemarques.Location = new System.Drawing.Point(54, 207);
            this.rtxtRemarques.Name = "rtxtRemarques";
            this.rtxtRemarques.Size = new System.Drawing.Size(292, 181);
            this.rtxtRemarques.TabIndex = 8;
            this.rtxtRemarques.Text = "";
            // 
            // lstInterCourantes
            // 
            this.lstInterCourantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstInterCourantes.FormattingEnabled = true;
            this.lstInterCourantes.Location = new System.Drawing.Point(60, 477);
            this.lstInterCourantes.Name = "lstInterCourantes";
            this.lstInterCourantes.Size = new System.Drawing.Size(130, 21);
            this.lstInterCourantes.TabIndex = 9;
            this.lstInterCourantes.Enter += new System.EventHandler(this.lstInterCourantes_Enter);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(56, 410);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 20);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(60, 433);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 11;
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeStatus.Location = new System.Drawing.Point(216, 473);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(130, 27);
            this.btnChangeStatus.TabIndex = 12;
            this.btnChangeStatus.Text = "Changer le status";
            this.btnChangeStatus.UseVisualStyleBackColor = true;
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
            // 
            // lblAlarmeSDIS
            // 
            this.lblAlarmeSDIS.AutoSize = true;
            this.lblAlarmeSDIS.Location = new System.Drawing.Point(430, 47);
            this.lblAlarmeSDIS.Name = "lblAlarmeSDIS";
            this.lblAlarmeSDIS.Size = new System.Drawing.Size(70, 13);
            this.lblAlarmeSDIS.TabIndex = 13;
            this.lblAlarmeSDIS.Text = "Alarmer SDIS";
            // 
            // lstSDIS
            // 
            this.lstSDIS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstSDIS.DropDownWidth = 150;
            this.lstSDIS.FormattingEnabled = true;
            this.lstSDIS.Location = new System.Drawing.Point(506, 43);
            this.lstSDIS.Name = "lstSDIS";
            this.lstSDIS.Size = new System.Drawing.Size(137, 21);
            this.lstSDIS.TabIndex = 14;
            this.lstSDIS.SelectedIndexChanged += new System.EventHandler(this.lstSDIS_SelectedIndexChanged);
            // 
            // lstEngagement
            // 
            this.lstEngagement.FormattingEnabled = true;
            this.lstEngagement.Location = new System.Drawing.Point(433, 81);
            this.lstEngagement.Name = "lstEngagement";
            this.lstEngagement.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstEngagement.Size = new System.Drawing.Size(210, 199);
            this.lstEngagement.TabIndex = 15;
            // 
            // grpMoyens
            // 
            this.grpMoyens.Controls.Add(this.btnVMSR);
            this.grpMoyens.Controls.Add(this.btnVOfficier);
            this.grpMoyens.Controls.Add(this.btnVEchelle30D);
            this.grpMoyens.Controls.Add(this.btnVEchelle25S);
            this.grpMoyens.Controls.Add(this.btnVTransportPM);
            this.grpMoyens.Controls.Add(this.btnVTonneP6000);
            this.grpMoyens.Controls.Add(this.btnVTonneP2000);
            this.grpMoyens.Controls.Add(this.btnVTonneP1000);
            this.grpMoyens.Location = new System.Drawing.Point(684, 44);
            this.grpMoyens.Name = "grpMoyens";
            this.grpMoyens.Size = new System.Drawing.Size(332, 296);
            this.grpMoyens.TabIndex = 16;
            this.grpMoyens.TabStop = false;
            this.grpMoyens.Text = "Moyens disponibles";
            // 
            // btnVMSR
            // 
            this.btnVMSR.BackgroundImage = global::Gestion_alarme.Properties.Resources.MSR;
            this.btnVMSR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVMSR.Location = new System.Drawing.Point(145, 220);
            this.btnVMSR.Name = "btnVMSR";
            this.btnVMSR.Size = new System.Drawing.Size(133, 61);
            this.btnVMSR.TabIndex = 7;
            this.btnVMSR.UseVisualStyleBackColor = true;
            // 
            // btnVOfficier
            // 
            this.btnVOfficier.BackgroundImage = global::Gestion_alarme.Properties.Resources.Officier;
            this.btnVOfficier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVOfficier.Location = new System.Drawing.Point(6, 220);
            this.btnVOfficier.Name = "btnVOfficier";
            this.btnVOfficier.Size = new System.Drawing.Size(133, 61);
            this.btnVOfficier.TabIndex = 6;
            this.btnVOfficier.UseVisualStyleBackColor = true;
            // 
            // btnVEchelle30D
            // 
            this.btnVEchelle30D.BackgroundImage = global::Gestion_alarme.Properties.Resources.Echelle30Double;
            this.btnVEchelle30D.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVEchelle30D.Location = new System.Drawing.Point(145, 153);
            this.btnVEchelle30D.Name = "btnVEchelle30D";
            this.btnVEchelle30D.Size = new System.Drawing.Size(133, 61);
            this.btnVEchelle30D.TabIndex = 5;
            this.btnVEchelle30D.UseVisualStyleBackColor = true;
            // 
            // btnVEchelle25S
            // 
            this.btnVEchelle25S.BackgroundImage = global::Gestion_alarme.Properties.Resources.Echelle25Simple;
            this.btnVEchelle25S.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVEchelle25S.Location = new System.Drawing.Point(6, 153);
            this.btnVEchelle25S.Name = "btnVEchelle25S";
            this.btnVEchelle25S.Size = new System.Drawing.Size(133, 61);
            this.btnVEchelle25S.TabIndex = 4;
            this.btnVEchelle25S.UseVisualStyleBackColor = true;
            // 
            // btnVTransportPM
            // 
            this.btnVTransportPM.BackgroundImage = global::Gestion_alarme.Properties.Resources.TPM;
            this.btnVTransportPM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVTransportPM.Location = new System.Drawing.Point(145, 86);
            this.btnVTransportPM.Name = "btnVTransportPM";
            this.btnVTransportPM.Size = new System.Drawing.Size(133, 61);
            this.btnVTransportPM.TabIndex = 3;
            this.btnVTransportPM.UseVisualStyleBackColor = true;
            // 
            // btnVTonneP6000
            // 
            this.btnVTonneP6000.BackgroundImage = global::Gestion_alarme.Properties.Resources.TP6000;
            this.btnVTonneP6000.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVTonneP6000.Location = new System.Drawing.Point(6, 86);
            this.btnVTonneP6000.Name = "btnVTonneP6000";
            this.btnVTonneP6000.Size = new System.Drawing.Size(133, 61);
            this.btnVTonneP6000.TabIndex = 2;
            this.btnVTonneP6000.UseVisualStyleBackColor = true;
            // 
            // btnVTonneP2000
            // 
            this.btnVTonneP2000.BackgroundImage = global::Gestion_alarme.Properties.Resources.TP2000;
            this.btnVTonneP2000.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVTonneP2000.Location = new System.Drawing.Point(145, 19);
            this.btnVTonneP2000.Name = "btnVTonneP2000";
            this.btnVTonneP2000.Size = new System.Drawing.Size(133, 61);
            this.btnVTonneP2000.TabIndex = 1;
            this.btnVTonneP2000.UseVisualStyleBackColor = true;
            // 
            // btnVTonneP1000
            // 
            this.btnVTonneP1000.BackgroundImage = global::Gestion_alarme.Properties.Resources.TP1000;
            this.btnVTonneP1000.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVTonneP1000.Location = new System.Drawing.Point(6, 19);
            this.btnVTonneP1000.Name = "btnVTonneP1000";
            this.btnVTonneP1000.Size = new System.Drawing.Size(133, 61);
            this.btnVTonneP1000.TabIndex = 0;
            this.btnVTonneP1000.UseVisualStyleBackColor = true;
            this.btnVTonneP1000.Click += new System.EventHandler(this.btnTonneP1000_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrain.Location = new System.Drawing.Point(684, 356);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(183, 23);
            this.btnTrain.TabIndex = 17;
            this.btnTrain.Text = "Mobiliser le train d\'intervention";
            this.btnTrain.UseVisualStyleBackColor = true;
            // 
            // btnQuittance
            // 
            this.btnQuittance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuittance.Location = new System.Drawing.Point(54, 552);
            this.btnQuittance.Name = "btnQuittance";
            this.btnQuittance.Size = new System.Drawing.Size(962, 38);
            this.btnQuittance.TabIndex = 18;
            this.btnQuittance.Text = "Quittancer";
            this.btnQuittance.UseVisualStyleBackColor = true;
            this.btnQuittance.Click += new System.EventHandler(this.btnQuittance_Click);
            // 
            // InterfaceGraphique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 602);
            this.Controls.Add(this.btnQuittance);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.grpMoyens);
            this.Controls.Add(this.lstEngagement);
            this.Controls.Add(this.lstSDIS);
            this.Controls.Add(this.lblAlarmeSDIS);
            this.Controls.Add(this.btnChangeStatus);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lstInterCourantes);
            this.Controls.Add(this.rtxtRemarques);
            this.Controls.Add(this.lblRemarques);
            this.Controls.Add(this.txtLieu);
            this.Controls.Add(this.SiteSinistre);
            this.Controls.Add(this.lblLieu);
            this.Controls.Add(this.lstTypeInter);
            this.Controls.Add(this.lblTypeInter);
            this.Controls.Add(this.lblQui);
            this.Controls.Add(this.txtQui);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InterfaceGraphique";
            this.Text = "Gestion d\'alarme";
            this.grpMoyens.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQui;
        private System.Windows.Forms.Label lblQui;
        private System.Windows.Forms.Label lblTypeInter;
        private System.Windows.Forms.ComboBox lstTypeInter;
        private System.Windows.Forms.Label lblLieu;
        private System.Windows.Forms.TextBox SiteSinistre;
        private System.Windows.Forms.TextBox txtLieu;
        private System.Windows.Forms.Label lblRemarques;
        private System.Windows.Forms.RichTextBox rtxtRemarques;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnChangeStatus;
        private System.Windows.Forms.Label lblAlarmeSDIS;
        private System.Windows.Forms.ComboBox lstSDIS;
        private System.Windows.Forms.ListBox lstEngagement;
        private System.Windows.Forms.GroupBox grpMoyens;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnQuittance;
        private System.Windows.Forms.ComboBox lstInterCourantes;
        private System.Windows.Forms.Button btnVTonneP1000;
        private System.Windows.Forms.Button btnVMSR;
        private System.Windows.Forms.Button btnVOfficier;
        private System.Windows.Forms.Button btnVEchelle30D;
        private System.Windows.Forms.Button btnVEchelle25S;
        private System.Windows.Forms.Button btnVTransportPM;
        private System.Windows.Forms.Button btnVTonneP6000;
        private System.Windows.Forms.Button btnVTonneP2000;
    }
}

