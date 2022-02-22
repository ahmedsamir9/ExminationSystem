using BL;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System.InstructorForms
{
    public partial class AddQuestion : MaterialForm
    {
        public AddQuestion()
        {
            InitializeComponent();
            InitForm();
            FormClosed += (seneder, e) => Process.GetCurrentProcess().Kill();
            ;
        }

        private void InitForm()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        QuestionList qlist;
        QuestionList qlistTF;
        BindingSource source;
        BindingSource sourceTF;

        public int CID { get; set; }

        private void AddQuestion_Load(object sender, EventArgs e)
        {
            qlist = QuestionManger.selectAllQuestionsOfCourse(CID);
            source = new BindingSource();
            source.DataSource = qlist;

            qlistTF = QuestionManger.selectAllTFQuestionsOfCourse(CID);
            sourceTF = new BindingSource();
            sourceTF.DataSource = qlistTF;

            dataGridView1.DataSource = source;
            dataGridView1.ForeColor = Color.Black;
            dataGridView1.Columns["EntityState"].Visible = false;
            dataGridView1.Columns["Type"].ReadOnly = true;

            dataGridView2.DataSource = sourceTF;
            dataGridView2.ForeColor = Color.Black;
            dataGridView2.Columns["EntityState"].Visible = false;
            dataGridView2.Columns["Choice1"].Visible = false;
            dataGridView2.Columns["Choice2"].Visible = false;
            dataGridView2.Columns["Choice3"].Visible = false;
            dataGridView2.Columns["Choice4"].Visible = false;
            dataGridView2.Columns["Type"].ReadOnly = true;

            source.AddingNew += Source_AddingNew;
            sourceTF.AddingNew += SourceTF_AddingNew;
            ;
        }

        private void SourceTF_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new Question()
            {
                QID = -1,
                QName = "NA",
                Ans = '?',
                Type = "TF",
                EntityState = EntityState.Added
            };
        }

        private void Source_AddingNew(object sender, System.ComponentModel.AddingNewEventArgs e)
        {
            e.NewObject = new Question()
            {
                QID = -1,
                QName = "NA",
                Ans = '?',
                Choice1 = "NA",
                Choice2 = "NA",
                Choice3 = "NA",
                Choice4 = "NA",
                Type = "MCQ",
                EntityState = EntityState.Added
            };
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int cid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void materialLabel1_Click(object sender, EventArgs e) { }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            saveMcqQestions();
            saveTFQestions();
        }

        private void saveMcqQestions()
        {
            for (int i = 0; i < source.Count; i++)
            {
                if (qlist[i].EntityState == EntityState.Modified)
                {
                    QuestionManger.UpdateQuestion(qlist[i]);
                }
                else if (qlist[i].EntityState == EntityState.Added)
                {
                    QuestionManger.InsertIntoQuestion(qlist[i], CID);
                }

                qlist[i].EntityState = EntityState.Unchanged;
            }
        }

        private void saveTFQestions()
        {
            for (int i = 0; i < sourceTF.Count; i++)
            {
                if (qlistTF[i].EntityState == EntityState.Modified)
                {
                    QuestionManger.UpdateQuestionGeneric(qlistTF[i]);
                }
                else if (qlistTF[i].EntityState == EntityState.Added)
                {
                    QuestionManger.InsertIntoQuestion(qlistTF[i], CID);
                }

                qlistTF[i].EntityState = EntityState.Unchanged;
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            new CouresFrom().Show();
            Hide();
        }
    }
}
