using Lesson5;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Animal> animals = new List<Animal>();
        Field field = new Field(15, 15);
        public Form1()
        {
            InitializeComponent();
           
            

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Wolf w = new Wolf(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            animals.Add(w);
            field.Space[w.X, w.Y] = 'w';
        }
    }
}