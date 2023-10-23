namespace T3_E2
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
            btn_Addnum = new Button();
            txtb_Num = new TextBox();
            lbl_Lista = new Label();
            txtb_NumList = new TextBox();
            btn_OrdAsc = new Button();
            btn_OrdDesc = new Button();
            btn_Buscar = new Button();
            btn_Eliminar = new Button();
            txtb_Buscar = new TextBox();
            groupBox1 = new GroupBox();
            txtb_Eliminar = new TextBox();
            txtb_Output = new TextBox();
            lbl_Output = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Addnum
            // 
            btn_Addnum.Location = new Point(51, 54);
            btn_Addnum.Name = "btn_Addnum";
            btn_Addnum.Size = new Size(75, 23);
            btn_Addnum.TabIndex = 0;
            btn_Addnum.Text = "Add Num";
            btn_Addnum.UseVisualStyleBackColor = true;
            btn_Addnum.Click += button1_Click;
            // 
            // txtb_Num
            // 
            txtb_Num.Location = new Point(154, 54);
            txtb_Num.Name = "txtb_Num";
            txtb_Num.Size = new Size(93, 23);
            txtb_Num.TabIndex = 1;
            // 
            // lbl_Lista
            // 
            lbl_Lista.AutoSize = true;
            lbl_Lista.Location = new Point(357, 38);
            lbl_Lista.Name = "lbl_Lista";
            lbl_Lista.Size = new Size(97, 15);
            lbl_Lista.TabIndex = 3;
            lbl_Lista.Text = "Lista de números";
            // 
            // txtb_NumList
            // 
            txtb_NumList.Location = new Point(357, 56);
            txtb_NumList.Multiline = true;
            txtb_NumList.Name = "txtb_NumList";
            txtb_NumList.Size = new Size(370, 56);
            txtb_NumList.TabIndex = 4;
            // 
            // btn_OrdAsc
            // 
            btn_OrdAsc.Location = new Point(426, 118);
            btn_OrdAsc.Name = "btn_OrdAsc";
            btn_OrdAsc.Size = new Size(91, 23);
            btn_OrdAsc.TabIndex = 5;
            btn_OrdAsc.Text = "Ascendente";
            btn_OrdAsc.UseVisualStyleBackColor = true;
            btn_OrdAsc.Click += btn_OrdAsc_Click;
            // 
            // btn_OrdDesc
            // 
            btn_OrdDesc.Location = new Point(579, 118);
            btn_OrdDesc.Name = "btn_OrdDesc";
            btn_OrdDesc.Size = new Size(95, 23);
            btn_OrdDesc.TabIndex = 6;
            btn_OrdDesc.Text = "Descendente";
            btn_OrdDesc.UseVisualStyleBackColor = true;
            btn_OrdDesc.Click += btn_OrdDesc_Click;
            // 
            // btn_Buscar
            // 
            btn_Buscar.Location = new Point(21, 22);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(75, 23);
            btn_Buscar.TabIndex = 7;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Location = new Point(21, 70);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(75, 23);
            btn_Eliminar.TabIndex = 8;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // txtb_Buscar
            // 
            txtb_Buscar.Location = new Point(124, 22);
            txtb_Buscar.Name = "txtb_Buscar";
            txtb_Buscar.Size = new Size(93, 23);
            txtb_Buscar.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtb_Eliminar);
            groupBox1.Controls.Add(txtb_Buscar);
            groupBox1.Controls.Add(btn_Eliminar);
            groupBox1.Controls.Add(btn_Buscar);
            groupBox1.Location = new Point(30, 160);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 105);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opciones";
            // 
            // txtb_Eliminar
            // 
            txtb_Eliminar.Location = new Point(124, 70);
            txtb_Eliminar.Name = "txtb_Eliminar";
            txtb_Eliminar.Size = new Size(93, 23);
            txtb_Eliminar.TabIndex = 10;
            // 
            // txtb_Output
            // 
            txtb_Output.Location = new Point(497, 201);
            txtb_Output.Name = "txtb_Output";
            txtb_Output.Size = new Size(294, 23);
            txtb_Output.TabIndex = 11;
            // 
            // lbl_Output
            // 
            lbl_Output.AutoSize = true;
            lbl_Output.Location = new Point(497, 182);
            lbl_Output.Name = "lbl_Output";
            lbl_Output.Size = new Size(45, 15);
            lbl_Output.TabIndex = 12;
            lbl_Output.Text = "Output";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 505);
            Controls.Add(lbl_Output);
            Controls.Add(txtb_Output);
            Controls.Add(groupBox1);
            Controls.Add(btn_OrdDesc);
            Controls.Add(btn_OrdAsc);
            Controls.Add(txtb_NumList);
            Controls.Add(lbl_Lista);
            Controls.Add(txtb_Num);
            Controls.Add(btn_Addnum);
            Name = "Form1";
            Text = "Enunciado 2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Addnum;
        private TextBox txtb_Num;
        private Label lbl_Lista;
        private TextBox txtb_NumList;
        private Button btn_OrdAsc;
        private Button btn_OrdDesc;
        private Button btn_Buscar;
        private Button btn_Eliminar;
        private TextBox txtb_Buscar;
        private GroupBox groupBox1;
        private TextBox txtb_Eliminar;
        private TextBox txtb_Output;
        private Label lbl_Output;
    }
}