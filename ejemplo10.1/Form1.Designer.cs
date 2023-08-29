namespace ejemplo10._1
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
            descuento = new Label();
            impuesto = new Label();
            subtotal = new Label();
            importe_a_pagar = new Label();
            resultado = new Button();
            consumo = new Label();
            consumoTextBox = new TextBox();
            descuentoLa = new Button();
            impuestoLa = new Button();
            subtotalLa = new Button();
            importe_a_pagarLa = new Button();
            SuspendLayout();
            // 
            // descuento
            // 
            descuento.AutoSize = true;
            descuento.Location = new Point(51, 112);
            descuento.Name = "descuento";
            descuento.Size = new Size(62, 15);
            descuento.TabIndex = 1;
            descuento.Text = "descuento";
            descuento.Click += label1_Click;
            // 
            // impuesto
            // 
            impuesto.AutoSize = true;
            impuesto.Location = new Point(51, 147);
            impuesto.Name = "impuesto";
            impuesto.Size = new Size(57, 15);
            impuesto.TabIndex = 2;
            impuesto.Text = "impuesto";
            // 
            // subtotal
            // 
            subtotal.AutoSize = true;
            subtotal.Location = new Point(51, 180);
            subtotal.Name = "subtotal";
            subtotal.Size = new Size(50, 15);
            subtotal.TabIndex = 3;
            subtotal.Text = "subtotal";
            // 
            // importe_a_pagar
            // 
            importe_a_pagar.AutoSize = true;
            importe_a_pagar.Location = new Point(51, 209);
            importe_a_pagar.Name = "importe_a_pagar";
            importe_a_pagar.Size = new Size(91, 15);
            importe_a_pagar.TabIndex = 4;
            importe_a_pagar.Text = "importe a pagar";
            // 
            // resultado
            // 
            resultado.Location = new Point(207, 253);
            resultado.Name = "resultado";
            resultado.Size = new Size(97, 63);
            resultado.TabIndex = 9;
            resultado.Text = "Ejecutar";
            resultado.UseVisualStyleBackColor = true;
            resultado.Click += button1_Click;
            // 
            // consumo
            // 
            consumo.AutoSize = true;
            consumo.Location = new Point(12, 49);
            consumo.Name = "consumo";
            consumo.Size = new Size(171, 15);
            consumo.TabIndex = 10;
            consumo.Text = "Ingrese el monto del consumo:";
            // 
            // consumoTextBox
            // 
            consumoTextBox.Location = new Point(189, 46);
            consumoTextBox.Name = "consumoTextBox";
            consumoTextBox.Size = new Size(144, 23);
            consumoTextBox.TabIndex = 11;
            // 
            // descuentoLa
            // 
            descuentoLa.Location = new Point(170, 101);
            descuentoLa.Name = "descuentoLa";
            descuentoLa.Size = new Size(163, 26);
            descuentoLa.TabIndex = 12;
            descuentoLa.Text = "button1";
            descuentoLa.UseVisualStyleBackColor = true;
            // 
            // impuestoLa
            // 
            impuestoLa.Location = new Point(170, 133);
            impuestoLa.Name = "impuestoLa";
            impuestoLa.Size = new Size(163, 29);
            impuestoLa.TabIndex = 13;
            impuestoLa.Text = "button2";
            impuestoLa.UseVisualStyleBackColor = true;
            // 
            // subtotalLa
            // 
            subtotalLa.Location = new Point(170, 168);
            subtotalLa.Name = "subtotalLa";
            subtotalLa.Size = new Size(163, 29);
            subtotalLa.TabIndex = 14;
            subtotalLa.Text = "button3";
            subtotalLa.UseVisualStyleBackColor = true;
            // 
            // importe_a_pagarLa
            // 
            importe_a_pagarLa.Location = new Point(170, 203);
            importe_a_pagarLa.Name = "importe_a_pagarLa";
            importe_a_pagarLa.Size = new Size(163, 31);
            importe_a_pagarLa.TabIndex = 15;
            importe_a_pagarLa.Text = "button4";
            importe_a_pagarLa.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(importe_a_pagarLa);
            Controls.Add(subtotalLa);
            Controls.Add(impuestoLa);
            Controls.Add(descuentoLa);
            Controls.Add(consumoTextBox);
            Controls.Add(consumo);
            Controls.Add(resultado);
            Controls.Add(importe_a_pagar);
            Controls.Add(subtotal);
            Controls.Add(impuesto);
            Controls.Add(descuento);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label descuento;
        private Label impuesto;
        private Label subtotal;
        private Label importe_a_pagar;
        private Button resultado;
        private Label consumo;
        private TextBox consumoTextBox;
        private Button descuentoLa;
        private Button impuestoLa;
        private Button subtotalLa;
        private Button importe_a_pagarLa;
    }
}