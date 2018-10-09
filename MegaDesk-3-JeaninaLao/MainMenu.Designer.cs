namespace MegaDesk_3_JeaninaLao
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.AddQuoteButton = new System.Windows.Forms.Button();
            this.viewQuoteButton = new System.Windows.Forms.Button();
            this.SearchQuote = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(340, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 343);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(250, 23);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(263, 29);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Welcome to MegaDesk";
            // 
            // AddQuoteButton
            // 
            this.AddQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQuoteButton.Location = new System.Drawing.Point(23, 69);
            this.AddQuoteButton.Name = "AddQuoteButton";
            this.AddQuoteButton.Size = new System.Drawing.Size(267, 68);
            this.AddQuoteButton.TabIndex = 2;
            this.AddQuoteButton.Text = "Add Quote";
            this.AddQuoteButton.UseVisualStyleBackColor = true;
            this.AddQuoteButton.Click += new System.EventHandler(this.AddQuoteButton_Click);
            // 
            // viewQuoteButton
            // 
            this.viewQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuoteButton.Location = new System.Drawing.Point(23, 162);
            this.viewQuoteButton.Name = "viewQuoteButton";
            this.viewQuoteButton.Size = new System.Drawing.Size(267, 68);
            this.viewQuoteButton.TabIndex = 3;
            this.viewQuoteButton.Text = "View Quotes";
            this.viewQuoteButton.UseVisualStyleBackColor = true;
            this.viewQuoteButton.Click += new System.EventHandler(this.viewQuoteButton_Click);
            // 
            // SearchQuote
            // 
            this.SearchQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchQuote.Location = new System.Drawing.Point(23, 253);
            this.SearchQuote.Name = "SearchQuote";
            this.SearchQuote.Size = new System.Drawing.Size(267, 68);
            this.SearchQuote.TabIndex = 4;
            this.SearchQuote.Text = "Search Quotes";
            this.SearchQuote.UseVisualStyleBackColor = true;
            this.SearchQuote.Click += new System.EventHandler(this.SearchQuote_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(23, 344);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(267, 68);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.SearchQuote);
            this.Controls.Add(this.viewQuoteButton);
            this.Controls.Add(this.AddQuoteButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainMenu";
            this.Text = "MegaDesk";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button AddQuoteButton;
        private System.Windows.Forms.Button viewQuoteButton;
        private System.Windows.Forms.Button SearchQuote;
        private System.Windows.Forms.Button exitButton;
    }
}

