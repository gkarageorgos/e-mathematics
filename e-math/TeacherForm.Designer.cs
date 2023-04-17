
namespace e_math
{
    partial class TeacherForm
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
            this.studentListView = new System.Windows.Forms.ListView();
            this.usernameColumnHeadear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.score1ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.score2ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.score3ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.score4ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.score5ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.score6ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scoreColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.levelColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // studentListView
            // 
            this.studentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.usernameColumnHeadear,
            this.score1ColumnHeader,
            this.score2ColumnHeader,
            this.score3ColumnHeader,
            this.score4ColumnHeader,
            this.score5ColumnHeader,
            this.score6ColumnHeader,
            this.scoreColumnHeader,
            this.levelColumnHeader});
            this.studentListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.studentListView.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.studentListView.GridLines = true;
            this.studentListView.HideSelection = false;
            this.studentListView.Location = new System.Drawing.Point(12, 12);
            this.studentListView.Name = "studentListView";
            this.studentListView.Size = new System.Drawing.Size(1407, 639);
            this.studentListView.TabIndex = 0;
            this.studentListView.UseCompatibleStateImageBehavior = false;
            this.studentListView.View = System.Windows.Forms.View.Details;
            // 
            // usernameColumnHeadear
            // 
            this.usernameColumnHeadear.Text = "Όνομα χρήστη";
            this.usernameColumnHeadear.Width = 173;
            // 
            // score1ColumnHeader
            // 
            this.score1ColumnHeader.Text = "Ενότητα 1";
            this.score1ColumnHeader.Width = 143;
            // 
            // score2ColumnHeader
            // 
            this.score2ColumnHeader.Text = "Ενότητα 2";
            this.score2ColumnHeader.Width = 142;
            // 
            // score3ColumnHeader
            // 
            this.score3ColumnHeader.Text = "Ενότητα 3";
            this.score3ColumnHeader.Width = 136;
            // 
            // score4ColumnHeader
            // 
            this.score4ColumnHeader.Text = "Ενότητα 4";
            this.score4ColumnHeader.Width = 136;
            // 
            // score5ColumnHeader
            // 
            this.score5ColumnHeader.Text = "Ενότητα 5";
            this.score5ColumnHeader.Width = 142;
            // 
            // score6ColumnHeader
            // 
            this.score6ColumnHeader.Text = "Ενότητα 6";
            this.score6ColumnHeader.Width = 137;
            // 
            // scoreColumnHeader
            // 
            this.scoreColumnHeader.Text = "Συνολική βαθμολογία";
            this.scoreColumnHeader.Width = 267;
            // 
            // levelColumnHeader
            // 
            this.levelColumnHeader.Text = "Επίπεδο";
            this.levelColumnHeader.Width = 125;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 663);
            this.Controls.Add(this.studentListView);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeacherForm_FormClosed);
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView studentListView;
        private System.Windows.Forms.ColumnHeader usernameColumnHeadear;
        private System.Windows.Forms.ColumnHeader score1ColumnHeader;
        private System.Windows.Forms.ColumnHeader score2ColumnHeader;
        private System.Windows.Forms.ColumnHeader score3ColumnHeader;
        private System.Windows.Forms.ColumnHeader score4ColumnHeader;
        private System.Windows.Forms.ColumnHeader score5ColumnHeader;
        private System.Windows.Forms.ColumnHeader score6ColumnHeader;
        private System.Windows.Forms.ColumnHeader scoreColumnHeader;
        private System.Windows.Forms.ColumnHeader levelColumnHeader;
    }
}