using MalariaPredication;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace malaria
{
    public partial class Form2 : Form
    {

        static string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\malaria.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con;
        SqlCommand cmd;






        public Form2()
        {

            InitializeComponent();
            con = new SqlConnection(str);





        }

        void PredictMalaria()
        {


            // حساب النسبة المئوية للتنبؤ بالملاريا

            var sampleData = new MLModel1.ModelInput()
            {
                Id = 2F,
                Fever = @Fever.Text,
                Headache = @Headache.Text,
                Fatigue = @Fatigue.Text,
                MusclePain = @MusclePain.Text,
                Nausea_Vomiting = @Nausea_vomit.Text,
                Diarrhea = @Diarrhea.Text,
                Seizures = @Seizures.Text,
                City = @City.Text,
            };

            var result = MLModel1.Predict(sampleData);
            Int32 prec = (int)(result.Score * 100);

            MessageBox.Show("احتمال اصابتك بالملاريا هو :" + prec.ToString() + "%");
        }




        private void Form2_Load(object sender, EventArgs e)
        {



        }








        public void invisible()
        {

        }

        public void button1_Click_1(object sender, EventArgs e)
        {


            PredictMalaria();
            foreach (Control c in this.Controls)
            {
                c.Visible = false;
            }
            labResult.Visible = true;
            addData.Visible = true;

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        public void seizures_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (labResult.Text == "مصاب")
            {

            }
            else if (labResult.Text == "غير مصاب")
            {

            }
        }
    }
}




