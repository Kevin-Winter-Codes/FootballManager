namespace KWProjects.Clients.GeoNamesOrgClient.UI
{
    partial class GeoNameClientView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.databasePanel = new System.Windows.Forms.Panel();
            this.dgvDBView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowPanelItems = new System.Windows.Forms.FlowLayoutPanel();
            this.gbContinents = new System.Windows.Forms.GroupBox();
            this.cbContinents = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.gbCountries = new System.Windows.Forms.GroupBox();
            this.cbCountries = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbStates = new System.Windows.Forms.ComboBox();
            this.btnImportContinents = new System.Windows.Forms.Button();
            this.btnImportCountries = new System.Windows.Forms.Button();
            this.btnImportStates = new System.Windows.Forms.Button();
            this.btnImportCities = new System.Windows.Forms.Button();
            this.lvDBList = new System.Windows.Forms.ListView();
            this.clientPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvGeoNameOrgClientResultsView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRequestContinents = new System.Windows.Forms.Button();
            this.btnRequestStates = new System.Windows.Forms.Button();
            this.btnRequestCities = new System.Windows.Forms.Button();
            this.lvGeonameList = new System.Windows.Forms.ListView();
            this.databasePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBView)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowPanelItems.SuspendLayout();
            this.gbContinents.SuspendLayout();
            this.gbCountries.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.clientPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeoNameOrgClientResultsView)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // databasePanel
            // 
            this.databasePanel.Controls.Add(this.dgvDBView);
            this.databasePanel.Controls.Add(this.panel1);
            this.databasePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.databasePanel.Location = new System.Drawing.Point(0, 0);
            this.databasePanel.Name = "databasePanel";
            this.databasePanel.Size = new System.Drawing.Size(1431, 357);
            this.databasePanel.TabIndex = 0;
            // 
            // dgvDBView
            // 
            this.dgvDBView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDBView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDBView.Location = new System.Drawing.Point(0, 89);
            this.dgvDBView.Name = "dgvDBView";
            this.dgvDBView.ReadOnly = true;
            this.dgvDBView.RowHeadersWidth = 51;
            this.dgvDBView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDBView.Size = new System.Drawing.Size(1431, 268);
            this.dgvDBView.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowPanelItems);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1431, 89);
            this.panel1.TabIndex = 0;
            // 
            // flowPanelItems
            // 
            this.flowPanelItems.Controls.Add(this.gbContinents);
            this.flowPanelItems.Controls.Add(this.gbCountries);
            this.flowPanelItems.Controls.Add(this.groupBox1);
            this.flowPanelItems.Controls.Add(this.btnImportContinents);
            this.flowPanelItems.Controls.Add(this.btnImportCountries);
            this.flowPanelItems.Controls.Add(this.btnImportStates);
            this.flowPanelItems.Controls.Add(this.btnImportCities);
            this.flowPanelItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanelItems.Location = new System.Drawing.Point(0, 0);
            this.flowPanelItems.Name = "flowPanelItems";
            this.flowPanelItems.Size = new System.Drawing.Size(1431, 89);
            this.flowPanelItems.TabIndex = 4;
            // 
            // gbContinents
            // 
            this.gbContinents.Controls.Add(this.cbContinents);
            this.gbContinents.Controls.Add(this.comboBox1);
            this.gbContinents.Controls.Add(this.comboBox2);
            this.gbContinents.Location = new System.Drawing.Point(3, 3);
            this.gbContinents.Name = "gbContinents";
            this.gbContinents.Size = new System.Drawing.Size(230, 68);
            this.gbContinents.TabIndex = 0;
            this.gbContinents.TabStop = false;
            this.gbContinents.Text = "Cotinent List";
            // 
            // cbContinents
            // 
            this.cbContinents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbContinents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContinents.FormattingEnabled = true;
            this.cbContinents.Location = new System.Drawing.Point(6, 26);
            this.cbContinents.Name = "cbContinents";
            this.cbContinents.Size = new System.Drawing.Size(221, 28);
            this.cbContinents.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(-1036, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(715, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(-2025, 30);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(1118, 28);
            this.comboBox2.TabIndex = 1;
            // 
            // gbCountries
            // 
            this.gbCountries.Controls.Add(this.cbCountries);
            this.gbCountries.Location = new System.Drawing.Point(239, 3);
            this.gbCountries.Name = "gbCountries";
            this.gbCountries.Size = new System.Drawing.Size(230, 68);
            this.gbCountries.TabIndex = 1;
            this.gbCountries.TabStop = false;
            this.gbCountries.Text = "Country List";
            // 
            // cbCountries
            // 
            this.cbCountries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountries.FormattingEnabled = true;
            this.cbCountries.Location = new System.Drawing.Point(6, 26);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(218, 28);
            this.cbCountries.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbStates);
            this.groupBox1.Location = new System.Drawing.Point(475, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 68);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "State List";
            // 
            // cbStates
            // 
            this.cbStates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStates.FormattingEnabled = true;
            this.cbStates.Location = new System.Drawing.Point(6, 26);
            this.cbStates.Name = "cbStates";
            this.cbStates.Size = new System.Drawing.Size(218, 28);
            this.cbStates.TabIndex = 0;
            // 
            // btnImportContinents
            // 
            this.btnImportContinents.Location = new System.Drawing.Point(723, 15);
            this.btnImportContinents.Margin = new System.Windows.Forms.Padding(15);
            this.btnImportContinents.Name = "btnImportContinents";
            this.btnImportContinents.Size = new System.Drawing.Size(139, 50);
            this.btnImportContinents.TabIndex = 3;
            this.btnImportContinents.Text = "Continents -> DB";
            this.btnImportContinents.UseVisualStyleBackColor = true;
            this.btnImportContinents.Click += new System.EventHandler(this.btnImportContinents_Click);
            // 
            // btnImportCountries
            // 
            this.btnImportCountries.Location = new System.Drawing.Point(892, 15);
            this.btnImportCountries.Margin = new System.Windows.Forms.Padding(15);
            this.btnImportCountries.Name = "btnImportCountries";
            this.btnImportCountries.Size = new System.Drawing.Size(145, 50);
            this.btnImportCountries.TabIndex = 4;
            this.btnImportCountries.Text = "Countries -> DB";
            this.btnImportCountries.UseVisualStyleBackColor = true;
            // 
            // btnImportStates
            // 
            this.btnImportStates.Location = new System.Drawing.Point(1067, 15);
            this.btnImportStates.Margin = new System.Windows.Forms.Padding(15);
            this.btnImportStates.Name = "btnImportStates";
            this.btnImportStates.Size = new System.Drawing.Size(145, 50);
            this.btnImportStates.TabIndex = 5;
            this.btnImportStates.Text = "States -> DB";
            this.btnImportStates.UseVisualStyleBackColor = true;
            // 
            // btnImportCities
            // 
            this.btnImportCities.Location = new System.Drawing.Point(1242, 15);
            this.btnImportCities.Margin = new System.Windows.Forms.Padding(15);
            this.btnImportCities.Name = "btnImportCities";
            this.btnImportCities.Size = new System.Drawing.Size(145, 50);
            this.btnImportCities.TabIndex = 6;
            this.btnImportCities.Text = "Cities -> DB";
            this.btnImportCities.UseVisualStyleBackColor = true;
            // 
            // lvDBList
            // 
            this.lvDBList.HideSelection = false;
            this.lvDBList.Location = new System.Drawing.Point(0, 0);
            this.lvDBList.Name = "lvDBList";
            this.lvDBList.Size = new System.Drawing.Size(121, 97);
            this.lvDBList.TabIndex = 0;
            this.lvDBList.UseCompatibleStateImageBehavior = false;
            // 
            // clientPanel
            // 
            this.clientPanel.Controls.Add(this.panel3);
            this.clientPanel.Controls.Add(this.panel2);
            this.clientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientPanel.Location = new System.Drawing.Point(0, 357);
            this.clientPanel.Name = "clientPanel";
            this.clientPanel.Size = new System.Drawing.Size(1431, 424);
            this.clientPanel.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvGeoNameOrgClientResultsView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1431, 341);
            this.panel3.TabIndex = 1;
            // 
            // dgvGeoNameOrgClientResultsView
            // 
            this.dgvGeoNameOrgClientResultsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeoNameOrgClientResultsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGeoNameOrgClientResultsView.Location = new System.Drawing.Point(0, 0);
            this.dgvGeoNameOrgClientResultsView.Name = "dgvGeoNameOrgClientResultsView";
            this.dgvGeoNameOrgClientResultsView.ReadOnly = true;
            this.dgvGeoNameOrgClientResultsView.RowHeadersWidth = 51;
            this.dgvGeoNameOrgClientResultsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGeoNameOrgClientResultsView.Size = new System.Drawing.Size(1431, 341);
            this.dgvGeoNameOrgClientResultsView.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1431, 83);
            this.panel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnRequestContinents);
            this.flowLayoutPanel1.Controls.Add(this.btnRequestStates);
            this.flowLayoutPanel1.Controls.Add(this.btnRequestCities);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1431, 83);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnRequestContinents
            // 
            this.btnRequestContinents.Location = new System.Drawing.Point(15, 15);
            this.btnRequestContinents.Margin = new System.Windows.Forms.Padding(15);
            this.btnRequestContinents.Name = "btnRequestContinents";
            this.btnRequestContinents.Size = new System.Drawing.Size(139, 50);
            this.btnRequestContinents.TabIndex = 0;
            this.btnRequestContinents.Text = "Request Continents";
            this.btnRequestContinents.UseVisualStyleBackColor = true;
            this.btnRequestContinents.Click += new System.EventHandler(this.btnRequestContinents_Click);
            // 
            // btnRequestStates
            // 
            this.btnRequestStates.Location = new System.Drawing.Point(184, 15);
            this.btnRequestStates.Margin = new System.Windows.Forms.Padding(15);
            this.btnRequestStates.Name = "btnRequestStates";
            this.btnRequestStates.Size = new System.Drawing.Size(139, 50);
            this.btnRequestStates.TabIndex = 1;
            this.btnRequestStates.Text = "Request States";
            this.btnRequestStates.UseVisualStyleBackColor = true;
            // 
            // btnRequestCities
            // 
            this.btnRequestCities.Location = new System.Drawing.Point(353, 15);
            this.btnRequestCities.Margin = new System.Windows.Forms.Padding(15);
            this.btnRequestCities.Name = "btnRequestCities";
            this.btnRequestCities.Size = new System.Drawing.Size(139, 50);
            this.btnRequestCities.TabIndex = 2;
            this.btnRequestCities.Text = "Request Cities";
            this.btnRequestCities.UseVisualStyleBackColor = true;
            // 
            // lvGeonameList
            // 
            this.lvGeonameList.HideSelection = false;
            this.lvGeonameList.Location = new System.Drawing.Point(0, 0);
            this.lvGeonameList.Name = "lvGeonameList";
            this.lvGeonameList.Size = new System.Drawing.Size(121, 97);
            this.lvGeonameList.TabIndex = 0;
            this.lvGeonameList.UseCompatibleStateImageBehavior = false;
            // 
            // GeoNameClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 781);
            this.Controls.Add(this.clientPanel);
            this.Controls.Add(this.databasePanel);
            this.Name = "GeoNameClientView";
            this.Text = "GeoNameOrg Client";
            this.Load += new System.EventHandler(this.GeoNameClientView_Load);
            this.Resize += new System.EventHandler(this.GeoNameClientView_Resize);
            this.databasePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flowPanelItems.ResumeLayout(false);
            this.gbContinents.ResumeLayout(false);
            this.gbCountries.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.clientPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeoNameOrgClientResultsView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel databasePanel;
        private System.Windows.Forms.Panel clientPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowPanelItems;
        private System.Windows.Forms.GroupBox gbContinents;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cbContinents;
        private System.Windows.Forms.GroupBox gbCountries;
        private System.Windows.Forms.ComboBox cbCountries;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbStates;
        private System.Windows.Forms.Button btnImportContinents;
        private System.Windows.Forms.Button btnImportCountries;
        private System.Windows.Forms.Button btnImportStates;
        private System.Windows.Forms.Button btnImportCities;
        private System.Windows.Forms.ListView lvDBList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnRequestContinents;
        private System.Windows.Forms.Button btnRequestStates;
        private System.Windows.Forms.Button btnRequestCities;
        private System.Windows.Forms.ListView lvGeonameList;
        private System.Windows.Forms.DataGridView dgvDBView;
        private System.Windows.Forms.DataGridView dgvGeoNameOrgClientResultsView;

        private System.Windows.Forms.BindingSource bsDb;
        private System.Windows.Forms.BindingSource bsGeonamesOrgResults;
    }
}

