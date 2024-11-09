using System.Diagnostics;

namespace TaskManagerClone
{
	public partial class MainForm
	{
		private ImageList imageList = new();

		private void processTimer_Tick(object sender, EventArgs e)
		{
			UpdateProcesses();
		}

		private void runNewTaskButton_Click(object sender, EventArgs e)
		{
			// Show dialog to get filepath
			var openFileDialog = new OpenFileDialog();

			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			// Create new process
			var newProcess = new Process();

			try
			{
				// Fill process props and start
				newProcess.StartInfo.FileName = openFileDialog.FileName;
				newProcess.Start();
				newProcess.WaitForInputIdle();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			// Update processes
			UpdateProcesses();
		}

		private void endTaskButton_Click(object sender, EventArgs e)
		{
			// Avoid mistake click
			if (processView.SelectedItems.Count == 0)
			{
				return;
			}

			// Get process and kill
			var selectItem = processView.SelectedItems[0];
			int processId = int.Parse(selectItem.SubItems[1].Text);
			var process = Process.GetProcessById(processId);
			process.Kill();
			process.WaitForExit();

			// Update processes
			UpdateProcesses();
		}

		private void restartTaskButton_Click(object sender, EventArgs e)
		{
			// Avoid mistake click
			if (processView.SelectedItems.Count == 0)
			{
				return;
			}

			// Get process and try to restart
			var selectItem = processView.SelectedItems[0];
			int processId = int.Parse(selectItem.SubItems[1].Text);
			var process = Process.GetProcessById(processId);

			try
			{
				string processFileName = process.MainModule.FileName;
				process.Kill();
				process.WaitForExit();

				var newProcess = new Process();
				newProcess.StartInfo.FileName = processFileName;
				newProcess.Start();
				newProcess.WaitForInputIdle();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			// Update processes
			UpdateProcesses();
		}

		private void refreshButton_Click(object sender, EventArgs e)
		{
			UpdateProcesses();
		}

		private void searchBar_TextChanged(object sender, EventArgs e)
		{
			UpdateProcesses();
		}

		private void UpdateProcesses()
		{
			// Stop showing in process view
			processView.BeginUpdate();

			// Get processes
			var processes = ProcessGetter.GetProcesses(searchBar.Text);

			// Clear process view
			ClearProcessView();

			foreach (var process in processes)
			{
				// Convert props
				string processName = process.Name.ToString();
				string processId = process.Id.ToString();
				string processCpu = process.Cpu.ToString();
				string processMemory = $"{process.Memory / (1024.0 * 1024.0)} MB";
				string processDescription = process.Description.ToString();
				Icon processIcon = process.Icon;

				// Add to image list
				imageList.Images.Add(processId, processIcon);

				// Create new item
				var newItem = new ListViewItem(processName)
				{
					SubItems =
					{
						processId,
						processCpu,
						processMemory,
						processDescription
					},
					ImageIndex = imageList.Images.IndexOfKey(processId)
				};

				// Add to process view
				processView.Items.Add(newItem);
			}

			// Update process icon list 
			processView.SmallImageList = imageList;
			processView.LargeImageList = imageList;

			// Change last update label
			ChangeLastUpdateLabel();

			// Continue showing in process view
			processView.EndUpdate();
		}

		private void ClearProcessView()
		{
			processView.Items.Clear();
			imageList.Images.Clear();
		}

		private void ChangeLastUpdateLabel()
		{
			lastUpdateLabel.Text = DateTime.Now.ToString();
		}
	}
}