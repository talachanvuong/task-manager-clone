using System.Diagnostics;

namespace TaskManagerClone
{
	public partial class MainForm
	{
		private List<QueueProcess> queueList = [];

		private struct QueueProcess
		{
			public Process process;
			public DateTime timeRun;
			public DateTime createdOn;
			public string status;
		}

		private void queueTimer_Tick(object sender, EventArgs e)
		{
			ExecuteWhenOnTime();
		}

		private void runAtButton_Click(object sender, EventArgs e)
		{
			// Show dialog to get file path
			var openFileDialog = new OpenFileDialog();

			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			// Create new process
			var newProcess = new Process();

			// Fill process props
			newProcess.StartInfo.FileName = openFileDialog.FileName;

			// Validate time picker
			if (!IsValidTimePicker())
			{
				MessageBox.Show("The timer must be set after 5 seconds from now!");
				return;
			}

			// Add to queue list
			queueList.Add(new QueueProcess
			{
				process = newProcess,
				timeRun = timePicker.Value,
				createdOn = DateTime.Now,
				status = "Run"
			});

			// Update queue view
			UpdateQueueView();
		}

		private void stopAtButton_Click(object sender, EventArgs e)
		{
			// Avoid mistake click
			if (processView.SelectedItems.Count == 0)
			{
				return;
			}

			// Get process
			var selectItem = processView.SelectedItems[0];
			int processId = int.Parse(selectItem.SubItems[1].Text);
			var process = Process.GetProcessById(processId);

			// Validate time picker
			if (!IsValidTimePicker())
			{
				MessageBox.Show("The timer must be set after 5 seconds from now!");
				return;
			}

			// Add to queue list
			queueList.Add(new QueueProcess
			{
				process = process,
				timeRun = timePicker.Value,
				createdOn = DateTime.Now,
				status = "Stop"
			});

			// Update queue view
			UpdateQueueView();
		}

		private void restartAtButton_Click(object sender, EventArgs e)
		{
			// Avoid mistake click
			if (processView.SelectedItems.Count == 0)
			{
				return;
			}

			// Get process
			var selectItem = processView.SelectedItems[0];
			int processId = int.Parse(selectItem.SubItems[1].Text);
			var process = Process.GetProcessById(processId);

			try
			{
				// Check exist file Path
				string processFileName = process.MainModule.FileName;

				// Validate time picker
				if (!IsValidTimePicker())
				{
					MessageBox.Show("The timer must be set after 5 seconds from now!");
					return;
				}

				// Add to queue list
				queueList.Add(new QueueProcess
				{
					process = process,
					timeRun = timePicker.Value,
					createdOn = DateTime.Now,
					status = "Restart"
				});
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			// Update queue view
			UpdateQueueView();
		}

		private void dequeueButton_Click(object sender, EventArgs e)
		{
			// Avoid mistake click
			if (queueView.SelectedItems.Count == 0)
			{
				return;
			}

			// Get queue item
			var selectItem = queueView.SelectedItems[0];
			string createdOn = selectItem.SubItems[1].Text;
			var queueItem = queueList.First(item => item.createdOn.ToString() == createdOn);

			// Remove queue item
			queueList.Remove(queueItem);

			// Update queue view
			UpdateQueueView();
		}

		private void UpdateQueueView()
		{
			// Clear queue view
			queueView.Items.Clear();

			// Update queue view
			foreach (var item in queueList)
			{
				string processName = item.status switch
				{
					"Run" => Path.GetFileName(item.process.StartInfo.FileName),
					"Stop" => item.process.ProcessName,
					"Restart" => item.process.ProcessName
				};
				string processTimeRun = item.timeRun.ToString();
				string processCreatedOn = item.createdOn.ToString();
				string processStatus = item.status;

				var newItem = new ListViewItem(processTimeRun)
				{
					SubItems = { processCreatedOn, processName, processStatus },
					ForeColor = processStatus switch
					{
						"Run" => Color.Green,
						"Stop" => Color.Red,
						"Restart" => Color.Blue
					}
				};
				queueView.Items.Add(newItem);
			}
		}

		private void ExecuteWhenOnTime()
		{
			var now = DateTime.Now;

			// Run all processes in scheduled time
			for (int i = 0; i < queueList.Count; i++)
			{
				var item = queueList[i];
				bool canRun = (item.timeRun - now) < TimeSpan.FromMilliseconds(1.0);

				if (canRun)
				{
					try
					{
						switch (item.status)
						{
							case "Run":
								item.process.Start();
								item.process.WaitForInputIdle();
								break;

							case "Stop":
								item.process.Kill();
								item.process.WaitForExit();
								break;

							case "Restart":
								string processFileName = item.process.MainModule.FileName;
								item.process.Kill();
								item.process.WaitForExit();

								var newProcess = new Process();
								newProcess.StartInfo.FileName = processFileName;
								newProcess.Start();
								newProcess.WaitForInputIdle();
								break;
						}	
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}

					// Remove from queue list
					queueList.Remove(item);

					// Update queue view
					UpdateQueueView();
				}
			}
		}

		private bool IsValidTimePicker()
		{
			var now = DateTime.Now;
			var timer = timePicker.Value;

			return (timer - now) >= TimeSpan.FromSeconds(5.0);
		}
	}
}