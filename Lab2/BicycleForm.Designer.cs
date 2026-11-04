namespace Lab2
{
    partial class BicycleForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblStart = new Label();
            txtStart = new TextBox();
            lblEnd = new Label();
            txtEnd = new TextBox();
            btnCalculate = new Button();
            lblTotal = new Label();
            txtTotal = new TextBox();
            btnBack = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(200, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(102, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Bicycle";
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Font = new Font("Segoe UI", 10F);
            lblStart.Location = new Point(55, 90);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(202, 23);
            lblStart.TabIndex = 1;
            lblStart.Text = "Starting hour (0-23):";
            // 
            // txtStart
            // 
            txtStart.Font = new Font("Segoe UI", 10F);
            txtStart.Location = new Point(265, 87);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(160, 30);
            txtStart.TabIndex = 2;
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Font = new Font("Segoe UI", 10F);
            lblEnd.Location = new Point(55, 140);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(192, 23);
            lblEnd.TabIndex = 3;
            lblEnd.Text = "Ending hour (1-24):";
            // 
            // txtEnd
            // 
            txtEnd.Font = new Font("Segoe UI", 10F);
            txtEnd.Location = new Point(265, 137);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(160, 30);
            txtEnd.TabIndex = 4;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCalculate.Location = new Point(265, 185);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(160, 38);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotal.Location = new Point(55, 245);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(54, 23);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 10F);
            txtTotal.Location = new Point(265, 242);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(160, 30);
            txtTotal.TabIndex = 7;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.Location = new Point(95, 315);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 38);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 10F);
            btnLogout.Location = new Point(275, 315);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(120, 38);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // BicycleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 390);
            Controls.Add(btnLogout);
            Controls.Add(btnBack);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(btnCalculate);
            Controls.Add(txtEnd);
            Controls.Add(lblEnd);
            Controls.Add(txtStart);
            Controls.Add(lblStart);
            Controls.Add(lblTitle);
            Name = "BicycleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bicycle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblStart;
        private TextBox txtStart;
        private Label lblEnd;
        private TextBox txtEnd;
        private Button btnCalculate;
        private Label lblTotal;
        private TextBox txtTotal;
        private Button btnBack;
        private Button btnLogout;
    }
}

