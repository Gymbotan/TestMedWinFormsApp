namespace TestMedWinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.modesGroupBox = new System.Windows.Forms.GroupBox();
            this.modeResetButton = new System.Windows.Forms.Button();
            this.modeSaveButton = new System.Windows.Forms.Button();
            this.modeDeleteButton = new System.Windows.Forms.Button();
            this.modeAddButton = new System.Windows.Forms.Button();
            this.modeTipsTBox = new System.Windows.Forms.TextBox();
            this.modeBottleTBox = new System.Windows.Forms.TextBox();
            this.modeNameTBox = new System.Windows.Forms.TextBox();
            this.modeIdTBox = new System.Windows.Forms.TextBox();
            this.modeTipsLabel = new System.Windows.Forms.Label();
            this.modeBottleLabel = new System.Windows.Forms.Label();
            this.modeNameLabel = new System.Windows.Forms.Label();
            this.modeIdLabel = new System.Windows.Forms.Label();
            this.stepsGroupBox = new System.Windows.Forms.GroupBox();
            this.stepResetButton = new System.Windows.Forms.Button();
            this.stepSaveButton = new System.Windows.Forms.Button();
            this.stepDeleteButton = new System.Windows.Forms.Button();
            this.stepAddButton = new System.Windows.Forms.Button();
            this.stepVolumeTBox = new System.Windows.Forms.TextBox();
            this.stepDestinationTBox = new System.Windows.Forms.TextBox();
            this.stepId = new System.Windows.Forms.Label();
            this.stepTypeTBox = new System.Windows.Forms.TextBox();
            this.stepTimerTBox = new System.Windows.Forms.TextBox();
            this.StepSpeedLabel = new System.Windows.Forms.Label();
            this.stepSpeedTBox = new System.Windows.Forms.TextBox();
            this.stepModeIdLabel = new System.Windows.Forms.Label();
            this.StepTypeLabel = new System.Windows.Forms.Label();
            this.stepModeIdTbox = new System.Windows.Forms.TextBox();
            this.stepTimerLabel = new System.Windows.Forms.Label();
            this.stepVolumeLabel = new System.Windows.Forms.Label();
            this.stepIdTBox = new System.Windows.Forms.TextBox();
            this.stepDestinationLabel = new System.Windows.Forms.Label();
            this.modesGridView = new System.Windows.Forms.DataGridView();
            this.stepsGridView = new System.Windows.Forms.DataGridView();
            this.excelButton = new System.Windows.Forms.Button();
            this.modesGroupBox.SuspendLayout();
            this.stepsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // modesGroupBox
            // 
            this.modesGroupBox.Controls.Add(this.modeResetButton);
            this.modesGroupBox.Controls.Add(this.modeSaveButton);
            this.modesGroupBox.Controls.Add(this.modeDeleteButton);
            this.modesGroupBox.Controls.Add(this.modeAddButton);
            this.modesGroupBox.Controls.Add(this.modeTipsTBox);
            this.modesGroupBox.Controls.Add(this.modeBottleTBox);
            this.modesGroupBox.Controls.Add(this.modeNameTBox);
            this.modesGroupBox.Controls.Add(this.modeIdTBox);
            this.modesGroupBox.Controls.Add(this.modeTipsLabel);
            this.modesGroupBox.Controls.Add(this.modeBottleLabel);
            this.modesGroupBox.Controls.Add(this.modeNameLabel);
            this.modesGroupBox.Controls.Add(this.modeIdLabel);
            this.modesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modesGroupBox.Location = new System.Drawing.Point(66, 34);
            this.modesGroupBox.Name = "modesGroupBox";
            this.modesGroupBox.Size = new System.Drawing.Size(279, 233);
            this.modesGroupBox.TabIndex = 0;
            this.modesGroupBox.TabStop = false;
            this.modesGroupBox.Text = "Modes";
            // 
            // modeResetButton
            // 
            this.modeResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modeResetButton.ForeColor = System.Drawing.Color.Red;
            this.modeResetButton.Location = new System.Drawing.Point(143, 195);
            this.modeResetButton.Name = "modeResetButton";
            this.modeResetButton.Size = new System.Drawing.Size(100, 29);
            this.modeResetButton.TabIndex = 3;
            this.modeResetButton.Text = "Reset";
            this.modeResetButton.UseVisualStyleBackColor = true;
            this.modeResetButton.Click += new System.EventHandler(this.modeResetButton_Click);
            // 
            // modeSaveButton
            // 
            this.modeSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modeSaveButton.ForeColor = System.Drawing.Color.Green;
            this.modeSaveButton.Location = new System.Drawing.Point(29, 195);
            this.modeSaveButton.Name = "modeSaveButton";
            this.modeSaveButton.Size = new System.Drawing.Size(100, 29);
            this.modeSaveButton.TabIndex = 2;
            this.modeSaveButton.Text = "Save all";
            this.modeSaveButton.UseVisualStyleBackColor = true;
            this.modeSaveButton.Click += new System.EventHandler(this.modeSaveButton_Click);
            // 
            // modeDeleteButton
            // 
            this.modeDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modeDeleteButton.ForeColor = System.Drawing.Color.Red;
            this.modeDeleteButton.Location = new System.Drawing.Point(143, 160);
            this.modeDeleteButton.Name = "modeDeleteButton";
            this.modeDeleteButton.Size = new System.Drawing.Size(100, 29);
            this.modeDeleteButton.TabIndex = 2;
            this.modeDeleteButton.Text = "Delete";
            this.modeDeleteButton.UseVisualStyleBackColor = true;
            this.modeDeleteButton.Click += new System.EventHandler(this.modeDeleteButton_Click);
            // 
            // modeAddButton
            // 
            this.modeAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modeAddButton.ForeColor = System.Drawing.Color.Blue;
            this.modeAddButton.Location = new System.Drawing.Point(29, 160);
            this.modeAddButton.Name = "modeAddButton";
            this.modeAddButton.Size = new System.Drawing.Size(100, 29);
            this.modeAddButton.TabIndex = 2;
            this.modeAddButton.Text = "Add new";
            this.modeAddButton.UseVisualStyleBackColor = true;
            this.modeAddButton.Click += new System.EventHandler(this.modeAddButton_Click);
            // 
            // modeTipsTBox
            // 
            this.modeTipsTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modeTipsTBox.Location = new System.Drawing.Point(112, 126);
            this.modeTipsTBox.Name = "modeTipsTBox";
            this.modeTipsTBox.Size = new System.Drawing.Size(131, 23);
            this.modeTipsTBox.TabIndex = 1;
            // 
            // modeBottleTBox
            // 
            this.modeBottleTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modeBottleTBox.Location = new System.Drawing.Point(112, 92);
            this.modeBottleTBox.Name = "modeBottleTBox";
            this.modeBottleTBox.Size = new System.Drawing.Size(131, 23);
            this.modeBottleTBox.TabIndex = 1;
            // 
            // modeNameTBox
            // 
            this.modeNameTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modeNameTBox.Location = new System.Drawing.Point(112, 59);
            this.modeNameTBox.Name = "modeNameTBox";
            this.modeNameTBox.Size = new System.Drawing.Size(131, 23);
            this.modeNameTBox.TabIndex = 1;
            // 
            // modeIdTBox
            // 
            this.modeIdTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modeIdTBox.Location = new System.Drawing.Point(112, 26);
            this.modeIdTBox.Name = "modeIdTBox";
            this.modeIdTBox.Size = new System.Drawing.Size(131, 23);
            this.modeIdTBox.TabIndex = 1;
            // 
            // modeTipsLabel
            // 
            this.modeTipsLabel.AutoSize = true;
            this.modeTipsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modeTipsLabel.Location = new System.Drawing.Point(26, 129);
            this.modeTipsLabel.Name = "modeTipsLabel";
            this.modeTipsLabel.Size = new System.Drawing.Size(60, 17);
            this.modeTipsLabel.TabIndex = 0;
            this.modeTipsLabel.Text = "MaxTips";
            // 
            // modeBottleLabel
            // 
            this.modeBottleLabel.AutoSize = true;
            this.modeBottleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modeBottleLabel.Location = new System.Drawing.Point(26, 95);
            this.modeBottleLabel.Name = "modeBottleLabel";
            this.modeBottleLabel.Size = new System.Drawing.Size(69, 17);
            this.modeBottleLabel.TabIndex = 0;
            this.modeBottleLabel.Text = "MaxBottle";
            // 
            // modeNameLabel
            // 
            this.modeNameLabel.AutoSize = true;
            this.modeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modeNameLabel.Location = new System.Drawing.Point(26, 62);
            this.modeNameLabel.Name = "modeNameLabel";
            this.modeNameLabel.Size = new System.Drawing.Size(45, 17);
            this.modeNameLabel.TabIndex = 0;
            this.modeNameLabel.Text = "Name";
            // 
            // modeIdLabel
            // 
            this.modeIdLabel.AutoSize = true;
            this.modeIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modeIdLabel.Location = new System.Drawing.Point(26, 29);
            this.modeIdLabel.Name = "modeIdLabel";
            this.modeIdLabel.Size = new System.Drawing.Size(19, 17);
            this.modeIdLabel.TabIndex = 0;
            this.modeIdLabel.Text = "Id";
            // 
            // stepsGroupBox
            // 
            this.stepsGroupBox.Controls.Add(this.stepResetButton);
            this.stepsGroupBox.Controls.Add(this.stepSaveButton);
            this.stepsGroupBox.Controls.Add(this.stepDeleteButton);
            this.stepsGroupBox.Controls.Add(this.stepAddButton);
            this.stepsGroupBox.Controls.Add(this.stepVolumeTBox);
            this.stepsGroupBox.Controls.Add(this.stepDestinationTBox);
            this.stepsGroupBox.Controls.Add(this.stepId);
            this.stepsGroupBox.Controls.Add(this.stepTypeTBox);
            this.stepsGroupBox.Controls.Add(this.stepTimerTBox);
            this.stepsGroupBox.Controls.Add(this.StepSpeedLabel);
            this.stepsGroupBox.Controls.Add(this.stepSpeedTBox);
            this.stepsGroupBox.Controls.Add(this.stepModeIdLabel);
            this.stepsGroupBox.Controls.Add(this.StepTypeLabel);
            this.stepsGroupBox.Controls.Add(this.stepModeIdTbox);
            this.stepsGroupBox.Controls.Add(this.stepTimerLabel);
            this.stepsGroupBox.Controls.Add(this.stepVolumeLabel);
            this.stepsGroupBox.Controls.Add(this.stepIdTBox);
            this.stepsGroupBox.Controls.Add(this.stepDestinationLabel);
            this.stepsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepsGroupBox.Location = new System.Drawing.Point(66, 276);
            this.stepsGroupBox.Name = "stepsGroupBox";
            this.stepsGroupBox.Size = new System.Drawing.Size(279, 307);
            this.stepsGroupBox.TabIndex = 1;
            this.stepsGroupBox.TabStop = false;
            this.stepsGroupBox.Text = "Steps";
            // 
            // stepResetButton
            // 
            this.stepResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepResetButton.ForeColor = System.Drawing.Color.Red;
            this.stepResetButton.Location = new System.Drawing.Point(143, 268);
            this.stepResetButton.Name = "stepResetButton";
            this.stepResetButton.Size = new System.Drawing.Size(100, 28);
            this.stepResetButton.TabIndex = 5;
            this.stepResetButton.Text = "Reset";
            this.stepResetButton.UseVisualStyleBackColor = true;
            this.stepResetButton.Click += new System.EventHandler(this.stepResetButton_Click);
            // 
            // stepSaveButton
            // 
            this.stepSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepSaveButton.ForeColor = System.Drawing.Color.Green;
            this.stepSaveButton.Location = new System.Drawing.Point(30, 268);
            this.stepSaveButton.Name = "stepSaveButton";
            this.stepSaveButton.Size = new System.Drawing.Size(99, 28);
            this.stepSaveButton.TabIndex = 4;
            this.stepSaveButton.Text = "Save all";
            this.stepSaveButton.UseVisualStyleBackColor = true;
            this.stepSaveButton.Click += new System.EventHandler(this.stepSaveButton_Click);
            // 
            // stepDeleteButton
            // 
            this.stepDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepDeleteButton.ForeColor = System.Drawing.Color.Red;
            this.stepDeleteButton.Location = new System.Drawing.Point(143, 233);
            this.stepDeleteButton.Name = "stepDeleteButton";
            this.stepDeleteButton.Size = new System.Drawing.Size(100, 28);
            this.stepDeleteButton.TabIndex = 3;
            this.stepDeleteButton.Text = "Delete";
            this.stepDeleteButton.UseVisualStyleBackColor = true;
            this.stepDeleteButton.Click += new System.EventHandler(this.stepDeleteButton_Click);
            // 
            // stepAddButton
            // 
            this.stepAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepAddButton.ForeColor = System.Drawing.Color.Blue;
            this.stepAddButton.Location = new System.Drawing.Point(29, 233);
            this.stepAddButton.Name = "stepAddButton";
            this.stepAddButton.Size = new System.Drawing.Size(100, 29);
            this.stepAddButton.TabIndex = 2;
            this.stepAddButton.Text = "Add new";
            this.stepAddButton.UseVisualStyleBackColor = true;
            this.stepAddButton.Click += new System.EventHandler(this.stepAddButton_Click);
            // 
            // stepVolumeTBox
            // 
            this.stepVolumeTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepVolumeTBox.Location = new System.Drawing.Point(112, 204);
            this.stepVolumeTBox.Name = "stepVolumeTBox";
            this.stepVolumeTBox.Size = new System.Drawing.Size(131, 23);
            this.stepVolumeTBox.TabIndex = 1;
            // 
            // stepDestinationTBox
            // 
            this.stepDestinationTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepDestinationTBox.Location = new System.Drawing.Point(112, 117);
            this.stepDestinationTBox.Name = "stepDestinationTBox";
            this.stepDestinationTBox.Size = new System.Drawing.Size(131, 23);
            this.stepDestinationTBox.TabIndex = 1;
            // 
            // stepId
            // 
            this.stepId.AutoSize = true;
            this.stepId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepId.Location = new System.Drawing.Point(26, 34);
            this.stepId.Name = "stepId";
            this.stepId.Size = new System.Drawing.Size(19, 17);
            this.stepId.TabIndex = 0;
            this.stepId.Text = "Id";
            // 
            // stepTypeTBox
            // 
            this.stepTypeTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepTypeTBox.Location = new System.Drawing.Point(112, 175);
            this.stepTypeTBox.Name = "stepTypeTBox";
            this.stepTypeTBox.Size = new System.Drawing.Size(131, 23);
            this.stepTypeTBox.TabIndex = 1;
            // 
            // stepTimerTBox
            // 
            this.stepTimerTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepTimerTBox.Location = new System.Drawing.Point(112, 88);
            this.stepTimerTBox.Name = "stepTimerTBox";
            this.stepTimerTBox.Size = new System.Drawing.Size(131, 23);
            this.stepTimerTBox.TabIndex = 1;
            // 
            // StepSpeedLabel
            // 
            this.StepSpeedLabel.AutoSize = true;
            this.StepSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StepSpeedLabel.Location = new System.Drawing.Point(26, 149);
            this.StepSpeedLabel.Name = "StepSpeedLabel";
            this.StepSpeedLabel.Size = new System.Drawing.Size(49, 17);
            this.StepSpeedLabel.TabIndex = 0;
            this.StepSpeedLabel.Text = "Speed";
            // 
            // stepSpeedTBox
            // 
            this.stepSpeedTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepSpeedTBox.Location = new System.Drawing.Point(112, 146);
            this.stepSpeedTBox.Name = "stepSpeedTBox";
            this.stepSpeedTBox.Size = new System.Drawing.Size(131, 23);
            this.stepSpeedTBox.TabIndex = 1;
            // 
            // stepModeIdLabel
            // 
            this.stepModeIdLabel.AutoSize = true;
            this.stepModeIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepModeIdLabel.Location = new System.Drawing.Point(26, 62);
            this.stepModeIdLabel.Name = "stepModeIdLabel";
            this.stepModeIdLabel.Size = new System.Drawing.Size(54, 17);
            this.stepModeIdLabel.TabIndex = 0;
            this.stepModeIdLabel.Text = "ModeId";
            // 
            // StepTypeLabel
            // 
            this.StepTypeLabel.AutoSize = true;
            this.StepTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StepTypeLabel.Location = new System.Drawing.Point(26, 178);
            this.StepTypeLabel.Name = "StepTypeLabel";
            this.StepTypeLabel.Size = new System.Drawing.Size(40, 17);
            this.StepTypeLabel.TabIndex = 0;
            this.StepTypeLabel.Text = "Type";
            // 
            // stepModeIdTbox
            // 
            this.stepModeIdTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepModeIdTbox.Location = new System.Drawing.Point(112, 59);
            this.stepModeIdTbox.Name = "stepModeIdTbox";
            this.stepModeIdTbox.Size = new System.Drawing.Size(131, 23);
            this.stepModeIdTbox.TabIndex = 1;
            // 
            // stepTimerLabel
            // 
            this.stepTimerLabel.AutoSize = true;
            this.stepTimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepTimerLabel.Location = new System.Drawing.Point(26, 91);
            this.stepTimerLabel.Name = "stepTimerLabel";
            this.stepTimerLabel.Size = new System.Drawing.Size(44, 17);
            this.stepTimerLabel.TabIndex = 0;
            this.stepTimerLabel.Text = "Timer";
            // 
            // stepVolumeLabel
            // 
            this.stepVolumeLabel.AutoSize = true;
            this.stepVolumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepVolumeLabel.Location = new System.Drawing.Point(26, 207);
            this.stepVolumeLabel.Name = "stepVolumeLabel";
            this.stepVolumeLabel.Size = new System.Drawing.Size(55, 17);
            this.stepVolumeLabel.TabIndex = 0;
            this.stepVolumeLabel.Text = "Volume";
            // 
            // stepIdTBox
            // 
            this.stepIdTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepIdTBox.Location = new System.Drawing.Point(112, 31);
            this.stepIdTBox.Name = "stepIdTBox";
            this.stepIdTBox.Size = new System.Drawing.Size(131, 23);
            this.stepIdTBox.TabIndex = 1;
            // 
            // stepDestinationLabel
            // 
            this.stepDestinationLabel.AutoSize = true;
            this.stepDestinationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepDestinationLabel.Location = new System.Drawing.Point(26, 120);
            this.stepDestinationLabel.Name = "stepDestinationLabel";
            this.stepDestinationLabel.Size = new System.Drawing.Size(79, 17);
            this.stepDestinationLabel.TabIndex = 0;
            this.stepDestinationLabel.Text = "Destination";
            // 
            // modesGridView
            // 
            this.modesGridView.BackgroundColor = System.Drawing.Color.White;
            this.modesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modesGridView.Location = new System.Drawing.Point(385, 34);
            this.modesGridView.Name = "modesGridView";
            this.modesGridView.Size = new System.Drawing.Size(527, 233);
            this.modesGridView.TabIndex = 2;
            // 
            // stepsGridView
            // 
            this.stepsGridView.BackgroundColor = System.Drawing.Color.White;
            this.stepsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stepsGridView.Location = new System.Drawing.Point(385, 276);
            this.stepsGridView.Name = "stepsGridView";
            this.stepsGridView.Size = new System.Drawing.Size(527, 307);
            this.stepsGridView.TabIndex = 3;
            // 
            // excelButton
            // 
            this.excelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.excelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.excelButton.Location = new System.Drawing.Point(66, 4);
            this.excelButton.Name = "excelButton";
            this.excelButton.Size = new System.Drawing.Size(279, 30);
            this.excelButton.TabIndex = 4;
            this.excelButton.Text = "Open EXCEL file";
            this.excelButton.UseVisualStyleBackColor = false;
            this.excelButton.Click += new System.EventHandler(this.excelButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 595);
            this.Controls.Add(this.excelButton);
            this.Controls.Add(this.stepsGridView);
            this.Controls.Add(this.modesGridView);
            this.Controls.Add(this.stepsGroupBox);
            this.Controls.Add(this.modesGroupBox);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.modesGroupBox.ResumeLayout(false);
            this.modesGroupBox.PerformLayout();
            this.stepsGroupBox.ResumeLayout(false);
            this.stepsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox modesGroupBox;
        private System.Windows.Forms.GroupBox stepsGroupBox;
        private System.Windows.Forms.DataGridView modesGridView;
        private System.Windows.Forms.DataGridView stepsGridView;
        private System.Windows.Forms.TextBox modeTipsTBox;
        private System.Windows.Forms.TextBox modeBottleTBox;
        private System.Windows.Forms.TextBox modeNameTBox;
        private System.Windows.Forms.TextBox modeIdTBox;
        private System.Windows.Forms.Label modeTipsLabel;
        private System.Windows.Forms.Label modeBottleLabel;
        private System.Windows.Forms.Label modeNameLabel;
        private System.Windows.Forms.Label modeIdLabel;
        private System.Windows.Forms.TextBox stepVolumeTBox;
        private System.Windows.Forms.TextBox stepDestinationTBox;
        private System.Windows.Forms.Label stepId;
        private System.Windows.Forms.TextBox stepTypeTBox;
        private System.Windows.Forms.TextBox stepTimerTBox;
        private System.Windows.Forms.Label StepSpeedLabel;
        private System.Windows.Forms.TextBox stepSpeedTBox;
        private System.Windows.Forms.Label stepModeIdLabel;
        private System.Windows.Forms.Label StepTypeLabel;
        private System.Windows.Forms.TextBox stepModeIdTbox;
        private System.Windows.Forms.Label stepTimerLabel;
        private System.Windows.Forms.Label stepVolumeLabel;
        private System.Windows.Forms.TextBox stepIdTBox;
        private System.Windows.Forms.Label stepDestinationLabel;
        private System.Windows.Forms.Button modeSaveButton;
        private System.Windows.Forms.Button modeDeleteButton;
        private System.Windows.Forms.Button modeAddButton;
        private System.Windows.Forms.Button excelButton;
        private System.Windows.Forms.Button stepAddButton;
        private System.Windows.Forms.Button stepResetButton;
        private System.Windows.Forms.Button stepSaveButton;
        private System.Windows.Forms.Button stepDeleteButton;
        private System.Windows.Forms.Button modeResetButton;
    }
}