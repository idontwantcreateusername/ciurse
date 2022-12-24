using Orcoids;

namespace tester_2
{
    public partial class Form1 : Form
    {
        private Orcoid[] Wagh = new Orcoid[12];
        
       
        private int change = 0;
        
        public Form1()
        {
            
            for(int i = 0;i< Wagh.Length;i++)
            {
                Wagh[i] = new Orcoid();
            }


            InitializeComponent();
            panel4.Hide();
            panel5.Hide();
           
            panel7.Hide();
            panel6.Hide();
            panel8.Hide();
            panel9.Hide();
            panel10.Hide();
            panel11.Hide();
            panel12.Hide();
            progressBar1.Maximum = 100;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnorc(int i)
        {
            change = i;
            
            progressBar1.Value = Wagh[change].HP_Status();
            label17.Text = Wagh[i].Name_yourself();
            
            close();
           
            switch (Wagh[i].getclass())
            {
                
                case "orc":
                   panel5.Show();
                    
                    
                    label18.Text = "îðê";
                    panel8.Show();
                    
                    pictureBox2.BackgroundImage = button38.BackgroundImage;
                    break;
                case "mech":
                   panel5.Show();
                    panel9.Show();
                    string[] e = Wagh[i].getdata().Split("_");
                    label31.Text = $"ÐÎÑÒ:{e[0]}";
                    label30.Text = $"ÌÀÑÑÀ:{e[1]}";
                    label29.Text = $"ÆÓÁÛ: {e[2]}";
                    label28.Text = $"ÏÓØÊÀ: {e[3]}";
                    label27.Text = $"Îïèñàíèå: {e[4]}";
                    label32.Text = $"ÌÅÒÀËË: {e[5]}";
                    label18.Text = "ìåê";
                    pictureBox2.BackgroundImage = button39.BackgroundImage;
                    break;
                case "doc":
                   panel5.Show();
                    panel10.Show();
                    
                    label18.Text = "äîê";
                    pictureBox2.BackgroundImage = button40.BackgroundImage;
                    break;
                case "weird":
                    panel5.Show();
                    panel11.Show();
                    
                    label18.Text = "÷óäèëà";
                    string[] e1 = Wagh[i].getdata().Split("_");
                    label44.Text = $"ÐÎÑÒ:{e1[0]}";
                    label43.Text = $"ÌÀÑÑÀ:{e1[1]}";
                    label42.Text = $"ÆÓÁÛ: {e1[2]}";
                    label41.Text = $"ÏÓØÊÀ: {e1[3]}";
                    label40.Text = $"Îïèñàíèå: {e1[4]}";
                    label39.Text = $"ÐÀÑÑÓÄÎÊ: {e1[5]}";
                    pictureBox2.BackgroundImage = button41.BackgroundImage;
                    break;
                case "pilot":
                   panel5.Show();
                    panel12.Show();
                    string[] w = Wagh[i].getdata().Split("_");
                    label50.Text = $"ÐÎÑÒ:{w[0]}";
                    label49.Text = $"ÌÀÑÑÀ:{w[1]}";
                    label48.Text = $"ÆÓÁÛ: {w[2]}";
                    label47.Text = $"ÏÓØÊÀ: {w[3]}";
                    label46.Text = $"Îïèñàíèå: {w[4]}";
                    label45.Text = $"ÒÎÏËÈÂÎ: {w[5]} / {w[6]}";

                    label18.Text = "øòîðìáîé";
                    pictureBox2.BackgroundImage = button42.BackgroundImage;
                    break;
                case "snotling":
                    panel5.Show();
                   panel6.Show();
                    label18.Text = "ãðåò÷èí";
                    pictureBox2.BackgroundImage = button44.BackgroundImage;
                    break;
                case "grot":
                    panel5.Show();
                    panel7.Show();
                    
                    label18.Text = "áîåâîé ãðåò÷èí";
                    label19.Text = Wagh[i].Name_yourself();
                    pictureBox2.BackgroundImage = button43.BackgroundImage;
                    string[] q = Wagh[i].getdata().Split(" ");
                    label19.Text = $"ÐÎÑÒ:{q[0]}";
                    label20.Text = $"ÌÀÑÑÀ:{q[1]}";
                    if (q[2] == "False")
                    {
                        label21.Text = "ÌÎÐÀËÜ: ÂÛÑÎÊÀß" ;
                    }
                    else
                    {
                        label21.Text = "ÌÎÐÀËÜ: ÍÀÏÓÃÀÍ";
                    }
                    break;
                default:
                    
                    panel4.Show();
                    panel4.Enabled = true;
                    break;
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    private void choosebtn(int i, Image q)
        {
            switch(i)
            {
                case 0:
                    button26.BackgroundImage = q; break;
                case 1:
                    button27.BackgroundImage = q; break;
                case 2:
                    button28.BackgroundImage = q; break;
                case 3:
                    button29.BackgroundImage = q; break;
                case 4:
                    button30.BackgroundImage = q; break;
                case 5:
                    button31.BackgroundImage = q; break;
                case 6:
                    button32.BackgroundImage = q; break;
                case 7:
                    button33.BackgroundImage = q; break;
                case 8:
                    button34.BackgroundImage = q; break;
                case 9:
                    button35.BackgroundImage = q; break;
                case 10:
                    button36.BackgroundImage = q; break;
                case 11:
                    button37.BackgroundImage = q; break;
            }
        }

    private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button48_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }



        

        private void close()
        {
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            panel8.Hide();
            panel9.Hide();
            panel10.Hide();
            panel11.Hide();
            panel12.Hide();
        }
        private void button68_Click(object sender, EventArgs e)
        {
            close();

        }

        private void button26_Click(object sender, EventArgs e)
        {
            btnorc(0);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            btnorc(1);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            btnorc(2);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            btnorc(3);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            btnorc(4);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            btnorc(5);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            btnorc(6);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            btnorc(7);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            btnorc(8);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            btnorc(9);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            btnorc(10);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            btnorc(11);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Wagh[change] = new Orc();
            panel4.Hide();
            choosebtn(change, button38.BackgroundImage);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Wagh[change] = new Mech();
            panel4.Hide();
            choosebtn(change, button39.BackgroundImage);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Wagh[change] = new Doc();
            panel4.Hide();
            choosebtn(change, button40.BackgroundImage);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Wagh[change] = new Weirdboy();
            panel4.Hide();
            choosebtn(change, button41.BackgroundImage);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Wagh[change] = new Pilot();
            panel4.Hide();
            choosebtn(change, button42.BackgroundImage);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Wagh[change] = new Grot();
            panel4.Hide();
            choosebtn(change, button43.BackgroundImage);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Wagh[change] = new Snotling();
            panel4.Hide();
            choosebtn(change, button44.BackgroundImage);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void label47_Click(object sender, EventArgs e)
        {

        }
    }
}