using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace baiktraso2
{
    public partial class frmPatientProfiles : Form
    {
        public frmPatientProfiles()
        {
            InitializeComponent();
        }

        private void frmPatientProfiles_Load(object sender, EventArgs e)
        {
            List<PatientModel> patients = new List<PatientModel>
            {
                new PatientModel { PatientId = "BN001", FullName = "Nguyễn Văn A", Gender = "Nam", BirthYear = 1985, Diagnosis = "Viêm ruột thừa", Room = "P.301" },
                new PatientModel { PatientId = "BN002", FullName = "Trần Thị B", Gender = "Nữ", BirthYear = 1992, Diagnosis = "Sốt xuất huyết", Room = "P.205" },
                new PatientModel { PatientId = "BN003", FullName = "Lê Hoàng C", Gender = "Nam", BirthYear = 1978, Diagnosis = "Tăng huyết áp", Room = "P.102" }
            };

            dgvPatients.DataSource = patients;
            dgvPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPatients.ReadOnly = true;
        }
    }
}