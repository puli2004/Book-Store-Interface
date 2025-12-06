using Book_Store_Interface.Repository;
using BookStoreApp;
using System;
using System.IO;
using System.Windows.Forms;

namespace Book_Store_Interface
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();

            // Apply consistent button style after Designer initialization
            StyleButton(btnGenerateReport);
            StyleButton(btnGoBack);
        }

        private void StyleButton(Button btn)
        {
            btn.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            btn.ForeColor = System.Drawing.Color.Black;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 120, 215);
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(200, 200, 200);
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            DateTime start = dtpStartDate.Value.Date;
            DateTime end = dtpEndDate.Value.Date;

            var repository = new SalesRepository();
            var results = repository.GetSalesReport(start, end);

            SaveFileDialog dlg = new SaveFileDialog
            {
                Filter = "Text File|*.txt",
                FileName = "SalesReport.txt"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(dlg.FileName))
                {
                    sw.WriteLine("SALES REPORT");
                    sw.WriteLine($"From {start:d} to {end:d}");
                    sw.WriteLine("=======================================");
                    sw.WriteLine();

                    foreach (var item in results)
                    {
                        sw.WriteLine(
                            $"Ord#: {item.OrdNum} | TitleID: {item.TitleId} | Title: {item.Title} | Qty: {item.Qty} | OrdDate: {item.OrdDate:d} | Total: ${item.TotalValue:F2}"
                        );
                    }
                }

                MessageBox.Show("Report created successfully!");
            }

            // Write to TextBox for demo
            txtReportList.Clear();
            txtReportList.AppendText($"SALES REPORT{Environment.NewLine}From {start:d} to {end:d}{Environment.NewLine}======================================={Environment.NewLine}");
            foreach (var item in results)
            {
                txtReportList.AppendText(
                    $"Ord#: {item.OrdNum} | {Environment.NewLine}" +
                    $"TitleID: {item.TitleId} | {Environment.NewLine}" +
                    $"Title: {item.Title} | {Environment.NewLine}" +
                    $"Qty: {item.Qty} | {Environment.NewLine}" +
                    $"OrdDate: {item.OrdDate:d} | {Environment.NewLine}" +
                    $"Total: ${item.TotalValue:F2}{Environment.NewLine}"
                );
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Hide();
        }
    }
}
