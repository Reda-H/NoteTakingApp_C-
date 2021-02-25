namespace NoteWinApp
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
            this.noteTitle = new System.Windows.Forms.TextBox();
            this.noteTitleLabel = new System.Windows.Forms.Label();
            this.noteContentTextBox = new System.Windows.Forms.RichTextBox();
            this.listNodeLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.dataGridTable = new System.Windows.Forms.DataGridView();
            this.newButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTable)).BeginInit();
            this.SuspendLayout();
            // 
            // noteTitle
            // 
            this.noteTitle.Location = new System.Drawing.Point(491, 52);
            this.noteTitle.Name = "noteTitle";
            this.noteTitle.Size = new System.Drawing.Size(238, 22);
            this.noteTitle.TabIndex = 0;
            this.noteTitle.TextChanged += new System.EventHandler(this.noteTitle_TextChanged);
            // 
            // noteTitleLabel
            // 
            this.noteTitleLabel.AutoSize = true;
            this.noteTitleLabel.Location = new System.Drawing.Point(488, 32);
            this.noteTitleLabel.Name = "noteTitleLabel";
            this.noteTitleLabel.Size = new System.Drawing.Size(69, 17);
            this.noteTitleLabel.TabIndex = 1;
            this.noteTitleLabel.Text = "Note Title";
            // 
            // noteContentTextBox
            // 
            this.noteContentTextBox.Location = new System.Drawing.Point(491, 96);
            this.noteContentTextBox.Name = "noteContentTextBox";
            this.noteContentTextBox.Size = new System.Drawing.Size(238, 362);
            this.noteContentTextBox.TabIndex = 2;
            this.noteContentTextBox.Text = "";
            // 
            // listNodeLabel
            // 
            this.listNodeLabel.AutoSize = true;
            this.listNodeLabel.Location = new System.Drawing.Point(27, 32);
            this.listNodeLabel.Name = "listNodeLabel";
            this.listNodeLabel.Size = new System.Drawing.Size(64, 17);
            this.listNodeLabel.TabIndex = 4;
            this.listNodeLabel.Text = "All Notes";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(653, 477);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // dataGridTable
            // 
            this.dataGridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTable.Location = new System.Drawing.Point(30, 52);
            this.dataGridTable.Name = "dataGridTable";
            this.dataGridTable.ReadOnly = true;
            this.dataGridTable.RowHeadersWidth = 51;
            this.dataGridTable.RowTemplate.Height = 24;
            this.dataGridTable.Size = new System.Drawing.Size(395, 406);
            this.dataGridTable.TabIndex = 6;
            this.dataGridTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridTable.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTable_CellContentDoubleClick);
            this.dataGridTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(572, 477);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 7;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(491, 477);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(593, 31);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 17);
            this.labelID.TabIndex = 9;
            this.labelID.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 523);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.dataGridTable);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.listNodeLabel);
            this.Controls.Add(this.noteContentTextBox);
            this.Controls.Add(this.noteTitleLabel);
            this.Controls.Add(this.noteTitle);
            this.Name = "Form1";
            this.Text = "Note Application in C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox noteTitle;
        private System.Windows.Forms.Label noteTitleLabel;
        private System.Windows.Forms.RichTextBox noteContentTextBox;
        private System.Windows.Forms.Label listNodeLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView dataGridTable;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label labelID;
    }
}

