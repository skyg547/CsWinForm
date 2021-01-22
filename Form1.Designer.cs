namespace Sudoku
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Solution = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.게임규칙ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.게임방법ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.제작ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.난이도ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.중ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.하ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Record = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Emit = new System.Windows.Forms.Button();
            this.Hint = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Solution
            // 
            this.Solution.Location = new System.Drawing.Point(33, 261);
            this.Solution.Name = "Solution";
            this.Solution.Size = new System.Drawing.Size(87, 25);
            this.Solution.TabIndex = 10;
            this.Solution.Text = "정답보기";
            this.Solution.UseVisualStyleBackColor = true;
            this.Solution.Click += new System.EventHandler(this.Solution_Click);
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(33, 292);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(87, 25);
            this.New.TabIndex = 11;
            this.New.Text = "새로하기";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도움말ToolStripMenuItem,
            this.난이도ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(244, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.게임규칙ToolStripMenuItem,
            this.게임방법ToolStripMenuItem,
            this.제작ToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // 게임규칙ToolStripMenuItem
            // 
            this.게임규칙ToolStripMenuItem.Name = "게임규칙ToolStripMenuItem";
            this.게임규칙ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.게임규칙ToolStripMenuItem.Text = "게임규칙";
            this.게임규칙ToolStripMenuItem.Click += new System.EventHandler(this.게임규칙ToolStripMenuItem_Click);
            // 
            // 게임방법ToolStripMenuItem
            // 
            this.게임방법ToolStripMenuItem.Name = "게임방법ToolStripMenuItem";
            this.게임방법ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.게임방법ToolStripMenuItem.Text = "게임방법";
            this.게임방법ToolStripMenuItem.Click += new System.EventHandler(this.게임방법ToolStripMenuItem_Click);
            // 
            // 제작ToolStripMenuItem
            // 
            this.제작ToolStripMenuItem.Name = "제작ToolStripMenuItem";
            this.제작ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.제작ToolStripMenuItem.Text = "제작";
            this.제작ToolStripMenuItem.Click += new System.EventHandler(this.제작ToolStripMenuItem_Click);
            // 
            // 난이도ToolStripMenuItem
            // 
            this.난이도ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.상ToolStripMenuItem,
            this.중ToolStripMenuItem,
            this.하ToolStripMenuItem});
            this.난이도ToolStripMenuItem.Name = "난이도ToolStripMenuItem";
            this.난이도ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.난이도ToolStripMenuItem.Text = "난이도";
            // 
            // 상ToolStripMenuItem
            // 
            this.상ToolStripMenuItem.Name = "상ToolStripMenuItem";
            this.상ToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.상ToolStripMenuItem.Text = "상";
            this.상ToolStripMenuItem.Click += new System.EventHandler(this.상ToolStripMenuItem_Click);
            // 
            // 중ToolStripMenuItem
            // 
            this.중ToolStripMenuItem.Name = "중ToolStripMenuItem";
            this.중ToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.중ToolStripMenuItem.Text = "중";
            this.중ToolStripMenuItem.Click += new System.EventHandler(this.중ToolStripMenuItem_Click);
            // 
            // 하ToolStripMenuItem
            // 
            this.하ToolStripMenuItem.Name = "하ToolStripMenuItem";
            this.하ToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.하ToolStripMenuItem.Text = "하";
            this.하ToolStripMenuItem.Click += new System.EventHandler(this.하ToolStripMenuItem_Click);
            // 
            // Record
            // 
            this.Record.AutoSize = true;
            this.Record.Location = new System.Drawing.Point(180, 9);
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(29, 12);
            this.Record.TabIndex = 16;
            this.Record.Text = "기록";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(215, 8);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(22, 12);
            this.Time.TabIndex = 17;
            this.Time.Text = "0\'s";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Emit
            // 
            this.Emit.Cursor = System.Windows.Forms.Cursors.Default;
            this.Emit.Location = new System.Drawing.Point(126, 262);
            this.Emit.Name = "Emit";
            this.Emit.Size = new System.Drawing.Size(87, 25);
            this.Emit.TabIndex = 18;
            this.Emit.Text = "검사";
            this.Emit.UseVisualStyleBackColor = true;
            this.Emit.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Hint
            // 
            this.Hint.Location = new System.Drawing.Point(126, 293);
            this.Hint.Name = "Hint";
            this.Hint.Size = new System.Drawing.Size(87, 23);
            this.Hint.TabIndex = 19;
            this.Hint.Text = "?";
            this.Hint.UseVisualStyleBackColor = true;
            this.Hint.Click += new System.EventHandler(this.Hint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(244, 360);
            this.Controls.Add(this.Hint);
            this.Controls.Add(this.Emit);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Record);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Solution);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(260, 398);
            this.MinimumSize = new System.Drawing.Size(260, 398);
            this.Name = "Form1";
            this.Text = "Sudoku";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button Solution;
        internal System.Windows.Forms.Button New;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 게임규칙ToolStripMenuItem;
        private System.Windows.Forms.Label Record;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 난이도ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 중ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 하ToolStripMenuItem;
        internal System.Windows.Forms.Button Emit;
        private System.Windows.Forms.ToolStripMenuItem 제작ToolStripMenuItem;
        private System.Windows.Forms.Button Hint;
        private System.Windows.Forms.ToolStripMenuItem 게임방법ToolStripMenuItem;
    }
}

