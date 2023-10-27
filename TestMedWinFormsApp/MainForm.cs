using ExcelDataReader;
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using TestMedWinFormsApp.DB;
using TestMedWinFormsApp.DB.Interfaces;
using TestMedWinFormsApp.Entities;

namespace TestMedWinFormsApp
{
    public partial class MainForm : Form
    {
        private static BindingSource bindingSrc;
        private readonly IStepsRepository _stepsRepository;
        private readonly IModesRepository _modesRepository;

        public MainForm()
        {
            InitializeComponent();
            this.modeIdTBox.Enabled = false;
            this.stepIdTBox.Enabled = false;
            _stepsRepository = new StepsRepository();
            _modesRepository = new ModesRepository();
        }

        public MainForm(IStepsRepository stepsRepository, IModesRepository modesRepository)
        {
            InitializeComponent();
            this.modeIdTBox.Enabled = false;
            this.stepIdTBox.Enabled = false;
            _stepsRepository = stepsRepository;
            _modesRepository = modesRepository;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection(DBInfo.ConnectionString))
            {
                connection.Open();
                updateModesDataBinding();
                updateStepsDataBinding();
            }
        }

        private void updateModesDataBinding()
        {
            try
            {
                TextBox tb;

                foreach(Control c in modesGroupBox.Controls)
                {
                    if(c.GetType() == typeof(TextBox))
                    {
                        tb = (TextBox)c;
                        tb.DataBindings.Clear();
                        tb.Text = "";
                    }
                }
                
                bindingSrc = new BindingSource();
                bindingSrc.DataSource = _modesRepository.GetFullTable();
                
                //data binding
                modeIdTBox.DataBindings.Add("Text", bindingSrc, "Id");
                modeNameTBox.DataBindings.Add("Text", bindingSrc, "Name");
                modeBottleTBox.DataBindings.Add("Text", bindingSrc, "MaxBottleNumber");
                modeTipsTBox.DataBindings.Add("Text", bindingSrc, "MaxUsedTips");

                modesGridView.Enabled = true;
                modesGridView.DataSource = bindingSrc;

                modesGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                modesGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Modes data binding error: " + ex.Message, "Binding error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void updateStepsDataBinding()
        {
            try
            {
                TextBox tb;

                foreach (Control c in stepsGroupBox.Controls)
                {
                    if (c.GetType() == typeof(TextBox))
                    {
                        tb = (TextBox)c;
                        tb.DataBindings.Clear();
                        tb.Text = "";
                    }
                }
                
                bindingSrc = new BindingSource();
                bindingSrc.DataSource = _stepsRepository.GetFullTable();

                //data binding
                stepIdTBox.DataBindings.Add("Text", bindingSrc, "Id");
                stepModeIdTbox.DataBindings.Add("Text", bindingSrc, "ModeId"); 
                stepTimerTBox.DataBindings.Add("Text", bindingSrc, "Timer");
                stepDestinationTBox.DataBindings.Add("Text", bindingSrc, "Destination");
                stepSpeedTBox.DataBindings.Add("Text", bindingSrc, "Speed");
                stepTypeTBox.DataBindings.Add("Text", bindingSrc, "Type");
                stepVolumeTBox.DataBindings.Add("Text", bindingSrc, "Volume");

                stepsGridView.Enabled = true;
                stepsGridView.DataSource = bindingSrc;

                stepsGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                stepsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Steps data binding error: " + ex.Message, "Binding error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modeAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(modeNameTBox.Text)||
                    string.IsNullOrEmpty(modeBottleTBox.Text)||
                    string.IsNullOrEmpty(modeTipsTBox.Text))
                {
                    MessageBox.Show("Please fill all the required fields.", "Add new record warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmResult = MessageBox.Show("Are you sure to add this item? (Id will be set automatically) \nDid you save all changes? Pressing 'Ok' will cancel all unsaved changes!",
                                     "Confirm Adding",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    Mode newMode = new Mode()
                    {
                        Name = modeNameTBox.Text,
                        MaxBottleNumber = int.Parse(modeBottleTBox.Text),
                        MaxUsedTips = int.Parse(modeTipsTBox.Text)
                    };

                    _modesRepository.AddMode(newMode);
                    updateModesDataBinding();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. " + ex.Message, "Adding error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modeDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this item ?? \nDid you save all changes? Pressing 'Ok' will cancel all unsaved changes!",
                                     "Confirm Deleting",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    _modesRepository.DeleteModeById(int.Parse(modeIdTBox.Text));
                    updateModesDataBinding();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. " + ex.Message, "Deleting error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modeSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Are you sure to save all the changes?",
                                     "Confirm Saving",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    for (int i = 0; i < modesGridView.RowCount - 1; i++)
                    {
                        Mode newMode = new Mode()
                        {
                            Id = int.Parse(modesGridView.Rows[i].Cells[0].Value.ToString()),
                            Name = modesGridView.Rows[i].Cells[1].Value.ToString(),
                            MaxBottleNumber = int.Parse(modesGridView.Rows[i].Cells[2].Value.ToString()),
                            MaxUsedTips = int.Parse(modesGridView.Rows[i].Cells[3].Value.ToString())
                        };

                        _modesRepository.UpdateMode(newMode);
                        updateModesDataBinding();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. " + ex.Message, "Saving error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modeResetButton_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Are you sure to reset all the changes?",
                                     "Confirm Reseting",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    updateModesDataBinding();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. " + ex.Message, "Reseting error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void excelButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog() { Filter = "Excel workbook|*.xlsx|Excel 97-2003 Workbook|*.xls" })
            {
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    using (var stream = File.Open(dialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet ds = reader.AsDataSet(new ExcelDataSetConfiguration());
                            DataTableCollection tableCollection = ds.Tables;
                            
                            if (tableCollection.Contains("Modes"))
                            {
                                var table = tableCollection["Modes"];
                                for (int i = 1; i < table.Rows.Count; i++)
                                {
                                    try
                                    {
                                        Mode newMode = new Mode()
                                        {
                                            Name = table.Rows[i][1].ToString(),
                                            MaxBottleNumber = int.Parse(table.Rows[i][2].ToString()),
                                            MaxUsedTips = int.Parse(table.Rows[i][3].ToString())
                                        };

                                        _modesRepository.AddMode(newMode);
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Something went wrong. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }

                            updateModesDataBinding();

                            if (tableCollection.Contains("Steps"))
                            {
                                var table = tableCollection["Steps"];
                                for (int i = 1; i < table.Rows.Count; i++)
                                {
                                    try
                                    {
                                        Step newStep = new Step()
                                        {
                                            ModeId = int.Parse(table.Rows[i][1].ToString()),
                                            Timer = int.Parse(table.Rows[i][2].ToString()),
                                            Destination = table.Rows[i][3].ToString(),
                                            Speed = int.Parse(table.Rows[i][4].ToString()),
                                            Type = table.Rows[i][5].ToString(),
                                            Volume = int.Parse(table.Rows[i][6].ToString()),
                                        };

                                        _stepsRepository.AddStep(newStep);

                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Something went wrong. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }

                            updateStepsDataBinding();
                        }
                    }
                }
            }
        }

        private void stepAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(stepModeIdTbox.Text) ||
                    string.IsNullOrEmpty(stepTimerTBox.Text) ||
                    //string.IsNullOrEmpty(stepDestinationTBox.Text) ||
                    string.IsNullOrEmpty(stepSpeedTBox.Text) ||
                    string.IsNullOrEmpty(stepTypeTBox.Text) ||
                    string.IsNullOrEmpty(stepVolumeTBox.Text))
                {
                    MessageBox.Show("Please fill all the required fields.", "Add new record warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmResult = MessageBox.Show("Are you sure to add this item? (Id will be set automatically) \nDid you save all changes? Pressing 'Ok' will cancel all unsaved changes!",
                                     "Confirm Adding",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    Step newStep = new Step()
                    {
                        ModeId = int.Parse(stepModeIdTbox.Text),
                        Timer = int.Parse(stepTimerTBox.Text), 
                        Destination = stepDestinationTBox.Text,
                        Speed = int.Parse(stepSpeedTBox.Text), 
                        Type = stepTypeTBox.Text, 
                        Volume = int.Parse(stepVolumeTBox.Text)
                    };

                    _stepsRepository.AddStep(newStep);
                    
                    updateStepsDataBinding();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. " + ex.Message, "Adding error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stepDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this item? \nDid you save all changes? Pressing 'Ok' will cancel all unsaved changes!",
                                     "Confirm Deleting",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    _stepsRepository.DeleteStepById(int.Parse(stepIdTBox.Text));
                    updateStepsDataBinding();                    
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. " + ex.Message, "Deleting error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stepSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Are you sure to save all the changes?",
                                     "Confirm Saving",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    for (int i = 0; i < stepsGridView.RowCount - 1; i++)
                    {
                        Step newStep = new Step()
                        {
                            Id = int.Parse(stepsGridView.Rows[i].Cells[0].Value.ToString()),
                            ModeId = int.Parse(stepsGridView.Rows[i].Cells[1].Value.ToString()),
                            Timer = int.Parse(stepsGridView.Rows[i].Cells[2].Value.ToString()),
                            Destination = stepsGridView.Rows[i].Cells[3].Value.ToString(),
                            Speed = int.Parse(stepsGridView.Rows[i].Cells[4].Value.ToString()),
                            Type = stepsGridView.Rows[i].Cells[5].Value.ToString(),
                            Volume = int.Parse(stepsGridView.Rows[i].Cells[6].Value.ToString()),
                        };

                        _stepsRepository.UpdateStep(newStep);
                    }

                    updateStepsDataBinding();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. " + ex.Message, "Saving error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stepResetButton_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Are you sure to reset all the changes?",
                                     "Confirm Reseting",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    updateStepsDataBinding();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. " + ex.Message, "Reseting error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
