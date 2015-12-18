namespace LAB2_SGBD
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddNewStep = new System.Windows.Forms.Button();
            this.txtTransport = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPunct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNrPasilor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodRetur = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstCalatorii = new System.Windows.Forms.ListBox();
            this.connection = new System.Data.SqlClient.SqlConnection();
            this.command = new System.Data.SqlClient.SqlCommand();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRaport = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btnAddNewStep);
            this.groupBox1.Controls.Add(this.txtTransport);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPunct);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNume);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adauga un nou pas";
            // 
            // btnAddNewStep
            // 
            this.btnAddNewStep.Location = new System.Drawing.Point(9, 175);
            this.btnAddNewStep.Name = "btnAddNewStep";
            this.btnAddNewStep.Size = new System.Drawing.Size(106, 23);
            this.btnAddNewStep.TabIndex = 8;
            this.btnAddNewStep.Text = "Adauga pas";
            this.btnAddNewStep.UseVisualStyleBackColor = true;
            this.btnAddNewStep.Click += new System.EventHandler(this.btnAddNewStep_Click);
            // 
            // txtTransport
            // 
            this.txtTransport.Location = new System.Drawing.Point(9, 149);
            this.txtTransport.Name = "txtTransport";
            this.txtTransport.Size = new System.Drawing.Size(106, 20);
            this.txtTransport.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Transport:";
            // 
            // txtPunct
            // 
            this.txtPunct.Location = new System.Drawing.Point(9, 110);
            this.txtPunct.Name = "txtPunct";
            this.txtPunct.Size = new System.Drawing.Size(106, 20);
            this.txtPunct.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Punct:";
            // 
            // txtPas
            // 
            this.txtPas.Location = new System.Drawing.Point(9, 71);
            this.txtPas.Name = "txtPas";
            this.txtPas.Size = new System.Drawing.Size(106, 20);
            this.txtPas.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pas:";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(9, 32);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(106, 20);
            this.txtNume.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Numarul pasilor:";
            // 
            // txtNrPasilor
            // 
            this.txtNrPasilor.Location = new System.Drawing.Point(92, 224);
            this.txtNrPasilor.Name = "txtNrPasilor";
            this.txtNrPasilor.Size = new System.Drawing.Size(43, 20);
            this.txtNrPasilor.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Codul returnat:";
            // 
            // txtCodRetur
            // 
            this.txtCodRetur.Location = new System.Drawing.Point(92, 251);
            this.txtCodRetur.Name = "txtCodRetur";
            this.txtCodRetur.Size = new System.Drawing.Size(43, 20);
            this.txtCodRetur.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstCalatorii);
            this.groupBox2.Location = new System.Drawing.Point(150, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 381);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista calatoriilor";
            // 
            // lstCalatorii
            // 
            this.lstCalatorii.FormattingEnabled = true;
            this.lstCalatorii.Location = new System.Drawing.Point(6, 16);
            this.lstCalatorii.Name = "lstCalatorii";
            this.lstCalatorii.Size = new System.Drawing.Size(193, 355);
            this.lstCalatorii.TabIndex = 0;
            // 
            // connection
            // 
            this.connection.ConnectionString = "Data Source=(localdb)\\v11.0;Initial Catalog=nume;Integrated Security=True";
            this.connection.FireInfoMessageEventOnUserErrors = false;
            this.connection.InfoMessage += new System.Data.SqlClient.SqlInfoMessageEventHandler(this.connection_InfoMessage);
            // 
            // command
            // 
            this.command.Connection = this.connection;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.btnRaport);
            this.groupBox3.Location = new System.Drawing.Point(12, 286);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(123, 50);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Generare raport";
            // 
            // btnRaport
            // 
            this.btnRaport.Location = new System.Drawing.Point(6, 19);
            this.btnRaport.Name = "btnRaport";
            this.btnRaport.Size = new System.Drawing.Size(109, 23);
            this.btnRaport.TabIndex = 0;
            this.btnRaport.Text = "Genereaza";
            this.btnRaport.UseVisualStyleBackColor = true;
            this.btnRaport.Click += new System.EventHandler(this.btnRaport_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(12, 342);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(123, 51);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Generare statistici";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Genereaza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 400);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtCodRetur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNrPasilor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTransport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPunct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNrPasilor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodRetur;
        private System.Windows.Forms.Button btnAddNewStep;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstCalatorii;
        private System.Data.SqlClient.SqlConnection connection;
        private System.Data.SqlClient.SqlCommand command;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRaport;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
    }
}

