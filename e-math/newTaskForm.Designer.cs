
namespace e_math
{
    partial class newTaskForm
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
            this.answerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // answerButton
            // 
            this.answerButton.BackColor = System.Drawing.Color.White;
            this.answerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.answerButton.ForeColor = System.Drawing.Color.Green;
            this.answerButton.Location = new System.Drawing.Point(521, 569);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(190, 62);
            this.answerButton.TabIndex = 16;
            this.answerButton.Text = "Υποβολή Απάντησης";
            this.answerButton.UseVisualStyleBackColor = false;
            this.answerButton.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // newTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 660);
            this.Controls.Add(this.answerButton);
            this.Name = "newTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "newTaskForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button answerButton;
    }
}