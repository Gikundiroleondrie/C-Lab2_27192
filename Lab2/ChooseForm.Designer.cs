namespace Lab2
{
    partial class ChooseForm
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
            btnBicycle = new Button();
            btnMushroom = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(195, 45);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(105, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Choose";
            // 
            // btnBicycle
            // 
            btnBicycle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBicycle.Location = new Point(80, 130);
            btnBicycle.Name = "btnBicycle";
            btnBicycle.Size = new Size(145, 50);
            btnBicycle.TabIndex = 1;
            btnBicycle.Text = "Bicycle";
            btnBicycle.UseVisualStyleBackColor = true;
            btnBicycle.Click += btnBicycle_Click;
            // 
            // btnMushroom
            // 
            btnMushroom.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnMushroom.Location = new Point(260, 130);
            btnMushroom.Name = "btnMushroom";
            btnMushroom.Size = new Size(145, 50);
            btnMushroom.TabIndex = 2;
            btnMushroom.Text = "Mushroom";
            btnMushroom.UseVisualStyleBackColor = true;
            btnMushroom.Click += btnMushroom_Click;
            // 
            // ChooseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 280);
            Controls.Add(btnMushroom);
            Controls.Add(btnBicycle);
            Controls.Add(lblTitle);
            Name = "ChooseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Choose";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnBicycle;
        private Button btnMushroom;
    }
}

