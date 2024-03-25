using System;
using System.Collections;
using System.Windows.Forms;
using System.IO;

using ExcelDataReader;

using Tekla.Structures.Model;
using Tekla.Structures.Model.Operations;
using Tekla.Structures.Model.UI;


namespace SmartBoltAdjuster
{
    public partial class MainForm : Form
    {
       Model model = new Model();


        public MainForm()
        {
            InitializeComponent();


            try
            {


                if (model.GetConnectionStatus())
                {
                    string connectedMessage = "Smart Bolt Adjuster is now connected to Tekla Structures!";


                    var modelName = model.GetInfo().ModelName;
                    string modelNameMessage = $"Current Model Name: {modelName}";

                    Operation.DisplayPrompt(connectedMessage);
                }
                else
                {
                    MessageBox.Show("Could not connect to Tekla Structures.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {


            Operation.DisplayPrompt("Thanks for using Smart Bolt Adjuster. Goodbye until next time!");
            this.Dispose();

        }

        private void open_excel_file_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xls;*.xlsx;*.xlsm",
                Title = "Select an Excel file",
                CheckFileExists = true,
                CheckPathExists = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileExtension = Path.GetExtension(filePath);

                if (fileExtension == ".xls" || fileExtension == ".xlsx" || fileExtension == ".xlsm")
                {
                    ReadExcelFile(filePath);
                }
                else
                {
                    MessageBox.Show("Invalid file format. Please select an Excel file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ReadExcelFile(string filePath)
        {
            try
            {
                using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        var result = reader.AsDataSet();

                        if (result != null && result.Tables.Count > 0)
                        {

                            result.Tables[0].Columns[0].ColumnName = "Bolt Diameter";
                            result.Tables[0].Columns[1].ColumnName = "Extra Length";

                            dataGridView.DataSource = result.Tables[0];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to read the Excel file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void apply_btn_Click(object sender, EventArgs e)
        {
            ApplyExtraLengthToBolts();
        }

        private void pickerBolts_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            GetSelectedBolts();
        }

        private void allBoltsSelected_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            GetAllBolts();
        }


        private ArrayList GetSelectedBolts()
        {
            Picker picker = new Picker();
            ArrayList boltList = new ArrayList();

            try
            {
                ModelObjectEnumerator moe = picker.PickObjects(Picker.PickObjectsEnum.PICK_N_BOLTGROUPS, "Could you pick out some bolts?");

                while (moe.MoveNext())
                {
                    BoltGroup bolt = moe.Current as BoltGroup;
                    if (bolt != null)
                    {
                        boltList.Add(bolt);
                    }
                }
            }
            catch (System.ApplicationException ex)
            {
                Console.WriteLine("Error occurred during picking bolts: " + ex.Message);
            }

            return boltList;
        }


        private ArrayList GetAllBolts()
        {
            ArrayList boltList = new ArrayList();
            ModelObjectEnumerator moe = model.GetModelObjectSelector().GetAllObjects();

            while (moe.MoveNext())
            {
                if (moe.Current is BoltGroup bolt)
                {
                    boltList.Add(bolt);
                }
            }

            return boltList;
        }


        private void ApplyExtraLengthToBolts()
        {

            if (pickerBolts_rbtn.Checked)
            {
                ArrayList boltList = GetSelectedBolts();
                ApplyExtraLength(boltList);
            }
            else if (allBoltsSelected_rbtn.Checked)
            {
                ArrayList boltList = GetAllBolts();
                ApplyExtraLength(boltList);
            }



        }

        private void ApplyExtraLength(ArrayList boltList)
        {

            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Please open an Excel file to apply the extra length to the bolts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (boltList.Count > 0)
            {
                Tekla.Structures.Model.UI.ModelObjectSelector mos = new Tekla.Structures.Model.UI.ModelObjectSelector();
                mos.Select(boltList);
                Console.WriteLine($"Selected {boltList.Count} bolts in the model.");
            }
            else
            {
                Console.WriteLine("No bolts found in the model.");
            }

            foreach (BoltGroup bolt in boltList)
            {


                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {


                    if (dataGridView.Rows[i].Cells[0].Value != null && dataGridView.Rows[i].Cells[0].Value.ToString() == bolt.BoltSize.ToString())
                    {
                        bolt.ExtraLength = Convert.ToDouble(dataGridView.Rows[i].Cells[1].Value);
                        bolt.Modify();
                    }
                }


            }

            model.CommitChanges();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "http://www.kamel-essridi.com",
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(psi);
        }

        private void userGuide_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            HelpForm helpForm = new HelpForm();
            helpForm.Show();



        }
    }
}