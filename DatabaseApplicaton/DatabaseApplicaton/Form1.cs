using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace DatabaseApplicaton
{
    public partial class Form1 : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private BindingSource bindingSource2 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private string connectionString = "Data Source = DESKTOP-1P3VN9V\\SQLEXPRESS; " + " Initial Catalog = VideoGameShop; Integrated Security = SSPI";
        public Form1()
        {
            InitializeComponent();
            Form1_Load();
        }

        private void GetData(string selectCommand, BindingSource bs)
        {
            dataAdapter = new SqlDataAdapter(selectCommand, connectionString);
            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);
            bs.DataSource = ds.Tables[0];
        }

        private void Form1_Load()
        {
            CompaniesDataGrid.DataSource = bindingSource1;
            GamesDataGrid.DataSource = bindingSource2;
            FillCompaniesDataGrid();
        }

        private void FillCompaniesDataGrid()
        {
            GetData("select * from Companies", bindingSource1);
        }

        private void FillGamesDataGrid()
        {
            if (CompaniesDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = CompaniesDataGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = CompaniesDataGrid.Rows[selectedrowindex];
                int cellValue = Convert.ToInt32(selectedRow.Cells["CompanyID"].Value);

                GetData("select * from Games where CompanyID='" + cellValue + "'", bindingSource2);
            }
        }

        private void CompaniesDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            FillGamesDataGrid();
        }

        private void GamesDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (GamesDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = GamesDataGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = GamesDataGrid.Rows[selectedrowindex];

                textBox_Name.Text = Convert.ToString(selectedRow.Cells["Name"].Value);
                textBox_Price.Text = Convert.ToString(selectedRow.Cells["Price"].Value);
                textBox_CompanyID.Text = Convert.ToString(selectedRow.Cells["CompanyId"].Value);
                textBox_PlatformID.Text = Convert.ToString(selectedRow.Cells["PlatformId"].Value);
                textBox_GenreID.Text = Convert.ToString(selectedRow.Cells["GenreId"].Value);
                textBox_ReleaseYear.Text = Convert.ToString(selectedRow.Cells["ReleaseYear"].Value);

            }
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text != "" && textBox_Price.Text != "" && textBox_CompanyID.Text != "" && textBox_PlatformID.Text != "" && textBox_GenreID.Text != "" && textBox_ReleaseYear.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = connectionString;

                con.Open();

                string name = textBox_Name.Text;
                int price = Convert.ToInt32(textBox_Price.Text);
                int companyID = Convert.ToInt32(textBox_CompanyID.Text);
                int platformID = Convert.ToInt32(textBox_PlatformID.Text);
                int genreID = Convert.ToInt32(textBox_GenreID.Text);
                int release = Convert.ToInt32(textBox_ReleaseYear.Text);

                string cmd = "INSERT INTO Games(Name,Price,CompanyId,GenreId,PlatformId,ReleaseYear) VALUES('" + name + "','" + price + "'," +
                    "'" + companyID + "','" + genreID + "','" + platformID + "','" + release + "')";
                SqlCommand addCommand = new SqlCommand(cmd, con);
                addCommand.ExecuteNonQuery();
                FillGamesDataGrid();
                con.Close();
            }
            else
            {
                MessageBox.Show("Invalid Input!!");
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (GamesDataGrid.SelectedCells.Count > 0)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = connectionString;

                con.Open();

                int selectedrowindex = GamesDataGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = GamesDataGrid.Rows[selectedrowindex];

                int gameID = Convert.ToInt32(selectedRow.Cells["GameId"].Value);

                string cmd = "DELETE FROM Games WHERE GameId='"+gameID+"'";
                SqlCommand addCommand = new SqlCommand(cmd, con);
                addCommand.ExecuteNonQuery();
                FillGamesDataGrid();
                con.Close();
            }
            else
            {
                MessageBox.Show("Invalid Input!!");
            }
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            if (GamesDataGrid.SelectedCells.Count>0 && textBox_Name.Text != "" && textBox_Price.Text != "" && textBox_CompanyID.Text != "" && textBox_PlatformID.Text != "" && textBox_GenreID.Text != "" && textBox_ReleaseYear.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = connectionString;

                con.Open();

                int selectedrowindex = GamesDataGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = GamesDataGrid.Rows[selectedrowindex];
                int gameID = Convert.ToInt32(selectedRow.Cells["GameId"].Value);

                string name = textBox_Name.Text;
                int price = Convert.ToInt32(textBox_Price.Text);
                int companyID = Convert.ToInt32(textBox_CompanyID.Text);
                int platformID = Convert.ToInt32(textBox_PlatformID.Text);
                int genreID = Convert.ToInt32(textBox_GenreID.Text);
                int release = Convert.ToInt32(textBox_ReleaseYear.Text);

                string cmd = "UPDATE Games SET Name ='" + name + "' ,Price ='" + price + "' ,CompanyId ='" + companyID + "', GenreId ='" + genreID + "',PlatformId='" + platformID + "',ReleaseYear='" + release + "' " +
                    "WHERE GameId='"+gameID+"'";
                SqlCommand addCommand = new SqlCommand(cmd, con);
                addCommand.ExecuteNonQuery();
                FillGamesDataGrid();
                con.Close();
            }
            else
            {
                MessageBox.Show("Invalid Input!!");
            }
        }
    }
}
