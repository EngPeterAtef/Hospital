﻿namespace Hospital
{
    partial class Serve
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
            this.Serve_btn = new System.Windows.Forms.Button();
            this.RoomNo_lbl = new System.Windows.Forms.Label();
            this.ID_lbl = new System.Windows.Forms.Label();
            this.ID_cmb = new System.Windows.Forms.ComboBox();
            this.RoomNumber_cmb = new System.Windows.Forms.ComboBox();
            this.Serve_gb = new System.Windows.Forms.GroupBox();
            this.Name_cmb = new System.Windows.Forms.ComboBox();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.DontServe_gb = new System.Windows.Forms.GroupBox();
            this.DontName_cmb = new System.Windows.Forms.ComboBox();
            this.DontName_lbl = new System.Windows.Forms.Label();
            this.DontRoomNumber_cmb = new System.Windows.Forms.ComboBox();
            this.DontID_cmb = new System.Windows.Forms.ComboBox();
            this.DontServe_btn = new System.Windows.Forms.Button();
            this.DontID_lbl = new System.Windows.Forms.Label();
            this.DontRoomNumber_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Serve_gb.SuspendLayout();
            this.DontServe_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // Serve_btn
            // 
            this.Serve_btn.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Serve_btn.ForeColor = System.Drawing.Color.Black;
            this.Serve_btn.Location = new System.Drawing.Point(146, 208);
            this.Serve_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Serve_btn.Name = "Serve_btn";
            this.Serve_btn.Size = new System.Drawing.Size(249, 47);
            this.Serve_btn.TabIndex = 33;
            this.Serve_btn.Text = "Serve";
            this.Serve_btn.UseVisualStyleBackColor = true;
            this.Serve_btn.Click += new System.EventHandler(this.Serve_btn_Click);
            // 
            // RoomNo_lbl
            // 
            this.RoomNo_lbl.AutoSize = true;
            this.RoomNo_lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.RoomNo_lbl.ForeColor = System.Drawing.Color.Black;
            this.RoomNo_lbl.Location = new System.Drawing.Point(35, 162);
            this.RoomNo_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RoomNo_lbl.Name = "RoomNo_lbl";
            this.RoomNo_lbl.Size = new System.Drawing.Size(79, 20);
            this.RoomNo_lbl.TabIndex = 29;
            this.RoomNo_lbl.Text = "Room#";
            // 
            // ID_lbl
            // 
            this.ID_lbl.AutoSize = true;
            this.ID_lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.ID_lbl.ForeColor = System.Drawing.Color.Black;
            this.ID_lbl.Location = new System.Drawing.Point(35, 94);
            this.ID_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID_lbl.Name = "ID_lbl";
            this.ID_lbl.Size = new System.Drawing.Size(32, 20);
            this.ID_lbl.TabIndex = 27;
            this.ID_lbl.Text = "ID";
            // 
            // ID_cmb
            // 
            this.ID_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ID_cmb.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.ID_cmb.FormattingEnabled = true;
            this.ID_cmb.Location = new System.Drawing.Point(186, 85);
            this.ID_cmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ID_cmb.Name = "ID_cmb";
            this.ID_cmb.Size = new System.Drawing.Size(252, 28);
            this.ID_cmb.TabIndex = 26;
            // 
            // RoomNumber_cmb
            // 
            this.RoomNumber_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoomNumber_cmb.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.RoomNumber_cmb.FormattingEnabled = true;
            this.RoomNumber_cmb.Location = new System.Drawing.Point(186, 154);
            this.RoomNumber_cmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RoomNumber_cmb.Name = "RoomNumber_cmb";
            this.RoomNumber_cmb.Size = new System.Drawing.Size(252, 28);
            this.RoomNumber_cmb.TabIndex = 34;
            // 
            // Serve_gb
            // 
            this.Serve_gb.Controls.Add(this.Name_cmb);
            this.Serve_gb.Controls.Add(this.Name_lbl);
            this.Serve_gb.Controls.Add(this.RoomNumber_cmb);
            this.Serve_gb.Controls.Add(this.ID_cmb);
            this.Serve_gb.Controls.Add(this.Serve_btn);
            this.Serve_gb.Controls.Add(this.ID_lbl);
            this.Serve_gb.Controls.Add(this.RoomNo_lbl);
            this.Serve_gb.Location = new System.Drawing.Point(52, 68);
            this.Serve_gb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Serve_gb.Name = "Serve_gb";
            this.Serve_gb.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Serve_gb.Size = new System.Drawing.Size(479, 303);
            this.Serve_gb.TabIndex = 35;
            this.Serve_gb.TabStop = false;
            this.Serve_gb.Text = "Serve";
            // 
            // Name_cmb
            // 
            this.Name_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Name_cmb.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Name_cmb.FormattingEnabled = true;
            this.Name_cmb.Location = new System.Drawing.Point(186, 26);
            this.Name_cmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name_cmb.Name = "Name_cmb";
            this.Name_cmb.Size = new System.Drawing.Size(252, 28);
            this.Name_cmb.TabIndex = 37;
            this.Name_cmb.TextChanged += new System.EventHandler(this.Name_cmb_TextChanged);
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Name_lbl.ForeColor = System.Drawing.Color.Black;
            this.Name_lbl.Location = new System.Drawing.Point(35, 34);
            this.Name_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(63, 20);
            this.Name_lbl.TabIndex = 36;
            this.Name_lbl.Text = "Name";
            // 
            // DontServe_gb
            // 
            this.DontServe_gb.Controls.Add(this.DontName_cmb);
            this.DontServe_gb.Controls.Add(this.DontName_lbl);
            this.DontServe_gb.Controls.Add(this.DontRoomNumber_cmb);
            this.DontServe_gb.Controls.Add(this.DontID_cmb);
            this.DontServe_gb.Controls.Add(this.DontServe_btn);
            this.DontServe_gb.Controls.Add(this.DontID_lbl);
            this.DontServe_gb.Controls.Add(this.DontRoomNumber_lbl);
            this.DontServe_gb.Location = new System.Drawing.Point(566, 68);
            this.DontServe_gb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DontServe_gb.Name = "DontServe_gb";
            this.DontServe_gb.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DontServe_gb.Size = new System.Drawing.Size(488, 303);
            this.DontServe_gb.TabIndex = 36;
            this.DontServe_gb.TabStop = false;
            this.DontServe_gb.Text = "DontServe";
            // 
            // DontName_cmb
            // 
            this.DontName_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DontName_cmb.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.DontName_cmb.FormattingEnabled = true;
            this.DontName_cmb.Location = new System.Drawing.Point(172, 31);
            this.DontName_cmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DontName_cmb.Name = "DontName_cmb";
            this.DontName_cmb.Size = new System.Drawing.Size(252, 28);
            this.DontName_cmb.TabIndex = 37;
            this.DontName_cmb.TextChanged += new System.EventHandler(this.DontName_cmb_TextChanged);
            // 
            // DontName_lbl
            // 
            this.DontName_lbl.AutoSize = true;
            this.DontName_lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.DontName_lbl.ForeColor = System.Drawing.Color.Black;
            this.DontName_lbl.Location = new System.Drawing.Point(45, 34);
            this.DontName_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DontName_lbl.Name = "DontName_lbl";
            this.DontName_lbl.Size = new System.Drawing.Size(63, 20);
            this.DontName_lbl.TabIndex = 36;
            this.DontName_lbl.Text = "Name";
            // 
            // DontRoomNumber_cmb
            // 
            this.DontRoomNumber_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DontRoomNumber_cmb.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.DontRoomNumber_cmb.FormattingEnabled = true;
            this.DontRoomNumber_cmb.Location = new System.Drawing.Point(172, 164);
            this.DontRoomNumber_cmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DontRoomNumber_cmb.Name = "DontRoomNumber_cmb";
            this.DontRoomNumber_cmb.Size = new System.Drawing.Size(252, 28);
            this.DontRoomNumber_cmb.TabIndex = 34;
            // 
            // DontID_cmb
            // 
            this.DontID_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DontID_cmb.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.DontID_cmb.FormattingEnabled = true;
            this.DontID_cmb.Location = new System.Drawing.Point(172, 90);
            this.DontID_cmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DontID_cmb.Name = "DontID_cmb";
            this.DontID_cmb.Size = new System.Drawing.Size(252, 28);
            this.DontID_cmb.TabIndex = 26;
            // 
            // DontServe_btn
            // 
            this.DontServe_btn.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.DontServe_btn.ForeColor = System.Drawing.Color.Black;
            this.DontServe_btn.Location = new System.Drawing.Point(146, 218);
            this.DontServe_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DontServe_btn.Name = "DontServe_btn";
            this.DontServe_btn.Size = new System.Drawing.Size(249, 47);
            this.DontServe_btn.TabIndex = 33;
            this.DontServe_btn.Text = "Don\'t Serve";
            this.DontServe_btn.UseVisualStyleBackColor = true;
            this.DontServe_btn.Click += new System.EventHandler(this.DontServe_btn_Click);
            // 
            // DontID_lbl
            // 
            this.DontID_lbl.AutoSize = true;
            this.DontID_lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.DontID_lbl.ForeColor = System.Drawing.Color.Black;
            this.DontID_lbl.Location = new System.Drawing.Point(45, 94);
            this.DontID_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DontID_lbl.Name = "DontID_lbl";
            this.DontID_lbl.Size = new System.Drawing.Size(32, 20);
            this.DontID_lbl.TabIndex = 27;
            this.DontID_lbl.Text = "ID";
            // 
            // DontRoomNumber_lbl
            // 
            this.DontRoomNumber_lbl.AutoSize = true;
            this.DontRoomNumber_lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.DontRoomNumber_lbl.ForeColor = System.Drawing.Color.Black;
            this.DontRoomNumber_lbl.Location = new System.Drawing.Point(45, 167);
            this.DontRoomNumber_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DontRoomNumber_lbl.Name = "DontRoomNumber_lbl";
            this.DontRoomNumber_lbl.Size = new System.Drawing.Size(79, 20);
            this.DontRoomNumber_lbl.TabIndex = 29;
            this.DontRoomNumber_lbl.Text = "Room#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(273, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 32);
            this.label2.TabIndex = 37;
            this.label2.Text = "Serve";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(745, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 32);
            this.label1.TabIndex = 38;
            this.label1.Text = "Do not serve";
            // 
            // Serve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DontServe_gb);
            this.Controls.Add(this.Serve_gb);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Serve";
            this.Text = "Serve";
            this.Load += new System.EventHandler(this.Serve_Load);
            this.Serve_gb.ResumeLayout(false);
            this.Serve_gb.PerformLayout();
            this.DontServe_gb.ResumeLayout(false);
            this.DontServe_gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Serve_btn;
        private System.Windows.Forms.Label RoomNo_lbl;
        private System.Windows.Forms.Label ID_lbl;
        private System.Windows.Forms.ComboBox ID_cmb;
        private System.Windows.Forms.ComboBox RoomNumber_cmb;
        private System.Windows.Forms.GroupBox Serve_gb;
        private System.Windows.Forms.GroupBox DontServe_gb;
        private System.Windows.Forms.ComboBox DontRoomNumber_cmb;
        private System.Windows.Forms.ComboBox DontID_cmb;
        private System.Windows.Forms.Button DontServe_btn;
        private System.Windows.Forms.Label DontID_lbl;
        private System.Windows.Forms.Label DontRoomNumber_lbl;
        private System.Windows.Forms.ComboBox Name_cmb;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.ComboBox DontName_cmb;
        private System.Windows.Forms.Label DontName_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}