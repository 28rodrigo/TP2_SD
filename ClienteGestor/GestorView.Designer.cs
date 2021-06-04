
namespace ClienteGestor
{
    partial class GestorView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestorView));
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConfirmarRegisto = new System.Windows.Forms.Button();
            this.listViewRAnteriores = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxEstrela2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxEstrela1 = new System.Windows.Forms.TextBox();
            this.textBoxNum5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNum4 = new System.Windows.Forms.TextBox();
            this.textBoxNum3 = new System.Windows.Forms.TextBox();
            this.textBoxNum2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNum1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(69, 202);
            this.label2.MaximumSize = new System.Drawing.Size(400, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 84);
            this.label2.TabIndex = 25;
            this.label2.Text = "Registar Chave Vencedora:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonConfirmarRegisto
            // 
            this.buttonConfirmarRegisto.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonConfirmarRegisto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfirmarRegisto.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirmarRegisto.ForeColor = System.Drawing.Color.MintCream;
            this.buttonConfirmarRegisto.Location = new System.Drawing.Point(22, 585);
            this.buttonConfirmarRegisto.Margin = new System.Windows.Forms.Padding(6);
            this.buttonConfirmarRegisto.Name = "buttonConfirmarRegisto";
            this.buttonConfirmarRegisto.Size = new System.Drawing.Size(388, 62);
            this.buttonConfirmarRegisto.TabIndex = 24;
            this.buttonConfirmarRegisto.Text = "Registar";
            this.buttonConfirmarRegisto.UseVisualStyleBackColor = false;
            this.buttonConfirmarRegisto.Click += new System.EventHandler(this.buttonConfirmarRegisto_Click);
            // 
            // listViewRAnteriores
            // 
            this.listViewRAnteriores.BackColor = System.Drawing.Color.MintCream;
            this.listViewRAnteriores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewRAnteriores.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewRAnteriores.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewRAnteriores.HideSelection = false;
            this.listViewRAnteriores.Location = new System.Drawing.Point(422, 78);
            this.listViewRAnteriores.Margin = new System.Windows.Forms.Padding(6);
            this.listViewRAnteriores.Name = "listViewRAnteriores";
            this.listViewRAnteriores.Size = new System.Drawing.Size(730, 569);
            this.listViewRAnteriores.TabIndex = 41;
            this.listViewRAnteriores.UseCompatibleStateImageBehavior = false;
            this.listViewRAnteriores.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nº Aposta";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NIF";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Números";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Estrelas";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Prémio";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Data";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 210;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(600, 30);
            this.label1.MaximumSize = new System.Drawing.Size(430, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 42);
            this.label1.TabIndex = 40;
            this.label1.Text = "Lista de Vencedores:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Lucida Sans Unicode", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(197, 509);
            this.label12.MaximumSize = new System.Drawing.Size(250, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 42);
            this.label12.TabIndex = 69;
            this.label12.Text = "-";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxEstrela2
            // 
            this.textBoxEstrela2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEstrela2.BackColor = System.Drawing.Color.MintCream;
            this.textBoxEstrela2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEstrela2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxEstrela2.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEstrela2.HideSelection = false;
            this.textBoxEstrela2.Location = new System.Drawing.Point(241, 511);
            this.textBoxEstrela2.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxEstrela2.MaxLength = 2;
            this.textBoxEstrela2.Name = "textBoxEstrela2";
            this.textBoxEstrela2.Size = new System.Drawing.Size(40, 40);
            this.textBoxEstrela2.TabIndex = 68;
            this.textBoxEstrela2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxEstrela2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNif_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label13.Font = new System.Drawing.Font("Lucida Sans Unicode", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(115, 448);
            this.label13.MaximumSize = new System.Drawing.Size(250, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(207, 42);
            this.label13.TabIndex = 67;
            this.label13.Text = "✰ Estrelas:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxEstrela1
            // 
            this.textBoxEstrela1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEstrela1.BackColor = System.Drawing.Color.MintCream;
            this.textBoxEstrela1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEstrela1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxEstrela1.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEstrela1.HideSelection = false;
            this.textBoxEstrela1.Location = new System.Drawing.Point(153, 511);
            this.textBoxEstrela1.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxEstrela1.MaxLength = 2;
            this.textBoxEstrela1.Name = "textBoxEstrela1";
            this.textBoxEstrela1.Size = new System.Drawing.Size(40, 40);
            this.textBoxEstrela1.TabIndex = 66;
            this.textBoxEstrela1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxEstrela1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNif_KeyPress);
            // 
            // textBoxNum5
            // 
            this.textBoxNum5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNum5.BackColor = System.Drawing.Color.MintCream;
            this.textBoxNum5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNum5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNum5.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNum5.HideSelection = false;
            this.textBoxNum5.Location = new System.Drawing.Point(369, 389);
            this.textBoxNum5.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxNum5.MaxLength = 2;
            this.textBoxNum5.Name = "textBoxNum5";
            this.textBoxNum5.Size = new System.Drawing.Size(40, 40);
            this.textBoxNum5.TabIndex = 65;
            this.textBoxNum5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNum5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNif_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Unicode", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(325, 387);
            this.label8.MaximumSize = new System.Drawing.Size(250, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 42);
            this.label8.TabIndex = 64;
            this.label8.Text = "-";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(241, 387);
            this.label7.MaximumSize = new System.Drawing.Size(250, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 42);
            this.label7.TabIndex = 63;
            this.label7.Text = "-";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(153, 387);
            this.label5.MaximumSize = new System.Drawing.Size(250, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 42);
            this.label5.TabIndex = 62;
            this.label5.Text = "-";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(65, 387);
            this.label6.MaximumSize = new System.Drawing.Size(250, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 42);
            this.label6.TabIndex = 61;
            this.label6.Text = "-";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNum4
            // 
            this.textBoxNum4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNum4.BackColor = System.Drawing.Color.MintCream;
            this.textBoxNum4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNum4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNum4.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNum4.HideSelection = false;
            this.textBoxNum4.Location = new System.Drawing.Point(281, 389);
            this.textBoxNum4.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxNum4.MaxLength = 2;
            this.textBoxNum4.Name = "textBoxNum4";
            this.textBoxNum4.Size = new System.Drawing.Size(40, 40);
            this.textBoxNum4.TabIndex = 60;
            this.textBoxNum4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNum4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNif_KeyPress);
            // 
            // textBoxNum3
            // 
            this.textBoxNum3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNum3.BackColor = System.Drawing.Color.MintCream;
            this.textBoxNum3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNum3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNum3.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNum3.HideSelection = false;
            this.textBoxNum3.Location = new System.Drawing.Point(197, 389);
            this.textBoxNum3.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxNum3.MaxLength = 2;
            this.textBoxNum3.Name = "textBoxNum3";
            this.textBoxNum3.Size = new System.Drawing.Size(40, 40);
            this.textBoxNum3.TabIndex = 59;
            this.textBoxNum3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNum3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNif_KeyPress);
            // 
            // textBoxNum2
            // 
            this.textBoxNum2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNum2.BackColor = System.Drawing.Color.MintCream;
            this.textBoxNum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNum2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNum2.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNum2.HideSelection = false;
            this.textBoxNum2.Location = new System.Drawing.Point(104, 389);
            this.textBoxNum2.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxNum2.MaxLength = 2;
            this.textBoxNum2.Name = "textBoxNum2";
            this.textBoxNum2.Size = new System.Drawing.Size(40, 40);
            this.textBoxNum2.TabIndex = 58;
            this.textBoxNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNif_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(96, 320);
            this.label4.MaximumSize = new System.Drawing.Size(250, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 42);
            this.label4.TabIndex = 57;
            this.label4.Text = "﹟Números:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNum1
            // 
            this.textBoxNum1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNum1.BackColor = System.Drawing.Color.MintCream;
            this.textBoxNum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNum1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNum1.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNum1.HideSelection = false;
            this.textBoxNum1.Location = new System.Drawing.Point(21, 389);
            this.textBoxNum1.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxNum1.MaxLength = 2;
            this.textBoxNum1.Name = "textBoxNum1";
            this.textBoxNum1.Size = new System.Drawing.Size(40, 40);
            this.textBoxNum1.TabIndex = 56;
            this.textBoxNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNif_KeyPress);
            // 
            // GestorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1167, 678);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxEstrela2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxEstrela1);
            this.Controls.Add(this.textBoxNum5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxNum4);
            this.Controls.Add(this.textBoxNum3);
            this.Controls.Add(this.textBoxNum2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNum1);
            this.Controls.Add(this.listViewRAnteriores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonConfirmarRegisto);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestorView";
            this.Text = "Gestor de Sorteio Euromilhões";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConfirmarRegisto;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ListView listViewRAnteriores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxEstrela2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxEstrela1;
        private System.Windows.Forms.TextBox textBoxNum5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNum4;
        private System.Windows.Forms.TextBox textBoxNum3;
        private System.Windows.Forms.TextBox textBoxNum2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNum1;
    }
}