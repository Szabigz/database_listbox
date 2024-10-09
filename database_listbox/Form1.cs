using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database_listbox
{
    public partial class Form1 : Form
    {
        dbHandler db;

        public Form1()
        {
            InitializeComponent();
            Start();
        }
        void Start()
        {
            db = new dbHandler();
            readInfo();
            addb.Click += addbutton;
            deleteb.Click += deletebutton;
            deleteall.Click += deleteallbutton;
        }
        void deleteallbutton(object s,EventArgs e)
        {
            db.deleteAll();
            readInfo();
        }
        void deletebutton(object s, EventArgs e)
        {
            int temp = listBox1.SelectedIndex;
            if (temp<0)
            {
                return;
            }
            db.deleteOne(kolbasz.kolbaszok[temp]);
            kolbasz.kolbaszok.RemoveAt(temp);
            readInfo();

        }
        void addbutton(object s,EventArgs e)
        {
                kolbasz oneNewKolbasz = new kolbasz();
                oneNewKolbasz.name = guna2TextBox1.Text;
                oneNewKolbasz.price = Convert.ToInt32(guna2TextBox2.Text);
                oneNewKolbasz.weight = Convert.ToInt32(guna2TextBox3.Text);
                db.insertOne(oneNewKolbasz);
                readInfo();

        }
        void readInfo()
        {
            listBox1.Items.Clear();
            db.readAll();
            foreach (kolbasz item in kolbasz.kolbaszok)
            {
                listBox1.Items.Add($"Kolbasz: {item.name}, ár: {item.price}, suly: {item.weight}");
            }
        }

    }
}
