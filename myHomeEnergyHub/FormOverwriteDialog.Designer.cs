
namespace myHomeEnergyHub
{
    partial class FormOverwriteDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOverwriteDialog));
            this.btnOverwrite = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnOverwriteAll = new System.Windows.Forms.Button();
            this.btnSkipAll = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOverwrite
            // 
            this.btnOverwrite.Location = new System.Drawing.Point(52, 370);
            this.btnOverwrite.Name = "btnOverwrite";
            this.btnOverwrite.Size = new System.Drawing.Size(113, 47);
            this.btnOverwrite.TabIndex = 0;
            this.btnOverwrite.Text = "Overwrite";
            this.btnOverwrite.UseVisualStyleBackColor = true;
            this.btnOverwrite.Click += new System.EventHandler(this.btnOverwrite_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(191, 370);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(113, 47);
            this.btnSkip.TabIndex = 1;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnOverwriteAll
            // 
            this.btnOverwriteAll.Location = new System.Drawing.Point(331, 370);
            this.btnOverwriteAll.Name = "btnOverwriteAll";
            this.btnOverwriteAll.Size = new System.Drawing.Size(113, 47);
            this.btnOverwriteAll.TabIndex = 2;
            this.btnOverwriteAll.Text = "Overwrite All";
            this.btnOverwriteAll.UseVisualStyleBackColor = true;
            this.btnOverwriteAll.Click += new System.EventHandler(this.btnOverwriteAll_Click);
            // 
            // btnSkipAll
            // 
            this.btnSkipAll.Location = new System.Drawing.Point(463, 370);
            this.btnSkipAll.Name = "btnSkipAll";
            this.btnSkipAll.Size = new System.Drawing.Size(113, 47);
            this.btnSkipAll.TabIndex = 3;
            this.btnSkipAll.Text = "Skip All";
            this.btnSkipAll.UseVisualStyleBackColor = true;
            this.btnSkipAll.Click += new System.EventHandler(this.btnSkipAll_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(81, 81);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(29, 20);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "[...]";
            // 
            // FormOverwriteDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnSkipAll);
            this.Controls.Add(this.btnOverwriteAll);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnOverwrite);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOverwriteDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Overwrite?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOverwrite;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnOverwriteAll;
        private System.Windows.Forms.Button btnSkipAll;
        private System.Windows.Forms.Label lblMessage;
    }
}