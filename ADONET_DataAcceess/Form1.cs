using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADONET_DataAcceess
{
    public partial class Form1 : Form
    {
        private DataSet _dataSet = new DataSet();
        private DataTable _dataTable = new DataTable();
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=SURFACE-KW4;Initial Catalog=AdventureWorks2017;Integrated Security=True;";
            

            
            //Beispiel1 SqlDataApdater
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    string selectCommand = "Select * FROM Person.Person";

            //    SqlCommand sqlCommand = new SqlCommand(selectCommand, connection);

            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            //    sqlDataAdapter.Fill(_dataTable);


            //    dataGridView1.DataSource = _dataTable;
            //}

            //Beispiel2

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                connection.Open();
                string query = "Select * FROM Person.Person";

                SqlCommand sqlCommand = new SqlCommand(query, connection);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();



                // Variante 1 mit sqlDataReader
                //if (sqlDataReader.HasRows)
                //{
                //    while (sqlDataReader.Read())
                //    {
                //        //Debug.WriteLine("{0}\t{1}", sqlDataReader.GetInt32(0),
                //        //    sqlDataReader.GetString(1));
                //    }
                //}
                //else
                //{
                //    Console.WriteLine("No rows found.");
                //

                //Variante 2
                _dataTable.Load(sqlDataReader);

                dataGridView1.DataSource = _dataTable;
            }


            //Wenn das Object Person mit einer using - Statement verwendet wird, benötigt die Klasse Person
            // das Interface IDisposeable
            //
            //using (Person person = new Person())
            //{

            //}

            string wert1 = "Test", wert2="123";

            // Bei Inserts und Updates...bzw wenn Variablen - Werte in einem SQL-Statement verwendet werden, ist diese Variante gefährtlich (SqlInjections Attack)
            // 
            string sqlInsertQuery = "INSERT ... INTO Person.Person VALUES(" + wert1 + "," + wert2 + ")";



            // Bessere Variante ist mit SqlCommand -> SqlParameter zu arbeiten


            //https://www.dotnetperls.com/sqlparameter
            //Beispiel für einen SqlQuery ->
            string paramterisiertesQuery = "SELECT * FROM Dogs1 WHERE Name LIKE @Name"; //@Name = Platzhalter

            //Platzhalter bekommt einen Wert zugewiesen
            //command.Parameters.Add(new SqlParameter("Name", dogName));

            // danach weiter wie üblich (siehe Beispiel2)
            //SqlDataReader reader = command.ExecuteReader();
            //while (reader.Read())
            //{
            //    int weight = reader.GetInt32(0);
            //    string name = reader.GetString(1);
            //    string breed = reader.GetString(2);
            //    Console.WriteLine("Weight = {0}, Name = {1}, Breed = {2}",
            //        weight,
            //        name,
            //        breed);
            //}
        }



    }


    public class Person : IDisposable
    {

        public Person()
        {

        }
        public string Vorname { get; set; }

        public void Dispose()
        {
            Vorname = null;
        }
    }
}
