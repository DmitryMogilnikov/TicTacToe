namespace TicTacToe_NewVersion_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.x_wins_count = new System.Windows.Forms.Label();
            this.draw_count = new System.Windows.Forms.Label();
            this.o_wins_count = new System.Windows.Forms.Label();
            this.resetCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(478, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resetCountToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(164, 34);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A1.Location = new System.Drawing.Point(82, 56);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(100, 100);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.button_click);
            this.A1.MouseEnter += new System.EventHandler(this.button_enter);
            this.A1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A2.Location = new System.Drawing.Point(188, 56);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(100, 100);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.button_click);
            this.A2.MouseEnter += new System.EventHandler(this.button_enter);
            this.A2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A3.Location = new System.Drawing.Point(294, 56);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(100, 100);
            this.A3.TabIndex = 3;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.button_click);
            this.A3.MouseEnter += new System.EventHandler(this.button_enter);
            this.A3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B1.Location = new System.Drawing.Point(82, 162);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(100, 100);
            this.B1.TabIndex = 4;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.button_click);
            this.B1.MouseEnter += new System.EventHandler(this.button_enter);
            this.B1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B2.Location = new System.Drawing.Point(188, 162);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(100, 100);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.button_click);
            this.B2.MouseEnter += new System.EventHandler(this.button_enter);
            this.B2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B3.Location = new System.Drawing.Point(294, 162);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(100, 100);
            this.B3.TabIndex = 6;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.button_click);
            this.B3.MouseEnter += new System.EventHandler(this.button_enter);
            this.B3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C1.Location = new System.Drawing.Point(82, 268);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(100, 100);
            this.C1.TabIndex = 7;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.button_click);
            this.C1.MouseEnter += new System.EventHandler(this.button_enter);
            this.C1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C2.Location = new System.Drawing.Point(188, 268);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(100, 100);
            this.C2.TabIndex = 8;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.button_click);
            this.C2.MouseEnter += new System.EventHandler(this.button_enter);
            this.C2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C3.Location = new System.Drawing.Point(294, 268);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(100, 100);
            this.C3.TabIndex = 9;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.button_click);
            this.C3.MouseEnter += new System.EventHandler(this.button_enter);
            this.C3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "X Wins Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Draw Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "O Wins Total";
            // 
            // x_wins_count
            // 
            this.x_wins_count.AutoSize = true;
            this.x_wins_count.Location = new System.Drawing.Point(116, 410);
            this.x_wins_count.Name = "x_wins_count";
            this.x_wins_count.Size = new System.Drawing.Size(22, 25);
            this.x_wins_count.TabIndex = 13;
            this.x_wins_count.Text = "0";
            // 
            // draw_count
            // 
            this.draw_count.AutoSize = true;
            this.draw_count.Location = new System.Drawing.Point(224, 410);
            this.draw_count.Name = "draw_count";
            this.draw_count.Size = new System.Drawing.Size(22, 25);
            this.draw_count.TabIndex = 14;
            this.draw_count.Text = "0";
            // 
            // o_wins_count
            // 
            this.o_wins_count.AutoSize = true;
            this.o_wins_count.Location = new System.Drawing.Point(334, 410);
            this.o_wins_count.Name = "o_wins_count";
            this.o_wins_count.Size = new System.Drawing.Size(22, 25);
            this.o_wins_count.TabIndex = 15;
            this.o_wins_count.Text = "0";
            // 
            // resetCountToolStripMenuItem
            // 
            this.resetCountToolStripMenuItem.Name = "resetCountToolStripMenuItem";
            this.resetCountToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.resetCountToolStripMenuItem.Text = "Reset Win Count";
            this.resetCountToolStripMenuItem.Click += new System.EventHandler(this.resetCountToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 444);
            this.Controls.Add(this.o_wins_count);
            this.Controls.Add(this.draw_count);
            this.Controls.Add(this.x_wins_count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Button A1;
        private Button A2;
        private Button A3;
        private Button B1;
        private Button B2;
        private Button B3;
        private Button C1;
        private Button C2;
        private Button C3;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label x_wins_count;
        private Label draw_count;
        private Label o_wins_count;
        private ToolStripMenuItem resetCountToolStripMenuItem;
    }
}