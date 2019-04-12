using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;//used for db connection as well as disconnected entities
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//ADO.net classed



namespace Assignment1
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;


        public Form1()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=IBMDB;Persist Security Info=True;User ID=sa;Password=password@123";
            //Configure DataAdapter
            da = new SqlDataAdapter("select * from BookDetails", con);

            //create DataSet
            ds = new DataSet();

            //fill the DataSet using DataAdapter
            da.Fill(ds, "BookDetails");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].NewRow();
            //Supply values to the columns
            row[0] = bName.Text;
            row[1] = bid.Text;
            row[2] = Aname.Text;
            row[3] = Pname.Text;
            row[4] = Copies.Text;
            row[5] = txtPrice.Text;

            //add new row to the row of the datatable of DataSet
            ds.Tables[0].Rows.Add(row);

            //save the record to the Database using the Data Adapter
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "BookDetails");
            dgv.DataSource = null;
            dgv.DataSource = ds.Tables["BookDetails"];
            MessageBox.Show("Insertion sucessful");
        }

        private void Copies_Click(object sender, EventArgs e)
        {

        }
    }
}
