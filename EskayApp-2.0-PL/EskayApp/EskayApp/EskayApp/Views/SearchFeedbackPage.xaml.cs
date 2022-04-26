using Newtonsoft.Json;
using RestSharp;
using System;
using System.Data;
using EskayApp.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.CSharp;
using Newtonsoft.Json.Linq;

namespace EskayApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SearchFeedbackPage : ContentPage
	{
		public SearchFeedbackPage ()
		{
			InitializeComponent ();

            FrameInfo.IsVisible = false;
        }

        public  bool GetIsSuccessfull = false;
        private DataTable dTableConcern = new DataTable();
        public DataTable GetConcern(string Code)
        {
            var client = new RestClient("http://api.tingog.bohol.gov.ph/concerns/getconcern/app/" + Code);
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
       
            string content = "["+response.Content+"]"; // raw content as string
            
            
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                GetIsSuccessfull = true;
                if (!content.Equals("[null]"))
                {
                    DataTable table =     JsonStringToDatatable(content);
                    //DataTable table = (DataTable)JsonConvert.DeserializeObject(response.Content, typeof(DataTable));
                    return table;
                }
                else return null;
            }
            else
            {
                GetIsSuccessfull = false;
                return null;
            }
        }

        public DataTable JsonStringToDatatable(string json)
        {
            var result = new DataTable();
            var jArray = JArray.Parse(json);
            //Initialize the columns, If you know the row type, replace this   
            foreach (var row in jArray)
            {
                foreach (var jToken in row)
                {
                    var jproperty = jToken as JProperty;
                    if (jproperty == null) continue;
                    if (result.Columns[jproperty.Name] == null)
                        result.Columns.Add(jproperty.Name, typeof(string));
                }
            }
            foreach (var row in jArray)
            {
                var datarow = result.NewRow();
                foreach (var jToken in row)
                {
                    var jProperty = jToken as JProperty;
                    if (jProperty == null) continue;
                    datarow[jProperty.Name] = jProperty.Value.ToString();
                }
                result.Rows.Add(datarow);
            }

            return result;
        }

        private void FillData()
        {
            dTableConcern = GetConcern(Search.Text.Trim());
            if (GetIsSuccessfull)
            {
                if (dTableConcern != null)
                {
                    if (dTableConcern.Rows.Count > 0 )
                    {
                        FrameInfo.IsVisible = true;
                        ConcernCode.Text = "Concern Code: " + dTableConcern.Rows[0]["concern_code"].ToString();
                        ConcernStatus.Text = "Status: " + dTableConcern.Rows[0]["status"].ToString();
                        ConcernMsg.Text = "Concern: " + dTableConcern.Rows[0]["concerns"].ToString();
                        string action = !string.IsNullOrEmpty(dTableConcern.Rows[0]["final_action"].ToString()) ? dTableConcern.Rows[0]["final_action"].ToString() : "No action taken yet.";
                        ActionTaken.Text = "Action Taken: " + action;
                        ConcernCode.TextColor = Color.Red;
                        ConcernStatus.TextColor = Color.Orange;
                    }
                }
                else
                {
                    FrameInfo.IsVisible = false;
                    ConcernCode.Text = "Concern Code:";
                    ConcernStatus.Text = "Status:";
                    ConcernMsg.Text = "Concern:";
                    ActionTaken.Text = "Action Taken:";
                    ConcernStatus.TextColor = Color.Default;
                    ConcernCode.TextColor = Color.Default;
                    var message = "No data found. Please enter valid concern code...";
                    DependencyService.Get<IMessage>().ShortTime(message);
                }
            }
            else {
                FrameInfo.IsVisible = false;
                var message = "No data found. There's an error while getting the data...";
                DependencyService.Get<IMessage>().ShortTime(message);
            }
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Search.Text.Trim()))
            {
                FillData();
            }
        }
    }
}