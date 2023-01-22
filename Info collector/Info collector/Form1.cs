namespace Info_collector
{
    public partial class Form1 : Form
    {
        List<Student> student = new List<Student>();
        List<double> grade = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            String name = this.name_box.Text;
            String id = this.id_box.Text;
            String by = this.birth_box.Text;
            String height = this.high_box.Text;
            String grade = this.grade_box.Text;
            String degree = this.degree_box.Text;

            int ib = Int32.Parse(by);
            double ih = double.Parse(height);
            double ig = double.Parse(grade);

            Student newStudent = new Student(name, id, ib, ih, ig, degree);
            this.student.Add(newStudent);
            this.grade.Add(ig);

            this.name_box.Text = "";
            this.id_box.Text = "";
            this.birth_box.Text = "";
            this.high_box.Text = "";
            this.degree_box.Text = "";

            BindingSource source = new BindingSource();
            source.DataSource = this.student;
            this.monitor.DataSource = source;

        }

        private void collect_bot_Click(object sender, EventArgs e)
        {
            Int32 length = student.Count;
            double max_grade = grade.Max();
            double min_grade = grade.Min();

            amount.Text = length.ToString();
            maxg.Text = max_grade.ToString();
            ming.Text = min_grade.ToString();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}