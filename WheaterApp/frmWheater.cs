using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WheaterApp.Models;

namespace WheaterApp
{
    public partial class frmWheater : Form
    {
        public frmWheater()
        {
            InitializeComponent();
        }

        public int selectedWoeid { get {
                int r = 0;
                try
                {
                    r =(int) cbCity.SelectedValue;
                }
                catch 
                {

                   
                }

                return r; } }


        private void frmWheater_Load(object sender, EventArgs e)
        {
            cbCity.DataSource = new City().getList();
           
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(selectedWoeid.ToString());

            var client = new RestClient("https://www.metaweather.com");
            // client.Authenticator = new HttpBasicAuthenticator(username, password);

            var request = new RestRequest("api/location/{id}", Method.POST);
            request.AddUrlSegment("id", selectedWoeid.ToString()); // replaces matching token in request.Resource

            // execute the request
            IRestResponse response = client.Execute(request);
            var content = response.Content; // raw content as string

            var forecast = JsonConvert.DeserializeObject<WhearterForeCast>(content);

            fillGrid(forecast);


            // abort the request on demand

        }

        private void fillGrid(WhearterForeCast forecast)
        {
            lblUpdateTime.Text = forecast.time.ToLongDateString();
            grdResult.Rows.Clear();
            foreach(var data in forecast.consolidated_weather)
            {
                grdResult.Rows.Add(new object[] {
                    data.applicable_date,
                    data.weather_state_name,
                    data.the_temp,
                    data.min_temp,
                    data.max_temp,
                    data.wind_speed
                });
            }
        }
    }
}
