
namespace ClienteAdministrador
{
    partial class AdminView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminView));
            this.listViewChaves = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonArquivar = new System.Windows.Forms.Button();
            this.listViewUtilizadores = new System.Windows.Forms.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewChaves
            // 
            this.listViewChaves.BackColor = System.Drawing.Color.MintCream;
            this.listViewChaves.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewChaves.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewChaves.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewChaves.HideSelection = false;
            this.listViewChaves.Location = new System.Drawing.Point(206, 113);
            this.listViewChaves.Margin = new System.Windows.Forms.Padding(6);
            this.listViewChaves.Name = "listViewChaves";
            this.listViewChaves.Size = new System.Drawing.Size(358, 392);
            this.listViewChaves.TabIndex = 43;
            this.listViewChaves.UseCompatibleStateImageBehavior = false;
            this.listViewChaves.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nº Aposta";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Números";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Estrelas";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Prémio";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Data";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(197, 23);
            this.label1.MaximumSize = new System.Drawing.Size(430, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 84);
            this.label1.TabIndex = 42;
            this.label1.Text = "Lista de Chaves Não Validadas:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonArquivar
            // 
            this.buttonArquivar.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonArquivar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonArquivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonArquivar.ForeColor = System.Drawing.Color.MintCream;
            this.buttonArquivar.Location = new System.Drawing.Point(15, 190);
            this.buttonArquivar.Margin = new System.Windows.Forms.Padding(6);
            this.buttonArquivar.Name = "buttonArquivar";
            this.buttonArquivar.Size = new System.Drawing.Size(179, 315);
            this.buttonArquivar.TabIndex = 44;
            this.buttonArquivar.Text = "Arquivar Apostas";
            this.buttonArquivar.UseVisualStyleBackColor = false;
            this.buttonArquivar.Click += new System.EventHandler(this.buttonArquivar_Click);
            // 
            // listViewUtilizadores
            // 
            this.listViewUtilizadores.BackColor = System.Drawing.Color.MintCream;
            this.listViewUtilizadores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6});
            this.listViewUtilizadores.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewUtilizadores.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewUtilizadores.HideSelection = false;
            this.listViewUtilizadores.Location = new System.Drawing.Point(591, 113);
            this.listViewUtilizadores.Margin = new System.Windows.Forms.Padding(6);
            this.listViewUtilizadores.Name = "listViewUtilizadores";
            this.listViewUtilizadores.Size = new System.Drawing.Size(358, 392);
            this.listViewUtilizadores.TabIndex = 46;
            this.listViewUtilizadores.UseCompatibleStateImageBehavior = false;
            this.listViewUtilizadores.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Utilizador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(579, 44);
            this.label2.MaximumSize = new System.Drawing.Size(430, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 42);
            this.label2.TabIndex = 47;
            this.label2.Text = "Lista de Utilizadores:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(970, 520);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewUtilizadores);
            this.Controls.Add(this.buttonArquivar);
            this.Controls.Add(this.listViewChaves);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminView";
            this.Text = "Administrador de Sorteio Euromilhões";
            this.Load += new System.EventHandler(this.AdminView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewChaves;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonArquivar;
        private System.Windows.Forms.ListView listViewUtilizadores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

