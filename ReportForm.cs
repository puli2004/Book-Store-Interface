using Book_Store_Interface.Repository;
using BookStoreApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Store_Interface
{
    public partial class ReportForm : Form
    {

        public ReportForm()
        {
            InitializeComponent();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {

            DateTime start = dtpStartDate.Value.Date;
            DateTime end = dtpEndDate.Value.Date;

            var repository = new SalesRepository();
            var results = repository.GetSalesReport(start, end);

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Text File|*.txt";
            dlg.FileName = "SalesReport.txt";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(dlg.FileName))
                {
                    sw.WriteLine("SALES REPORT");
                    sw.WriteLine($"From {start} to {end}");
                    sw.WriteLine("=======================================");
                    sw.WriteLine();

                    foreach (var item in results)
                    {
                        sw.WriteLine(
                            $"Ord#: {item.OrdNum} | " +
                            $"TitleID: {item.TitleId} | " +
                            $"Title: {item.Title} | " +
                            $"Qty: {item.Qty} | " +
                            $"OrdDate: {item.OrdDate:d} | " +
                            $"Total: ${item.TotalValue:F2}"
                        );
                    }
                }

                MessageBox.Show("Report created successfully!");
            }

        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Hide();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
