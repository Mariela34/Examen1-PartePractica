namespace ControlExamen1_MarielaBonilla
{
    partial class UserControl1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.texto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iniciar = new System.Windows.Forms.Button();
            this.comparar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.intentos = new System.Windows.Forms.Label();
            this.restantes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.parciales = new System.Windows.Forms.Label();
            this.totales = new System.Windows.Forms.Label();
            this.winner = new System.Windows.Forms.Label();
            this.loser = new System.Windows.Forms.Label();
            this.escondida = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.aviso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // texto
            // 
            this.texto.Enabled = false;
            this.texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto.Location = new System.Drawing.Point(392, 200);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(202, 26);
            this.texto.TabIndex = 0;
            this.texto.Text = " ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(389, 139);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(241, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese una combinación de 4 caracteres con la letra que le corresponda al color";
            // 
            // iniciar
            // 
            this.iniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciar.Location = new System.Drawing.Point(392, 340);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(202, 41);
            this.iniciar.TabIndex = 2;
            this.iniciar.Text = "Iniciar Juego";
            this.iniciar.UseVisualStyleBackColor = true;
            this.iniciar.Click += new System.EventHandler(this.iniciar_Click);
            // 
            // comparar
            // 
            this.comparar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comparar.Enabled = false;
            this.comparar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comparar.Location = new System.Drawing.Point(392, 277);
            this.comparar.Name = "comparar";
            this.comparar.Size = new System.Drawing.Size(202, 42);
            this.comparar.TabIndex = 3;
            this.comparar.Text = "Comparar combinación";
            this.comparar.UseVisualStyleBackColor = true;
            this.comparar.Click += new System.EventHandler(this.comparar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número de intentos";
            // 
            // intentos
            // 
            this.intentos.BackColor = System.Drawing.Color.Beige;
            this.intentos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.intentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intentos.Location = new System.Drawing.Point(31, 68);
            this.intentos.Name = "intentos";
            this.intentos.Size = new System.Drawing.Size(64, 23);
            this.intentos.TabIndex = 5;
            this.intentos.Text = "0";
            this.intentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // restantes
            // 
            this.restantes.BackColor = System.Drawing.Color.Beige;
            this.restantes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.restantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restantes.Location = new System.Drawing.Point(215, 68);
            this.restantes.Name = "restantes";
            this.restantes.Size = new System.Drawing.Size(64, 23);
            this.restantes.TabIndex = 7;
            this.restantes.Text = "8";
            this.restantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Intentos restantes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Aciertos Parciales:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Aciertos Totales:";
            // 
            // parciales
            // 
            this.parciales.AutoSize = true;
            this.parciales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parciales.Location = new System.Drawing.Point(164, 180);
            this.parciales.Name = "parciales";
            this.parciales.Size = new System.Drawing.Size(16, 17);
            this.parciales.TabIndex = 10;
            this.parciales.Text = "0";
            // 
            // totales
            // 
            this.totales.AutoSize = true;
            this.totales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totales.Location = new System.Drawing.Point(164, 226);
            this.totales.Name = "totales";
            this.totales.Size = new System.Drawing.Size(16, 17);
            this.totales.TabIndex = 11;
            this.totales.Text = "0";
            // 
            // winner
            // 
            this.winner.AutoSize = true;
            this.winner.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.winner.ForeColor = System.Drawing.Color.Lime;
            this.winner.Location = new System.Drawing.Point(86, 359);
            this.winner.Name = "winner";
            this.winner.Size = new System.Drawing.Size(230, 37);
            this.winner.TabIndex = 12;
            this.winner.Text = "HA GANADO!!";
            this.winner.Visible = false;
            // 
            // loser
            // 
            this.loser.AutoSize = true;
            this.loser.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.loser.ForeColor = System.Drawing.Color.Red;
            this.loser.Location = new System.Drawing.Point(86, 359);
            this.loser.Name = "loser";
            this.loser.Size = new System.Drawing.Size(228, 37);
            this.loser.TabIndex = 13;
            this.loser.Text = "GAME OVER!!";
            this.loser.Visible = false;
            // 
            // escondida
            // 
            this.escondida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.escondida.Location = new System.Drawing.Point(163, 307);
            this.escondida.Name = "escondida";
            this.escondida.Size = new System.Drawing.Size(66, 23);
            this.escondida.TabIndex = 14;
            this.escondida.Text = "XXXX";
            this.escondida.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(121, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Combinación escondida";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(389, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Colores disponibles";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(389, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 51);
            this.label8.TabIndex = 17;
            this.label8.Text = "Azul(A), Rojo(R), \r\nBlanco(B), Negro(N), \r\nVerde(V), Amarillo(M).";
            // 
            // aviso
            // 
            this.aviso.AutoSize = true;
            this.aviso.ForeColor = System.Drawing.Color.Red;
            this.aviso.Location = new System.Drawing.Point(379, 231);
            this.aviso.Name = "aviso";
            this.aviso.Size = new System.Drawing.Size(0, 13);
            this.aviso.TabIndex = 18;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.aviso);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.escondida);
            this.Controls.Add(this.loser);
            this.Controls.Add(this.winner);
            this.Controls.Add(this.totales);
            this.Controls.Add(this.parciales);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.restantes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.intentos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comparar);
            this.Controls.Add(this.iniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texto);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(642, 435);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button iniciar;
        private System.Windows.Forms.Button comparar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label intentos;
        private System.Windows.Forms.Label restantes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label parciales;
        private System.Windows.Forms.Label totales;
        private System.Windows.Forms.Label winner;
        private System.Windows.Forms.Label loser;
        private System.Windows.Forms.Label escondida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label aviso;
    }
}
