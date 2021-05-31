
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
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxConfirmar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.listViewRAnteriores = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfirmar.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirmar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonConfirmar.Location = new System.Drawing.Point(174, 572);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(287, 62);
            this.buttonConfirmar.TabIndex = 0;
            this.buttonConfirmar.Text = "=>";
            this.buttonConfirmar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(882, 111);
            this.label1.MaximumSize = new System.Drawing.Size(250, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 126);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consultar Resultados Anteriores:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxConfirmar
            // 
            this.textBoxConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxConfirmar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxConfirmar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxConfirmar.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxConfirmar.HideSelection = false;
            this.textBoxConfirmar.Location = new System.Drawing.Point(209, 43);
            this.textBoxConfirmar.MaxLength = 9;
            this.textBoxConfirmar.Name = "textBoxConfirmar";
            this.textBoxConfirmar.Size = new System.Drawing.Size(876, 40);
            this.textBoxConfirmar.TabIndex = 2;
            this.textBoxConfirmar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(189, 153);
            this.label2.MaximumSize = new System.Drawing.Size(250, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nova Aposta:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(119, 41);
            this.label3.MaximumSize = new System.Drawing.Size(250, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 42);
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
            this.buttonConsultar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonConsultar.Location = new System.Drawing.Point(795, 572);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(387, 62);
            this.buttonConsultar.TabIndex = 5;
            this.buttonConsultar.Text = "=>";
            this.buttonConsultar.UseVisualStyleBackColor = false;
            // 
            // listViewRAnteriores
            // 
            this.listViewRAnteriores.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewRAnteriores.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewRAnteriores.HideSelection = false;
            this.listViewRAnteriores.Location = new System.Drawing.Point(795, 240);
            this.listViewRAnteriores.Name = "listViewRAnteriores";
            this.listViewRAnteriores.Size = new System.Drawing.Size(387, 326);
            this.listViewRAnteriores.TabIndex = 6;
            this.listViewRAnteriores.UseCompatibleStateImageBehavior = false;
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1256, 730);
            this.Controls.Add(this.listViewRAnteriores);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxConfirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConfirmar);
            this.Name = "UserView";
            this.Text = "Cliente Utilizador Euromilhões";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxConfirmar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.ListView listViewRAnteriores;
    }
}

