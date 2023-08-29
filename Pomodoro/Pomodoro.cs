using System.Data;
using System.Media;
using System.Text;
using System.Timers;

namespace Pomodoro
{
    public partial class Pomodoro : Form
    {
        private readonly Color _Verde = Color.FromArgb(0, 128, 0);
        private readonly Color _Vermelho = Color.FromArgb(255, 99, 71);
        private readonly Color _Preto = Color.FromArgb(0, 0, 0);

        private StringBuilder ssxBuiderTempo = new();
        private bool _IsRodando = false;
        private bool _IsDescanco = false;

        int min = 0;
        int seg = 0;

        public Pomodoro()
        {
            InitializeComponent();
            Timer.Interval = 1000;
            Timer.Start();
        }

        private void BtnComecar_Click(object sender, EventArgs e)
        {
            if (BtnComecar.Text != "Come�ar")
            {
                BtnComecar.Text = "Come�ar";
            }
            Timer.Start();
            _IsDescanco = false;
            PnlCorpo.BackColor = _Verde;
            _IsRodando = true;
        }
        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            Timer.Start();
            PnlCorpo.BackColor = _Vermelho;
            _IsDescanco = true;
            LblTempo.Text = "00:00";
            min = 0;
            seg = 0;
            _IsRodando = true;
        }
        private void BtnResetar_Click(object sender, EventArgs e)
        {
            Timer.Start();
            LblTempo.Text = "00:00";
            min = 0;
            seg = 0;
            _IsRodando = true;
        }
        private void BtnPausar_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            PnlCorpo.BackColor = _Preto;
            _IsRodando = false;
            if (BtnComecar.Text == "Come�ar")
            {
                BtnComecar.Text = "Continuar";
            }
            else
            {
                BtnComecar.Text = "Come�ar";
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_IsRodando)
            {
                seg += 1;
                if (seg == 60)
                {
                    seg = 0;
                    min += 1;
                }

                if (_IsDescanco)
                {
                    if (min == 1)
                    {
                        BtnComecar.PerformClick();
                    }
                }
                else
                {
                    if (min == 1)
                    {
                        BtnFinalizar.PerformClick();
                    }
                }

                ssxBuiderTempo = new();
                ssxBuiderTempo.Append(string.Format("{0:D2}", min));
                ssxBuiderTempo.Append(':');
                ssxBuiderTempo.Append(string.Format("{0:D2}", seg));

                LblTempo.Text = ssxBuiderTempo.ToString();
            }
            else
            {
                LblTempo.Text = "00:00";
            }
        }

        private void Pomodoro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                BtnComecar.PerformClick();
            }
            else if (e.Control && e.KeyCode == Keys.F)
            {
                BtnFinalizar.PerformClick();
            }
            else if (e.Control && e.KeyCode == Keys.R)
            {
                BtnResetar.PerformClick();
            }
        }
    }
}