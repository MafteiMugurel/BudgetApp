using System;
using System.Collections.Generic;
using System.IO; // fisiere
using System.Linq; // calcule rapide
using System.Windows.Forms;
using FinancialTools; 

namespace BudgetApp
{
    public partial class Form1 : Form
    {
       
        List<Tranzactie> listaMea = new List<Tranzactie>();
        string fisierDate = "date_buget.txt";

        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            IncarcaDate();
            ActualizeazaLista();
        }

       
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            // Validare Categorie
            if (string.IsNullOrWhiteSpace(txtCategorie.Text))
            {
                MessageBox.Show("Scrie o categorie!");
                return;
            }

            // Validare Suma
            decimal suma;
            if (!decimal.TryParse(txtSuma.Text, out suma) || suma <= 0)
            {
                MessageBox.Show("Introdu o suma corecta (numar pozitiv)!");
                return;
            }

            // Creare obiect
            Tranzactie t = new Tranzactie();
            t.Data = dtpData.Value;
            t.Suma = suma;
            t.Categorie = txtCategorie.Text;
            t.Tip = rbVenit.Checked ? "Venit" : "Cheltuiala";

            // Adaugare in lista
            listaMea.Add(t);

            // Salvare si Refresh
            SalveazaInFisier();
            ActualizeazaLista();

            // Curatam campurile
            txtSuma.Clear();
            txtCategorie.Clear();
        }

       
        private void btnRaport_Click(object sender, EventArgs e)
        {
            decimal totalV = listaMea.Where(x => x.Tip == "Venit").Sum(x => x.Suma);
            decimal totalC = listaMea.Where(x => x.Tip == "Cheltuiala").Sum(x => x.Suma);

            CalculatorBuget calc = new CalculatorBuget();
            decimal balanta = calc.CalculeazaBalanta(totalV, totalC);
            bool eAlerta = calc.EsteAlerta(balanta);

            string raport = "raport.txt";
            using (StreamWriter sw = new StreamWriter(raport))
            {
                sw.WriteLine("=== RAPORT BUGET ===");
                sw.WriteLine($"Total Venituri: {totalV}");
                sw.WriteLine($"Total Cheltuieli: {totalC}");
                sw.WriteLine($"Balanta: {balanta}");
                if (eAlerta) sw.WriteLine("!!! ALERTA: Esti pe minus !!!");
            }

            MessageBox.Show($"Raport generat!\nBalanta: {balanta}");
            
            System.Diagnostics.Process.Start("notepad.exe", raport);
        }

        
        private void SalveazaInFisier()
        {
            using (StreamWriter sw = new StreamWriter(fisierDate))
            {
                foreach (var item in listaMea)
                {
                    // Suma,Categorie,Tip,Data
                    sw.WriteLine($"{item.Suma},{item.Categorie},{item.Tip},{item.Data}");
                }
            }
        }

        private void IncarcaDate()
        {
            if (!File.Exists(fisierDate)) return;

            using (StreamReader sr = new StreamReader(fisierDate))
            {
                string linie;
                while ((linie = sr.ReadLine()) != null)
                {
                    var bucati = linie.Split(',');
                    if (bucati.Length >= 4)
                    {
                        Tranzactie t = new Tranzactie();
                        t.Suma = decimal.Parse(bucati[0]);
                        t.Categorie = bucati[1];
                        t.Tip = bucati[2];
                        t.Data = DateTime.Parse(bucati[3]);
                        listaMea.Add(t);
                    }
                }
            }
        }

        private void ActualizeazaLista()
        {
            lstAfisare.Items.Clear();
            foreach (var t in listaMea)
            {
                lstAfisare.Items.Add(t.ToString());
            }
            decimal venituri = listaMea.Where(x => x.Tip == "Venit").Sum(x => x.Suma);
            decimal cheltuieli = listaMea.Where(x => x.Tip == "Cheltuiala").Sum(x => x.Suma);
            decimal balanta = venituri - cheltuieli;

            lblBalanta.Text = $"Balanta curenta: {balanta} RON";

           
            if (balanta >= 0) lblBalanta.ForeColor = Color.Green;
            else lblBalanta.ForeColor = Color.Red;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSuma_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true; 
            }

            
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            // Verificam daca e selectat ceva in lista
            if (lstAfisare.SelectedIndex != -1)
            {
                // Stergem din lista de date (backend)
                listaMea.RemoveAt(lstAfisare.SelectedIndex);

                // Salvam noul fisier si actualizam lista vizuala
                SalveazaInFisier();
                ActualizeazaLista();
            }
            else
            {
                MessageBox.Show("Selecteaza un rand ca sa il poti sterge!");
            }
        }
    }

    
    public class Tranzactie
    {
        public DateTime Data { get; set; }
        public decimal Suma { get; set; }
        public string Categorie { get; set; }
        public string Tip { get; set; } 

        public override string ToString()
        {
            return $"{Data.ToShortDateString()} | {Tip} | {Suma} RON | {Categorie}";
        }
    }
}