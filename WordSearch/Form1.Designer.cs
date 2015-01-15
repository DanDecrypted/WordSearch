namespace WordSearch
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditWord = new System.Windows.Forms.Button();
            this.txtEdit = new System.Windows.Forms.TextBox();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.lblWords = new System.Windows.Forms.Label();
            this.lstWords = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGridSize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.wordGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditWord);
            this.groupBox1.Controls.Add(this.txtEdit);
            this.groupBox1.Controls.Add(this.btnAddWord);
            this.groupBox1.Controls.Add(this.txtAdd);
            this.groupBox1.Controls.Add(this.lblWords);
            this.groupBox1.Controls.Add(this.lstWords);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnGridSize);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSize);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 428);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grid Settings ";
            // 
            // btnEditWord
            // 
            this.btnEditWord.Location = new System.Drawing.Point(112, 148);
            this.btnEditWord.Name = "btnEditWord";
            this.btnEditWord.Size = new System.Drawing.Size(48, 23);
            this.btnEditWord.TabIndex = 10;
            this.btnEditWord.Text = "Save";
            this.btnEditWord.UseVisualStyleBackColor = true;
            this.btnEditWord.Click += new System.EventHandler(this.btnEditWord_Click);
            // 
            // txtEdit
            // 
            this.txtEdit.Location = new System.Drawing.Point(6, 150);
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(100, 20);
            this.txtEdit.TabIndex = 9;
            // 
            // btnAddWord
            // 
            this.btnAddWord.Location = new System.Drawing.Point(112, 98);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(48, 23);
            this.btnAddWord.TabIndex = 8;
            this.btnAddWord.Text = "Add";
            this.btnAddWord.UseVisualStyleBackColor = true;
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(6, 100);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(100, 20);
            this.txtAdd.TabIndex = 7;
            // 
            // lblWords
            // 
            this.lblWords.AutoSize = true;
            this.lblWords.Location = new System.Drawing.Point(6, 188);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(102, 13);
            this.lblWords.TabIndex = 6;
            this.lblWords.Text = "Find these 10 words";
            // 
            // lstWords
            // 
            this.lstWords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstWords.FormattingEnabled = true;
            this.lstWords.Location = new System.Drawing.Point(6, 204);
            this.lstWords.Name = "lstWords";
            this.lstWords.Size = new System.Drawing.Size(120, 212);
            this.lstWords.TabIndex = 5;
            this.lstWords.SelectedIndexChanged += new System.EventHandler(this.lstWords_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Edit existing word...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add new word...";
            // 
            // btnGridSize
            // 
            this.btnGridSize.Location = new System.Drawing.Point(112, 43);
            this.btnGridSize.Name = "btnGridSize";
            this.btnGridSize.Size = new System.Drawing.Size(48, 23);
            this.btnGridSize.TabIndex = 2;
            this.btnGridSize.Text = "GO";
            this.btnGridSize.UseVisualStyleBackColor = true;
            this.btnGridSize.Click += new System.EventHandler(this.btnGridSize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter grid size: *Required";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(6, 45);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 20);
            this.txtSize.TabIndex = 0;
            // 
            // wordGrid
            // 
            this.wordGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.wordGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.wordGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wordGrid.ColumnHeadersVisible = false;
            this.wordGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wordGrid.Location = new System.Drawing.Point(168, 0);
            this.wordGrid.Name = "wordGrid";
            this.wordGrid.RowHeadersVisible = false;
            this.wordGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.wordGrid.ShowCellToolTips = false;
            this.wordGrid.ShowEditingIcon = false;
            this.wordGrid.Size = new System.Drawing.Size(458, 428);
            this.wordGrid.TabIndex = 11;
            this.wordGrid.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.wordGrid_CellStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 428);
            this.Controls.Add(this.wordGrid);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Word Search ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditWord;
        private System.Windows.Forms.TextBox txtEdit;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.ListBox lstWords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGridSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.DataGridView wordGrid;
    }
}

