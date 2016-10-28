namespace SQL_Beautifier
{
    partial class FormTab
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
      this.textBoxSQL = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.Queries = new System.Windows.Forms.TabPage();
      this.comboBoxChoices = new System.Windows.Forms.ComboBox();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.listViewKeywords = new System.Windows.Forms.ListView();
      this.buttonRemoveListviewItem = new System.Windows.Forms.Button();
      this.buttonAddListviewItem = new System.Windows.Forms.Button();
      this.textBoxListviewItem = new System.Windows.Forms.TextBox();
      this.tabControl1.SuspendLayout();
      this.Queries.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBoxSQL
      // 
      this.textBoxSQL.Location = new System.Drawing.Point(6, 23);
      this.textBoxSQL.Multiline = true;
      this.textBoxSQL.Name = "textBoxSQL";
      this.textBoxSQL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBoxSQL.Size = new System.Drawing.Size(346, 255);
      this.textBoxSQL.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 7);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(59, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "SQL Query";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(277, 284);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 4;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.buttonExecuteChoice_Click);
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.Queries);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(12, 12);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(365, 341);
      this.tabControl1.TabIndex = 5;
      // 
      // Queries
      // 
      this.Queries.Controls.Add(this.comboBoxChoices);
      this.Queries.Controls.Add(this.textBoxSQL);
      this.Queries.Controls.Add(this.button1);
      this.Queries.Controls.Add(this.label1);
      this.Queries.Location = new System.Drawing.Point(4, 22);
      this.Queries.Name = "Queries";
      this.Queries.Padding = new System.Windows.Forms.Padding(3);
      this.Queries.Size = new System.Drawing.Size(357, 315);
      this.Queries.TabIndex = 0;
      this.Queries.Text = "Query";
      this.Queries.UseVisualStyleBackColor = true;
      // 
      // comboBoxChoices
      // 
      this.comboBoxChoices.FormattingEnabled = true;
      this.comboBoxChoices.Items.AddRange(new object[] {
            "Beautify",
            "Commafy",
            "Quoteify",
            "Unquoteify"});
      this.comboBoxChoices.Location = new System.Drawing.Point(150, 284);
      this.comboBoxChoices.Name = "comboBoxChoices";
      this.comboBoxChoices.Size = new System.Drawing.Size(121, 21);
      this.comboBoxChoices.TabIndex = 6;
      this.comboBoxChoices.SelectedIndexChanged += new System.EventHandler(this.comboBoxChoices_SelectedIndexChanged);
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.textBoxListviewItem);
      this.tabPage2.Controls.Add(this.buttonAddListviewItem);
      this.tabPage2.Controls.Add(this.buttonRemoveListviewItem);
      this.tabPage2.Controls.Add(this.listViewKeywords);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(357, 315);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "SQL Keywords";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // listViewKeywords
      // 
      this.listViewKeywords.Location = new System.Drawing.Point(3, 6);
      this.listViewKeywords.Name = "listViewKeywords";
      this.listViewKeywords.Size = new System.Drawing.Size(348, 274);
      this.listViewKeywords.TabIndex = 0;
      this.listViewKeywords.UseCompatibleStateImageBehavior = false;
      // 
      // buttonRemoveListviewItem
      // 
      this.buttonRemoveListviewItem.Location = new System.Drawing.Point(276, 286);
      this.buttonRemoveListviewItem.Name = "buttonRemoveListviewItem";
      this.buttonRemoveListviewItem.Size = new System.Drawing.Size(75, 23);
      this.buttonRemoveListviewItem.TabIndex = 1;
      this.buttonRemoveListviewItem.Text = "Remove";
      this.buttonRemoveListviewItem.UseVisualStyleBackColor = true;
      this.buttonRemoveListviewItem.Click += new System.EventHandler(this.buttonRemoveListviewItem_Click);
      // 
      // buttonAddListviewItem
      // 
      this.buttonAddListviewItem.Location = new System.Drawing.Point(112, 286);
      this.buttonAddListviewItem.Name = "buttonAddListviewItem";
      this.buttonAddListviewItem.Size = new System.Drawing.Size(39, 23);
      this.buttonAddListviewItem.TabIndex = 2;
      this.buttonAddListviewItem.Text = "Add";
      this.buttonAddListviewItem.UseVisualStyleBackColor = true;
      this.buttonAddListviewItem.Click += new System.EventHandler(this.buttonAddListviewItem_Click);
      // 
      // textBoxListviewItem
      // 
      this.textBoxListviewItem.Location = new System.Drawing.Point(6, 286);
      this.textBoxListviewItem.Name = "textBoxListviewItem";
      this.textBoxListviewItem.Size = new System.Drawing.Size(100, 20);
      this.textBoxListviewItem.TabIndex = 3;
      // 
      // FormTab
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(389, 365);
      this.Controls.Add(this.tabControl1);
      this.Name = "FormTab";
      this.Text = "Dillon SQL Beautifier";
      this.tabControl1.ResumeLayout(false);
      this.Queries.ResumeLayout(false);
      this.Queries.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSQL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage Queries;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.ListView listViewKeywords;
    private System.Windows.Forms.ComboBox comboBoxChoices;
    private System.Windows.Forms.TextBox textBoxListviewItem;
    private System.Windows.Forms.Button buttonAddListviewItem;
    private System.Windows.Forms.Button buttonRemoveListviewItem;
  }
}

