using Microsoft.EntityFrameworkCore;

namespace Zadatak2
{
    public partial class Form1 : Form
    {
        ZadatakDbContext _dbContext = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _dbContext.Database.Migrate();
            _dbContext.Ljubimci.Load();
            ljubimciBindingSource.DataSource = _dbContext.Ljubimci.Local.ToObservableCollection();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _dbContext.SaveChanges();
        }
    }
}
