namespace Merddyns_Super_Beautiful_Palette_Holder_WinForm
{
    partial class ColorControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ColorName = new System.Windows.Forms.TextBox();
            this.CopyButton = new System.Windows.Forms.Button();
            this.OutputType = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.txt_ColorValue = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ColorName
            // 
            this.ColorName.Location = new System.Drawing.Point(0, 0);
            this.ColorName.Name = "ColorName";
            this.ColorName.Size = new System.Drawing.Size(97, 20);
            this.ColorName.TabIndex = 0;
            this.ColorName.TextChanged += new System.EventHandler(this.ColorName_TextChanged);
            this.ColorName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ColorName_KeyDown);
            // 
            // CopyButton
            // 
            this.CopyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyButton.Location = new System.Drawing.Point(0, 129);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(49, 21);
            this.CopyButton.TabIndex = 2;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // OutputType
            // 
            this.OutputType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OutputType.FormattingEnabled = true;
            this.OutputType.Items.AddRange(new object[] {
            "RGB",
            "RGB(R,G,B)",
            "Hex",
            "#Hex",
            "Hex (RRGGBB)",
            "#Hex (RRGGBB)",
            "HSV"});
            this.OutputType.Location = new System.Drawing.Point(46, 130);
            this.OutputType.Name = "OutputType";
            this.OutputType.Size = new System.Drawing.Size(74, 21);
            this.OutputType.TabIndex = 3;
            this.OutputType.SelectedIndexChanged += new System.EventHandler(this.OutputType_SelectedIndexChanged);
            // 
            // txt_ColorValue
            // 
            this.txt_ColorValue.Location = new System.Drawing.Point(0, 112);
            this.txt_ColorValue.Name = "txt_ColorValue";
            this.txt_ColorValue.Size = new System.Drawing.Size(120, 20);
            this.txt_ColorValue.TabIndex = 1;
            this.txt_ColorValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ColorValue_KeyDown);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(94, 0);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(26, 20);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "❌";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // ColorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.txt_ColorValue);
            this.Controls.Add(this.OutputType);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.ColorName);
            this.Name = "ColorControl";
            this.Size = new System.Drawing.Size(120, 150);
            this.Load += new System.EventHandler(this.ColorControl_Load);
            this.BackColorChanged += new System.EventHandler(this.OutputType_SelectedIndexChanged);
            this.DoubleClick += new System.EventHandler(this.ColorControl_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ColorName;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.ComboBox OutputType;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox txt_ColorValue;
        private System.Windows.Forms.Button btn_Delete;
    }
}
