
namespace e_math
{
    partial class TheoryForm
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
            this.theoryButton = new System.Windows.Forms.Button();
            this.exercisesΒutton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // theoryButton
            // 
            this.theoryButton.BackColor = System.Drawing.Color.White;
            this.theoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.theoryButton.ForeColor = System.Drawing.Color.Purple;
            this.theoryButton.Location = new System.Drawing.Point(50, 196);
            this.theoryButton.Name = "theoryButton";
            this.theoryButton.Size = new System.Drawing.Size(170, 82);
            this.theoryButton.TabIndex = 7;
            this.theoryButton.Text = "Θεωρία";
            this.theoryButton.UseVisualStyleBackColor = false;
            this.theoryButton.Click += new System.EventHandler(this.theoryButton_Click);
            // 
            // exercisesΒutton
            // 
            this.exercisesΒutton.BackColor = System.Drawing.Color.White;
            this.exercisesΒutton.Enabled = false;
            this.exercisesΒutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.exercisesΒutton.ForeColor = System.Drawing.Color.Purple;
            this.exercisesΒutton.Location = new System.Drawing.Point(250, 196);
            this.exercisesΒutton.Name = "exercisesΒutton";
            this.exercisesΒutton.Size = new System.Drawing.Size(170, 82);
            this.exercisesΒutton.TabIndex = 8;
            this.exercisesΒutton.Text = "Ασκήσεις";
            this.exercisesΒutton.UseVisualStyleBackColor = false;
            this.exercisesΒutton.Click += new System.EventHandler(this.exercisesΒutton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(448, 165);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "Χρήσιμες οδηγίες\nΒημα 1: Πατώντας το κουμπί θεωρία, κάντε επανάληψη στο κεφάλαιο " +
    "που επιθυμείτε. \nΒημα 2: Αφού κατανοήσετε τη θεωρία προχωρήστε στις Ασκήσεις.";
            // 
            // TheoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 300);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.exercisesΒutton);
            this.Controls.Add(this.theoryButton);
            this.Name = "TheoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TheoryForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Theory_FormClosed);
            this.Load += new System.EventHandler(this.Theory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button theoryButton;
        private System.Windows.Forms.Button exercisesΒutton;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}