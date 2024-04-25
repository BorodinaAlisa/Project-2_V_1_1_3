using DB_993;

namespace design
{
    public partial class MarkWindow : Form
    {
        public int IdRealty { get; set; }
        public MarkWindow()
        {
            InitializeComponent();
        }
        public MarkWindow(int idRealty)
        {
            InitializeComponent();
            IdRealty = idRealty;
        }
        public void MarkInDb(int mark)
        {
            using(var context = new ApplicationContex())
            {
                var markInRealty = context.Realtys.FirstOrDefault(m => m.Id == IdRealty);
                if (markInRealty != null)
                {
                    var updateMark = new Realty
                    {
                        Mark = mark
                    };
                }
            }
        }

        private void Star1_Click(object sender, EventArgs e)
        {
            MarkInDb(0);
        }

        private void Star2_Click(object sender, EventArgs e)
        {
            MarkInDb(2);
        }

        private void Star3_Click(object sender, EventArgs e)
        {
            MarkInDb(3);
        }

        private void Star4_Click(object sender, EventArgs e)
        {
            MarkInDb(4);
        }

        private void Star5_Click(object sender, EventArgs e)
        {
            MarkInDb(5);
        }
    }
}
