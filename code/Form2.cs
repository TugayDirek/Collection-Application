using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsFormsApp12
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //Form1 f1 = new Form1();
            //string write = f1.allString;
            //textBox1.Text = "sdfasf";
            //textBox1.Text = write;
            //MessageBox.Show(write);


            Database databaseObject = new Database();




            databaseObject.OpenConnection();



            string query_id = "Select * from type2 ";
            //string query_name = "Select * from type2 BY type)";

            SQLiteCommand myCommand = new SQLiteCommand(query_id, databaseObject.myConnection);



            string[] collectType = new string[100];
            string[] collectType_numbers = new string[100];

            int counter = 0;
            int counter_1 = 1;
            int counter_2 = 2;

            using (SQLiteDataReader rdr = myCommand.ExecuteReader())
            {
                while (rdr.Read())
                {
                    string type = (rdr["type"].ToString()); string numbers_1 = (rdr["1"].ToString()); string numbers_2 = (rdr["2"].ToString());
                    string numbers_3 = (rdr["3"].ToString()); string numbers_4 = (rdr["4"].ToString()); string numbers_5 = (rdr["5"].ToString());
                    string numbers_6 = (rdr["6"].ToString()); string numbers_7 = (rdr["7"].ToString()); string numbers_8 = (rdr["8"].ToString());
                    string numbers_9 = (rdr["9"].ToString()); string numbers_10 = (rdr["10"].ToString()); string numbers_11 = (rdr["11"].ToString());
                    string numbers_12 = (rdr["12"].ToString()); string numbers_13 = (rdr["13"].ToString()); string numbers_14 = (rdr["14"].ToString());
                    string numbers_15 = (rdr["15"].ToString()); string numbers_16 = (rdr["16"].ToString()); string numbers_17 = (rdr["17"].ToString());
                    string numbers_18 = (rdr["18"].ToString()); string numbers_19 = (rdr["19"].ToString()); string numbers_20 = (rdr["20"].ToString());
                    string numbers_21 = (rdr["21"].ToString()); string numbers_22 = (rdr["22"].ToString()); string numbers_23 = (rdr["23"].ToString());
                    string numbers_24 = (rdr["24"].ToString()); string numbers_25 = (rdr["25"].ToString()); string numbers_26 = (rdr["26"].ToString());
                    string numbers_27 = (rdr["27"].ToString()); string numbers_28 = (rdr["28"].ToString());

                    if (type != "")
                        type = type + "\n";
                    if (numbers_1 != "")
                        numbers_1 = numbers_1 + "\n";
                    if (numbers_2 != "")
                        numbers_2 = numbers_2 + "\n";
                    if (numbers_3 != "")
                        numbers_3 = numbers_3 + "\n";
                    if (numbers_4 != "")
                        numbers_4 = numbers_4 + "\n";
                    if (numbers_5 != "")
                        numbers_5 = numbers_5 + "\n";
                    if (numbers_6 != "")
                        numbers_6 = numbers_6 + "\n";
                    if (numbers_7 != "")
                        numbers_7 = numbers_7 + "\n";
                    if (numbers_8 != "")
                        numbers_8 = numbers_8 + "\n";
                    if (numbers_9 != "")
                        numbers_9 = numbers_9 + "\n";
                    if (numbers_10 != "")
                        numbers_10 = numbers_10 + "\n";
                    if (numbers_11 != "")
                        numbers_11 = numbers_11 + "\n";
                    if (numbers_12 != "")
                        numbers_12 = numbers_12 + "\n";
                    if (numbers_13 != "")
                        numbers_13 = numbers_13 + "\n";
                    if (numbers_14 != "")
                        numbers_14 = numbers_14 + "\n";
                    if (numbers_15 != "")
                        numbers_15 = numbers_15 + "\n";
                    if (numbers_16 != "")
                        numbers_16 = numbers_16 + "\n";
                    if (numbers_17 != "")
                        numbers_17 = numbers_17 + "\n";
                    if (numbers_18 != "")
                        numbers_18 = numbers_18 + "\n";
                    if (numbers_19 != "")
                        numbers_19 = numbers_19 + "\n";
                    if (numbers_20 != "")
                        numbers_20 = numbers_20 + "\n";
                    if (numbers_21 != "")
                        numbers_21 = numbers_21 + "\n";
                    if (numbers_22 != "")
                        numbers_22 = numbers_22 + "\n";
                    if (numbers_23 != "")
                        numbers_23 = numbers_23 + "\n";
                    if (numbers_24 != "")
                        numbers_24 = numbers_24 + "\n";
                    if (numbers_25 != "")
                        numbers_25 = numbers_25 + "\n";
                    if (numbers_26 != "")
                        numbers_26 = numbers_26 + "\n";
                    if (numbers_27 != "")
                        numbers_27 = numbers_27 + "\n";
                    if (numbers_28 != "")
                        numbers_28 = numbers_28 + "\n";




                    string all = "Type - "+type.ToUpper()+"\n" + numbers_1.ToUpper() + numbers_2 + numbers_3.ToUpper() + numbers_4 + numbers_5.ToUpper() + numbers_6 + numbers_7.ToUpper() + numbers_8 + numbers_9.ToUpper()
                         + numbers_10 + numbers_11.ToUpper() + numbers_12 + numbers_13.ToUpper() + numbers_14 + numbers_15.ToUpper() + numbers_16 + numbers_17.ToUpper() + numbers_18
                         + numbers_19.ToUpper() + numbers_20 + numbers_21.ToUpper() + numbers_22 + numbers_23.ToUpper() + numbers_24 + numbers_25.ToUpper() + numbers_26 + numbers_27.ToUpper() + numbers_28+"\n\n";

                    collectType[counter] = all;

                    counter++;
                }

                int countAll = 0;
                string allString = "";

                for (; countAll < counter; countAll++)
                {
                    //MessageBox.Show(collectType[countAll]);
                    allString = allString + collectType[countAll];
                }

                flowLayoutPanel1.Text = allString;
                label1.Text = allString;
                //MessageBox.Show(allString);


            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
