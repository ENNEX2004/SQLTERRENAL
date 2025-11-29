using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Terrenal_Kiel_Andrew_A._Open_menu
{
    public partial class Form1 : Form
    {
        string conn = "Server = localhost\\SQLEXPRESS;InitialCatalog=DBRecords;Trusted_Connection=True";
        public Form1()
        {
            InitializeComponent();
        }
        private void showList()
        {
            listView1.Items.Clear();
            using (SqlConnection Record = new SqlConnection(conn))
            {
                Record.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblPersonalinfo", Record))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        ListViewItem list = new ListViewItem(dataReader.GetInt32(0).ToString());
                        list.SubItems.Add(dataReader.GetString(1));
                        list.SubItems.Add(dataReader.GetString(2));
                        list.SubItems.Add(dataReader.GetString(3));
                        list.SubItems.Add(dataReader.GetString(4));
                        listView1.Items.Add(list);

                    }
                }
            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnRecord = new SqlConnection(conn))
            { 
                 cnRecord.Open();

            using (SqlCommand cmd = new SqlCommand("INSERT INTO tblRecords(Id, Product, Category, Price) VALUES( '" + textproduct + "' '" + listcategory + "''" + textprice + "')", conn))
                {
                    cmd.ExecuteNonQuery();
                    showList();
                    MessageBox.Show("Record successfully added!");
                    showList();
                    clearList();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showList();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                using (SqlCommand cmd = new SqlCommand("INSERT INTO tblRecords(Id, Product, Category, Price) VALUES( '" + textproduct + "' '" + listcategory + "''" + textprice + "')", conn))
                {
                    sqlcon2.ExecuteNonQuery();
                    showList();
                    MessageBox.Show("Record successfully added!");
                    showList();
                    clearList();
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                using (SqlCommand cmd = new SqlCommand("INSERT INTO tblRecords(Id, Product, Category, Price) VALUES( '" + textproduct + "' '" + listcategory + "''" + textprice + "')", conn))
                {
                    sqlcon2.ExecuteNonQuery();
                    showList();
                    MessageBox.Show("Record successfully added!");
                    showList();
                    clearList();
                }
            }
        }
        private void clearList()
        {
            textid.Text = "";
            textproduct.Clear();
            listcategory.Clear();
            textprice.Clear();
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(conn))
            { sqlcon.Open();
                using (SqlCommand sqlcon2 = new SqlCommand("DELETE FROM  tblPersonalinfo WHERE ID = " + textid.Text, sqlcon))

        }
    }




