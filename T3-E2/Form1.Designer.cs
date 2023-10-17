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
            SuspendLayout();
            // 
            // btn_Addnum
            // 
            btn_Addnum.Location = new Point(30, 55);
            btn_Addnum.Name = "btn_Addnum";
            btn_Addnum.Size = new Size(75, 23);
            btn_Addnum.TabIndex = 0;
            btn_Addnum.Text = "Add Num";
            btn_Addnum.UseVisualStyleBackColor = true;
            btn_Addnum.Click += button1_Click;
            // 
            // txtb_Num
            // 
            txtb_Num.Location = new Point(134, 55);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_OrdDesc);
            Controls.Add(btn_OrdAsc);
            Controls.Add(txtb_NumList);
            Controls.Add(lbl_Lista);
            Controls.Add(txtb_Num);
            Controls.Add(btn_Addnum);
            Name = "Form1";
            Text = "Form1";
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
    }
}