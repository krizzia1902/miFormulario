namespace miFormulario
{
    partial class tx
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
            lblnombre = new Label();
            lblApellido = new Label();
            DNI = new Label();
            txbNombre = new TextBox();
            textAPELLIDO = new TextBox();
            titDNI = new TextBox();
            btlACEPTAR = new Button();
            label1 = new Label();
            lblApellidoNombre = new Label();
            SuspendLayout();
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(28, 21);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(49, 15);
            lblnombre.TabIndex = 0;
            lblnombre.Text = "nombre";
            lblnombre.Click += label1_Click;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(32, 53);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(49, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "apellido";
            // 
            // DNI
            // 
            DNI.AutoSize = true;
            DNI.Location = new Point(34, 97);
            DNI.Name = "DNI";
            DNI.Size = new Size(27, 15);
            DNI.TabIndex = 2;
            DNI.Text = "DNI";
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(106, 15);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(371, 23);
            txbNombre.TabIndex = 3;
            // 
            // textAPELLIDO
            // 
            textAPELLIDO.Location = new Point(109, 53);
            textAPELLIDO.Multiline = true;
            textAPELLIDO.Name = "textAPELLIDO";
            textAPELLIDO.Size = new Size(368, 23);
            textAPELLIDO.TabIndex = 4;
            textAPELLIDO.TextChanged += textAPELLIDO_TextChanged;
            // 
            // titDNI
            // 
            titDNI.Location = new Point(106, 94);
            titDNI.Name = "titDNI";
            titDNI.Size = new Size(100, 23);
            titDNI.TabIndex = 5;
            // 
            // btlACEPTAR
            // 
            btlACEPTAR.Location = new Point(961, 575);
            btlACEPTAR.Name = "btlACEPTAR";
            btlACEPTAR.Size = new Size(75, 23);
            btlACEPTAR.TabIndex = 6;
            btlACEPTAR.Text = "ACEPTAR";
            btlACEPTAR.UseVisualStyleBackColor = true;
            btlACEPTAR.Click += btlACEPTAR_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 211);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 7;
            label1.Text = "Nombre Completo:";
            // 
            // lblApellidoNombre
            // 
            lblApellidoNombre.AutoSize = true;
            lblApellidoNombre.Location = new Point(162, 211);
            lblApellidoNombre.Name = "lblApellidoNombre";
            lblApellidoNombre.Size = new Size(166, 15);
            lblApellidoNombre.TabIndex = 8;
            lblApellidoNombre.Text = "aqui va ir el nombre completo";
            // 
            // tx
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 620);
            Controls.Add(lblApellidoNombre);
            Controls.Add(label1);
            Controls.Add(btlACEPTAR);
            Controls.Add(titDNI);
            Controls.Add(textAPELLIDO);
            Controls.Add(txbNombre);
            Controls.Add(DNI);
            Controls.Add(lblApellido);
            Controls.Add(lblnombre);
            Name = "tx";
            Text = "DATOS DE PERSONA";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnombre;
        private Label lblApellido;
        private Label DNI;
        private TextBox txbNombre;
        private TextBox textAPELLIDO;
        private TextBox titDNI;
        private Button btlACEPTAR;
        private Label label1;
        private Label lblApellidoNombre;
    }
}