namespace TestWF
{
    partial class Form2
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
            splitContainer1 = new SplitContainer();
            btnAdd = new Button();
            label1 = new Label();
            txtNumber = new TextBox();
            DGVTicket = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVTicket).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnAdd);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(txtNumber);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(DGVTicket);
            splitContainer1.Size = new Size(959, 525);
            splitContainer1.SplitterDistance = 319;
            splitContainer1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.AppWorkspace;
            btnAdd.Location = new Point(63, 78);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(136, 49);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Добавить ";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(137, 23);
            label1.TabIndex = 1;
            label1.Text = "Введите цифры ";
            // 
            // txtNumber
            // 
            txtNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumber.Location = new Point(12, 38);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(237, 34);
            txtNumber.TabIndex = 0;
            // 
            // DGVTicket
            // 
            DGVTicket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVTicket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVTicket.Dock = DockStyle.Fill;
            DGVTicket.Location = new Point(0, 0);
            DGVTicket.Name = "DGVTicket";
            DGVTicket.RowHeadersWidth = 51;
            DGVTicket.RowTemplate.Height = 29;
            DGVTicket.Size = new Size(636, 525);
            DGVTicket.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(959, 525);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVTicket).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView DGVTicket;
        private Label label1;
        private TextBox txtNumber;
        private Button btnAdd;
    }
}