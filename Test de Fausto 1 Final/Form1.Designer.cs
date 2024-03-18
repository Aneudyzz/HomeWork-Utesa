using Test_de_Fausto_1;
using System.Windows.Forms;
namespace Test_de_Fausto_1

{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pausa_c1_reload = new System.Windows.Forms.Button();
            this.detener_c1 = new System.Windows.Forms.Button();
            this.pausa_c2 = new System.Windows.Forms.Button();
            this.detener_c2 = new System.Windows.Forms.Button();
            this.pausa_c3 = new System.Windows.Forms.Button();
            this.detener_c3 = new System.Windows.Forms.Button();
            this.pausa_c4 = new System.Windows.Forms.Button();
            this.detener_c4 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
            this.listView4 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.limite_btn = new System.Windows.Forms.Button();
            this.limpiar_btn1 = new System.Windows.Forms.Button();
            this.reanudar_c1 = new System.Windows.Forms.Button();
            this.reanudar_c2 = new System.Windows.Forms.Button();
            this.reanudar_c3 = new System.Windows.Forms.Button();
            this.reanudar_c4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // pausa_c1_reload
            // 
            this.pausa_c1_reload.Location = new System.Drawing.Point(56, 235);
            this.pausa_c1_reload.Name = "pausa_c1_reload";
            this.pausa_c1_reload.Size = new System.Drawing.Size(75, 23);
            this.pausa_c1_reload.TabIndex = 1;
            this.pausa_c1_reload.Text = "Pausa";
            this.pausa_c1_reload.UseVisualStyleBackColor = true;
            this.pausa_c1_reload.Click += new System.EventHandler(this.pausa_c1_reload_Click);
            // 
            // detener_c1
            // 
            this.detener_c1.Location = new System.Drawing.Point(56, 264);
            this.detener_c1.Name = "detener_c1";
            this.detener_c1.Size = new System.Drawing.Size(75, 23);
            this.detener_c1.TabIndex = 3;
            this.detener_c1.Text = "Detener";
            this.detener_c1.UseVisualStyleBackColor = true;
            this.detener_c1.Click += new System.EventHandler(this.detener_c1_Click);
            // 
            // pausa_c2
            // 
            this.pausa_c2.Location = new System.Drawing.Point(253, 235);
            this.pausa_c2.Name = "pausa_c2";
            this.pausa_c2.Size = new System.Drawing.Size(75, 23);
            this.pausa_c2.TabIndex = 4;
            this.pausa_c2.Text = "Pausa";
            this.pausa_c2.UseVisualStyleBackColor = true;
            this.pausa_c2.Click += new System.EventHandler(this.pausa_c2_Click);
            // 
            // detener_c2
            // 
            this.detener_c2.Location = new System.Drawing.Point(253, 264);
            this.detener_c2.Name = "detener_c2";
            this.detener_c2.Size = new System.Drawing.Size(75, 23);
            this.detener_c2.TabIndex = 6;
            this.detener_c2.Text = "Detener";
            this.detener_c2.UseVisualStyleBackColor = true;
            this.detener_c2.Click += new System.EventHandler(this.detener_c2_Click);
            // 
            // pausa_c3
            // 
            this.pausa_c3.Location = new System.Drawing.Point(441, 235);
            this.pausa_c3.Name = "pausa_c3";
            this.pausa_c3.Size = new System.Drawing.Size(75, 23);
            this.pausa_c3.TabIndex = 7;
            this.pausa_c3.Text = "Pausa";
            this.pausa_c3.UseVisualStyleBackColor = true;
            this.pausa_c3.Click += new System.EventHandler(this.pausa_c3_Click);
            // 
            // detener_c3
            // 
            this.detener_c3.Location = new System.Drawing.Point(441, 264);
            this.detener_c3.Name = "detener_c3";
            this.detener_c3.Size = new System.Drawing.Size(75, 23);
            this.detener_c3.TabIndex = 9;
            this.detener_c3.Text = "Detener";
            this.detener_c3.UseVisualStyleBackColor = true;
            this.detener_c3.Click += new System.EventHandler(this.detener_c3_Click);
            // 
            // pausa_c4
            // 
            this.pausa_c4.Location = new System.Drawing.Point(639, 235);
            this.pausa_c4.Name = "pausa_c4";
            this.pausa_c4.Size = new System.Drawing.Size(75, 23);
            this.pausa_c4.TabIndex = 10;
            this.pausa_c4.Text = "Pausa";
            this.pausa_c4.UseVisualStyleBackColor = true;
            this.pausa_c4.Click += new System.EventHandler(this.pausa_c4_Click);
            // 
            // detener_c4
            // 
            this.detener_c4.Location = new System.Drawing.Point(639, 264);
            this.detener_c4.Name = "detener_c4";
            this.detener_c4.Size = new System.Drawing.Size(75, 23);
            this.detener_c4.TabIndex = 12;
            this.detener_c4.Text = "Detener";
            this.detener_c4.UseVisualStyleBackColor = true;
            this.detener_c4.Click += new System.EventHandler(this.detener_c4_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 91);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(169, 138);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(218, 91);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(156, 138);
            this.listView2.TabIndex = 14;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView3
            // 
            this.listView3.Location = new System.Drawing.Point(403, 91);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(162, 138);
            this.listView3.TabIndex = 15;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // listView4
            // 
            this.listView4.Location = new System.Drawing.Point(598, 91);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(164, 138);
            this.listView4.TabIndex = 16;
            this.listView4.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 338);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 17;
            // 
            // limite_btn
            // 
            this.limite_btn.Location = new System.Drawing.Point(129, 382);
            this.limite_btn.Name = "limite_btn";
            this.limite_btn.Size = new System.Drawing.Size(75, 23);
            this.limite_btn.TabIndex = 18;
            this.limite_btn.Text = "Limte";
            this.limite_btn.UseVisualStyleBackColor = true;
            this.limite_btn.Click += new System.EventHandler(this.limite_btn_Click);
            // 
            // limpiar_btn1
            // 
            this.limpiar_btn1.Location = new System.Drawing.Point(210, 382);
            this.limpiar_btn1.Name = "limpiar_btn1";
            this.limpiar_btn1.Size = new System.Drawing.Size(75, 23);
            this.limpiar_btn1.TabIndex = 19;
            this.limpiar_btn1.Text = "Limpiar";
            this.limpiar_btn1.UseVisualStyleBackColor = true;
            this.limpiar_btn1.Click += new System.EventHandler(this.limpiar_btn1_Click);
            // 
            // reanudar_c1
            // 
            this.reanudar_c1.Location = new System.Drawing.Point(56, 293);
            this.reanudar_c1.Name = "reanudar_c1";
            this.reanudar_c1.Size = new System.Drawing.Size(75, 23);
            this.reanudar_c1.TabIndex = 20;
            this.reanudar_c1.Text = "Reanudar";
            this.reanudar_c1.UseVisualStyleBackColor = true;
            this.reanudar_c1.Click += new System.EventHandler(this.reanudar_c1_Click);
            // 
            // reanudar_c2
            // 
            this.reanudar_c2.Location = new System.Drawing.Point(253, 293);
            this.reanudar_c2.Name = "reanudar_c2";
            this.reanudar_c2.Size = new System.Drawing.Size(75, 23);
            this.reanudar_c2.TabIndex = 21;
            this.reanudar_c2.Text = "Reanudar";
            this.reanudar_c2.UseVisualStyleBackColor = true;
            this.reanudar_c2.Click += new System.EventHandler(this.reanudar_c2_Click);
            // 
            // reanudar_c3
            // 
            this.reanudar_c3.Location = new System.Drawing.Point(441, 293);
            this.reanudar_c3.Name = "reanudar_c3";
            this.reanudar_c3.Size = new System.Drawing.Size(75, 23);
            this.reanudar_c3.TabIndex = 22;
            this.reanudar_c3.Text = "Reanudar";
            this.reanudar_c3.UseVisualStyleBackColor = true;
            this.reanudar_c3.Click += new System.EventHandler(this.reanudar_c3_Click);
            // 
            // reanudar_c4
            // 
            this.reanudar_c4.Location = new System.Drawing.Point(639, 293);
            this.reanudar_c4.Name = "reanudar_c4";
            this.reanudar_c4.Size = new System.Drawing.Size(75, 23);
            this.reanudar_c4.TabIndex = 23;
            this.reanudar_c4.Text = "Reanudar";
            this.reanudar_c4.UseVisualStyleBackColor = true;
            this.reanudar_c4.Click += new System.EventHandler(this.reanudar_c4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reanudar_c4);
            this.Controls.Add(this.reanudar_c3);
            this.Controls.Add(this.reanudar_c2);
            this.Controls.Add(this.reanudar_c1);
            this.Controls.Add(this.limpiar_btn1);
            this.Controls.Add(this.limite_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView4);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.detener_c4);
            this.Controls.Add(this.pausa_c4);
            this.Controls.Add(this.detener_c3);
            this.Controls.Add(this.pausa_c3);
            this.Controls.Add(this.detener_c2);
            this.Controls.Add(this.pausa_c2);
            this.Controls.Add(this.detener_c1);
            this.Controls.Add(this.pausa_c1_reload);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button pausa_c1_reload;
        private Button detener_c1;
        private Button pausa_c2;
        private Button detener_c2;
        private Button pausa_c3;
        private Button detener_c3;
        private Button pausa_c4;
        private Button detener_c4;
        private ListView listView1;
        private ListView listView2;
        private ListView listView3;
        private ListView listView4;
        private TextBox textBox1;
        private Button limite_btn;
        private Button limpiar_btn1;
        private Button reanudar_c1;
        private Button reanudar_c2;
        private Button reanudar_c3;
        private Button reanudar_c4;
    }
}