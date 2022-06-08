namespace Merddyns_Super_Beautiful_Palette_Holder_WinForm
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.PalettesListBox = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_AddPalette = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_RemoveColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_ColorList = new System.Windows.Forms.ComboBox();
            this.btn_RemovePalette = new System.Windows.Forms.Button();
            this.btn_AddColor = new System.Windows.Forms.Button();
            this.lbl_PaletteName = new System.Windows.Forms.Label();
            this.txt_PaletteName = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PalettesListBox
            // 
            this.PalettesListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.PalettesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PalettesListBox.FormattingEnabled = true;
            this.PalettesListBox.ItemHeight = 20;
            this.PalettesListBox.Location = new System.Drawing.Point(0, 0);
            this.PalettesListBox.Name = "PalettesListBox";
            this.PalettesListBox.Size = new System.Drawing.Size(156, 501);
            this.PalettesListBox.TabIndex = 1;
            this.PalettesListBox.SelectedIndexChanged += new System.EventHandler(this.PalettesListBox_SelectedIndexChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(109, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(89, 26);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_AddPalette
            // 
            this.btn_AddPalette.Location = new System.Drawing.Point(0, 3);
            this.btn_AddPalette.Name = "btn_AddPalette";
            this.btn_AddPalette.Size = new System.Drawing.Size(98, 26);
            this.btn_AddPalette.TabIndex = 2;
            this.btn_AddPalette.Text = "Add Palette";
            this.btn_AddPalette.UseVisualStyleBackColor = true;
            this.btn_AddPalette.Click += new System.EventHandler(this.btn_AddPalette_Click);
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(448, 3);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(89, 26);
            this.btn_Load.TabIndex = 6;
            this.btn_Load.Text = "Import Palette";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel.Location = new System.Drawing.Point(156, 65);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(540, 436);
            this.flowLayoutPanel.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.btn_RemoveColor);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmb_ColorList);
            this.panel2.Controls.Add(this.btn_RemovePalette);
            this.panel2.Controls.Add(this.btn_AddColor);
            this.panel2.Controls.Add(this.lbl_PaletteName);
            this.panel2.Controls.Add(this.txt_PaletteName);
            this.panel2.Controls.Add(this.btn_Load);
            this.panel2.Controls.Add(this.btn_Save);
            this.panel2.Controls.Add(this.btn_AddPalette);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(156, 0);
            this.panel2.MaximumSize = new System.Drawing.Size(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 59);
            this.panel2.TabIndex = 6;
            // 
            // btn_RemoveColor
            // 
            this.btn_RemoveColor.Location = new System.Drawing.Point(247, 35);
            this.btn_RemoveColor.Name = "btn_RemoveColor";
            this.btn_RemoveColor.Size = new System.Drawing.Size(46, 21);
            this.btn_RemoveColor.TabIndex = 9;
            this.btn_RemoveColor.Text = "Delete";
            this.btn_RemoveColor.UseVisualStyleBackColor = true;
            this.btn_RemoveColor.Click += new System.EventHandler(this.btn_RemoveColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Remove Color:";
            // 
            // cmb_ColorList
            // 
            this.cmb_ColorList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ColorList.FormattingEnabled = true;
            this.cmb_ColorList.Location = new System.Drawing.Point(205, 35);
            this.cmb_ColorList.Name = "cmb_ColorList";
            this.cmb_ColorList.Size = new System.Drawing.Size(36, 21);
            this.cmb_ColorList.TabIndex = 8;
            // 
            // btn_RemovePalette
            // 
            this.btn_RemovePalette.Location = new System.Drawing.Point(0, 35);
            this.btn_RemovePalette.Name = "btn_RemovePalette";
            this.btn_RemovePalette.Size = new System.Drawing.Size(98, 21);
            this.btn_RemovePalette.TabIndex = 7;
            this.btn_RemovePalette.Text = "Remove Palette";
            this.btn_RemovePalette.UseVisualStyleBackColor = true;
            this.btn_RemovePalette.Click += new System.EventHandler(this.btn_RemovePalette_Click);
            // 
            // btn_AddColor
            // 
            this.btn_AddColor.Location = new System.Drawing.Point(204, 3);
            this.btn_AddColor.Name = "btn_AddColor";
            this.btn_AddColor.Size = new System.Drawing.Size(89, 26);
            this.btn_AddColor.TabIndex = 4;
            this.btn_AddColor.Text = "Add Color";
            this.btn_AddColor.UseVisualStyleBackColor = true;
            this.btn_AddColor.Click += new System.EventHandler(this.btn_AddColor_Click);
            // 
            // lbl_PaletteName
            // 
            this.lbl_PaletteName.AutoSize = true;
            this.lbl_PaletteName.Location = new System.Drawing.Point(299, 6);
            this.lbl_PaletteName.Name = "lbl_PaletteName";
            this.lbl_PaletteName.Size = new System.Drawing.Size(40, 13);
            this.lbl_PaletteName.TabIndex = 5;
            this.lbl_PaletteName.Text = "Palette";
            // 
            // txt_PaletteName
            // 
            this.txt_PaletteName.Location = new System.Drawing.Point(345, 3);
            this.txt_PaletteName.Name = "txt_PaletteName";
            this.txt_PaletteName.Size = new System.Drawing.Size(97, 20);
            this.txt_PaletteName.TabIndex = 5;
            this.txt_PaletteName.TextChanged += new System.EventHandler(this.txt_PaletteName_TextChanged);
            this.txt_PaletteName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_PaletteName_KeyDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(696, 501);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.PalettesListBox);
            this.Name = "Form1";
            this.Text = "Merddyn\'s Super Beautiful Palette Holder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ListBox PalettesListBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_AddPalette;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_PaletteName;
        private System.Windows.Forms.TextBox txt_PaletteName;
        private System.Windows.Forms.Button btn_AddColor;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_RemovePalette;
        private System.Windows.Forms.Button btn_RemoveColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_ColorList;
    }
}

