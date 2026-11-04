namespace Lab2
{
    partial class MushroomForm
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
            lblInfo = new Label();
            lblMushrooms = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblRing = new Label();
            txtRing = new TextBox();
            lblConvexCup = new Label();
            txtConvexCup = new TextBox();
            lblForest = new Label();
            txtForest = new TextBox();
            lblGills = new Label();
            txtGills = new TextBox();
            lblRedCap = new Label();
            txtRedCap = new TextBox();
            lblEdible = new Label();
            txtEdible = new TextBox();
            lblResult = new Label();
            txtResult = new TextBox();
            btnFind = new Button();
            btnClear = new Button();
            btnBack = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(235, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(150, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Mushroom";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblInfo.Location = new Point(40, 60);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(410, 21);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Think of one of these mushrooms (Answer yes or no):";
            // 
            // lblMushrooms
            // 
            lblMushrooms.AutoSize = true;
            lblMushrooms.Font = new Font("Segoe UI", 8.5F);
            lblMushrooms.Location = new Point(40, 85);
            lblMushrooms.Name = "lblMushrooms";
            lblMushrooms.Size = new Size(560, 38);
            lblMushrooms.TabIndex = 2;
            lblMushrooms.Text = "Agaric Jaunissant | Amanite tue-mouche | Amanite des Cesars | Cepe de bordeau\r\nCoprin chevelu | Girolle | Lepiota | Morille | Pied bleu | Russule";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F);
            lblName.Location = new Point(40, 135);
            lblName.Name = "lblName";
            lblName.Size = new Size(155, 23);
            lblName.TabIndex = 3;
            lblName.Text = "What's your name?";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(430, 132);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 30);
            txtName.TabIndex = 4;
            // 
            // lblRing
            // 
            lblRing.AutoSize = true;
            lblRing.Font = new Font("Segoe UI", 10F);
            lblRing.Location = new Point(40, 175);
            lblRing.Name = "lblRing";
            lblRing.Size = new Size(310, 23);
            lblRing.TabIndex = 5;
            lblRing.Text = "1) Does your mushroom have a ring?";
            // 
            // txtRing
            // 
            txtRing.Font = new Font("Segoe UI", 10F);
            txtRing.Location = new Point(430, 172);
            txtRing.Name = "txtRing";
            txtRing.Size = new Size(150, 30);
            txtRing.TabIndex = 6;
            // 
            // lblConvexCup
            // 
            lblConvexCup.AutoSize = true;
            lblConvexCup.Font = new Font("Segoe UI", 10F);
            lblConvexCup.Location = new Point(40, 215);
            lblConvexCup.Name = "lblConvexCup";
            lblConvexCup.Size = new Size(350, 23);
            lblConvexCup.TabIndex = 7;
            lblConvexCup.Text = "2) Does your mushroom have a convex cup?";
            // 
            // txtConvexCup
            // 
            txtConvexCup.Font = new Font("Segoe UI", 10F);
            txtConvexCup.Location = new Point(430, 212);
            txtConvexCup.Name = "txtConvexCup";
            txtConvexCup.Size = new Size(150, 30);
            txtConvexCup.TabIndex = 8;
            // 
            // lblForest
            // 
            lblForest.AutoSize = true;
            lblForest.Font = new Font("Segoe UI", 10F);
            lblForest.Location = new Point(40, 255);
            lblForest.Name = "lblForest";
            lblForest.Size = new Size(340, 23);
            lblForest.TabIndex = 9;
            lblForest.Text = "3) Does your mushroom grow in a forest?";
            // 
            // txtForest
            // 
            txtForest.Font = new Font("Segoe UI", 10F);
            txtForest.Location = new Point(430, 252);
            txtForest.Name = "txtForest";
            txtForest.Size = new Size(150, 30);
            txtForest.TabIndex = 10;
            // 
            // lblGills
            // 
            lblGills.AutoSize = true;
            lblGills.Font = new Font("Segoe UI", 10F);
            lblGills.Location = new Point(40, 295);
            lblGills.Name = "lblGills";
            lblGills.Size = new Size(295, 23);
            lblGills.TabIndex = 11;
            lblGills.Text = "4) Does your mushroom have gills?";
            // 
            // txtGills
            // 
            txtGills.Font = new Font("Segoe UI", 10F);
            txtGills.Location = new Point(430, 292);
            txtGills.Name = "txtGills";
            txtGills.Size = new Size(150, 30);
            txtGills.TabIndex = 12;
            // 
            // lblRedCap
            // 
            lblRedCap.AutoSize = true;
            lblRedCap.Font = new Font("Segoe UI", 10F);
            lblRedCap.Location = new Point(40, 335);
            lblRedCap.Name = "lblRedCap";
            lblRedCap.Size = new Size(375, 23);
            lblRedCap.TabIndex = 13;
            lblRedCap.Text = "5) Does your mushroom have a bright/red cap?";
            // 
            // txtRedCap
            // 
            txtRedCap.Font = new Font("Segoe UI", 10F);
            txtRedCap.Location = new Point(430, 332);
            txtRedCap.Name = "txtRedCap";
            txtRedCap.Size = new Size(150, 30);
            txtRedCap.TabIndex = 14;
            // 
            // lblEdible
            // 
            lblEdible.AutoSize = true;
            lblEdible.Font = new Font("Segoe UI", 10F);
            lblEdible.Location = new Point(40, 375);
            lblEdible.Name = "lblEdible";
            lblEdible.Size = new Size(260, 23);
            lblEdible.TabIndex = 15;
            lblEdible.Text = "6) Is your mushroom edible?";
            // 
            // txtEdible
            // 
            txtEdible.Font = new Font("Segoe UI", 10F);
            txtEdible.Location = new Point(430, 372);
            txtEdible.Name = "txtEdible";
            txtEdible.Size = new Size(150, 30);
            txtEdible.TabIndex = 16;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblResult.Location = new Point(40, 420);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(150, 23);
            lblResult.TabIndex = 17;
            lblResult.Text = "Mushroom Result:";
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Segoe UI", 10F);
            txtResult.Location = new Point(430, 417);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(150, 30);
            txtResult.TabIndex = 18;
            // 
            // btnFind
            // 
            btnFind.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFind.Location = new Point(130, 465);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(170, 38);
            btnFind.TabIndex = 19;
            btnFind.Text = "Find Mushroom";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 10F);
            btnClear.Location = new Point(320, 465);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 38);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.Location = new Point(150, 515);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(130, 38);
            btnBack.TabIndex = 21;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 10F);
            btnLogout.Location = new Point(320, 515);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(130, 38);
            btnLogout.TabIndex = 22;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // MushroomForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 575);
            Controls.Add(btnLogout);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnFind);
            Controls.Add(txtResult);
            Controls.Add(lblResult);
            Controls.Add(txtEdible);
            Controls.Add(lblEdible);
            Controls.Add(txtRedCap);
            Controls.Add(lblRedCap);
            Controls.Add(txtGills);
            Controls.Add(lblGills);
            Controls.Add(txtForest);
            Controls.Add(lblForest);
            Controls.Add(txtConvexCup);
            Controls.Add(lblConvexCup);
            Controls.Add(txtRing);
            Controls.Add(lblRing);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblMushrooms);
            Controls.Add(lblInfo);
            Controls.Add(lblTitle);
            Name = "MushroomForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mushroom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblInfo;
        private Label lblMushrooms;
        private Label lblName;
        private TextBox txtName;
        private Label lblRing;
        private TextBox txtRing;
        private Label lblConvexCup;
        private TextBox txtConvexCup;
        private Label lblForest;
        private TextBox txtForest;
        private Label lblGills;
        private TextBox txtGills;
        private Label lblRedCap;
        private TextBox txtRedCap;
        private Label lblEdible;
        private TextBox txtEdible;
        private Label lblResult;
        private TextBox txtResult;
        private Button btnFind;
        private Button btnClear;
        private Button btnBack;
        private Button btnLogout;
    }
}
