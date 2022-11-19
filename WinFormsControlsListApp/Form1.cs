namespace WinFormsControlsListApp
{
    public partial class Form1 : Form
    {
        List<string> cities;
        public Form1()
        {
            Phone[] phones = new Phone[]
            {
                new(){ Model = "Galaxy 9", Company = "Sumsung", Price = 17000.00m},
                new(){ Model = "Galaxy A5", Company = "Sumsung", Price = 16000.00m},
                new(){ Model = "iPhone XR", Company = "Apple", Price = 25000.00m},
                new(){ Model = "AA33", Company = "Huaway", Price = 12000.00m},
            };


            InitializeComponent();

            cities = new(){ "Moscow", "Tula", "Voroneg", "Orel", "St Peterburg", "Kazan", "Novosibirsk" };

            //listCities.Items.Add("Orel");
            //listCities.Items.AddRange(cities);

            listCities.DataSource = cities;
            //listCities.DataBindings.Add(new Binding("Items", cities)) 

            cmbPhones.Items.AddRange(phones);
            cmbPhones.SelectedIndex = 0;

            chkBoxCities.Items.AddRange(cities.ToArray());
            domainUpDown1.Items.AddRange(cities.ToArray());
            domainUpDown1.Sorted = true;
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            listCities.Items.Insert(listCities.SelectedIndex + 1, txtCity.Text);
            txtCity.Text = "";
            listCities.SelectedIndex++;
        }

        private void btnDelCity_Click(object sender, EventArgs e)
        {
            if (listCities.SelectedIndex == -1)
                return;

            if(listCities.SelectionMode == SelectionMode.One)
            {
                int index = listCities.SelectedIndex;
                listCities.Items.RemoveAt(listCities.SelectedIndex);
                listCities.SelectedIndex = index;
            }
            else
            {
                //int index = listCities.SelectedIndices[listCities.SelectedIndices.Count - 1];
                List<string> cities = new();
                foreach (string item in listCities.SelectedItems)
                    cities.Add(item);

                foreach (var item in cities)
                    listCities.Items.Remove(item);
            }
        }

        private void btnShowSelections_Click(object sender, EventArgs e)
        {
            string message = "";
            foreach (var item in listCities.SelectedItems)
                message += item + "\n";
            MessageBox.Show(message);
        }

        private void listCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            listSelections.Items.Clear();
            foreach (string item in listCities.SelectedItems)
                listSelections.Items.Add(item);
        }

        

        private void btnShowChecks_Click(object sender, EventArgs e)
        {
            string msg = "";
            foreach (string s in chkBoxCities.CheckedItems)
                msg += s + "\n";
            MessageBox.Show(msg);
        }
    }
}