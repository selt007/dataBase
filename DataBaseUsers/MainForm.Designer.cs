namespace DataBaseUsers
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonAddID = new System.Windows.Forms.Button();
            this.panelData = new System.Windows.Forms.Panel();
            this.textBoxAddID = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.BackColor = System.Drawing.Color.Honeydew;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(253, 12);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(114, 60);
            this.buttonUpdate.TabIndex = 0;
            this.buttonUpdate.Text = "Обновить файлы";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(12, 14);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(235, 21);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonAddID
            // 
            this.buttonAddID.BackColor = System.Drawing.Color.LightCyan;
            this.buttonAddID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddID.Location = new System.Drawing.Point(142, 45);
            this.buttonAddID.Name = "buttonAddID";
            this.buttonAddID.Size = new System.Drawing.Size(105, 27);
            this.buttonAddID.TabIndex = 3;
            this.buttonAddID.Text = "Добавить ID";
            this.buttonAddID.UseVisualStyleBackColor = false;
            this.buttonAddID.Click += new System.EventHandler(this.buttonAddID_Click);
            // 
            // panelData
            // 
            this.panelData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelData.Location = new System.Drawing.Point(12, 78);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(355, 263);
            this.panelData.TabIndex = 4;
            // 
            // textBoxAddID
            // 
            this.textBoxAddID.Location = new System.Drawing.Point(12, 49);
            this.textBoxAddID.Mask = "ID-00000";
            this.textBoxAddID.Name = "textBoxAddID";
            this.textBoxAddID.PromptChar = 'X';
            this.textBoxAddID.Size = new System.Drawing.Size(124, 20);
            this.textBoxAddID.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(379, 353);
            this.Controls.Add(this.textBoxAddID);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.buttonAddID);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База данных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonAddID;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.MaskedTextBox textBoxAddID;
    }
}

