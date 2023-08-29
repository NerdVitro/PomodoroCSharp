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
            BtnPausar = new Button();
            LblTempo = new Label();
            BtnResetar = new Button();
            BtnFinalizar = new Button();
            BtnComecar = new Button();
            Timer = new System.Windows.Forms.Timer(components);
            PnlCorpo.SuspendLayout();
            SuspendLayout();
            // 
            // PnlCorpo
            // 
            PnlCorpo.Controls.Add(BtnPausar);
            PnlCorpo.Controls.Add(LblTempo);
            PnlCorpo.Controls.Add(BtnResetar);
            PnlCorpo.Controls.Add(BtnFinalizar);
            PnlCorpo.Controls.Add(BtnComecar);
            PnlCorpo.Dock = DockStyle.Fill;
            PnlCorpo.Location = new Point(0, 0);
            PnlCorpo.Name = "PnlCorpo";
            PnlCorpo.Size = new Size(784, 461);
            PnlCorpo.TabIndex = 0;
            // 
            // BtnPausar
            // 
            BtnPausar.FlatStyle = FlatStyle.Flat;
            BtnPausar.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnPausar.ForeColor = Color.White;
            BtnPausar.Location = new Point(455, 269);
            BtnPausar.Name = "BtnPausar";
            BtnPausar.Size = new Size(120, 42);
            BtnPausar.TabIndex = 101;
            BtnPausar.Text = "Pausar";
            BtnPausar.UseVisualStyleBackColor = true;
            BtnPausar.Click += BtnPausar_Click;
            // 
            // LblTempo
            // 
            LblTempo.Font = new Font("Tahoma", 48F, FontStyle.Bold, GraphicsUnit.Point);
            LblTempo.ForeColor = Color.White;
            LblTempo.Location = new Point(194, 125);
            LblTempo.Name = "LblTempo";
            LblTempo.Size = new Size(255, 186);
            LblTempo.TabIndex = 100;
            LblTempo.Text = "00:00";
            LblTempo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnResetar
            // 
            BtnResetar.FlatStyle = FlatStyle.Flat;
            BtnResetar.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnResetar.ForeColor = Color.White;
            BtnResetar.Location = new Point(455, 221);
            BtnResetar.Name = "BtnResetar";
            BtnResetar.Size = new Size(120, 42);
            BtnResetar.TabIndex = 3;
            BtnResetar.Text = "Resetar";
            BtnResetar.UseVisualStyleBackColor = true;
            BtnResetar.Click += BtnResetar_Click;
            // 
            // BtnFinalizar
            // 
            BtnFinalizar.FlatStyle = FlatStyle.Flat;
            BtnFinalizar.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnFinalizar.ForeColor = Color.White;
            BtnFinalizar.Location = new Point(455, 173);
            BtnFinalizar.Name = "BtnFinalizar";
            BtnFinalizar.Size = new Size(120, 42);
            BtnFinalizar.TabIndex = 2;
            BtnFinalizar.Text = "Finalizar";
            BtnFinalizar.UseVisualStyleBackColor = true;
            BtnFinalizar.Click += BtnFinalizar_Click;
            // 
            // BtnComecar
            // 
            BtnComecar.FlatStyle = FlatStyle.Flat;
            BtnComecar.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnComecar.ForeColor = Color.White;
            BtnComecar.Location = new Point(455, 125);
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
        private Button BtnResetar;
        private Button BtnFinalizar;
        private Button BtnComecar;
        private Label LblTempo;
        private System.Windows.Forms.Timer Timer;
        private Button BtnPausar;
    }
}