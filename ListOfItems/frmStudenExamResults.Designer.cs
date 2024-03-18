
namespace ListOfItems
{
    partial class frmStudenExamResults
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbAddNew = new System.Windows.Forms.GroupBox();
            this.grbDetails = new System.Windows.Forms.GroupBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblNameSurname = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtNameSurname = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.txtMidTerm = new System.Windows.Forms.TextBox();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblMidTerm = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.grdList = new System.Windows.Forms.DataGridView();
            this.clmOrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNameSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMidTerm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExamNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbAddNew.SuspendLayout();
            this.grbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).BeginInit();
            this.SuspendLayout();
            // 
            // grbAddNew
            // 
            this.grbAddNew.Controls.Add(this.btnRemove);
            this.grbAddNew.Controls.Add(this.btnAdd);
            this.grbAddNew.Controls.Add(this.txtFinal);
            this.grbAddNew.Controls.Add(this.txtMidTerm);
            this.grbAddNew.Controls.Add(this.lblFinal);
            this.grbAddNew.Controls.Add(this.lblMidTerm);
            this.grbAddNew.Controls.Add(this.txtNameSurname);
            this.grbAddNew.Controls.Add(this.txtNumber);
            this.grbAddNew.Controls.Add(this.lblNameSurname);
            this.grbAddNew.Controls.Add(this.lblNumber);
            this.grbAddNew.Location = new System.Drawing.Point(12, 12);
            this.grbAddNew.Name = "grbAddNew";
            this.grbAddNew.Size = new System.Drawing.Size(776, 124);
            this.grbAddNew.TabIndex = 0;
            this.grbAddNew.TabStop = false;
            this.grbAddNew.Text = "Add New";
            // 
            // grbDetails
            // 
            this.grbDetails.Controls.Add(this.grdList);
            this.grbDetails.Location = new System.Drawing.Point(12, 152);
            this.grbDetails.Name = "grbDetails";
            this.grbDetails.Size = new System.Drawing.Size(776, 267);
            this.grbDetails.TabIndex = 1;
            this.grbDetails.TabStop = false;
            this.grbDetails.Text = "Add New";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(19, 32);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(44, 13);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Number";
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.AutoSize = true;
            this.lblNameSurname.Location = new System.Drawing.Point(19, 66);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(80, 13);
            this.lblNameSurname.TabIndex = 1;
            this.lblNameSurname.Text = "Name Surname";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(152, 25);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 2;
            // 
            // txtNameSurname
            // 
            this.txtNameSurname.Location = new System.Drawing.Point(152, 63);
            this.txtNameSurname.Name = "txtNameSurname";
            this.txtNameSurname.Size = new System.Drawing.Size(253, 20);
            this.txtNameSurname.TabIndex = 3;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(589, 66);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(100, 20);
            this.txtFinal.TabIndex = 7;
            // 
            // txtMidTerm
            // 
            this.txtMidTerm.Location = new System.Drawing.Point(589, 28);
            this.txtMidTerm.Name = "txtMidTerm";
            this.txtMidTerm.Size = new System.Drawing.Size(100, 20);
            this.txtMidTerm.TabIndex = 6;
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(456, 69);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(58, 13);
            this.lblFinal.TabIndex = 5;
            this.lblFinal.Text = "Final Exam";
            // 
            // lblMidTerm
            // 
            this.lblMidTerm.AutoSize = true;
            this.lblMidTerm.Location = new System.Drawing.Point(456, 35);
            this.lblMidTerm.Name = "lblMidTerm";
            this.lblMidTerm.Size = new System.Drawing.Size(80, 13);
            this.lblMidTerm.TabIndex = 4;
            this.lblMidTerm.Text = "Mid-Term Exam";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(711, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(711, 60);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(59, 23);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // grdList
            // 
            this.grdList.AllowUserToAddRows = false;
            this.grdList.AllowUserToDeleteRows = false;
            this.grdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmOrderNo,
            this.clmNumber,
            this.clmNameSurname,
            this.clmMidTerm,
            this.clmFinal,
            this.clmExamNote,
            this.clmState});
            this.grdList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdList.Location = new System.Drawing.Point(3, 16);
            this.grdList.Name = "grdList";
            this.grdList.ReadOnly = true;
            this.grdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdList.Size = new System.Drawing.Size(770, 248);
            this.grdList.TabIndex = 0;
            // 
            // clmOrderNo
            // 
            this.clmOrderNo.HeaderText = "Order N.";
            this.clmOrderNo.Name = "clmOrderNo";
            this.clmOrderNo.ReadOnly = true;
            this.clmOrderNo.Width = 75;
            // 
            // clmNumber
            // 
            this.clmNumber.HeaderText = "Number";
            this.clmNumber.Name = "clmNumber";
            this.clmNumber.ReadOnly = true;
            // 
            // clmNameSurname
            // 
            this.clmNameSurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmNameSurname.HeaderText = "Name Surname";
            this.clmNameSurname.Name = "clmNameSurname";
            this.clmNameSurname.ReadOnly = true;
            // 
            // clmMidTerm
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmMidTerm.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmMidTerm.HeaderText = "Mid Term";
            this.clmMidTerm.Name = "clmMidTerm";
            this.clmMidTerm.ReadOnly = true;
            // 
            // clmFinal
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmFinal.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmFinal.HeaderText = "Final";
            this.clmFinal.Name = "clmFinal";
            this.clmFinal.ReadOnly = true;
            this.clmFinal.Width = 75;
            // 
            // clmExamNote
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmExamNote.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmExamNote.HeaderText = "Exam Note";
            this.clmExamNote.Name = "clmExamNote";
            this.clmExamNote.ReadOnly = true;
            this.clmExamNote.Width = 85;
            // 
            // clmState
            // 
            this.clmState.HeaderText = "State";
            this.clmState.Name = "clmState";
            this.clmState.ReadOnly = true;
            this.clmState.Width = 75;
            // 
            // frmStudenExamResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 429);
            this.Controls.Add(this.grbDetails);
            this.Controls.Add(this.grbAddNew);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudenExamResults";
            this.Text = "Student Exam Results";
            this.grbAddNew.ResumeLayout(false);
            this.grbAddNew.PerformLayout();
            this.grbDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAddNew;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.TextBox txtMidTerm;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblMidTerm;
        private System.Windows.Forms.TextBox txtNameSurname;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNameSurname;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.GroupBox grbDetails;
        private System.Windows.Forms.DataGridView grdList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNameSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMidTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExamNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmState;
    }
}

