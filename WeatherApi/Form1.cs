using Microsoft.VisualBasic.Logging;
using System.Windows.Forms.DataVisualization.Charting;

namespace WeatherProject
{
    public partial class WeatherApiForm : Form
    {

        private API api;
        int kryteriumSortowania = 0;

        public WeatherApiForm()
        {
            InitializeComponent();

            api = new API();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void lonTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void SendCoordinatesButton_Click(object sender, EventArgs e)
        {
            double lat = 0;
            double lon = 0;

            if (!double.TryParse(textBox1.Text, out lat))
            {
                MessageBox.Show("Wrong latitude data");
            }

            if (!double.TryParse(lonTextBox.Text, out lon))
            {
                MessageBox.Show("Wrong longitude data");
            }
            if (double.TryParse(textBox1.Text, out lat) == true && double.TryParse(lonTextBox.Text, out lon) == true)
            {
                api.AddCityToDatabase(lat, lon);
            }
        }

        private void printData(List<WeatherTable> List)
        {
            var databaseList = List;
            listBox1.Items.Clear();
            foreach (var item in databaseList)
            {
                listBox1.Items.Add($"Id: {item.Id}");
                listBox1.Items.Add($"City name: {item.city_name}");
                listBox1.Items.Add($"Temperature: {item.temp.ToString("0.00")} °C");
                listBox1.Items.Add($"Wind: {item.speed} m/s");
                listBox1.Items.Add($"Humidity: {item.humidity} %");
                listBox1.Items.Add($"Pressure: {item.pressure} hPa");
                listBox1.Items.Add($"Feel temperature: {item.feels_like.ToString("0.00")} °C");
            }
        }

        private void RefreshListButton_Click(object sender, EventArgs e)
        {
            var databaseList = api.returnList();

            printData(databaseList);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var databaseList = api.returnList();
            printData(databaseList);
            api.dropDatabase();
            listBox1.Items.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var dbList = api.returnList();
            dbList.Sort((x, y) => y.temp.CompareTo(x.temp));
            printData(dbList);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dbList = api.returnList();
            dbList.Sort((x, y) => y.speed.CompareTo(x.speed));
            printData(dbList);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dbList = api.returnList();
            dbList.Sort((x, y) => y.humidity.CompareTo(x.humidity));
            printData(dbList);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var dbList = api.returnList();
            dbList.Sort((x, y) => y.pressure.CompareTo(x.pressure));
            printData(dbList);
        }

        private void WeatherApiForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button6_Click(object sender, EventArgs e)
        {
            var dbList = api.returnList();
            dbList.Sort((x, y) => y.feels_like.CompareTo(x.feels_like));
            printData(dbList);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {

                case 0:
                    api.AddCityToDatabase(48.8566, 2.3522);
                    break;

                case 1:
                    api.AddCityToDatabase(51.5074, -0.1278);
                    break;
                case 2:
                    api.AddCityToDatabase(52.5200, 13.4050);
                    break;
                case 3:
                    api.AddCityToDatabase(41.9028, 12.4964);
                    break;
                case 4:
                    api.AddCityToDatabase(52.2297, 21.0122);
                    break;
                case 5:
                    api.AddCityToDatabase(51.1079, 17.0385);
                    break;
                default:
                    break;

            }
            var databaseList = api.returnList();
            printData(databaseList);


        }
    }
}
