namespace TaskManagerClone
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			tabControl = new TabControl();
			processPage = new TabPage();
			restartAtButton = new Button();
			lastUpdateLabel = new Label();
			lastUpdateTitleLabel = new Label();
			refreshButton = new Button();
			queueLabel = new Label();
			queueView = new ListView();
			queueTimeRunColumn = new ColumnHeader();
			queueCreatedOnColumn = new ColumnHeader();
			queueProcessColumn = new ColumnHeader();
			queueStatusColumn = new ColumnHeader();
			dequeueButton = new Button();
			timePicker = new DateTimePicker();
			stopAtButton = new Button();
			runAtButton = new Button();
			processView = new ListView();
			processProcessColumn = new ColumnHeader();
			processIdColumn = new ColumnHeader();
			processCpuColumn = new ColumnHeader();
			processMemoryColumn = new ColumnHeader();
			processDescriptionColumn = new ColumnHeader();
			searchBar = new TextBox();
			restartTaskButton = new Button();
			endTaskButton = new Button();
			runNewTaskButton = new Button();
			cpuPage = new TabPage();
			cpuUpTimeLabel = new Label();
			cpuHandlesLabel = new Label();
			cpuThreadsLabel = new Label();
			cpuProcessesLabel = new Label();
			cpuSpeedLabel = new Label();
			cpuUtilizationLabel = new Label();
			cpuNameLabel = new Label();
			cpuUpTimeTitleLabel = new Label();
			cpuHandlesTitleLabel = new Label();
			cpuProcessesTitleLabel = new Label();
			cpuThreadTitleLabel = new Label();
			cpuSpeedTitleLabel = new Label();
			cpuUtilizationTitleLabel = new Label();
			cpuNameTitleLabel = new Label();
			cpuPlotView = new OxyPlot.WindowsForms.PlotView();
			memoryPage = new TabPage();
			memoryPageFileLabel = new Label();
			memoryPageFileTitleLabel = new Label();
			memorySlotsUsedLabel = new Label();
			memoryPhysicalRamLabel = new Label();
			memoryAvailableLabel = new Label();
			memoryInUseLabel = new Label();
			memoryUtilizationLabel = new Label();
			memoryPhysicalRamTitleLabel = new Label();
			memorySlotsUsedTitleLabel = new Label();
			memoryAvailableTitleLabel = new Label();
			memoryInUseTitleLabel = new Label();
			memoryUtilizationTitleLabel = new Label();
			memoryPlotView = new OxyPlot.WindowsForms.PlotView();
			diskPage = new TabPage();
			diskTracksLabel = new Label();
			diskSectorsLabel = new Label();
			diskHeadsLabel = new Label();
			diskCylindersLabel = new Label();
			diskTracksTitleLabel = new Label();
			diskSectorsTitleLabel = new Label();
			diskHeadsTitleLabel = new Label();
			diskCylindersTitleLabel = new Label();
			diskTypeLabel = new Label();
			diskTypeTitleLabel = new Label();
			diskNameLabel = new Label();
			diskNameTitleLabel = new Label();
			diskCapacityLabel = new Label();
			diskWriteSpeedLabel = new Label();
			diskReadSpeedLabel = new Label();
			diskResponeTimeLabel = new Label();
			diskActiveTimeLabel = new Label();
			diskWriteSpeedTitleLabel = new Label();
			diskCapacityTitleLabel = new Label();
			diskReadSpeedTitleLabel = new Label();
			diskResponeTimeTitleLabel = new Label();
			diskActiveTimeTitleLabel = new Label();
			diskPlotView = new OxyPlot.WindowsForms.PlotView();
			networkPage = new TabPage();
			networkTotalLabel = new Label();
			networkTotalTitleLabel = new Label();
			networkReceiveLabel = new Label();
			networkSendLabel = new Label();
			networkNameLabel = new Label();
			networkTypeLabel = new Label();
			networkReceiveTitleLabel = new Label();
			networkSendTitleLabel = new Label();
			networkNameTitleLabel = new Label();
			networkTypeTitleLabel = new Label();
			networkPlotView = new OxyPlot.WindowsForms.PlotView();
			gpuPage = new TabPage();
			gpuGroupBox1 = new GroupBox();
			gpu1NameTitleLabel = new Label();
			gpu1NameLabel = new Label();
			gpu1TemperatureLabel = new Label();
			gpu1UtilizationTitleLabel = new Label();
			gpu1UtilizationLabel = new Label();
			gpu1TemperatureTitleLabel = new Label();
			gpuGroupBox0 = new GroupBox();
			gpu0NameTitleLabel = new Label();
			gpu0NameLabel = new Label();
			gpu0TemperatureLabel = new Label();
			gpu0UtilizationTitleLabel = new Label();
			gpu0UtilizationLabel = new Label();
			gpu0TemperatureTitleLabel = new Label();
			gpuPlotView = new OxyPlot.WindowsForms.PlotView();
			processTimer = new System.Windows.Forms.Timer(components);
			queueTimer = new System.Windows.Forms.Timer(components);
			performanceTimer = new System.Windows.Forms.Timer(components);
			tabControl.SuspendLayout();
			processPage.SuspendLayout();
			cpuPage.SuspendLayout();
			memoryPage.SuspendLayout();
			diskPage.SuspendLayout();
			networkPage.SuspendLayout();
			gpuPage.SuspendLayout();
			gpuGroupBox1.SuspendLayout();
			gpuGroupBox0.SuspendLayout();
			SuspendLayout();
			// 
			// tabControl
			// 
			tabControl.Controls.Add(processPage);
			tabControl.Controls.Add(cpuPage);
			tabControl.Controls.Add(memoryPage);
			tabControl.Controls.Add(diskPage);
			tabControl.Controls.Add(networkPage);
			tabControl.Controls.Add(gpuPage);
			tabControl.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			tabControl.Location = new Point(12, 12);
			tabControl.Name = "tabControl";
			tabControl.SelectedIndex = 0;
			tabControl.Size = new Size(1338, 529);
			tabControl.TabIndex = 0;
			tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
			// 
			// processPage
			// 
			processPage.Controls.Add(restartAtButton);
			processPage.Controls.Add(lastUpdateLabel);
			processPage.Controls.Add(lastUpdateTitleLabel);
			processPage.Controls.Add(refreshButton);
			processPage.Controls.Add(queueLabel);
			processPage.Controls.Add(queueView);
			processPage.Controls.Add(dequeueButton);
			processPage.Controls.Add(timePicker);
			processPage.Controls.Add(stopAtButton);
			processPage.Controls.Add(runAtButton);
			processPage.Controls.Add(processView);
			processPage.Controls.Add(searchBar);
			processPage.Controls.Add(restartTaskButton);
			processPage.Controls.Add(endTaskButton);
			processPage.Controls.Add(runNewTaskButton);
			processPage.Location = new Point(4, 30);
			processPage.Name = "processPage";
			processPage.Padding = new Padding(3);
			processPage.Size = new Size(1330, 495);
			processPage.TabIndex = 0;
			processPage.Text = "Process";
			processPage.UseVisualStyleBackColor = true;
			// 
			// restartAtButton
			// 
			restartAtButton.Location = new Point(1118, 454);
			restartAtButton.Name = "restartAtButton";
			restartAtButton.Size = new Size(100, 35);
			restartAtButton.TabIndex = 15;
			restartAtButton.Text = "Restart at";
			restartAtButton.UseVisualStyleBackColor = true;
			restartAtButton.Click += restartAtButton_Click;
			// 
			// lastUpdateLabel
			// 
			lastUpdateLabel.AutoSize = true;
			lastUpdateLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lastUpdateLabel.Location = new Point(255, 461);
			lastUpdateLabel.Name = "lastUpdateLabel";
			lastUpdateLabel.Size = new Size(25, 21);
			lastUpdateLabel.TabIndex = 14;
			lastUpdateLabel.Text = "...";
			// 
			// lastUpdateTitleLabel
			// 
			lastUpdateTitleLabel.AutoSize = true;
			lastUpdateTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lastUpdateTitleLabel.Location = new Point(132, 461);
			lastUpdateTitleLabel.Name = "lastUpdateTitleLabel";
			lastUpdateTitleLabel.Size = new Size(117, 21);
			lastUpdateTitleLabel.TabIndex = 13;
			lastUpdateTitleLabel.Text = "Last update:";
			// 
			// refreshButton
			// 
			refreshButton.Location = new Point(6, 454);
			refreshButton.Name = "refreshButton";
			refreshButton.Size = new Size(120, 35);
			refreshButton.TabIndex = 12;
			refreshButton.Text = "Refresh";
			refreshButton.UseVisualStyleBackColor = true;
			refreshButton.Click += refreshButton_Click;
			// 
			// queueLabel
			// 
			queueLabel.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			queueLabel.Location = new Point(682, 6);
			queueLabel.Name = "queueLabel";
			queueLabel.Size = new Size(642, 35);
			queueLabel.TabIndex = 11;
			queueLabel.Text = "Queue Processes";
			queueLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// queueView
			// 
			queueView.Columns.AddRange(new ColumnHeader[] { queueTimeRunColumn, queueCreatedOnColumn, queueProcessColumn, queueStatusColumn });
			queueView.FullRowSelect = true;
			queueView.Location = new Point(682, 47);
			queueView.MultiSelect = false;
			queueView.Name = "queueView";
			queueView.Size = new Size(642, 401);
			queueView.Sorting = SortOrder.Ascending;
			queueView.TabIndex = 10;
			queueView.UseCompatibleStateImageBehavior = false;
			queueView.View = View.Details;
			// 
			// queueTimeRunColumn
			// 
			queueTimeRunColumn.Text = "Time run";
			queueTimeRunColumn.Width = 150;
			// 
			// queueCreatedOnColumn
			// 
			queueCreatedOnColumn.Text = "Created on";
			queueCreatedOnColumn.Width = 150;
			// 
			// queueProcessColumn
			// 
			queueProcessColumn.Text = "Process";
			queueProcessColumn.Width = 180;
			// 
			// queueStatusColumn
			// 
			queueStatusColumn.Text = "Status";
			queueStatusColumn.Width = 130;
			// 
			// dequeueButton
			// 
			dequeueButton.Location = new Point(1224, 454);
			dequeueButton.Name = "dequeueButton";
			dequeueButton.Size = new Size(100, 35);
			dequeueButton.TabIndex = 9;
			dequeueButton.Text = "Dequeue";
			dequeueButton.UseVisualStyleBackColor = true;
			dequeueButton.Click += dequeueButton_Click;
			// 
			// timePicker
			// 
			timePicker.CustomFormat = "dd/MM/yyyy HH:mm:ss";
			timePicker.Format = DateTimePickerFormat.Custom;
			timePicker.Location = new Point(682, 455);
			timePicker.Name = "timePicker";
			timePicker.Size = new Size(218, 28);
			timePicker.TabIndex = 7;
			// 
			// stopAtButton
			// 
			stopAtButton.Location = new Point(1012, 454);
			stopAtButton.Name = "stopAtButton";
			stopAtButton.Size = new Size(100, 35);
			stopAtButton.TabIndex = 6;
			stopAtButton.Text = "Stop at";
			stopAtButton.UseVisualStyleBackColor = true;
			stopAtButton.Click += stopAtButton_Click;
			// 
			// runAtButton
			// 
			runAtButton.Location = new Point(906, 454);
			runAtButton.Name = "runAtButton";
			runAtButton.Size = new Size(100, 35);
			runAtButton.TabIndex = 5;
			runAtButton.Text = "Run at";
			runAtButton.UseVisualStyleBackColor = true;
			runAtButton.Click += runAtButton_Click;
			// 
			// processView
			// 
			processView.Columns.AddRange(new ColumnHeader[] { processProcessColumn, processIdColumn, processCpuColumn, processMemoryColumn, processDescriptionColumn });
			processView.FullRowSelect = true;
			processView.Location = new Point(6, 47);
			processView.MultiSelect = false;
			processView.Name = "processView";
			processView.Size = new Size(670, 401);
			processView.Sorting = SortOrder.Ascending;
			processView.TabIndex = 4;
			processView.UseCompatibleStateImageBehavior = false;
			processView.View = View.Details;
			// 
			// processProcessColumn
			// 
			processProcessColumn.Text = "Process";
			processProcessColumn.Width = 200;
			// 
			// processIdColumn
			// 
			processIdColumn.Text = "ID";
			// 
			// processCpuColumn
			// 
			processCpuColumn.Text = "CPU";
			processCpuColumn.Width = 50;
			// 
			// processMemoryColumn
			// 
			processMemoryColumn.Text = "Memory";
			processMemoryColumn.Width = 150;
			// 
			// processDescriptionColumn
			// 
			processDescriptionColumn.Text = "Description";
			processDescriptionColumn.Width = 180;
			// 
			// searchBar
			// 
			searchBar.Location = new Point(6, 10);
			searchBar.Name = "searchBar";
			searchBar.Size = new Size(292, 28);
			searchBar.TabIndex = 3;
			searchBar.TextChanged += searchBar_TextChanged;
			// 
			// restartTaskButton
			// 
			restartTaskButton.Location = new Point(556, 6);
			restartTaskButton.Name = "restartTaskButton";
			restartTaskButton.Size = new Size(120, 35);
			restartTaskButton.TabIndex = 2;
			restartTaskButton.Text = "Restart task";
			restartTaskButton.UseVisualStyleBackColor = true;
			restartTaskButton.Click += restartTaskButton_Click;
			// 
			// endTaskButton
			// 
			endTaskButton.Location = new Point(430, 6);
			endTaskButton.Name = "endTaskButton";
			endTaskButton.Size = new Size(120, 35);
			endTaskButton.TabIndex = 1;
			endTaskButton.Text = "End task";
			endTaskButton.UseVisualStyleBackColor = true;
			endTaskButton.Click += endTaskButton_Click;
			// 
			// runNewTaskButton
			// 
			runNewTaskButton.Location = new Point(304, 6);
			runNewTaskButton.Name = "runNewTaskButton";
			runNewTaskButton.Size = new Size(120, 35);
			runNewTaskButton.TabIndex = 0;
			runNewTaskButton.Text = "Run new task";
			runNewTaskButton.UseVisualStyleBackColor = true;
			runNewTaskButton.Click += runNewTaskButton_Click;
			// 
			// cpuPage
			// 
			cpuPage.Controls.Add(cpuUpTimeLabel);
			cpuPage.Controls.Add(cpuHandlesLabel);
			cpuPage.Controls.Add(cpuThreadsLabel);
			cpuPage.Controls.Add(cpuProcessesLabel);
			cpuPage.Controls.Add(cpuSpeedLabel);
			cpuPage.Controls.Add(cpuUtilizationLabel);
			cpuPage.Controls.Add(cpuNameLabel);
			cpuPage.Controls.Add(cpuUpTimeTitleLabel);
			cpuPage.Controls.Add(cpuHandlesTitleLabel);
			cpuPage.Controls.Add(cpuProcessesTitleLabel);
			cpuPage.Controls.Add(cpuThreadTitleLabel);
			cpuPage.Controls.Add(cpuSpeedTitleLabel);
			cpuPage.Controls.Add(cpuUtilizationTitleLabel);
			cpuPage.Controls.Add(cpuNameTitleLabel);
			cpuPage.Controls.Add(cpuPlotView);
			cpuPage.Location = new Point(4, 30);
			cpuPage.Name = "cpuPage";
			cpuPage.Padding = new Padding(3);
			cpuPage.Size = new Size(1330, 495);
			cpuPage.TabIndex = 1;
			cpuPage.Text = "CPU";
			cpuPage.UseVisualStyleBackColor = true;
			// 
			// cpuUpTimeLabel
			// 
			cpuUpTimeLabel.AutoSize = true;
			cpuUpTimeLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			cpuUpTimeLabel.Location = new Point(95, 165);
			cpuUpTimeLabel.Name = "cpuUpTimeLabel";
			cpuUpTimeLabel.Size = new Size(25, 21);
			cpuUpTimeLabel.TabIndex = 14;
			cpuUpTimeLabel.Text = "...";
			// 
			// cpuHandlesLabel
			// 
			cpuHandlesLabel.AutoSize = true;
			cpuHandlesLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			cpuHandlesLabel.Location = new Point(97, 138);
			cpuHandlesLabel.Name = "cpuHandlesLabel";
			cpuHandlesLabel.Size = new Size(25, 21);
			cpuHandlesLabel.TabIndex = 13;
			cpuHandlesLabel.Text = "...";
			// 
			// cpuThreadsLabel
			// 
			cpuThreadsLabel.AutoSize = true;
			cpuThreadsLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			cpuThreadsLabel.Location = new Point(96, 111);
			cpuThreadsLabel.Name = "cpuThreadsLabel";
			cpuThreadsLabel.Size = new Size(25, 21);
			cpuThreadsLabel.TabIndex = 12;
			cpuThreadsLabel.Text = "...";
			// 
			// cpuProcessesLabel
			// 
			cpuProcessesLabel.AutoSize = true;
			cpuProcessesLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			cpuProcessesLabel.Location = new Point(113, 84);
			cpuProcessesLabel.Name = "cpuProcessesLabel";
			cpuProcessesLabel.Size = new Size(25, 21);
			cpuProcessesLabel.TabIndex = 11;
			cpuProcessesLabel.Text = "...";
			// 
			// cpuSpeedLabel
			// 
			cpuSpeedLabel.AutoSize = true;
			cpuSpeedLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			cpuSpeedLabel.Location = new Point(81, 57);
			cpuSpeedLabel.Name = "cpuSpeedLabel";
			cpuSpeedLabel.Size = new Size(25, 21);
			cpuSpeedLabel.TabIndex = 10;
			cpuSpeedLabel.Text = "...";
			// 
			// cpuUtilizationLabel
			// 
			cpuUtilizationLabel.AutoSize = true;
			cpuUtilizationLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			cpuUtilizationLabel.Location = new Point(116, 30);
			cpuUtilizationLabel.Name = "cpuUtilizationLabel";
			cpuUtilizationLabel.Size = new Size(25, 21);
			cpuUtilizationLabel.TabIndex = 9;
			cpuUtilizationLabel.Text = "...";
			// 
			// cpuNameLabel
			// 
			cpuNameLabel.AutoSize = true;
			cpuNameLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			cpuNameLabel.Location = new Point(77, 3);
			cpuNameLabel.Name = "cpuNameLabel";
			cpuNameLabel.Size = new Size(25, 21);
			cpuNameLabel.TabIndex = 8;
			cpuNameLabel.Text = "...";
			// 
			// cpuUpTimeTitleLabel
			// 
			cpuUpTimeTitleLabel.AutoSize = true;
			cpuUpTimeTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			cpuUpTimeTitleLabel.Location = new Point(6, 165);
			cpuUpTimeTitleLabel.Name = "cpuUpTimeTitleLabel";
			cpuUpTimeTitleLabel.Size = new Size(83, 21);
			cpuUpTimeTitleLabel.TabIndex = 7;
			cpuUpTimeTitleLabel.Text = "Up time:";
			// 
			// cpuHandlesTitleLabel
			// 
			cpuHandlesTitleLabel.AutoSize = true;
			cpuHandlesTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			cpuHandlesTitleLabel.Location = new Point(6, 138);
			cpuHandlesTitleLabel.Name = "cpuHandlesTitleLabel";
			cpuHandlesTitleLabel.Size = new Size(85, 21);
			cpuHandlesTitleLabel.TabIndex = 6;
			cpuHandlesTitleLabel.Text = "Handles:";
			// 
			// cpuProcessesTitleLabel
			// 
			cpuProcessesTitleLabel.AutoSize = true;
			cpuProcessesTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			cpuProcessesTitleLabel.Location = new Point(6, 84);
			cpuProcessesTitleLabel.Name = "cpuProcessesTitleLabel";
			cpuProcessesTitleLabel.Size = new Size(101, 21);
			cpuProcessesTitleLabel.TabIndex = 5;
			cpuProcessesTitleLabel.Text = "Processes:";
			// 
			// cpuThreadTitleLabel
			// 
			cpuThreadTitleLabel.AutoSize = true;
			cpuThreadTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			cpuThreadTitleLabel.Location = new Point(6, 111);
			cpuThreadTitleLabel.Name = "cpuThreadTitleLabel";
			cpuThreadTitleLabel.Size = new Size(84, 21);
			cpuThreadTitleLabel.TabIndex = 4;
			cpuThreadTitleLabel.Text = "Threads:";
			// 
			// cpuSpeedTitleLabel
			// 
			cpuSpeedTitleLabel.AutoSize = true;
			cpuSpeedTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			cpuSpeedTitleLabel.Location = new Point(6, 57);
			cpuSpeedTitleLabel.Name = "cpuSpeedTitleLabel";
			cpuSpeedTitleLabel.Size = new Size(69, 21);
			cpuSpeedTitleLabel.TabIndex = 3;
			cpuSpeedTitleLabel.Text = "Speed:";
			// 
			// cpuUtilizationTitleLabel
			// 
			cpuUtilizationTitleLabel.AutoSize = true;
			cpuUtilizationTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			cpuUtilizationTitleLabel.Location = new Point(6, 30);
			cpuUtilizationTitleLabel.Name = "cpuUtilizationTitleLabel";
			cpuUtilizationTitleLabel.Size = new Size(104, 21);
			cpuUtilizationTitleLabel.TabIndex = 2;
			cpuUtilizationTitleLabel.Text = "Utilization:";
			// 
			// cpuNameTitleLabel
			// 
			cpuNameTitleLabel.AutoSize = true;
			cpuNameTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			cpuNameTitleLabel.Location = new Point(6, 3);
			cpuNameTitleLabel.Name = "cpuNameTitleLabel";
			cpuNameTitleLabel.Size = new Size(65, 21);
			cpuNameTitleLabel.TabIndex = 1;
			cpuNameTitleLabel.Text = "Name:";
			// 
			// cpuPlotView
			// 
			cpuPlotView.Location = new Point(6, 195);
			cpuPlotView.Name = "cpuPlotView";
			cpuPlotView.PanCursor = Cursors.Hand;
			cpuPlotView.Size = new Size(688, 294);
			cpuPlotView.TabIndex = 0;
			cpuPlotView.Text = "CPU Usage";
			cpuPlotView.ZoomHorizontalCursor = Cursors.SizeWE;
			cpuPlotView.ZoomRectangleCursor = Cursors.SizeNWSE;
			cpuPlotView.ZoomVerticalCursor = Cursors.SizeNS;
			// 
			// memoryPage
			// 
			memoryPage.Controls.Add(memoryPageFileLabel);
			memoryPage.Controls.Add(memoryPageFileTitleLabel);
			memoryPage.Controls.Add(memorySlotsUsedLabel);
			memoryPage.Controls.Add(memoryPhysicalRamLabel);
			memoryPage.Controls.Add(memoryAvailableLabel);
			memoryPage.Controls.Add(memoryInUseLabel);
			memoryPage.Controls.Add(memoryUtilizationLabel);
			memoryPage.Controls.Add(memoryPhysicalRamTitleLabel);
			memoryPage.Controls.Add(memorySlotsUsedTitleLabel);
			memoryPage.Controls.Add(memoryAvailableTitleLabel);
			memoryPage.Controls.Add(memoryInUseTitleLabel);
			memoryPage.Controls.Add(memoryUtilizationTitleLabel);
			memoryPage.Controls.Add(memoryPlotView);
			memoryPage.Location = new Point(4, 30);
			memoryPage.Name = "memoryPage";
			memoryPage.Padding = new Padding(3);
			memoryPage.Size = new Size(1330, 495);
			memoryPage.TabIndex = 2;
			memoryPage.Text = "Memory";
			memoryPage.UseVisualStyleBackColor = true;
			// 
			// memoryPageFileLabel
			// 
			memoryPageFileLabel.AutoSize = true;
			memoryPageFileLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			memoryPageFileLabel.Location = new Point(102, 111);
			memoryPageFileLabel.Name = "memoryPageFileLabel";
			memoryPageFileLabel.Size = new Size(25, 21);
			memoryPageFileLabel.TabIndex = 29;
			memoryPageFileLabel.Text = "...";
			// 
			// memoryPageFileTitleLabel
			// 
			memoryPageFileTitleLabel.AutoSize = true;
			memoryPageFileTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			memoryPageFileTitleLabel.Location = new Point(6, 111);
			memoryPageFileTitleLabel.Name = "memoryPageFileTitleLabel";
			memoryPageFileTitleLabel.Size = new Size(90, 21);
			memoryPageFileTitleLabel.TabIndex = 28;
			memoryPageFileTitleLabel.Text = "Page file:";
			// 
			// memorySlotsUsedLabel
			// 
			memorySlotsUsedLabel.AutoSize = true;
			memorySlotsUsedLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			memorySlotsUsedLabel.Location = new Point(117, 138);
			memorySlotsUsedLabel.Name = "memorySlotsUsedLabel";
			memorySlotsUsedLabel.Size = new Size(25, 21);
			memorySlotsUsedLabel.TabIndex = 27;
			memorySlotsUsedLabel.Text = "...";
			// 
			// memoryPhysicalRamLabel
			// 
			memoryPhysicalRamLabel.AutoSize = true;
			memoryPhysicalRamLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			memoryPhysicalRamLabel.Location = new Point(142, 84);
			memoryPhysicalRamLabel.Name = "memoryPhysicalRamLabel";
			memoryPhysicalRamLabel.Size = new Size(25, 21);
			memoryPhysicalRamLabel.TabIndex = 26;
			memoryPhysicalRamLabel.Text = "...";
			// 
			// memoryAvailableLabel
			// 
			memoryAvailableLabel.AutoSize = true;
			memoryAvailableLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			memoryAvailableLabel.Location = new Point(106, 57);
			memoryAvailableLabel.Name = "memoryAvailableLabel";
			memoryAvailableLabel.Size = new Size(25, 21);
			memoryAvailableLabel.TabIndex = 25;
			memoryAvailableLabel.Text = "...";
			// 
			// memoryInUseLabel
			// 
			memoryInUseLabel.AutoSize = true;
			memoryInUseLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			memoryInUseLabel.Location = new Point(82, 30);
			memoryInUseLabel.Name = "memoryInUseLabel";
			memoryInUseLabel.Size = new Size(25, 21);
			memoryInUseLabel.TabIndex = 24;
			memoryInUseLabel.Text = "...";
			// 
			// memoryUtilizationLabel
			// 
			memoryUtilizationLabel.AutoSize = true;
			memoryUtilizationLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			memoryUtilizationLabel.Location = new Point(116, 3);
			memoryUtilizationLabel.Name = "memoryUtilizationLabel";
			memoryUtilizationLabel.Size = new Size(25, 21);
			memoryUtilizationLabel.TabIndex = 23;
			memoryUtilizationLabel.Text = "...";
			// 
			// memoryPhysicalRamTitleLabel
			// 
			memoryPhysicalRamTitleLabel.AutoSize = true;
			memoryPhysicalRamTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			memoryPhysicalRamTitleLabel.Location = new Point(6, 84);
			memoryPhysicalRamTitleLabel.Name = "memoryPhysicalRamTitleLabel";
			memoryPhysicalRamTitleLabel.Size = new Size(130, 21);
			memoryPhysicalRamTitleLabel.TabIndex = 20;
			memoryPhysicalRamTitleLabel.Text = "Physical RAM:";
			// 
			// memorySlotsUsedTitleLabel
			// 
			memorySlotsUsedTitleLabel.AutoSize = true;
			memorySlotsUsedTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			memorySlotsUsedTitleLabel.Location = new Point(6, 138);
			memorySlotsUsedTitleLabel.Name = "memorySlotsUsedTitleLabel";
			memorySlotsUsedTitleLabel.Size = new Size(105, 21);
			memorySlotsUsedTitleLabel.TabIndex = 19;
			memorySlotsUsedTitleLabel.Text = "Slots used:";
			// 
			// memoryAvailableTitleLabel
			// 
			memoryAvailableTitleLabel.AutoSize = true;
			memoryAvailableTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			memoryAvailableTitleLabel.Location = new Point(6, 57);
			memoryAvailableTitleLabel.Name = "memoryAvailableTitleLabel";
			memoryAvailableTitleLabel.Size = new Size(94, 21);
			memoryAvailableTitleLabel.TabIndex = 18;
			memoryAvailableTitleLabel.Text = "Available:";
			// 
			// memoryInUseTitleLabel
			// 
			memoryInUseTitleLabel.AutoSize = true;
			memoryInUseTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			memoryInUseTitleLabel.Location = new Point(6, 30);
			memoryInUseTitleLabel.Name = "memoryInUseTitleLabel";
			memoryInUseTitleLabel.Size = new Size(70, 21);
			memoryInUseTitleLabel.TabIndex = 17;
			memoryInUseTitleLabel.Text = "In use:";
			// 
			// memoryUtilizationTitleLabel
			// 
			memoryUtilizationTitleLabel.AutoSize = true;
			memoryUtilizationTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			memoryUtilizationTitleLabel.Location = new Point(6, 3);
			memoryUtilizationTitleLabel.Name = "memoryUtilizationTitleLabel";
			memoryUtilizationTitleLabel.Size = new Size(104, 21);
			memoryUtilizationTitleLabel.TabIndex = 16;
			memoryUtilizationTitleLabel.Text = "Utilization:";
			// 
			// memoryPlotView
			// 
			memoryPlotView.Location = new Point(6, 195);
			memoryPlotView.Name = "memoryPlotView";
			memoryPlotView.PanCursor = Cursors.Hand;
			memoryPlotView.Size = new Size(688, 294);
			memoryPlotView.TabIndex = 15;
			memoryPlotView.Text = "Memory Usage";
			memoryPlotView.ZoomHorizontalCursor = Cursors.SizeWE;
			memoryPlotView.ZoomRectangleCursor = Cursors.SizeNWSE;
			memoryPlotView.ZoomVerticalCursor = Cursors.SizeNS;
			// 
			// diskPage
			// 
			diskPage.Controls.Add(diskTracksLabel);
			diskPage.Controls.Add(diskSectorsLabel);
			diskPage.Controls.Add(diskHeadsLabel);
			diskPage.Controls.Add(diskCylindersLabel);
			diskPage.Controls.Add(diskTracksTitleLabel);
			diskPage.Controls.Add(diskSectorsTitleLabel);
			diskPage.Controls.Add(diskHeadsTitleLabel);
			diskPage.Controls.Add(diskCylindersTitleLabel);
			diskPage.Controls.Add(diskTypeLabel);
			diskPage.Controls.Add(diskTypeTitleLabel);
			diskPage.Controls.Add(diskNameLabel);
			diskPage.Controls.Add(diskNameTitleLabel);
			diskPage.Controls.Add(diskCapacityLabel);
			diskPage.Controls.Add(diskWriteSpeedLabel);
			diskPage.Controls.Add(diskReadSpeedLabel);
			diskPage.Controls.Add(diskResponeTimeLabel);
			diskPage.Controls.Add(diskActiveTimeLabel);
			diskPage.Controls.Add(diskWriteSpeedTitleLabel);
			diskPage.Controls.Add(diskCapacityTitleLabel);
			diskPage.Controls.Add(diskReadSpeedTitleLabel);
			diskPage.Controls.Add(diskResponeTimeTitleLabel);
			diskPage.Controls.Add(diskActiveTimeTitleLabel);
			diskPage.Controls.Add(diskPlotView);
			diskPage.Location = new Point(4, 30);
			diskPage.Name = "diskPage";
			diskPage.Padding = new Padding(3);
			diskPage.Size = new Size(1330, 495);
			diskPage.TabIndex = 3;
			diskPage.Text = "Disk";
			diskPage.UseVisualStyleBackColor = true;
			// 
			// diskTracksLabel
			// 
			diskTracksLabel.AutoSize = true;
			diskTracksLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			diskTracksLabel.Location = new Point(527, 84);
			diskTracksLabel.Name = "diskTracksLabel";
			diskTracksLabel.Size = new Size(25, 21);
			diskTracksLabel.TabIndex = 52;
			diskTracksLabel.Text = "...";
			// 
			// diskSectorsLabel
			// 
			diskSectorsLabel.AutoSize = true;
			diskSectorsLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			diskSectorsLabel.Location = new Point(536, 57);
			diskSectorsLabel.Name = "diskSectorsLabel";
			diskSectorsLabel.Size = new Size(25, 21);
			diskSectorsLabel.TabIndex = 51;
			diskSectorsLabel.Text = "...";
			// 
			// diskHeadsLabel
			// 
			diskHeadsLabel.AutoSize = true;
			diskHeadsLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			diskHeadsLabel.Location = new Point(525, 30);
			diskHeadsLabel.Name = "diskHeadsLabel";
			diskHeadsLabel.Size = new Size(25, 21);
			diskHeadsLabel.TabIndex = 50;
			diskHeadsLabel.Text = "...";
			// 
			// diskCylindersLabel
			// 
			diskCylindersLabel.AutoSize = true;
			diskCylindersLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			diskCylindersLabel.Location = new Point(551, 3);
			diskCylindersLabel.Name = "diskCylindersLabel";
			diskCylindersLabel.Size = new Size(25, 21);
			diskCylindersLabel.TabIndex = 49;
			diskCylindersLabel.Text = "...";
			// 
			// diskTracksTitleLabel
			// 
			diskTracksTitleLabel.AutoSize = true;
			diskTracksTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			diskTracksTitleLabel.Location = new Point(450, 84);
			diskTracksTitleLabel.Name = "diskTracksTitleLabel";
			diskTracksTitleLabel.Size = new Size(71, 21);
			diskTracksTitleLabel.TabIndex = 48;
			diskTracksTitleLabel.Text = "Tracks:";
			// 
			// diskSectorsTitleLabel
			// 
			diskSectorsTitleLabel.AutoSize = true;
			diskSectorsTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			diskSectorsTitleLabel.Location = new Point(450, 57);
			diskSectorsTitleLabel.Name = "diskSectorsTitleLabel";
			diskSectorsTitleLabel.Size = new Size(80, 21);
			diskSectorsTitleLabel.TabIndex = 47;
			diskSectorsTitleLabel.Text = "Sectors:";
			// 
			// diskHeadsTitleLabel
			// 
			diskHeadsTitleLabel.AutoSize = true;
			diskHeadsTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			diskHeadsTitleLabel.Location = new Point(450, 30);
			diskHeadsTitleLabel.Name = "diskHeadsTitleLabel";
			diskHeadsTitleLabel.Size = new Size(69, 21);
			diskHeadsTitleLabel.TabIndex = 46;
			diskHeadsTitleLabel.Text = "Heads:";
			// 
			// diskCylindersTitleLabel
			// 
			diskCylindersTitleLabel.AutoSize = true;
			diskCylindersTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			diskCylindersTitleLabel.Location = new Point(450, 3);
			diskCylindersTitleLabel.Name = "diskCylindersTitleLabel";
			diskCylindersTitleLabel.Size = new Size(95, 21);
			diskCylindersTitleLabel.TabIndex = 45;
			diskCylindersTitleLabel.Text = "Cylinders:";
			// 
			// diskTypeLabel
			// 
			diskTypeLabel.AutoSize = true;
			diskTypeLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			diskTypeLabel.Location = new Point(69, 165);
			diskTypeLabel.Name = "diskTypeLabel";
			diskTypeLabel.Size = new Size(25, 21);
			diskTypeLabel.TabIndex = 44;
			diskTypeLabel.Text = "...";
			// 
			// diskTypeTitleLabel
			// 
			diskTypeTitleLabel.AutoSize = true;
			diskTypeTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			diskTypeTitleLabel.Location = new Point(6, 165);
			diskTypeTitleLabel.Name = "diskTypeTitleLabel";
			diskTypeTitleLabel.Size = new Size(57, 21);
			diskTypeTitleLabel.TabIndex = 43;
			diskTypeTitleLabel.Text = "Type:";
			// 
			// diskNameLabel
			// 
			diskNameLabel.AutoSize = true;
			diskNameLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			diskNameLabel.Location = new Point(77, 111);
			diskNameLabel.Name = "diskNameLabel";
			diskNameLabel.Size = new Size(25, 21);
			diskNameLabel.TabIndex = 42;
			diskNameLabel.Text = "...";
			// 
			// diskNameTitleLabel
			// 
			diskNameTitleLabel.AutoSize = true;
			diskNameTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			diskNameTitleLabel.Location = new Point(6, 111);
			diskNameTitleLabel.Name = "diskNameTitleLabel";
			diskNameTitleLabel.Size = new Size(65, 21);
			diskNameTitleLabel.TabIndex = 41;
			diskNameTitleLabel.Text = "Name:";
			// 
			// diskCapacityLabel
			// 
			diskCapacityLabel.AutoSize = true;
			diskCapacityLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			diskCapacityLabel.Location = new Point(101, 138);
			diskCapacityLabel.Name = "diskCapacityLabel";
			diskCapacityLabel.Size = new Size(25, 21);
			diskCapacityLabel.TabIndex = 40;
			diskCapacityLabel.Text = "...";
			// 
			// diskWriteSpeedLabel
			// 
			diskWriteSpeedLabel.AutoSize = true;
			diskWriteSpeedLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			diskWriteSpeedLabel.Location = new Point(130, 84);
			diskWriteSpeedLabel.Name = "diskWriteSpeedLabel";
			diskWriteSpeedLabel.Size = new Size(25, 21);
			diskWriteSpeedLabel.TabIndex = 39;
			diskWriteSpeedLabel.Text = "...";
			// 
			// diskReadSpeedLabel
			// 
			diskReadSpeedLabel.AutoSize = true;
			diskReadSpeedLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			diskReadSpeedLabel.Location = new Point(127, 57);
			diskReadSpeedLabel.Name = "diskReadSpeedLabel";
			diskReadSpeedLabel.Size = new Size(25, 21);
			diskReadSpeedLabel.TabIndex = 38;
			diskReadSpeedLabel.Text = "...";
			// 
			// diskResponeTimeLabel
			// 
			diskResponeTimeLabel.AutoSize = true;
			diskResponeTimeLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			diskResponeTimeLabel.Location = new Point(224, 30);
			diskResponeTimeLabel.Name = "diskResponeTimeLabel";
			diskResponeTimeLabel.Size = new Size(25, 21);
			diskResponeTimeLabel.TabIndex = 37;
			diskResponeTimeLabel.Text = "...";
			// 
			// diskActiveTimeLabel
			// 
			diskActiveTimeLabel.AutoSize = true;
			diskActiveTimeLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			diskActiveTimeLabel.Location = new Point(124, 3);
			diskActiveTimeLabel.Name = "diskActiveTimeLabel";
			diskActiveTimeLabel.Size = new Size(25, 21);
			diskActiveTimeLabel.TabIndex = 36;
			diskActiveTimeLabel.Text = "...";
			// 
			// diskWriteSpeedTitleLabel
			// 
			diskWriteSpeedTitleLabel.AutoSize = true;
			diskWriteSpeedTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			diskWriteSpeedTitleLabel.Location = new Point(6, 84);
			diskWriteSpeedTitleLabel.Name = "diskWriteSpeedTitleLabel";
			diskWriteSpeedTitleLabel.Size = new Size(118, 21);
			diskWriteSpeedTitleLabel.TabIndex = 35;
			diskWriteSpeedTitleLabel.Text = "Write speed:";
			// 
			// diskCapacityTitleLabel
			// 
			diskCapacityTitleLabel.AutoSize = true;
			diskCapacityTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			diskCapacityTitleLabel.Location = new Point(6, 138);
			diskCapacityTitleLabel.Name = "diskCapacityTitleLabel";
			diskCapacityTitleLabel.Size = new Size(89, 21);
			diskCapacityTitleLabel.TabIndex = 34;
			diskCapacityTitleLabel.Text = "Capacity:";
			// 
			// diskReadSpeedTitleLabel
			// 
			diskReadSpeedTitleLabel.AutoSize = true;
			diskReadSpeedTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			diskReadSpeedTitleLabel.Location = new Point(6, 57);
			diskReadSpeedTitleLabel.Name = "diskReadSpeedTitleLabel";
			diskReadSpeedTitleLabel.Size = new Size(115, 21);
			diskReadSpeedTitleLabel.TabIndex = 33;
			diskReadSpeedTitleLabel.Text = "Read speed:";
			// 
			// diskResponeTimeTitleLabel
			// 
			diskResponeTimeTitleLabel.AutoSize = true;
			diskResponeTimeTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			diskResponeTimeTitleLabel.Location = new Point(6, 30);
			diskResponeTimeTitleLabel.Name = "diskResponeTimeTitleLabel";
			diskResponeTimeTitleLabel.Size = new Size(212, 21);
			diskResponeTimeTitleLabel.TabIndex = 32;
			diskResponeTimeTitleLabel.Text = "Average response time:";
			// 
			// diskActiveTimeTitleLabel
			// 
			diskActiveTimeTitleLabel.AutoSize = true;
			diskActiveTimeTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			diskActiveTimeTitleLabel.Location = new Point(6, 3);
			diskActiveTimeTitleLabel.Name = "diskActiveTimeTitleLabel";
			diskActiveTimeTitleLabel.Size = new Size(112, 21);
			diskActiveTimeTitleLabel.TabIndex = 31;
			diskActiveTimeTitleLabel.Text = "Active time:";
			// 
			// diskPlotView
			// 
			diskPlotView.Location = new Point(6, 195);
			diskPlotView.Name = "diskPlotView";
			diskPlotView.PanCursor = Cursors.Hand;
			diskPlotView.Size = new Size(688, 294);
			diskPlotView.TabIndex = 30;
			diskPlotView.Text = "Disk Usage";
			diskPlotView.ZoomHorizontalCursor = Cursors.SizeWE;
			diskPlotView.ZoomRectangleCursor = Cursors.SizeNWSE;
			diskPlotView.ZoomVerticalCursor = Cursors.SizeNS;
			// 
			// networkPage
			// 
			networkPage.Controls.Add(networkTotalLabel);
			networkPage.Controls.Add(networkTotalTitleLabel);
			networkPage.Controls.Add(networkReceiveLabel);
			networkPage.Controls.Add(networkSendLabel);
			networkPage.Controls.Add(networkNameLabel);
			networkPage.Controls.Add(networkTypeLabel);
			networkPage.Controls.Add(networkReceiveTitleLabel);
			networkPage.Controls.Add(networkSendTitleLabel);
			networkPage.Controls.Add(networkNameTitleLabel);
			networkPage.Controls.Add(networkTypeTitleLabel);
			networkPage.Controls.Add(networkPlotView);
			networkPage.Location = new Point(4, 30);
			networkPage.Name = "networkPage";
			networkPage.Padding = new Padding(3);
			networkPage.Size = new Size(1330, 495);
			networkPage.TabIndex = 4;
			networkPage.Text = "Network";
			networkPage.UseVisualStyleBackColor = true;
			// 
			// networkTotalLabel
			// 
			networkTotalLabel.AutoSize = true;
			networkTotalLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			networkTotalLabel.Location = new Point(71, 111);
			networkTotalLabel.Name = "networkTotalLabel";
			networkTotalLabel.Size = new Size(25, 21);
			networkTotalLabel.TabIndex = 57;
			networkTotalLabel.Text = "...";
			// 
			// networkTotalTitleLabel
			// 
			networkTotalTitleLabel.AutoSize = true;
			networkTotalTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			networkTotalTitleLabel.Location = new Point(6, 111);
			networkTotalTitleLabel.Name = "networkTotalTitleLabel";
			networkTotalTitleLabel.Size = new Size(59, 21);
			networkTotalTitleLabel.TabIndex = 56;
			networkTotalTitleLabel.Text = "Total:";
			// 
			// networkReceiveLabel
			// 
			networkReceiveLabel.AutoSize = true;
			networkReceiveLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			networkReceiveLabel.Location = new Point(94, 84);
			networkReceiveLabel.Name = "networkReceiveLabel";
			networkReceiveLabel.Size = new Size(25, 21);
			networkReceiveLabel.TabIndex = 54;
			networkReceiveLabel.Text = "...";
			// 
			// networkSendLabel
			// 
			networkSendLabel.AutoSize = true;
			networkSendLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			networkSendLabel.Location = new Point(71, 57);
			networkSendLabel.Name = "networkSendLabel";
			networkSendLabel.Size = new Size(25, 21);
			networkSendLabel.TabIndex = 53;
			networkSendLabel.Text = "...";
			// 
			// networkNameLabel
			// 
			networkNameLabel.AutoSize = true;
			networkNameLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			networkNameLabel.Location = new Point(77, 30);
			networkNameLabel.Name = "networkNameLabel";
			networkNameLabel.Size = new Size(25, 21);
			networkNameLabel.TabIndex = 52;
			networkNameLabel.Text = "...";
			// 
			// networkTypeLabel
			// 
			networkTypeLabel.AutoSize = true;
			networkTypeLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			networkTypeLabel.Location = new Point(69, 3);
			networkTypeLabel.Name = "networkTypeLabel";
			networkTypeLabel.Size = new Size(25, 21);
			networkTypeLabel.TabIndex = 51;
			networkTypeLabel.Text = "...";
			// 
			// networkReceiveTitleLabel
			// 
			networkReceiveTitleLabel.AutoSize = true;
			networkReceiveTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			networkReceiveTitleLabel.Location = new Point(6, 84);
			networkReceiveTitleLabel.Name = "networkReceiveTitleLabel";
			networkReceiveTitleLabel.Size = new Size(82, 21);
			networkReceiveTitleLabel.TabIndex = 50;
			networkReceiveTitleLabel.Text = "Receive:";
			// 
			// networkSendTitleLabel
			// 
			networkSendTitleLabel.AutoSize = true;
			networkSendTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			networkSendTitleLabel.Location = new Point(6, 57);
			networkSendTitleLabel.Name = "networkSendTitleLabel";
			networkSendTitleLabel.Size = new Size(59, 21);
			networkSendTitleLabel.TabIndex = 48;
			networkSendTitleLabel.Text = "Send:";
			// 
			// networkNameTitleLabel
			// 
			networkNameTitleLabel.AutoSize = true;
			networkNameTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			networkNameTitleLabel.Location = new Point(6, 30);
			networkNameTitleLabel.Name = "networkNameTitleLabel";
			networkNameTitleLabel.Size = new Size(65, 21);
			networkNameTitleLabel.TabIndex = 47;
			networkNameTitleLabel.Text = "Name:";
			// 
			// networkTypeTitleLabel
			// 
			networkTypeTitleLabel.AutoSize = true;
			networkTypeTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			networkTypeTitleLabel.Location = new Point(6, 3);
			networkTypeTitleLabel.Name = "networkTypeTitleLabel";
			networkTypeTitleLabel.Size = new Size(57, 21);
			networkTypeTitleLabel.TabIndex = 46;
			networkTypeTitleLabel.Text = "Type:";
			// 
			// networkPlotView
			// 
			networkPlotView.Location = new Point(6, 195);
			networkPlotView.Name = "networkPlotView";
			networkPlotView.PanCursor = Cursors.Hand;
			networkPlotView.Size = new Size(688, 294);
			networkPlotView.TabIndex = 45;
			networkPlotView.Text = "Network Usage";
			networkPlotView.ZoomHorizontalCursor = Cursors.SizeWE;
			networkPlotView.ZoomRectangleCursor = Cursors.SizeNWSE;
			networkPlotView.ZoomVerticalCursor = Cursors.SizeNS;
			// 
			// gpuPage
			// 
			gpuPage.Controls.Add(gpuGroupBox1);
			gpuPage.Controls.Add(gpuGroupBox0);
			gpuPage.Controls.Add(gpuPlotView);
			gpuPage.Location = new Point(4, 30);
			gpuPage.Name = "gpuPage";
			gpuPage.Padding = new Padding(3);
			gpuPage.Size = new Size(1330, 495);
			gpuPage.TabIndex = 5;
			gpuPage.Text = "GPU";
			gpuPage.UseVisualStyleBackColor = true;
			// 
			// gpuGroupBox1
			// 
			gpuGroupBox1.Controls.Add(gpu1NameTitleLabel);
			gpuGroupBox1.Controls.Add(gpu1NameLabel);
			gpuGroupBox1.Controls.Add(gpu1TemperatureLabel);
			gpuGroupBox1.Controls.Add(gpu1UtilizationTitleLabel);
			gpuGroupBox1.Controls.Add(gpu1UtilizationLabel);
			gpuGroupBox1.Controls.Add(gpu1TemperatureTitleLabel);
			gpuGroupBox1.Location = new Point(360, 6);
			gpuGroupBox1.Name = "gpuGroupBox1";
			gpuGroupBox1.Size = new Size(334, 183);
			gpuGroupBox1.TabIndex = 68;
			gpuGroupBox1.TabStop = false;
			gpuGroupBox1.Text = "GPU 1";
			// 
			// gpu1NameTitleLabel
			// 
			gpu1NameTitleLabel.AutoSize = true;
			gpu1NameTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			gpu1NameTitleLabel.Location = new Point(6, 24);
			gpu1NameTitleLabel.Name = "gpu1NameTitleLabel";
			gpu1NameTitleLabel.Size = new Size(65, 21);
			gpu1NameTitleLabel.TabIndex = 59;
			gpu1NameTitleLabel.Text = "Name:";
			// 
			// gpu1NameLabel
			// 
			gpu1NameLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			gpu1NameLabel.Location = new Point(77, 24);
			gpu1NameLabel.Name = "gpu1NameLabel";
			gpu1NameLabel.Size = new Size(251, 21);
			gpu1NameLabel.TabIndex = 63;
			gpu1NameLabel.Text = "...";
			// 
			// gpu1TemperatureLabel
			// 
			gpu1TemperatureLabel.AutoSize = true;
			gpu1TemperatureLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			gpu1TemperatureLabel.Location = new Point(137, 78);
			gpu1TemperatureLabel.Name = "gpu1TemperatureLabel";
			gpu1TemperatureLabel.Size = new Size(25, 21);
			gpu1TemperatureLabel.TabIndex = 65;
			gpu1TemperatureLabel.Text = "...";
			// 
			// gpu1UtilizationTitleLabel
			// 
			gpu1UtilizationTitleLabel.AutoSize = true;
			gpu1UtilizationTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			gpu1UtilizationTitleLabel.Location = new Point(6, 51);
			gpu1UtilizationTitleLabel.Name = "gpu1UtilizationTitleLabel";
			gpu1UtilizationTitleLabel.Size = new Size(104, 21);
			gpu1UtilizationTitleLabel.TabIndex = 60;
			gpu1UtilizationTitleLabel.Text = "Utilization:";
			// 
			// gpu1UtilizationLabel
			// 
			gpu1UtilizationLabel.AutoSize = true;
			gpu1UtilizationLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			gpu1UtilizationLabel.Location = new Point(116, 51);
			gpu1UtilizationLabel.Name = "gpu1UtilizationLabel";
			gpu1UtilizationLabel.Size = new Size(25, 21);
			gpu1UtilizationLabel.TabIndex = 64;
			gpu1UtilizationLabel.Text = "...";
			// 
			// gpu1TemperatureTitleLabel
			// 
			gpu1TemperatureTitleLabel.AutoSize = true;
			gpu1TemperatureTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			gpu1TemperatureTitleLabel.Location = new Point(6, 78);
			gpu1TemperatureTitleLabel.Name = "gpu1TemperatureTitleLabel";
			gpu1TemperatureTitleLabel.Size = new Size(125, 21);
			gpu1TemperatureTitleLabel.TabIndex = 61;
			gpu1TemperatureTitleLabel.Text = "Temperature:";
			// 
			// gpuGroupBox0
			// 
			gpuGroupBox0.Controls.Add(gpu0NameTitleLabel);
			gpuGroupBox0.Controls.Add(gpu0NameLabel);
			gpuGroupBox0.Controls.Add(gpu0TemperatureLabel);
			gpuGroupBox0.Controls.Add(gpu0UtilizationTitleLabel);
			gpuGroupBox0.Controls.Add(gpu0UtilizationLabel);
			gpuGroupBox0.Controls.Add(gpu0TemperatureTitleLabel);
			gpuGroupBox0.Location = new Point(6, 6);
			gpuGroupBox0.Name = "gpuGroupBox0";
			gpuGroupBox0.Size = new Size(334, 183);
			gpuGroupBox0.TabIndex = 67;
			gpuGroupBox0.TabStop = false;
			gpuGroupBox0.Text = "GPU 0";
			// 
			// gpu0NameTitleLabel
			// 
			gpu0NameTitleLabel.AutoSize = true;
			gpu0NameTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			gpu0NameTitleLabel.Location = new Point(6, 24);
			gpu0NameTitleLabel.Name = "gpu0NameTitleLabel";
			gpu0NameTitleLabel.Size = new Size(65, 21);
			gpu0NameTitleLabel.TabIndex = 59;
			gpu0NameTitleLabel.Text = "Name:";
			// 
			// gpu0NameLabel
			// 
			gpu0NameLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			gpu0NameLabel.Location = new Point(77, 24);
			gpu0NameLabel.Name = "gpu0NameLabel";
			gpu0NameLabel.Size = new Size(251, 21);
			gpu0NameLabel.TabIndex = 63;
			gpu0NameLabel.Text = "...";
			// 
			// gpu0TemperatureLabel
			// 
			gpu0TemperatureLabel.AutoSize = true;
			gpu0TemperatureLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			gpu0TemperatureLabel.Location = new Point(137, 78);
			gpu0TemperatureLabel.Name = "gpu0TemperatureLabel";
			gpu0TemperatureLabel.Size = new Size(25, 21);
			gpu0TemperatureLabel.TabIndex = 65;
			gpu0TemperatureLabel.Text = "...";
			// 
			// gpu0UtilizationTitleLabel
			// 
			gpu0UtilizationTitleLabel.AutoSize = true;
			gpu0UtilizationTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			gpu0UtilizationTitleLabel.Location = new Point(6, 51);
			gpu0UtilizationTitleLabel.Name = "gpu0UtilizationTitleLabel";
			gpu0UtilizationTitleLabel.Size = new Size(104, 21);
			gpu0UtilizationTitleLabel.TabIndex = 60;
			gpu0UtilizationTitleLabel.Text = "Utilization:";
			// 
			// gpu0UtilizationLabel
			// 
			gpu0UtilizationLabel.AutoSize = true;
			gpu0UtilizationLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			gpu0UtilizationLabel.Location = new Point(116, 51);
			gpu0UtilizationLabel.Name = "gpu0UtilizationLabel";
			gpu0UtilizationLabel.Size = new Size(25, 21);
			gpu0UtilizationLabel.TabIndex = 64;
			gpu0UtilizationLabel.Text = "...";
			// 
			// gpu0TemperatureTitleLabel
			// 
			gpu0TemperatureTitleLabel.AutoSize = true;
			gpu0TemperatureTitleLabel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			gpu0TemperatureTitleLabel.Location = new Point(6, 78);
			gpu0TemperatureTitleLabel.Name = "gpu0TemperatureTitleLabel";
			gpu0TemperatureTitleLabel.Size = new Size(125, 21);
			gpu0TemperatureTitleLabel.TabIndex = 61;
			gpu0TemperatureTitleLabel.Text = "Temperature:";
			// 
			// gpuPlotView
			// 
			gpuPlotView.Location = new Point(6, 195);
			gpuPlotView.Name = "gpuPlotView";
			gpuPlotView.PanCursor = Cursors.Hand;
			gpuPlotView.Size = new Size(688, 294);
			gpuPlotView.TabIndex = 58;
			gpuPlotView.Text = "GPU Usage";
			gpuPlotView.ZoomHorizontalCursor = Cursors.SizeWE;
			gpuPlotView.ZoomRectangleCursor = Cursors.SizeNWSE;
			gpuPlotView.ZoomVerticalCursor = Cursors.SizeNS;
			// 
			// processTimer
			// 
			processTimer.Enabled = true;
			processTimer.Interval = 60000;
			processTimer.Tick += processTimer_Tick;
			// 
			// queueTimer
			// 
			queueTimer.Enabled = true;
			queueTimer.Interval = 1000;
			queueTimer.Tick += queueTimer_Tick;
			// 
			// performanceTimer
			// 
			performanceTimer.Enabled = true;
			performanceTimer.Interval = 1000;
			performanceTimer.Tick += performanceTimer_Tick;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(12F, 27F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1362, 553);
			Controls.Add(tabControl);
			Font = new Font("Tahoma", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4);
			MaximizeBox = false;
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Task Manager Clone";
			Load += MainForm_Load;
			tabControl.ResumeLayout(false);
			processPage.ResumeLayout(false);
			processPage.PerformLayout();
			cpuPage.ResumeLayout(false);
			cpuPage.PerformLayout();
			memoryPage.ResumeLayout(false);
			memoryPage.PerformLayout();
			diskPage.ResumeLayout(false);
			diskPage.PerformLayout();
			networkPage.ResumeLayout(false);
			networkPage.PerformLayout();
			gpuPage.ResumeLayout(false);
			gpuGroupBox1.ResumeLayout(false);
			gpuGroupBox1.PerformLayout();
			gpuGroupBox0.ResumeLayout(false);
			gpuGroupBox0.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabControl;
		private TabPage processPage;
		private TabPage cpuPage;
		private Button runNewTaskButton;
		private Button restartTaskButton;
		private Button endTaskButton;
		private TextBox searchBar;
		private ListView processView;
		private System.Windows.Forms.Timer processTimer;
		private ColumnHeader processProcessColumn;
		private ColumnHeader processIdColumn;
		private ColumnHeader processCpuColumn;
		private ColumnHeader processMemoryColumn;
		private ColumnHeader processDescriptionColumn;
		private Button stopAtButton;
		private Button runAtButton;
		private DateTimePicker timePicker;
		private System.Windows.Forms.Timer queueTimer;
		private Button dequeueButton;
		private ListView queueView;
		private ColumnHeader queueTimeRunColumn;
		private ColumnHeader queueCreatedOnColumn;
		private Label queueLabel;
		private ColumnHeader queueProcessColumn;
		private ColumnHeader queueStatusColumn;
		private Button refreshButton;
		private Label lastUpdateLabel;
		private Label lastUpdateTitleLabel;
		private Button restartAtButton;
		private OxyPlot.WindowsForms.PlotView cpuPlotView;
		private System.Windows.Forms.Timer performanceTimer;
		private Label cpuNameTitleLabel;
		private Label cpuUtilizationTitleLabel;
		private Label cpuProcessesTitleLabel;
		private Label cpuThreadTitleLabel;
		private Label cpuSpeedTitleLabel;
		private Label cpuUpTimeTitleLabel;
		private Label cpuHandlesTitleLabel;
		private TabPage memoryPage;
		private Label cpuThreadsLabel;
		private Label cpuProcessesLabel;
		private Label cpuSpeedLabel;
		private Label cpuUtilizationLabel;
		private Label cpuNameLabel;
		private Label cpuUpTimeLabel;
		private Label cpuHandlesLabel;
		private Label memorySlotsUsedLabel;
		private Label memoryPhysicalRamLabel;
		private Label memoryAvailableLabel;
		private Label memoryInUseLabel;
		private Label memoryUtilizationLabel;
		private Label memoryPhysicalRamTitleLabel;
		private Label memorySlotsUsedTitleLabel;
		private Label memoryAvailableTitleLabel;
		private Label memoryInUseTitleLabel;
		private Label memoryUtilizationTitleLabel;
		private OxyPlot.WindowsForms.PlotView memoryPlotView;
		private Label memoryPageFileLabel;
		private Label memoryPageFileTitleLabel;
		private TabPage diskPage;
		private Label diskTypeTitleLabel;
		private Label diskNameLabel;
		private Label diskNameTitleLabel;
		private Label diskCapacityLabel;
		private Label diskWriteSpeedLabel;
		private Label diskReadSpeedLabel;
		private Label diskResponeTimeLabel;
		private Label diskActiveTimeLabel;
		private Label diskWriteSpeedTitleLabel;
		private Label diskCapacityTitleLabel;
		private Label diskReadSpeedTitleLabel;
		private Label diskResponeTimeTitleLabel;
		private Label diskActiveTimeTitleLabel;
		private OxyPlot.WindowsForms.PlotView diskPlotView;
		private Label diskTypeLabel;
		private Label diskCylindersTitleLabel;
		private Label diskHeadsTitleLabel;
		private Label diskTracksTitleLabel;
		private Label diskSectorsTitleLabel;
		private Label diskTracksLabel;
		private Label diskSectorsLabel;
		private Label diskHeadsLabel;
		private Label diskCylindersLabel;
		private TabPage networkPage;
		private TabPage gpuPage;
		private Label gpu1NameLabel;
		private Label gpu1TemperatureLabel;
		private Label networkTotalLabel;
		private Label networkTotalTitleLabel;
		private Label gpu1TemperatureTitleLabel;
		private Label networkReceiveLabel;
		private Label networkSendLabel;
		private Label networkNameLabel;
		private Label networkTypeLabel;
		private Label networkReceiveTitleLabel;
		private Label networkSendTitleLabel;
		private Label networkNameTitleLabel;
		private Label networkTypeTitleLabel;
		private OxyPlot.WindowsForms.PlotView networkPlotView;
		private Label gpu1UtilizationTitleLabel;
		private Label gpu1UtilizationLabel;
		private Label gpu0TemperatureLabel;
		private Label gpu0UtilizationLabel;
		private Label gpu0NameLabel;
		private Label gpu0TemperatureTitleLabel;
		private Label gpu0UtilizationTitleLabel;
		private Label gpu0NameTitleLabel;
		private OxyPlot.WindowsForms.PlotView gpuPlotView;
		private GroupBox gpuGroupBox0;
		private GroupBox gpuGroupBox1;
		private Label gpu1NameTitleLabel;
	}
}
