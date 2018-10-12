namespace MegaDesk_3_JeaninaLao
{
    partial class AddQuote
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
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.widthLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.numericWidthBox = new System.Windows.Forms.NumericUpDown();
            this.numericDepthBox = new System.Windows.Forms.NumericUpDown();
            this.deskBox = new System.Windows.Forms.GroupBox();
            this.optionsBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rushBox = new System.Windows.Forms.ComboBox();
            this.materialBox = new System.Windows.Forms.ComboBox();
            this.deskNumerLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.drawerNumberBox = new System.Windows.Forms.NumericUpDown();
            this.customerLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.titleLabelAddQuote = new System.Windows.Forms.Label();
            this.btnGetQuote = new System.Windows.Forms.Button();
            this.quoteBox = new System.Windows.Forms.GroupBox();
            this.quoteLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDepthBox)).BeginInit();
            this.deskBox.SuspendLayout();
            this.optionsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawerNumberBox)).BeginInit();
            this.quoteBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Location = new System.Drawing.Point(375, 378);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(112, 35);
            this.MainMenuButton.TabIndex = 1;
            this.MainMenuButton.Text = "Cancel";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(20, 37);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(100, 15);
            this.widthLabel.TabIndex = 4;
            this.widthLabel.Text = "Enter desk width:";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(18, 73);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(102, 15);
            this.depthLabel.TabIndex = 5;
            this.depthLabel.Text = "Enter desk depth:";
            // 
            // numericWidthBox
            // 
            this.numericWidthBox.Location = new System.Drawing.Point(143, 37);
            this.numericWidthBox.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.numericWidthBox.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericWidthBox.Name = "numericWidthBox";
            this.numericWidthBox.Size = new System.Drawing.Size(78, 20);
            this.numericWidthBox.TabIndex = 6;
            this.numericWidthBox.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // numericDepthBox
            // 
            this.numericDepthBox.Location = new System.Drawing.Point(143, 73);
            this.numericDepthBox.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numericDepthBox.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericDepthBox.Name = "numericDepthBox";
            this.numericDepthBox.Size = new System.Drawing.Size(78, 20);
            this.numericDepthBox.TabIndex = 7;
            this.numericDepthBox.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // deskBox
            // 
            this.deskBox.Controls.Add(this.widthLabel);
            this.deskBox.Controls.Add(this.numericDepthBox);
            this.deskBox.Controls.Add(this.depthLabel);
            this.deskBox.Controls.Add(this.numericWidthBox);
            this.deskBox.Location = new System.Drawing.Point(70, 96);
            this.deskBox.Name = "deskBox";
            this.deskBox.Size = new System.Drawing.Size(268, 131);
            this.deskBox.TabIndex = 8;
            this.deskBox.TabStop = false;
            this.deskBox.Text = "Measurements";
            // 
            // optionsBox
            // 
            this.optionsBox.Controls.Add(this.label1);
            this.optionsBox.Controls.Add(this.rushBox);
            this.optionsBox.Controls.Add(this.materialBox);
            this.optionsBox.Controls.Add(this.deskNumerLabel);
            this.optionsBox.Controls.Add(this.label2);
            this.optionsBox.Controls.Add(this.drawerNumberBox);
            this.optionsBox.Location = new System.Drawing.Point(375, 96);
            this.optionsBox.Name = "optionsBox";
            this.optionsBox.Size = new System.Drawing.Size(278, 170);
            this.optionsBox.TabIndex = 9;
            this.optionsBox.TabStop = false;
            this.optionsBox.Text = "Order Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Rush Order Options:";
            // 
            // rushBox
            // 
            this.rushBox.FormattingEnabled = true;
            this.rushBox.Location = new System.Drawing.Point(141, 116);
            this.rushBox.Name = "rushBox";
            this.rushBox.Size = new System.Drawing.Size(121, 21);
            this.rushBox.TabIndex = 8;
            // 
            // materialBox
            // 
            this.materialBox.FormattingEnabled = true;
            this.materialBox.Location = new System.Drawing.Point(141, 72);
            this.materialBox.Name = "materialBox";
            this.materialBox.Size = new System.Drawing.Size(121, 21);
            this.materialBox.TabIndex = 7;
            // 
            // deskNumerLabel
            // 
            this.deskNumerLabel.AutoSize = true;
            this.deskNumerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskNumerLabel.Location = new System.Drawing.Point(18, 32);
            this.deskNumerLabel.Name = "deskNumerLabel";
            this.deskNumerLabel.Size = new System.Drawing.Size(117, 15);
            this.deskNumerLabel.TabIndex = 4;
            this.deskNumerLabel.Text = "Number of Drawers:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Surface Material:";
            // 
            // drawerNumberBox
            // 
            this.drawerNumberBox.Location = new System.Drawing.Point(141, 32);
            this.drawerNumberBox.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawerNumberBox.Name = "drawerNumberBox";
            this.drawerNumberBox.Size = new System.Drawing.Size(37, 20);
            this.drawerNumberBox.TabIndex = 6;
            this.drawerNumberBox.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(210, 48);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(100, 15);
            this.customerLabel.TabIndex = 10;
            this.customerLabel.Text = "Customer Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(316, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 11;
            // 
            // titleLabelAddQuote
            // 
            this.titleLabelAddQuote.AutoSize = true;
            this.titleLabelAddQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabelAddQuote.Location = new System.Drawing.Point(311, 9);
            this.titleLabelAddQuote.Name = "titleLabelAddQuote";
            this.titleLabelAddQuote.Size = new System.Drawing.Size(114, 25);
            this.titleLabelAddQuote.TabIndex = 12;
            this.titleLabelAddQuote.Text = "Add Quote";
            // 
            // btnGetQuote
            // 
            this.btnGetQuote.Location = new System.Drawing.Point(226, 378);
            this.btnGetQuote.Name = "btnGetQuote";
            this.btnGetQuote.Size = new System.Drawing.Size(112, 35);
            this.btnGetQuote.TabIndex = 13;
            this.btnGetQuote.Text = "Get Quote";
            this.btnGetQuote.UseVisualStyleBackColor = true;
            this.btnGetQuote.Click += new System.EventHandler(this.btnGetQuote_Click);
            // 
            // quoteBox
            // 
            this.quoteBox.Controls.Add(this.label3);
            this.quoteBox.Controls.Add(this.quoteLabel);
            this.quoteBox.Location = new System.Drawing.Point(70, 293);
            this.quoteBox.Name = "quoteBox";
            this.quoteBox.Size = new System.Drawing.Size(573, 64);
            this.quoteBox.TabIndex = 14;
            this.quoteBox.TabStop = false;
            this.quoteBox.Text = "Quote";
            // 
            // quoteLabel
            // 
            this.quoteLabel.AutoSize = true;
            this.quoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteLabel.Location = new System.Drawing.Point(167, 26);
            this.quoteLabel.Name = "quoteLabel";
            this.quoteLabel.Size = new System.Drawing.Size(73, 15);
            this.quoteLabel.TabIndex = 11;
            this.quoteLabel.Text = "Final Quote:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(255, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 15);
            this.label3.TabIndex = 12;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.quoteBox);
            this.Controls.Add(this.btnGetQuote);
            this.Controls.Add(this.titleLabelAddQuote);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.optionsBox);
            this.Controls.Add(this.deskBox);
            this.Controls.Add(this.MainMenuButton);
            this.Name = "AddQuote";
            this.Text = "OrderOptions";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numericWidthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDepthBox)).EndInit();
            this.deskBox.ResumeLayout(false);
            this.deskBox.PerformLayout();
            this.optionsBox.ResumeLayout(false);
            this.optionsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawerNumberBox)).EndInit();
            this.quoteBox.ResumeLayout(false);
            this.quoteBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.NumericUpDown numericWidthBox;
        private System.Windows.Forms.NumericUpDown numericDepthBox;
        private System.Windows.Forms.GroupBox deskBox;
        private System.Windows.Forms.GroupBox optionsBox;
        private System.Windows.Forms.Label deskNumerLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown drawerNumberBox;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label titleLabelAddQuote;
        private System.Windows.Forms.Button btnGetQuote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox rushBox;
        private System.Windows.Forms.ComboBox materialBox;
        private System.Windows.Forms.GroupBox quoteBox;
        public System.Windows.Forms.Label quoteLabel;
        private System.Windows.Forms.Label label3;
    }
}