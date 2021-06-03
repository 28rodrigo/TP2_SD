
namespace ClienteUtilizador
{
    partial class UserView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserView));
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNif = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.textBoxNum1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNum2 = new System.Windows.Forms.TextBox();
            this.textBoxNum3 = new System.Windows.Forms.TextBox();
            this.textBoxNum4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNum5 = new System.Windows.Forms.TextBox();
            this.listViewRAnteriores = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxEstrela2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxEstrela1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfirmar.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirmar.ForeColor = System.Drawing.Color.MintCream;
            this.buttonConfirmar.Location = new System.Drawing.Point(92, 642);
            this.buttonConfirmar.Margin = new System.Windows.Forms.Padding(6);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(386, 62);
            this.buttonConfirmar.TabIndex = 0;
            this.buttonConfirmar.Text = "Apostar";
            this.buttonConfirmar.UseVisualStyleBackColor = false;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(529, 37);
            this.label1.MaximumSize = new System.Drawing.Size(550, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 118);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consultar Resultados Anteriores:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNif
            // 
            this.textBoxNif.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNif.BackColor = System.Drawing.Color.MintCream;
            this.textBoxNif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNif.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNif.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNif.HideSelection = false;
            this.textBoxNif.Location = new System.Drawing.Point(132, 50);
            this.textBoxNif.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxNif.MaxLength = 9;
            this.textBoxNif.Name = "textBoxNif";
            this.textBoxNif.Size = new System.Drawing.Size(342, 40);
            this.textBoxNif.TabIndex = 2;
            this.textBoxNif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNif_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(118, 145);
            this.label2.MaximumSize = new System.Drawing.Size(350, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 59);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nova Aposta:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.MaximumSize = new System.Drawing.Size(250, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 59);
            this.label3.TabIndex = 4;
            this.label3.Text = "NIF:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConsultar.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConsultar.ForeColor = System.Drawing.Color.MintCream;
            this.buttonConsultar.Location = new System.Drawing.Point(510, 634);
            this.buttonConsultar.Margin = new System.Windows.Forms.Padding(6);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(582, 62);
            this.buttonConsultar.TabIndex = 5;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = false;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
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
            this.textBoxNum1.Location = new System.Drawing.Point(92, 282);
            this.textBoxNum1.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxNum1.MaxLength = 2;
            this.textBoxNum1.Name = "textBoxNum1";
            this.textBoxNum1.Size = new System.Drawing.Size(40, 40);
            this.textBoxNum1.TabIndex = 7;
            this.textBoxNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNif_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(180, 223);
            this.label4.MaximumSize = new System.Drawing.Size(250, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 42);
            this.label4.TabIndex = 8;
            this.label4.Text = "﹟Números:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.textBoxNum2.Location = new System.Drawing.Point(184, 282);
            this.textBoxNum2.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxNum2.MaxLength = 2;
            this.textBoxNum2.Name = "textBoxNum2";
            this.textBoxNum2.Size = new System.Drawing.Size(40, 40);
            this.textBoxNum2.TabIndex = 9;
            this.textBoxNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNif_KeyPress);
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
            this.textBoxNum3.Location = new System.Drawing.Point(268, 282);
            this.textBoxNum3.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxNum3.MaxLength = 2;
            this.textBoxNum3.Name = "textBoxNum3";
            this.textBoxNum3.Size = new System.Drawing.Size(40, 40);
            this.textBoxNum3.TabIndex = 10;
            this.textBoxNum3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNum3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNif_KeyPress);
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
            this.textBoxNum4.Location = new System.Drawing.Point(352, 282);
            this.textBoxNum4.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxNum4.MaxLength = 2;
            this.textBoxNum4.Name = "textBoxNum4";
            this.textBoxNum4.Size = new System.Drawing.Size(40, 40);
            this.textBoxNum4.TabIndex = 11;
            this.textBoxNum4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNum4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNif_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(136, 280);
            this.label6.MaximumSize = new System.Drawing.Size(250, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 42);
            this.label6.TabIndex = 13;
            this.label6.Text = "-";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(224, 280);
            this.label5.MaximumSize = new System.Drawing.Size(250, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 42);
            this.label5.TabIndex = 14;
            this.label5.Text = "-";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(312, 280);
            this.label7.MaximumSize = new System.Drawing.Size(250, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 42);
            this.label7.TabIndex = 15;
            this.label7.Text = "-";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Unicode", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(396, 280);
            this.label8.MaximumSize = new System.Drawing.Size(250, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 42);
            this.label8.TabIndex = 16;
            this.label8.Text = "-";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.textBoxNum5.Location = new System.Drawing.Point(438, 282);
            this.textBoxNum5.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxNum5.MaxLength = 2;
            this.textBoxNum5.Name = "textBoxNum5";
            this.textBoxNum5.Size = new System.Drawing.Size(40, 40);
            this.textBoxNum5.TabIndex = 17;
            this.textBoxNum5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNum5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNif_KeyPress);
            // 
            // listViewRAnteriores
            // 
            this.listViewRAnteriores.BackColor = System.Drawing.Color.MintCream;
            this.listViewRAnteriores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewRAnteriores.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewRAnteriores.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewRAnteriores.HideSelection = false;
            this.listViewRAnteriores.Location = new System.Drawing.Point(510, 161);
            this.listViewRAnteriores.Margin = new System.Windows.Forms.Padding(6);
            this.listViewRAnteriores.Name = "listViewRAnteriores";
            this.listViewRAnteriores.Size = new System.Drawing.Size(582, 461);
            this.listViewRAnteriores.TabIndex = 6;
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
            this.columnHeader2.Text = "Números";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Estrelas";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Premio";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Data";
            this.columnHeader5.Width = 228;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Lucida Sans Unicode", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(268, 426);
            this.label12.MaximumSize = new System.Drawing.Size(250, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 42);
            this.label12.TabIndex = 23;
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
            this.textBoxEstrela2.Location = new System.Drawing.Point(316, 426);
            this.textBoxEstrela2.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxEstrela2.MaxLength = 2;
            this.textBoxEstrela2.Name = "textBoxEstrela2";
            this.textBoxEstrela2.Size = new System.Drawing.Size(40, 40);
            this.textBoxEstrela2.TabIndex = 20;
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
            this.label13.Location = new System.Drawing.Point(181, 358);
            this.label13.MaximumSize = new System.Drawing.Size(250, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(207, 42);
            this.label13.TabIndex = 19;
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
            this.textBoxEstrela1.Location = new System.Drawing.Point(224, 428);
            this.textBoxEstrela1.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxEstrela1.MaxLength = 2;
            this.textBoxEstrela1.Name = "textBoxEstrela1";
            this.textBoxEstrela1.Size = new System.Drawing.Size(40, 40);
            this.textBoxEstrela1.TabIndex = 18;
            this.textBoxEstrela1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxEstrela1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNif_KeyPress);
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1107, 741);
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
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNif);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConfirmar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserView";
            this.Text = "Cliente Utilizador Euromilhões";
            this.Load += new System.EventHandler(this.UserView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.TextBox textBoxNum1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNum2;
        private System.Windows.Forms.TextBox textBoxNum3;
        private System.Windows.Forms.TextBox textBoxNum4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNum5;
        private System.Windows.Forms.ListView listViewRAnteriores;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxEstrela2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxEstrela1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

