
namespace ProjetoAula02
{
    partial class FormPokemon
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
            this.lblDescricao = new System.Windows.Forms.Label();
            this.rbtBulbassauro = new System.Windows.Forms.RadioButton();
            this.rbtSquirtle = new System.Windows.Forms.RadioButton();
            this.rbtCharmander = new System.Windows.Forms.RadioButton();
            this.pictureBoxPokemon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(29, 9);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(250, 24);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Escolha seu Pokemon:";
            // 
            // rbtBulbassauro
            // 
            this.rbtBulbassauro.AutoSize = true;
            this.rbtBulbassauro.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtBulbassauro.Location = new System.Drawing.Point(33, 132);
            this.rbtBulbassauro.Name = "rbtBulbassauro";
            this.rbtBulbassauro.Size = new System.Drawing.Size(114, 21);
            this.rbtBulbassauro.TabIndex = 1;
            this.rbtBulbassauro.Text = "Bulbassauro";
            this.rbtBulbassauro.UseVisualStyleBackColor = true;
            this.rbtBulbassauro.CheckedChanged += new System.EventHandler(this.rbtBulbassauro_CheckedChanged);
            // 
            // rbtSquirtle
            // 
            this.rbtSquirtle.AutoSize = true;
            this.rbtSquirtle.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtSquirtle.Location = new System.Drawing.Point(33, 93);
            this.rbtSquirtle.Name = "rbtSquirtle";
            this.rbtSquirtle.Size = new System.Drawing.Size(82, 21);
            this.rbtSquirtle.TabIndex = 2;
            this.rbtSquirtle.Text = "Squitle";
            this.rbtSquirtle.UseVisualStyleBackColor = true;
            this.rbtSquirtle.CheckedChanged += new System.EventHandler(this.rbtSquirtle_CheckedChanged);
            // 
            // rbtCharmander
            // 
            this.rbtCharmander.AutoSize = true;
            this.rbtCharmander.Checked = true;
            this.rbtCharmander.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCharmander.Location = new System.Drawing.Point(33, 54);
            this.rbtCharmander.Name = "rbtCharmander";
            this.rbtCharmander.Size = new System.Drawing.Size(106, 21);
            this.rbtCharmander.TabIndex = 3;
            this.rbtCharmander.TabStop = true;
            this.rbtCharmander.Text = "Charmander";
            this.rbtCharmander.UseVisualStyleBackColor = true;
            this.rbtCharmander.CheckedChanged += new System.EventHandler(this.rbtCharmander_CheckedChanged);
            // 
            // pictureBoxPokemon
            // 
            this.pictureBoxPokemon.Image = global::ProjetoAula02.Properties.Resources.charmander;
            this.pictureBoxPokemon.Location = new System.Drawing.Point(217, 54);
            this.pictureBoxPokemon.Name = "pictureBoxPokemon";
            this.pictureBoxPokemon.Size = new System.Drawing.Size(475, 475);
            this.pictureBoxPokemon.TabIndex = 4;
            this.pictureBoxPokemon.TabStop = false;
            // 
            // FormPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 541);
            this.Controls.Add(this.pictureBoxPokemon);
            this.Controls.Add(this.rbtCharmander);
            this.Controls.Add(this.rbtSquirtle);
            this.Controls.Add(this.rbtBulbassauro);
            this.Controls.Add(this.lblDescricao);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormPokemon";
            this.Text = "O Programa Pokemon";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.RadioButton rbtBulbassauro;
        private System.Windows.Forms.RadioButton rbtSquirtle;
        private System.Windows.Forms.RadioButton rbtCharmander;
        private System.Windows.Forms.PictureBox pictureBoxPokemon;
    }
}

