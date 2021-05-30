using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMRControl
{
	public partial class FormMain : Form
	{
		private readonly WMRManager WMRM;
		private bool BlockVisible;

		public FormMain()
		{
			InitializeComponent();
			LockUI();
			WMRM = new WMRManager();
		}

		protected override void SetVisibleCore(bool value)
		{
			if (BlockVisible) { return; }
			base.SetVisibleCore(value);
		}

		private void LockUI()
		{
			B_State.Enabled = false;
			MI_Enable.Enabled = false;
			MI_Disable.Enabled = false;
		}

		private void RefreshUI()
		{
			if (WMRM.IsEnabled)
			{
				B_State.Text = "Disable WMR";
				B_State.Image = icons8.icons8_WMR_Off_16;
				Icon = icons8.icons8_WMR_On;
				TrayControl.Icon = icons8.icons8_WMR_On;
				MI_Disable.Enabled = true;
			}
			else
			{
				B_State.Text = "Enable WMR";
				B_State.Image = icons8.icons8_WMR_On_16;
				Icon = icons8.icons8_WMR_Off;
				TrayControl.Icon = icons8.icons8_WMR_Off;
				MI_Enable.Enabled = true;
			}
			TB_State.Text = WMRM.State;
			TB_Name.Text = WMRM.Name;
			B_State.Enabled = true;
		}

		private void SetWMRState(bool state)
		{
			LockUI();
			WMRM.SetWMRState(state);
		}

		private void ShowForm()
		{
			BlockVisible = false;
			Visible = true;
		}

		private void WMRM_StateChanged(object sender, EventArgs e)
		{
			RefreshUI();
		}

		#region Form Events

		private void B_State_Click(object sender, EventArgs e)
		{
			SetWMRState(!WMRM.IsEnabled);
		}

		private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
				Visible = false;
			}
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			WMRM.StateChanged += WMRM_StateChanged;
			WMRM.Init();
		}

		#endregion Form Events

		#region Tray Events

		private void MI_Disable_Click(object sender, EventArgs e)
		{
			SetWMRState(false);
		}

		private void MI_Enable_Click(object sender, EventArgs e)
		{
			SetWMRState(true);
		}

		private void MI_Exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void TrayControl_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left) { ShowForm(); }
		}

		#endregion Tray Events
	}
}