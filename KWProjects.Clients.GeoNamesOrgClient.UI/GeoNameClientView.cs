using KWProjects.Clients.GeoNamesOrgClient.ApplicationLayer;
using KWProjects.Clients.GeoNamesOrgClient.UI.Converter;
using KWProjects.Moduls.GeoDB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KWProjects.Clients.GeoNamesOrgClient.UI
{
    public partial class GeoNameClientView : Form
    {
        private GeoNameOrgImporter geoNameOrgImporter;

          
        #region Initial
        public GeoNameClientView()
        {
            geoNameOrgImporter = new GeoNameOrgImporter();
            InitializeComponent();
        }

        

        private void GeoNameClientView_Load(object sender, EventArgs e)
        {
            geoNameOrgImporter.Init();
            Init();
        }

        private void Init()
        {
            cbContinents.DataSource = geoNameOrgImporter.Continents;
            cbContinents.DisplayMember = "Name";
            cbContinents.ValueMember = "Id";

            dgvGeoNameOrgClientResultsView.DataSource = geoNameOrgImporter.GeonameResults;

            if (cbContinents.SelectedItem == null)
                return;

            cbCountries.DataSource = geoNameOrgImporter.Countries;
            cbCountries.DisplayMember = "Name";
            cbCountries.ValueMember = "Id";

            if (cbCountries.SelectedItem == null)
                return;

            cbStates.DataSource = geoNameOrgImporter.States;
            cbStates.DisplayMember = "Name";
            cbStates.ValueMember = "Id";
        }

        

        #endregion

        private void GeoNameClientView_Resize(object sender, EventArgs e)
        {
            this.clientPanel.Height = this.databasePanel.Height = (int)(this.Height / 2);
        }


        private void btnRequestContinents_Click(object sender, EventArgs e)
        {
            geoNameOrgImporter.Init();
        }

        private void btnImportContinents_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dgvGeoNameOrgClientResultsView.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0)
            {
                IList<Continent> resultList = new List<Continent>();
                foreach (DataGridViewRow selectedRow in dgvGeoNameOrgClientResultsView.SelectedRows)
                {
                    resultList.Add(selectedRow.ToContinent());
                }

                geoNameOrgImporter.InsertContinents(resultList);
            }

            Init();
        }
    }
}
