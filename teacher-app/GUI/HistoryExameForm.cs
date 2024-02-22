using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class HistoryExameForm : Form
    {
        private string testID { get; set; }
        private HistoryExameBUS historyExameBUS { get; set; }
        public HistoryExameForm(string testId)
        {
            this.testID = testId;
            historyExameBUS = new HistoryExameBUS();
            InitializeComponent();
            CenterForm.ToForm(this);
            _loadingData();
        }
        private void _loadingData()
        {
            List<Record> records = historyExameBUS.GetRecords(testID);
            int sd = 0;
            dataGridView1.Rows.Clear();
            foreach (Record record in records)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[sd].Cells[0].Value = record.ExamineeID;
                dataGridView1.Rows[sd].Cells[1].Value = record.TestID;
                dataGridView1.Rows[sd].Cells[2].Value = record.Score;
                dataGridView1.Rows[sd].Cells[3].Value = record.SubmittedTime;
                sd++;
            }
        }
    }
}
