
namespace BasicFacebookFeatures.Checkers
{
    partial class FormPostResult
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
            this.textBoxResultToPost = new System.Windows.Forms.TextBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelGeneralMessage = new System.Windows.Forms.Label();
            this.labelAskToPost = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxResultToPost
            // 
            this.textBoxResultToPost.Location = new System.Drawing.Point(12, 60);
            this.textBoxResultToPost.Multiline = true;
            this.textBoxResultToPost.Name = "textBoxResultToPost";
            this.textBoxResultToPost.Size = new System.Drawing.Size(200, 156);
            this.textBoxResultToPost.TabIndex = 0;
            // 
            // buttonPost
            // 
            this.buttonPost.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonPost.Location = new System.Drawing.Point(12, 248);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(75, 23);
            this.buttonPost.TabIndex = 1;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(137, 248);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelGeneralMessage
            // 
            this.labelGeneralMessage.AutoSize = true;
            this.labelGeneralMessage.Location = new System.Drawing.Point(51, 9);
            this.labelGeneralMessage.Name = "labelGeneralMessage";
            this.labelGeneralMessage.Size = new System.Drawing.Size(93, 13);
            this.labelGeneralMessage.TabIndex = 3;
            this.labelGeneralMessage.Text = "Match has ended!";
            // 
            // labelAskToPost
            // 
            this.labelAskToPost.AutoSize = true;
            this.labelAskToPost.Location = new System.Drawing.Point(9, 219);
            this.labelAskToPost.Name = "labelAskToPost";
            this.labelAskToPost.Size = new System.Drawing.Size(206, 13);
            this.labelAskToPost.TabIndex = 4;
            this.labelAskToPost.Text = "Would you like to post this on your profile?";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(9, 32);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(59, 13);
            this.labelResult.TabIndex = 5;
            this.labelResult.Text = "labelResult";
            // 
            // FormPostResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 279);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelAskToPost);
            this.Controls.Add(this.labelGeneralMessage);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.textBoxResultToPost);
            this.Name = "FormPostResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "The epic match has ended!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResultToPost;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelGeneralMessage;
        private System.Windows.Forms.Label labelAskToPost;
        private System.Windows.Forms.Label labelResult;
    }
}