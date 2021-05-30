using System;
using System.Linq;
using System.Management;
using System.Threading.Tasks;

namespace WMRControl
{
	internal class WMRManager
	{
		private const string Query = @"SELECT * FROM Win32_PnPEntity WHERE PNPClass LIKE 'Holographic'";
		private const string Scope = "root\\CIMV2";
		private ManagementObject WMRObject;
		private bool IsInvoking = false;

		#region Properties
		public bool IsEnabled { get; set; }
		public string Name => WMRObject.Properties["Name"].Value.ToString();
		public string State => ParseError((uint)WMRObject.Properties["ConfigManagerErrorCode"].Value);
		#endregion Properties

		public void DisableWMR()
		{
			_ = InvokeMethod("Disable");
		}

		public void EnableWMR()
		{
			_ = InvokeMethod("Enable");
		}

		public void SetWMRState(bool state)
		{
			_ = InvokeMethod(state ? "Enable" : "Disable");
		}

		public void Init()
		{
			using (var MOS = new ManagementObjectSearcher(Scope, Query))
			{
				using (var Objects = MOS.Get())
				{
					if (Objects.Count == 0) { throw new Exception("WMR Device not found"); }
					WMRObject = Objects.Cast<ManagementObject>().First();

					//var p = WMRObject.Properties;
					IsEnabled = (uint)WMRObject.Properties["ConfigManagerErrorCode"].Value != 22;
				}
			}
			OnStateChanged();
		}

		private async Task InvokeMethod(string method)
		{
			var MOO = new ManagementOperationObserver();
			MOO.Completed += new CompletedEventHandler(MOO_Completed);
			IsInvoking = true;
			WMRObject.InvokeMethod(MOO, method, null);
			while (IsInvoking)
			{
				await Task.Delay(500);
			}
			WMRObject.Get();
			//await Task.Delay(5000);
			//WMRObject.Get();
			IsEnabled = (uint)WMRObject.Properties["ConfigManagerErrorCode"].Value != 22;
			OnStateChanged();
		}

		private void MOO_Completed(object sender, CompletedEventArgs e)
		{
			IsInvoking = false;
		}

		protected virtual void OnStateChanged()
		{
			EventHandler handler = StateChanged;
			handler?.Invoke(this, EventArgs.Empty);
		}

		private string ParseError(uint error)
		{
			switch (error)
			{
				case 0: return "Device is working properly";
				case 1: return "Device is not configured correctly.";
				case 2: return "Windows cannot load the driver for this device";
				case 3: return "Driver for this device might be corrupted or the system may be low on memory or other resources.";
				case 4: return "Device is not working properly. One of its drivers or the registry might be corrupted.";
				case 5: return "Driver for the device requires a resource that Windows cannot manage.";
				case 6: return "Boot configuration for the device conflicts with other devices.";
				case 7: return "Cannot filter.";
				case 8: return "Driver loader for the device is missing.";
				case 9: return "Device is not working properly. The controlling firmware is incorrectly reporting the resources for the device.";
				case 10: return "Device cannot start.";
				case 11: return "Device failed.";
				case 12: return "Device cannot find enough free resources to use.";
				case 13: return "Windows cannot verify the device's resources.";
				case 14: return "Device cannot work properly until the computer is restarted.";
				case 15: return "Device is not working properly due to a possible re-enumeration problem.";
				case 16: return "Windows cannot identify all of the resources that the device uses.";
				case 17: return "Device is requesting an unknown resource type.";
				case 18: return "Device drivers must be reinstalled.";
				case 19: return "Failure using the VxD loader.";
				case 20: return "Registry might be corrupted.";
				case 21: return "System failure. If changing the device driver is ineffective, see the hardware documentation. Windows is removing the device.";
				case 22: return "Device is disabled.";
				case 23: return "System failure. If changing the device driver is ineffective, see the hardware documentation.";
				case 24: return "Device is not present, not working properly, or does not have all of its drivers installed.";
				case 25: return "Windows is still setting up the device.";
				case 26: return "Windows is still setting up the device.";
				case 27: return "Device does not have valid log configuration.";
				case 28: return "Device drivers are not installed.";
				case 29: return "Device is disabled. The device firmware did not provide the required resources.";
				case 30: return "Device is using an IRQ resource that another device is using.";
				case 31: return "Device is not working properly. Windows cannot load the required device drivers";
				default: return "";
			}
		}

		public event EventHandler StateChanged;
	}
}