using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace TaskManagerClone.Counters
{
	public class NetworkCounter
	{
		private PerformanceCounter totalCounter = new
		(
			"Network Interface",
			"Bytes Total/sec"
		);

		private PerformanceCounter sendCounter = new
		(
			"Network Interface",
			"Bytes Sent/sec"
		);

		private PerformanceCounter receiveCounter = new
		(
			"Network Interface",
			"Bytes Received/sec"
		);

		private string networkName = "N/A";
		private string networkType = "N/A";

		public string GetNetworkType()
		{
			UpdateCounter();
			return networkType;
		}

		public string GetName()
		{
			UpdateCounter();
			return networkName;
		}

		public double GetSend()
		{
			UpdateCounter();
			return networkName == "N/A" ? 0.0 : sendCounter.NextValue();
		}

		public double GetReceive()
		{
			UpdateCounter();
			return networkName == "N/A" ? 0.0 : receiveCounter.NextValue();
		}

		public double GetTotal()
		{
			UpdateCounter();
			return networkName == "N/A" ? 0.0 : totalCounter.NextValue();
		}

		private void UpdateCounter()
		{
			var categories = new PerformanceCounterCategory("Network Interface");
			var instances = categories.GetInstanceNames();

			foreach (var instance in instances)
			{
				if (CheckInstanceName(instance))
				{
					networkName = instance;
					totalCounter.InstanceName = networkName;
					sendCounter.InstanceName = networkName;
					receiveCounter.InstanceName = networkName;
					return;
				}
			}

			networkName = "N/A";
			totalCounter.InstanceName = string.Empty;
			sendCounter.InstanceName = string.Empty;
			receiveCounter.InstanceName = string.Empty;
		}

		private List<(string name, string type)> GetNetworkInterfaces()
		{
			var result = new List<(string name, string type)>();
			var networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

			foreach (var networkInterface in networkInterfaces)
			{
				if (networkInterface.OperationalStatus != OperationalStatus.Up)
				{
					continue;
				}

				if (networkInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet ||
					networkInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
				{

					result.Add
					(
						(
							networkInterface.Description,
							networkInterface.NetworkInterfaceType.ToString()
						)
					);
				}
			}

			return result;
		}

		private string ConvertString(string text) => Regex.Replace(text, @"[^a-zA-Z0-9]", "");

		private bool CheckInstanceName(string name)
		{
			var convertedName = ConvertString(name);
			var networkInterfaces = GetNetworkInterfaces();

			foreach (var networkInterface in networkInterfaces)
			{
				var convertedNetworkInterfaceName = ConvertString(networkInterface.name);

				if (convertedNetworkInterfaceName == convertedName)
				{
					// Handle network type here
					networkType = networkInterface.type;
					return true;
				}
			}

			// Return default value of network type 
			networkType = "N/A";
			return false;
		}
	}
}