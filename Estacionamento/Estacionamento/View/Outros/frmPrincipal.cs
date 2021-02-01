/*
 * Created by SharpDevelop.
 * User: maxwell.miquelino
 * Date: 28/04/2020
 * Time: 08:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using Estacionamento.AppUtil;
using Estacionamento.View;
using Estacionamento.View.Movto;
using Estacionamento.View.Relatorio;
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Estacionamento
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class frmPrincipal : Form
	{
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		public frmPrincipal()
		{
			InitializeComponent();
			Region = Region.FromHrgn(Funcao.CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
		}

		private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
		{
			Form formulario;
			formulario = panelConteudo.Controls.OfType<Forms>().FirstOrDefault();

			if (formulario == null)
			{
				formulario = new Forms();
				formulario.TopLevel = false;
				//formulario.FormBorderStyle = FormBorderStyle.None;
				formulario.Dock = DockStyle.Fill;
				panelConteudo.Controls.Add(formulario);
				panelConteudo.Tag = formulario;
				formulario.Show();
				formulario.BringToFront();
			}
			else
			{
				if (formulario.WindowState == FormWindowState.Minimized)
					formulario.WindowState = FormWindowState.Normal;
				formulario.BringToFront();
			}
		}

		private void frmPrincipal_Load(object sender, EventArgs e)
		{
			lblTitulo.Text = this.Text;
			if(BancoDados.RetornarParametro("Sistema", "MostrarFormMovtoInicio") == "S")
				AbrirFormNoPanel<frmMovimento>();
		}

		private void btnFechar_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnMinimizar_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btnNormal_Click(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Maximized)
				this.WindowState = FormWindowState.Normal;
			else
				this.WindowState = FormWindowState.Maximized;
		}

		private void panelCabecalho_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void btnCadEmpresa_Click(object sender, EventArgs e)
		{
			AbrirFormNoPanel<frmCadPessoa>();
		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnCadUsuario_Click(object sender, EventArgs e)
		{
			AbrirFormNoPanel<frmCadUsuario>();
		}

		private void btnFormaPagto_Click(object sender, EventArgs e)
		{
			AbrirFormNoPanel<frmCadFormaPagto>();
		}

		private void btnConvenio_Click(object sender, EventArgs e)
		{
			AbrirFormNoPanel<frmCadConvenio>();
		}

		private void btnParametros_Click(object sender, EventArgs e)
		{
			AbrirFormNoPanel<frmParametros>();
		}

		private void frmPrincipal_Resize(object sender, EventArgs e)
		{
			Region = Region.FromHrgn(Funcao.CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
		}

		private void btnMovto_Click(object sender, EventArgs e)
		{
			AbrirFormNoPanel<frmMovimento>();
		}

		private void btnRelatorio_Click(object sender, EventArgs e)
		{
			AbrirFormNoPanel<frmRelatorio>();
		}
	}
}
