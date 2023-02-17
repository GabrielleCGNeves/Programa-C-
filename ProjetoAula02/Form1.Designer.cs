
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
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(29, 26);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(250, 24);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Escolha seu Pokemon:";
            // 
            // rbtBulbassauro
            // 
            this.rbtBulbassauro.AutoSize = true;
            this.rbtBulbassauro.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtBulbassauro.Location = new System.Drawing.Point(33, 121);
            this.rbtBulbassauro.Name = "rbtBulbassauro";
            this.rbtBulbassauro.Size = new System.Drawing.Size(114, 21);
            this.rbtBulbassauro.TabIndex = 1;
            this.rbtBulbassauro.TabStop = true;
            this.rbtBulbassauro.Text = "Bulbassauro";
            this.rbtBulbassauro.UseVisualStyleBackColor = true;
            // 
            // rbtSquirtle
            // 
            this.rbtSquirtle.AutoSize = true;
            this.rbtSquirtle.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtSquirtle.Location = new System.Drawing.Point(33, 94);
            this.rbtSquirtle.Name = "rbtSquirtle";
            this.rbtSquirtle.Size = new System.Drawing.Size(82, 21);
            this.rbtSquirtle.TabIndex = 2;
            this.rbtSquirtle.TabStop = true;
            this.rbtSquirtle.Text = "Squitle";
            this.rbtSquirtle.UseVisualStyleBackColor = true;
            // 
            // rbtCharmander
            // 
            this.rbtCharmander.AutoSize = true;
            this.rbtCharmander.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCharmander.Location = new System.Drawing.Point(33, 67);
            this.rbtCharmander.Name = "rbtCharmander";
            this.rbtCharmander.Size = new System.Drawing.Size(106, 21);
            this.rbtCharmander.TabIndex = 3;
            this.rbtCharmander.TabStop = true;
            this.rbtCharmander.Text = "Charmander";
            this.rbtCharmander.UseVisualStyleBackColor = true;
            // 
            // FormPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.rbtCharmander);
            this.Controls.Add(this.rbtSquirtle);
            this.Controls.Add(this.rbtBulbassauro);
            this.Controls.Add(this.lblDescricao);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormPokemon";
            this.Text = "O Programa Pokemon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.RadioButton rbtBulbassauro;
        private System.Windows.Forms.RadioButton rbtSquirtle;
        private System.Windows.Forms.RadioButton rbtCharmander;
    }
}

