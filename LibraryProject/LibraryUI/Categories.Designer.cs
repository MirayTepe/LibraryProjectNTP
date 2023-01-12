namespace LibraryProject.LibraryUI
{
    partial class Categories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
            this.dgwCategroyList = new System.Windows.Forms.DataGridView();
            this.lblMemberNumber = new System.Windows.Forms.Label();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.tbxCategoryName = new System.Windows.Forms.TextBox();
            this.tbxCategoryId = new System.Windows.Forms.TextBox();
            this.groupBoxCategory = new System.Windows.Forms.GroupBox();
            this.btnCategorySave = new System.Windows.Forms.Button();
            this.btnCategoryDelete = new System.Windows.Forms.Button();
            this.btnCategoryUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCategroyList)).BeginInit();
            this.groupBoxCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwCategroyList
            // 
            this.dgwCategroyList.AllowUserToAddRows = false;
            this.dgwCategroyList.AllowUserToDeleteRows = false;
            this.dgwCategroyList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwCategroyList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwCategroyList.BackgroundColor = System.Drawing.Color.White;
            this.dgwCategroyList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwCategroyList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwCategroyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwCategroyList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwCategroyList.GridColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.dgwCategroyList, "dgwCategroyList");
            this.dgwCategroyList.Name = "dgwCategroyList";
            this.dgwCategroyList.ReadOnly = true;
            this.dgwCategroyList.RowTemplate.Height = 24;
            this.dgwCategroyList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCategroyList_CellClick);
            // 
            // lblMemberNumber
            // 
            resources.ApplyResources(this.lblMemberNumber, "lblMemberNumber");
            this.lblMemberNumber.BackColor = System.Drawing.Color.White;
            this.lblMemberNumber.ForeColor = System.Drawing.Color.Black;
            this.lblMemberNumber.Name = "lblMemberNumber";
            // 
            // lblCategoryId
            // 
            resources.ApplyResources(this.lblCategoryId, "lblCategoryId");
            this.lblCategoryId.BackColor = System.Drawing.Color.White;
            this.lblCategoryId.ForeColor = System.Drawing.Color.Black;
            this.lblCategoryId.Name = "lblCategoryId";
            // 
            // tbxCategoryName
            // 
            this.tbxCategoryName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.tbxCategoryName, "tbxCategoryName");
            this.tbxCategoryName.ForeColor = System.Drawing.Color.White;
            this.tbxCategoryName.Name = "tbxCategoryName";
            // 
            // tbxCategoryId
            // 
            this.tbxCategoryId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.tbxCategoryId, "tbxCategoryId");
            this.tbxCategoryId.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbxCategoryId.Name = "tbxCategoryId";
            // 
            // groupBoxCategory
            // 
            this.groupBoxCategory.Controls.Add(this.btnCategorySave);
            this.groupBoxCategory.Controls.Add(this.btnCategoryDelete);
            this.groupBoxCategory.Controls.Add(this.btnCategoryUpdate);
            this.groupBoxCategory.Controls.Add(this.lblCategoryId);
            this.groupBoxCategory.Controls.Add(this.tbxCategoryId);
            this.groupBoxCategory.Controls.Add(this.lblMemberNumber);
            this.groupBoxCategory.Controls.Add(this.tbxCategoryName);
            resources.ApplyResources(this.groupBoxCategory, "groupBoxCategory");
            this.groupBoxCategory.Name = "groupBoxCategory";
            this.groupBoxCategory.TabStop = false;
            // 
            // btnCategorySave
            // 
            resources.ApplyResources(this.btnCategorySave, "btnCategorySave");
            this.btnCategorySave.Name = "btnCategorySave";
            this.btnCategorySave.UseVisualStyleBackColor = true;
            this.btnCategorySave.Click += new System.EventHandler(this.btnCategorySave_Click);
            // 
            // btnCategoryDelete
            // 
            resources.ApplyResources(this.btnCategoryDelete, "btnCategoryDelete");
            this.btnCategoryDelete.Name = "btnCategoryDelete";
            this.btnCategoryDelete.UseVisualStyleBackColor = true;
            this.btnCategoryDelete.Click += new System.EventHandler(this.btnCategoryDelete_Click);
            // 
            // btnCategoryUpdate
            // 
            resources.ApplyResources(this.btnCategoryUpdate, "btnCategoryUpdate");
            this.btnCategoryUpdate.Name = "btnCategoryUpdate";
            this.btnCategoryUpdate.UseVisualStyleBackColor = true;
            this.btnCategoryUpdate.Click += new System.EventHandler(this.btnCategoryUpdate_Click);
            // 
            // Categories
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBoxCategory);
            this.Controls.Add(this.dgwCategroyList);
            this.Name = "Categories";
            this.Load += new System.EventHandler(this.Categories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCategroyList)).EndInit();
            this.groupBoxCategory.ResumeLayout(false);
            this.groupBoxCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCategroyList;
        private System.Windows.Forms.Label lblMemberNumber;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.TextBox tbxCategoryName;
        private System.Windows.Forms.TextBox tbxCategoryId;
        private System.Windows.Forms.GroupBox groupBoxCategory;
        private System.Windows.Forms.Button btnCategorySave;
        private System.Windows.Forms.Button btnCategoryDelete;
        private System.Windows.Forms.Button btnCategoryUpdate;
    }
}