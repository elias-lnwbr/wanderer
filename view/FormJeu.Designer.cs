﻿
namespace Wanderer.view
{
    partial class FormJeu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJeu));
            this.pbAide = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbPersonnes = new System.Windows.Forms.PictureBox();
            this.btnUsine = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnRefuge = new System.Windows.Forms.Button();
            this.btnChemin = new System.Windows.Forms.Button();
            this.btnClub = new System.Windows.Forms.Button();
            this.mapView1 = new Wanderer.view.Controls.MapView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblJoueur = new System.Windows.Forms.Label();
            this.lblArgent = new System.Windows.Forms.Label();
            this.lblMarcheur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAide)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonnes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAide
            // 
            this.pbAide.Image = ((System.Drawing.Image)(resources.GetObject("pbAide.Image")));
            this.pbAide.Location = new System.Drawing.Point(8, 10);
            this.pbAide.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbAide.Name = "pbAide";
            this.pbAide.Size = new System.Drawing.Size(46, 42);
            this.pbAide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAide.TabIndex = 0;
            this.pbAide.TabStop = false;
            this.pbAide.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMarcheur);
            this.panel1.Controls.Add(this.lblArgent);
            this.panel1.Controls.Add(this.lblJoueur);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pbAide);
            this.panel1.Controls.Add(this.pbPersonnes);
            this.panel1.Location = new System.Drawing.Point(29, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1218, 60);
            this.panel1.TabIndex = 1;
            // 
            // pbPersonnes
            // 
            this.pbPersonnes.Image = ((System.Drawing.Image)(resources.GetObject("pbPersonnes.Image")));
            this.pbPersonnes.Location = new System.Drawing.Point(1048, 19);
            this.pbPersonnes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbPersonnes.Name = "pbPersonnes";
            this.pbPersonnes.Size = new System.Drawing.Size(32, 33);
            this.pbPersonnes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPersonnes.TabIndex = 10;
            this.pbPersonnes.TabStop = false;
            // 
            // btnUsine
            // 
            this.btnUsine.BackColor = System.Drawing.Color.Transparent;
            this.btnUsine.FlatAppearance.BorderSize = 2;
            this.btnUsine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnUsine.ForeColor = System.Drawing.Color.White;
            this.btnUsine.Image = ((System.Drawing.Image)(resources.GetObject("btnUsine.Image")));
            this.btnUsine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsine.Location = new System.Drawing.Point(1080, 603);
            this.btnUsine.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsine.Name = "btnUsine";
            this.btnUsine.Size = new System.Drawing.Size(167, 77);
            this.btnUsine.TabIndex = 5;
            this.btnUsine.Text = "Usine";
            this.btnUsine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsine.UseVisualStyleBackColor = false;
            this.btnUsine.Click += new System.EventHandler(this.btnUsine_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.BackColor = System.Drawing.Color.Transparent;
            this.btnTrain.FlatAppearance.BorderSize = 2;
            this.btnTrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnTrain.ForeColor = System.Drawing.Color.White;
            this.btnTrain.Image = ((System.Drawing.Image)(resources.GetObject("btnTrain.Image")));
            this.btnTrain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrain.Location = new System.Drawing.Point(819, 603);
            this.btnTrain.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(167, 77);
            this.btnTrain.TabIndex = 6;
            this.btnTrain.Text = "Train";
            this.btnTrain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrain.UseVisualStyleBackColor = false;
            this.btnTrain.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRefuge
            // 
            this.btnRefuge.BackColor = System.Drawing.Color.Transparent;
            this.btnRefuge.FlatAppearance.BorderSize = 2;
            this.btnRefuge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefuge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnRefuge.ForeColor = System.Drawing.Color.White;
            this.btnRefuge.Image = ((System.Drawing.Image)(resources.GetObject("btnRefuge.Image")));
            this.btnRefuge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefuge.Location = new System.Drawing.Point(29, 603);
            this.btnRefuge.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefuge.Name = "btnRefuge";
            this.btnRefuge.Size = new System.Drawing.Size(167, 77);
            this.btnRefuge.TabIndex = 7;
            this.btnRefuge.Text = "Refuge";
            this.btnRefuge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefuge.UseVisualStyleBackColor = false;
            this.btnRefuge.Click += new System.EventHandler(this.btnRefuge_Click);
            // 
            // btnChemin
            // 
            this.btnChemin.BackColor = System.Drawing.Color.Transparent;
            this.btnChemin.FlatAppearance.BorderSize = 2;
            this.btnChemin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChemin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnChemin.ForeColor = System.Drawing.Color.White;
            this.btnChemin.Image = ((System.Drawing.Image)(resources.GetObject("btnChemin.Image")));
            this.btnChemin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChemin.Location = new System.Drawing.Point(281, 603);
            this.btnChemin.Margin = new System.Windows.Forms.Padding(2);
            this.btnChemin.Name = "btnChemin";
            this.btnChemin.Size = new System.Drawing.Size(167, 77);
            this.btnChemin.TabIndex = 8;
            this.btnChemin.Text = "Chemins";
            this.btnChemin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChemin.UseVisualStyleBackColor = false;
            // 
            // btnClub
            // 
            this.btnClub.BackColor = System.Drawing.Color.Transparent;
            this.btnClub.FlatAppearance.BorderSize = 2;
            this.btnClub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnClub.ForeColor = System.Drawing.Color.White;
            this.btnClub.Image = ((System.Drawing.Image)(resources.GetObject("btnClub.Image")));
            this.btnClub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClub.Location = new System.Drawing.Point(556, 603);
            this.btnClub.Margin = new System.Windows.Forms.Padding(2);
            this.btnClub.Name = "btnClub";
            this.btnClub.Size = new System.Drawing.Size(167, 77);
            this.btnClub.TabIndex = 9;
            this.btnClub.Text = "Club";
            this.btnClub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClub.UseVisualStyleBackColor = false;
            // 
            // mapView1
            // 
            this.mapView1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mapView1.BackgroundImage")));
            this.mapView1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mapView1.ColumnCount = 2;
            this.mapView1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mapView1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mapView1.Location = new System.Drawing.Point(29, 93);
            this.mapView1.Margin = new System.Windows.Forms.Padding(2);
            this.mapView1.Name = "mapView1";
            this.mapView1.RowCount = 2;
            this.mapView1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mapView1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mapView1.Size = new System.Drawing.Size(1218, 488);
            this.mapView1.TabIndex = 11;
            this.mapView1.Paint += new System.Windows.Forms.PaintEventHandler(this.mapView1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(831, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblJoueur
            // 
            this.lblJoueur.AutoSize = true;
            this.lblJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblJoueur.Location = new System.Drawing.Point(541, 10);
            this.lblJoueur.Name = "lblJoueur";
            this.lblJoueur.Size = new System.Drawing.Size(142, 46);
            this.lblJoueur.TabIndex = 12;
            this.lblJoueur.Text = "Joueur";
            this.lblJoueur.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblArgent
            // 
            this.lblArgent.AutoSize = true;
            this.lblArgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblArgent.Location = new System.Drawing.Point(868, 24);
            this.lblArgent.Name = "lblArgent";
            this.lblArgent.Size = new System.Drawing.Size(70, 25);
            this.lblArgent.TabIndex = 13;
            this.lblArgent.Text = "Argent";
            // 
            // lblMarcheur
            // 
            this.lblMarcheur.AutoSize = true;
            this.lblMarcheur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblMarcheur.Location = new System.Drawing.Point(1085, 24);
            this.lblMarcheur.Name = "lblMarcheur";
            this.lblMarcheur.Size = new System.Drawing.Size(105, 25);
            this.lblMarcheur.TabIndex = 14;
            this.lblMarcheur.Text = "Marcheurs";
            // 
            // FormJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1280, 700);
            this.Controls.Add(this.mapView1);
            this.Controls.Add(this.btnClub);
            this.Controls.Add(this.btnChemin);
            this.Controls.Add(this.btnRefuge);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.btnUsine);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormJeu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormJeu";
            ((System.ComponentModel.ISupportInitialize)(this.pbAide)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonnes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAide;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUsine;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnRefuge;
        private System.Windows.Forms.Button btnChemin;
        private System.Windows.Forms.Button btnClub;
        private System.Windows.Forms.PictureBox pbPersonnes;
        private Controls.MapView mapView1;
        private System.Windows.Forms.Label lblJoueur;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMarcheur;
        private System.Windows.Forms.Label lblArgent;
    }
}