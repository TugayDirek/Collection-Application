using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int i = 0;
        int a = 0;
        TextBox txt = new TextBox();
        TextBox txt2 = new TextBox();

        private void addFeature_Click(object sender, EventArgs e)
        {

            txt = new TextBox();
            txt2 = new TextBox();

            i++;
            a++;
            Label lb = new Label();
            this.Controls.Add(lb);
            lb.Top = i * 25;
            lb.Left = 350;
            lb.Text = "Name";

            //TextBox txt = new TextBox();
            this.Controls.Add(txt);
            txt.Top = i * 25;
            txt.Left = 450;

            txt.Name = "txt1" + a.ToString();
            //txt.Text = "Textbox" + txt.Name;

            i++;


            Label lb2 = new Label();
            this.Controls.Add(lb2);
            lb2.Top = i * 25;
            lb2.Left = 350;
            lb2.Text = "Feature";

            //TextBox txt2 = new TextBox();
            this.Controls.Add(txt2);
            txt2.Top = i * 25;
            txt2.Left = 450;

            txt2.Name = "txt2" + a.ToString();
            //txt2.Text = "Textbox" + txt2.Name;
        }


        void combo()
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

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




                    string all = "Type - " + type.ToUpper() + "\n" + numbers_1.ToUpper() + numbers_2 + numbers_3.ToUpper() + numbers_4 + numbers_5.ToUpper() + numbers_6 + numbers_7.ToUpper() + numbers_8 + numbers_9.ToUpper()
                         + numbers_10 + numbers_11.ToUpper() + numbers_12 + numbers_13.ToUpper() + numbers_14 + numbers_15.ToUpper() + numbers_16 + numbers_17.ToUpper() + numbers_18
                         + numbers_19.ToUpper() + numbers_20 + numbers_21.ToUpper() + numbers_22 + numbers_23.ToUpper() + numbers_24 + numbers_25.ToUpper() + numbers_26 + numbers_27.ToUpper() + numbers_28 + "\n\n";

                    collectType[counter] = type;

                    counter++;
                }

                int countAll = 0;
                string allString = "";

                for (; countAll < counter; countAll++)
                {

                    comboBox1.Items.Add(collectType[countAll]);
                }

                label1.Text = allString;
            }
        }

        string[] collectType_numbers = new string[100];
        string[] collectType = new string[100];

        void combo_2()
        {
            Database databaseObject = new Database();

            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            databaseObject.OpenConnection();

            string secondCombo = comboBox1.Text;

            string query_id = "Select * from type2 WHERE type='"+ secondCombo.Trim() + "' ";
            //string query_name = "Select * from type2 BY type)";

            SQLiteCommand myCommand = new SQLiteCommand(query_id, databaseObject.myConnection);



            collectType = new string[100];
            //string[] collectType_numbers = new string[100];

            int counter = 0;
            int counter_1 = 0;
            int counter_2 = 2;

            using (SQLiteDataReader rdr = myCommand.ExecuteReader())
            {

                comboBox2.Items.Clear();
                while (rdr.Read())
                {

                    counter_1 = 0;

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

                   
                    if (numbers_1 != "")
                    { 
                        collectType[counter_1] = numbers_1;
                        counter_1++;
                    }
                    if (numbers_2 != "")
                        //collectType[counter] = numbers_2;
                    if (numbers_3 != "") { 
                        collectType[counter_1] = numbers_3;
                    counter_1++;
                     }
                    if (numbers_4 != "")
                        //collectType[counter] = numbers_4;
                    if (numbers_5 != "") { 
                        collectType[counter_1] = numbers_5;
                    counter_1++;
                }
                if (numbers_6 != "")
                        //collectType[counter] = numbers_6;
                    if (numbers_7 != "") { 
                        collectType[counter_1] = numbers_7; counter_1++;
                }
                if (numbers_8 != "")
                        //collectType[counter] = numbers_8;
                    if (numbers_9 != "") { 
                        collectType[counter_1] = numbers_9; counter_1++;
                }
                if (numbers_10 != "")
                        //collectType[counter] = numbers_10;
                    if (numbers_11 != "") { 
                        collectType[counter_1] = numbers_11; counter_1++;
                }
                if (numbers_12 != "")
                        //collectType[counter] = numbers_12;
                    if (numbers_13 != "") { 
                        collectType[counter_1] = numbers_13; counter_1++;
                }
                if (numbers_14 != "")
                        //collectType[counter] = numbers_14;
                    if (numbers_15 != "") { 
                        collectType[counter_1] = numbers_15; counter_1++;
                }
                if (numbers_16 != "")
                        //collectType[counter] = numbers_16;
                    if (numbers_17 != "") { 
                        collectType[counter_1] = numbers_17; counter_1++;
                }
                if (numbers_18 != "")
                        //collectType[counter] = numbers_18;
                    if (numbers_19 != "") { 
                        collectType[counter_1] = numbers_19; counter_1++;
                }
                if (numbers_20 != "")
                        //collectType[counter] = numbers_20;
                    if (numbers_21 != "") { 
                        collectType[counter_1] = numbers_21; counter_1++;
                }
                if (numbers_22 != "")
                        //collectType[counter] = numbers_22;
                    if (numbers_23 != "") { 
                        collectType[counter_1] = numbers_23; counter_1++;
                }
                if (numbers_24 != "")
                        //collectType[counter] = numbers_24;
                    if (numbers_25 != "") { 
                        collectType[counter_1] = numbers_25; counter_1++;
                }
                if (numbers_26 != "")
                        //collectType[counter] = numbers_26;
                    if (numbers_27 != "") { 
                        collectType[counter_1] = numbers_27; counter_1++;
                }
                //if (numbers_28 != "")
                        //collectType[counter+1] = numbers_28;




                /*    string all = "Type - " + type.ToUpper() + "\n" + numbers_1.ToUpper() + numbers_2 + numbers_3.ToUpper() + numbers_4 + numbers_5.ToUpper() + numbers_6 + numbers_7.ToUpper() + numbers_8 + numbers_9.ToUpper()
                         + numbers_10 + numbers_11.ToUpper() + numbers_12 + numbers_13.ToUpper() + numbers_14 + numbers_15.ToUpper() + numbers_16 + numbers_17.ToUpper() + numbers_18
                         + numbers_19.ToUpper() + numbers_20 + numbers_21.ToUpper() + numbers_22 + numbers_23.ToUpper() + numbers_24 + numbers_25.ToUpper() + numbers_26 + numbers_27.ToUpper() + numbers_28 + "\n\n";
                         */
                    //collectType[counter] = numbers_1;

                    //counter_1++;
                }

                int countAll = 0;
                string allString = "";

                for (; countAll < counter_1; countAll++)
                {

                    comboBox2.Items.Add(collectType[countAll]);
                }

                label1.Text = allString;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //comboBox1.Items.Add("Wildcards");

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;



            combo();
        }
    
        

        private void tytleofType_TextChanged(object sender, EventArgs e)
        {
            
        }

      

        private void saveCollection_Click(object sender, EventArgs e)
        {
            string title = titleofType.Text;


            Database databaseObject = new Database();

            
            databaseObject.OpenConnection();

           

            string query_title = "INSERT INTO type2 ('type') VALUES (@type)";
            SQLiteCommand myCommand_title = new SQLiteCommand(query_title, databaseObject.myConnection);

            if (title != "")
            {

                myCommand_title.Parameters.AddWithValue("@type", title);
                var result_title = myCommand_title.ExecuteNonQuery();
            }
            int j = 1;
            int z = 2;
            int t = 1;

            if (title != "")
            {
                for (; j <= a; j++, z = z + 2, t = t + 2)
                {

                    string insertTitle = ((TextBox)(this.Controls[("txt1" + j.ToString())])).Text;//txt.Name("txt1" + j.ToString())
                    string insertFeature = ((TextBox)(this.Controls[("txt2" + j.ToString())])).Text;//txt.Name("txt1" + j.ToString())

                    //string query = "UPDATE type2 ('"+t.ToString()+"','"+z.ToString()+"') VALUES (@"+ t.ToString() + ",@"+ z.ToString() + ") WHERE type='"+title+"'";

                    string query = "UPDATE type2 SET '" + t.ToString() + "' = '" + insertTitle + "', '" + z.ToString() + "' = '" + insertFeature + "' WHERE type='" + title + "'";

                    SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);

                    // MessageBox.Show(t.ToString()+"  --"+ z.ToString()+"--"+insertTitle+"--"+insertFeature);




                   // myCommand.Parameters.AddWithValue("@ONE"/*+ t.ToString()*/, insertTitle);
                    //myCommand.Parameters.AddWithValue("@TWO"/*+ z.ToString()*/, insertFeature);
                    var result = myCommand.ExecuteNonQuery();

                    


                }

                MessageBox.Show("Succesfuly Saved.");
            }
            else
            {
                MessageBox.Show("Enter Type!!!");
            }


            databaseObject.CloseConnection();
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            i = 0;
            a = 0;
            combo();
            comboBox1.Text = "Saved Items";


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public string allString;

        private void button2_Click(object sender, EventArgs e)
        { 
                Form2 f2 = new Form2();
                f2.ShowDialog();

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            //combo_2();

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            combo_2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Database databaseObject = new Database();


            string comboString = comboBox1.Text;


            databaseObject.OpenConnection();

            //MessageBox.Show(comboString+"-");

            string query_id = "DELETE FROM type2 WHERE type ='"+ comboString.Trim() +"' ";
            //string query_name = "Select * from type2 BY type)";

            SQLiteCommand myCommand = new SQLiteCommand(query_id, databaseObject.myConnection);
            if (comboString != "")
            {
                try
                {
                    var result = myCommand.ExecuteNonQuery();
                    MessageBox.Show("Item Deleted");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                }else
            {
                MessageBox.Show("Select Item");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string newValue = textBox1.Text;
            string title = comboBox1.Text;

            Database databaseObject = new Database();


            //string comboString = comboBox1.Text;


            databaseObject.OpenConnection();

            int index = Array.IndexOf(collectType, comboBox2.Text);
            index++;
            index = index * 2;


            //string query2 = "UPDATE type2 SET '" + t.ToString() + "' = '" + insertTitle + "', '" + z.ToString() + "' = '" + insertFeature + "' WHERE type='" + title + "'";

            //MessageBox.Show(index.ToString()+title);

            string query = "UPDATE type2 SET '" + index.ToString().Trim() + "' = '" + newValue + "' WHERE type='" + title.Trim() + "'";

            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);

            // MessageBox.Show(t.ToString()+"  --"+ z.ToString()+"--"+insertTitle+"--"+insertFeature);




            //myCommand.Parameters.AddWithValue("@ONE"/*+ t.ToString()*/, newValue);

            if (newValue != "")
            {
                var result = myCommand.ExecuteNonQuery();
                MessageBox.Show(" Succesfully Edited");
            }
            else
            {
                MessageBox.Show("Enter New Value");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            i = 0;
            a = 0;
            combo();
            comboBox1.Text = "Saved Items";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
