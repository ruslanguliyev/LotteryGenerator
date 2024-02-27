namespace TestWF
{
    public partial class Form1 : Form
    {
        //private Control[] initialControls;
        //private Form2 form2Instance;
        //private Form3 form3Instance;



        public Form1()
        {
            InitializeComponent();
            //initialControls = pnlHome.Controls.Cast<Control>().ToArray();

        }



        private void LoadForm(object Form)
        {
            if (this.pnlHome.Controls.Count > 0)
                this.pnlHome.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlHome.Controls.Add(f);
            this.pnlHome.Tag = f;
            f.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadForm(new Form2());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadForm(new Form3());
        }



        //private void RestoreInitialLayout()
        //{
        //    pnlHome.Controls.AddRange(initialControls); // ƒобавл€ем обратно элементы начального состо€ни€
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (form2Instance == null || form2Instance.IsDisposed)
        //    {

        //        form2Instance = new Form2();
        //        form2Instance.FormClosed += (s, args) => { RestoreInitialLayout(); }; // ¬осстанавливаем начальное состо€ние pnlHome после закрыти€ формы form2Instance

        //        LoadForm(form2Instance);

        //    }
        //    else
        //    {

        //        if (form2Instance != null && !form2Instance.IsDisposed)
        //        {
        //            form2Instance.Close();

        //        }

        //    }
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    if (form3Instance == null || form3Instance.IsDisposed)
        //    {

        //        form3Instance = new Form3();
        //        form3Instance.FormClosed += (s, args) => { RestoreInitialLayout(); }; // ¬осстанавливаем начальное состо€ние pnlHome после закрыти€ формы form2Instance
        //        LoadForm(form3Instance);

        //    }
        //    else
        //    {

        //        if (form3Instance != null && !form3Instance.IsDisposed)
        //        {
        //            form3Instance.Close();

        //        }

        //    }
        //}
    }
}