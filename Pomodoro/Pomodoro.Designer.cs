namespace Pomodoro
{
    partial class Pomodoro
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
            components = new System.ComponentModel.Container();
            PnlCorpo = new Panel();
            BtnLongBreak = new Button();
            BtnShortBreak = new Button();
            BtnPomodoro = new Button();
            LblTempo = new Label();
            BtnComecar = new Button();
            Timer = new System.Windows.Forms.Timer(components);
            PnlCorpo.SuspendLayout();
            SuspendLayout();
            // 
            // PnlCorpo
            // 
            PnlCorpo.Controls.Add(BtnLongBreak);
            PnlCorpo.Controls.Add(BtnShortBreak);
            PnlCorpo.Controls.Add(BtnPomodoro);
            PnlCorpo.Controls.Add(LblTempo);
            PnlCorpo.Controls.Add(BtnComecar);
            PnlCorpo.Dock = DockStyle.Fill;
            PnlCorpo.Location = new Point(0, 0);
            PnlCorpo.Name = "PnlCorpo";
            PnlCorpo.Size = new Size(784, 461);
            PnlCorpo.TabIndex = 0;
            // 
            // BtnLongBreak
            // 
            BtnLongBreak.FlatAppearance.BorderSize = 0;
            BtnLongBreak.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnLongBreak.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnLongBreak.FlatStyle = FlatStyle.Flat;
            BtnLongBreak.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnLongBreak.ForeColor = Color.White;
            BtnLongBreak.Location = new Point(446, 80);
            BtnLongBreak.Name = "BtnLongBreak";
            BtnLongBreak.Size = new Size(120, 42);
            BtnLongBreak.TabIndex = 104;
            BtnLongBreak.Text = "Long Break";
            BtnLongBreak.UseVisualStyleBackColor = true;
            BtnLongBreak.Click += BtnLongBreak_Click;
            // 
            // BtnShortBreak
            // 
            BtnShortBreak.FlatAppearance.BorderSize = 0;
            BtnShortBreak.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnShortBreak.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnShortBreak.FlatStyle = FlatStyle.Flat;
            BtnShortBreak.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnShortBreak.ForeColor = Color.White;
            BtnShortBreak.Location = new Point(320, 80);
            BtnShortBreak.Name = "BtnShortBreak";
            BtnShortBreak.Size = new Size(120, 42);
            BtnShortBreak.TabIndex = 103;
            BtnShortBreak.Text = "Short Break";
            BtnShortBreak.UseVisualStyleBackColor = true;
            BtnShortBreak.Click += BtnShortBreak_Click;
            // 
            // BtnPomodoro
            // 
            BtnPomodoro.FlatAppearance.BorderSize = 0;
            BtnPomodoro.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnPomodoro.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnPomodoro.FlatStyle = FlatStyle.Flat;
            BtnPomodoro.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnPomodoro.ForeColor = Color.White;
            BtnPomodoro.Location = new Point(194, 80);
            BtnPomodoro.Name = "BtnPomodoro";
            BtnPomodoro.Size = new Size(120, 42);
            BtnPomodoro.TabIndex = 102;
            BtnPomodoro.Text = "Pomodoro";
            BtnPomodoro.UseVisualStyleBackColor = true;
            BtnPomodoro.Click += BtnPomodoro_Click;
            // 
            // LblTempo
            // 
            LblTempo.Font = new Font("Tahoma", 48F, FontStyle.Bold, GraphicsUnit.Point);
            LblTempo.ForeColor = Color.White;
            LblTempo.Location = new Point(194, 159);
            LblTempo.Name = "LblTempo";
            LblTempo.Size = new Size(372, 100);
            LblTempo.TabIndex = 100;
            LblTempo.Text = "00:00";
            LblTempo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnComecar
            // 
            BtnComecar.FlatStyle = FlatStyle.Flat;
            BtnComecar.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnComecar.ForeColor = Color.White;
            BtnComecar.Location = new Point(320, 302);
            BtnComecar.Name = "BtnComecar";
            BtnComecar.Size = new Size(120, 42);
            BtnComecar.TabIndex = 1;
            BtnComecar.Text = "Começar";
            BtnComecar.UseVisualStyleBackColor = true;
            BtnComecar.Click += BtnComecar_Click;
            // 
            // Timer
            // 
            Timer.Interval = 10;
            Timer.Tick += Timer_Tick;
            // 
            // Pomodoro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(784, 461);
            Controls.Add(PnlCorpo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Pomodoro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pomodoro";
            KeyDown += Pomodoro_KeyDown;
            PnlCorpo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlCorpo;
        private Button BtnComecar;
        private Label LblTempo;
        private System.Windows.Forms.Timer Timer;
        private Button BtnLongBreak;
        private Button BtnShortBreak;
        private Button BtnPomodoro;
    }
}