namespace ModernRealEstate
{
    partial class Form1
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
            CategoryCombo = new ComboBox();
            CategoryLabel = new Label();
            LegalCombo = new ComboBox();
            LegalLabel = new Label();
            CountriesLabel = new Label();
            CountriesCombo = new ComboBox();
            headerLabel = new Label();
            AddButton = new Button();
            DeleteButton = new Button();
            EditButton = new Button();
            StreetText = new TextBox();
            streetLabel = new Label();
            CityLabel = new Label();
            CityText = new TextBox();
            ZipLabel = new Label();
            ZipText = new TextBox();
            TypeLabel = new Label();
            TypeCombo = new ComboBox();
            CommercialPanel = new Panel();
            WareHousePanel = new Panel();
            LoadingDockLabel = new Label();
            CeilingHeightText = new TextBox();
            LoadingNoRadio = new RadioButton();
            CeilingHeightLabel = new Label();
            LoadingYesRadio = new RadioButton();
            ShopPanel = new Panel();
            ParkingCapacityLabel = new Label();
            RetailSpaceLabel = new Label();
            ParkingCapacityText = new TextBox();
            RetailSpaceText = new TextBox();
            PropertyNameLabel = new Label();
            PropertyNameText = new TextBox();
            ResidentialPanel = new Panel();
            ApartmentPanel = new Panel();
            ApartmentNumberLabel = new Label();
            ApartmentNumberText = new TextBox();
            FloorNumberLabel = new Label();
            FloorNumberText = new TextBox();
            TownhousePanel = new Panel();
            CommonAreaLabel = new Label();
            CommonAreaText = new TextBox();
            NumberOfFLoorLabel = new Label();
            NumberOfFloorText = new TextBox();
            VillaPanel = new Panel();
            GarageLabel = new Label();
            GarageNoRadio = new RadioButton();
            GardenAreaLabel = new Label();
            GarageYesRadio = new RadioButton();
            GardenAreaText = new TextBox();
            BathroomsLabel = new Label();
            BathroomsText = new TextBox();
            BedroomsLabel = new Label();
            BedroomsText = new TextBox();
            LivingAreaLabel = new Label();
            LivingAreaText = new TextBox();
            InstitutionalPanel = new Panel();
            CommunalLabel = new Label();
            CommunalNoRadio = new RadioButton();
            UniversityPanel = new Panel();
            StudentCapLabel = new Label();
            StudentCapText = new TextBox();
            CommunalYesRadio = new RadioButton();
            SchoolPanel = new Panel();
            SchoolTypeCombo = new ComboBox();
            SchoolTypeLabel = new Label();
            SchoolNameLabel = new Label();
            SchoolNameText = new TextBox();
            HospitalPanel = new Panel();
            EmergencyLabel = new Label();
            EmergencyNoRadio = new RadioButton();
            HospitalLabel = new Label();
            EmergencyYesRadio = new RadioButton();
            HospitalNameText = new TextBox();
            MainPanel = new Panel();
            picBox = new PictureBox();
            addPicButton = new Button();
            label1 = new Label();
            idLabel = new Label();
            DescTextBox = new RichTextBox();
            CommercialPanel.SuspendLayout();
            WareHousePanel.SuspendLayout();
            ShopPanel.SuspendLayout();
            ResidentialPanel.SuspendLayout();
            ApartmentPanel.SuspendLayout();
            TownhousePanel.SuspendLayout();
            VillaPanel.SuspendLayout();
            InstitutionalPanel.SuspendLayout();
            UniversityPanel.SuspendLayout();
            SchoolPanel.SuspendLayout();
            HospitalPanel.SuspendLayout();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            SuspendLayout();
            // 
            // CategoryCombo
            // 
            CategoryCombo.FormattingEnabled = true;
            CategoryCombo.Items.AddRange(new object[] { "Residential", "Commercial", "Institutional" });
            CategoryCombo.Location = new Point(35, 344);
            CategoryCombo.Name = "CategoryCombo";
            CategoryCombo.Size = new Size(121, 23);
            CategoryCombo.TabIndex = 0;
            CategoryCombo.Text = " ";
            CategoryCombo.SelectedIndexChanged += CategoryCombo_SelectedIndexChanged;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CategoryLabel.Location = new Point(33, 326);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(93, 15);
            CategoryLabel.TabIndex = 1;
            CategoryLabel.Text = "Estate category";
            // 
            // LegalCombo
            // 
            LegalCombo.FormattingEnabled = true;
            LegalCombo.Items.AddRange(new object[] { "Ownership", "Rental", "Tenement" });
            LegalCombo.Location = new Point(35, 282);
            LegalCombo.Name = "LegalCombo";
            LegalCombo.Size = new Size(121, 23);
            LegalCombo.TabIndex = 2;
            // 
            // LegalLabel
            // 
            LegalLabel.AutoSize = true;
            LegalLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LegalLabel.Location = new Point(33, 264);
            LegalLabel.Name = "LegalLabel";
            LegalLabel.Size = new Size(68, 15);
            LegalLabel.TabIndex = 3;
            LegalLabel.Text = "Legal Form";
            // 
            // CountriesLabel
            // 
            CountriesLabel.AutoSize = true;
            CountriesLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CountriesLabel.Location = new Point(34, 209);
            CountriesLabel.Name = "CountriesLabel";
            CountriesLabel.Size = new Size(59, 15);
            CountriesLabel.TabIndex = 5;
            CountriesLabel.Text = "Country *";
            // 
            // CountriesCombo
            // 
            CountriesCombo.FormattingEnabled = true;
            CountriesCombo.Location = new Point(36, 228);
            CountriesCombo.Name = "CountriesCombo";
            CountriesCombo.Size = new Size(121, 23);
            CountriesCombo.TabIndex = 6;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            headerLabel.Location = new Point(25, 24);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(209, 45);
            headerLabel.TabIndex = 7;
            headerLabel.Text = "Estate editor";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(28, 705);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 9;
            AddButton.Text = "Add estate";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Enabled = false;
            DeleteButton.Location = new Point(607, 705);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 10;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditButton
            // 
            EditButton.Enabled = false;
            EditButton.Location = new Point(109, 705);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(125, 23);
            EditButton.TabIndex = 11;
            EditButton.Text = "Update current item";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // StreetText
            // 
            StreetText.BorderStyle = BorderStyle.FixedSingle;
            StreetText.Location = new Point(35, 129);
            StreetText.Name = "StreetText";
            StreetText.Size = new Size(223, 23);
            StreetText.TabIndex = 12;
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            streetLabel.Location = new Point(33, 111);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new Size(85, 15);
            streetLabel.TabIndex = 13;
            streetLabel.Text = "Street name *";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CityLabel.Location = new Point(33, 158);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(36, 15);
            CityLabel.TabIndex = 15;
            CityLabel.Text = "City *";
            // 
            // CityText
            // 
            CityText.BorderStyle = BorderStyle.FixedSingle;
            CityText.Location = new Point(35, 176);
            CityText.Name = "CityText";
            CityText.Size = new Size(100, 23);
            CityText.TabIndex = 14;
            // 
            // ZipLabel
            // 
            ZipLabel.AutoSize = true;
            ZipLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ZipLabel.Location = new Point(156, 158);
            ZipLabel.Name = "ZipLabel";
            ZipLabel.Size = new Size(63, 15);
            ZipLabel.TabIndex = 17;
            ZipLabel.Text = "Zip Code *";
            // 
            // ZipText
            // 
            ZipText.BorderStyle = BorderStyle.FixedSingle;
            ZipText.Location = new Point(158, 176);
            ZipText.Name = "ZipText";
            ZipText.Size = new Size(100, 23);
            ZipText.TabIndex = 16;
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TypeLabel.Location = new Point(188, 326);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(33, 15);
            TypeLabel.TabIndex = 19;
            TypeLabel.Text = "Type";
            // 
            // TypeCombo
            // 
            TypeCombo.Enabled = false;
            TypeCombo.FormattingEnabled = true;
            TypeCombo.Location = new Point(190, 344);
            TypeCombo.Name = "TypeCombo";
            TypeCombo.Size = new Size(121, 23);
            TypeCombo.TabIndex = 18;
            TypeCombo.SelectedIndexChanged += TypeCombo_SelectedIndexChanged;
            // 
            // CommercialPanel
            // 
            CommercialPanel.Controls.Add(WareHousePanel);
            CommercialPanel.Controls.Add(ShopPanel);
            CommercialPanel.Controls.Add(PropertyNameLabel);
            CommercialPanel.Controls.Add(PropertyNameText);
            CommercialPanel.Location = new Point(4, 3);
            CommercialPanel.Name = "CommercialPanel";
            CommercialPanel.Size = new Size(313, 216);
            CommercialPanel.TabIndex = 20;
            CommercialPanel.Visible = false;
            // 
            // WareHousePanel
            // 
            WareHousePanel.Controls.Add(LoadingDockLabel);
            WareHousePanel.Controls.Add(CeilingHeightText);
            WareHousePanel.Controls.Add(LoadingNoRadio);
            WareHousePanel.Controls.Add(CeilingHeightLabel);
            WareHousePanel.Controls.Add(LoadingYesRadio);
            WareHousePanel.Location = new Point(3, 50);
            WareHousePanel.Name = "WareHousePanel";
            WareHousePanel.Size = new Size(221, 116);
            WareHousePanel.TabIndex = 21;
            WareHousePanel.Visible = false;
            // 
            // LoadingDockLabel
            // 
            LoadingDockLabel.AutoSize = true;
            LoadingDockLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LoadingDockLabel.Location = new Point(6, 47);
            LoadingDockLabel.Name = "LoadingDockLabel";
            LoadingDockLabel.Size = new Size(100, 15);
            LoadingDockLabel.TabIndex = 26;
            LoadingDockLabel.Text = "Has loading dock";
            // 
            // CeilingHeightText
            // 
            CeilingHeightText.BorderStyle = BorderStyle.FixedSingle;
            CeilingHeightText.Location = new Point(8, 21);
            CeilingHeightText.Name = "CeilingHeightText";
            CeilingHeightText.Size = new Size(100, 23);
            CeilingHeightText.TabIndex = 22;
            // 
            // LoadingNoRadio
            // 
            LoadingNoRadio.AutoSize = true;
            LoadingNoRadio.Location = new Point(63, 66);
            LoadingNoRadio.Name = "LoadingNoRadio";
            LoadingNoRadio.Size = new Size(41, 19);
            LoadingNoRadio.TabIndex = 25;
            LoadingNoRadio.TabStop = true;
            LoadingNoRadio.Text = "No";
            LoadingNoRadio.UseVisualStyleBackColor = true;
            // 
            // CeilingHeightLabel
            // 
            CeilingHeightLabel.AutoSize = true;
            CeilingHeightLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CeilingHeightLabel.Location = new Point(6, 3);
            CeilingHeightLabel.Name = "CeilingHeightLabel";
            CeilingHeightLabel.Size = new Size(85, 15);
            CeilingHeightLabel.TabIndex = 23;
            CeilingHeightLabel.Text = "Ceiling Height";
            // 
            // LoadingYesRadio
            // 
            LoadingYesRadio.AutoSize = true;
            LoadingYesRadio.Location = new Point(12, 66);
            LoadingYesRadio.Name = "LoadingYesRadio";
            LoadingYesRadio.Size = new Size(42, 19);
            LoadingYesRadio.TabIndex = 24;
            LoadingYesRadio.TabStop = true;
            LoadingYesRadio.Text = "Yes";
            LoadingYesRadio.UseVisualStyleBackColor = true;
            // 
            // ShopPanel
            // 
            ShopPanel.Controls.Add(ParkingCapacityLabel);
            ShopPanel.Controls.Add(RetailSpaceLabel);
            ShopPanel.Controls.Add(ParkingCapacityText);
            ShopPanel.Controls.Add(RetailSpaceText);
            ShopPanel.Location = new Point(3, 49);
            ShopPanel.Name = "ShopPanel";
            ShopPanel.Size = new Size(229, 126);
            ShopPanel.TabIndex = 22;
            ShopPanel.Visible = false;
            // 
            // ParkingCapacityLabel
            // 
            ParkingCapacityLabel.AutoSize = true;
            ParkingCapacityLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ParkingCapacityLabel.Location = new Point(7, 61);
            ParkingCapacityLabel.Name = "ParkingCapacityLabel";
            ParkingCapacityLabel.Size = new Size(98, 15);
            ParkingCapacityLabel.TabIndex = 21;
            ParkingCapacityLabel.Text = "Parking Capacity";
            // 
            // RetailSpaceLabel
            // 
            RetailSpaceLabel.AutoSize = true;
            RetailSpaceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            RetailSpaceLabel.Location = new Point(7, 4);
            RetailSpaceLabel.Name = "RetailSpaceLabel";
            RetailSpaceLabel.Size = new Size(166, 15);
            RetailSpaceLabel.TabIndex = 19;
            RetailSpaceLabel.Text = "Retail Space (square meters)";
            // 
            // ParkingCapacityText
            // 
            ParkingCapacityText.BorderStyle = BorderStyle.FixedSingle;
            ParkingCapacityText.Location = new Point(7, 79);
            ParkingCapacityText.Name = "ParkingCapacityText";
            ParkingCapacityText.Size = new Size(100, 23);
            ParkingCapacityText.TabIndex = 20;
            // 
            // RetailSpaceText
            // 
            RetailSpaceText.BorderStyle = BorderStyle.FixedSingle;
            RetailSpaceText.Location = new Point(7, 22);
            RetailSpaceText.Name = "RetailSpaceText";
            RetailSpaceText.Size = new Size(100, 23);
            RetailSpaceText.TabIndex = 18;
            // 
            // PropertyNameLabel
            // 
            PropertyNameLabel.AutoSize = true;
            PropertyNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PropertyNameLabel.Location = new Point(8, 1);
            PropertyNameLabel.Name = "PropertyNameLabel";
            PropertyNameLabel.Size = new Size(92, 15);
            PropertyNameLabel.TabIndex = 17;
            PropertyNameLabel.Text = "Property Name";
            // 
            // PropertyNameText
            // 
            PropertyNameText.BorderStyle = BorderStyle.FixedSingle;
            PropertyNameText.Location = new Point(11, 20);
            PropertyNameText.Name = "PropertyNameText";
            PropertyNameText.Size = new Size(100, 23);
            PropertyNameText.TabIndex = 16;
            // 
            // ResidentialPanel
            // 
            ResidentialPanel.Controls.Add(ApartmentPanel);
            ResidentialPanel.Controls.Add(TownhousePanel);
            ResidentialPanel.Controls.Add(VillaPanel);
            ResidentialPanel.Controls.Add(BathroomsLabel);
            ResidentialPanel.Controls.Add(BathroomsText);
            ResidentialPanel.Controls.Add(BedroomsLabel);
            ResidentialPanel.Controls.Add(BedroomsText);
            ResidentialPanel.Controls.Add(LivingAreaLabel);
            ResidentialPanel.Controls.Add(LivingAreaText);
            ResidentialPanel.Location = new Point(3, 4);
            ResidentialPanel.Name = "ResidentialPanel";
            ResidentialPanel.Size = new Size(260, 307);
            ResidentialPanel.TabIndex = 21;
            ResidentialPanel.Visible = false;
            // 
            // ApartmentPanel
            // 
            ApartmentPanel.Controls.Add(ApartmentNumberLabel);
            ApartmentPanel.Controls.Add(ApartmentNumberText);
            ApartmentPanel.Controls.Add(FloorNumberLabel);
            ApartmentPanel.Controls.Add(FloorNumberText);
            ApartmentPanel.Location = new Point(1, 157);
            ApartmentPanel.Name = "ApartmentPanel";
            ApartmentPanel.Size = new Size(202, 130);
            ApartmentPanel.TabIndex = 31;
            ApartmentPanel.Visible = false;
            // 
            // ApartmentNumberLabel
            // 
            ApartmentNumberLabel.AutoSize = true;
            ApartmentNumberLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ApartmentNumberLabel.Location = new Point(8, 57);
            ApartmentNumberLabel.Name = "ApartmentNumberLabel";
            ApartmentNumberLabel.Size = new Size(115, 15);
            ApartmentNumberLabel.TabIndex = 28;
            ApartmentNumberLabel.Text = "Apartment number";
            // 
            // ApartmentNumberText
            // 
            ApartmentNumberText.BorderStyle = BorderStyle.FixedSingle;
            ApartmentNumberText.Location = new Point(10, 75);
            ApartmentNumberText.Name = "ApartmentNumberText";
            ApartmentNumberText.Size = new Size(52, 23);
            ApartmentNumberText.TabIndex = 27;
            // 
            // FloorNumberLabel
            // 
            FloorNumberLabel.AutoSize = true;
            FloorNumberLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FloorNumberLabel.Location = new Point(8, 3);
            FloorNumberLabel.Name = "FloorNumberLabel";
            FloorNumberLabel.Size = new Size(82, 15);
            FloorNumberLabel.TabIndex = 26;
            FloorNumberLabel.Text = "Floor number";
            // 
            // FloorNumberText
            // 
            FloorNumberText.BorderStyle = BorderStyle.FixedSingle;
            FloorNumberText.Location = new Point(10, 21);
            FloorNumberText.Name = "FloorNumberText";
            FloorNumberText.Size = new Size(52, 23);
            FloorNumberText.TabIndex = 25;
            // 
            // TownhousePanel
            // 
            TownhousePanel.Controls.Add(CommonAreaLabel);
            TownhousePanel.Controls.Add(CommonAreaText);
            TownhousePanel.Controls.Add(NumberOfFLoorLabel);
            TownhousePanel.Controls.Add(NumberOfFloorText);
            TownhousePanel.Location = new Point(1, 157);
            TownhousePanel.Name = "TownhousePanel";
            TownhousePanel.Size = new Size(202, 130);
            TownhousePanel.TabIndex = 30;
            TownhousePanel.Visible = false;
            // 
            // CommonAreaLabel
            // 
            CommonAreaLabel.AutoSize = true;
            CommonAreaLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CommonAreaLabel.Location = new Point(9, 57);
            CommonAreaLabel.Name = "CommonAreaLabel";
            CommonAreaLabel.Size = new Size(106, 15);
            CommonAreaLabel.TabIndex = 28;
            CommonAreaLabel.Text = "Common area fee";
            // 
            // CommonAreaText
            // 
            CommonAreaText.BorderStyle = BorderStyle.FixedSingle;
            CommonAreaText.Location = new Point(9, 75);
            CommonAreaText.Name = "CommonAreaText";
            CommonAreaText.Size = new Size(52, 23);
            CommonAreaText.TabIndex = 27;
            // 
            // NumberOfFLoorLabel
            // 
            NumberOfFLoorLabel.AutoSize = true;
            NumberOfFLoorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            NumberOfFLoorLabel.Location = new Point(9, 3);
            NumberOfFLoorLabel.Name = "NumberOfFLoorLabel";
            NumberOfFLoorLabel.Size = new Size(103, 15);
            NumberOfFLoorLabel.TabIndex = 26;
            NumberOfFLoorLabel.Text = "Number of floors";
            // 
            // NumberOfFloorText
            // 
            NumberOfFloorText.BorderStyle = BorderStyle.FixedSingle;
            NumberOfFloorText.Location = new Point(9, 21);
            NumberOfFloorText.Name = "NumberOfFloorText";
            NumberOfFloorText.Size = new Size(52, 23);
            NumberOfFloorText.TabIndex = 25;
            // 
            // VillaPanel
            // 
            VillaPanel.Controls.Add(GarageLabel);
            VillaPanel.Controls.Add(GarageNoRadio);
            VillaPanel.Controls.Add(GardenAreaLabel);
            VillaPanel.Controls.Add(GarageYesRadio);
            VillaPanel.Controls.Add(GardenAreaText);
            VillaPanel.Location = new Point(1, 157);
            VillaPanel.Name = "VillaPanel";
            VillaPanel.Size = new Size(202, 130);
            VillaPanel.TabIndex = 22;
            VillaPanel.Visible = false;
            // 
            // GarageLabel
            // 
            GarageLabel.AutoSize = true;
            GarageLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            GarageLabel.Location = new Point(9, 56);
            GarageLabel.Name = "GarageLabel";
            GarageLabel.Size = new Size(68, 15);
            GarageLabel.TabIndex = 29;
            GarageLabel.Text = "Has garage";
            // 
            // GarageNoRadio
            // 
            GarageNoRadio.AutoSize = true;
            GarageNoRadio.Location = new Point(64, 75);
            GarageNoRadio.Name = "GarageNoRadio";
            GarageNoRadio.Size = new Size(41, 19);
            GarageNoRadio.TabIndex = 28;
            GarageNoRadio.TabStop = true;
            GarageNoRadio.Text = "No";
            GarageNoRadio.UseVisualStyleBackColor = true;
            // 
            // GardenAreaLabel
            // 
            GardenAreaLabel.AutoSize = true;
            GardenAreaLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            GardenAreaLabel.Location = new Point(9, 3);
            GardenAreaLabel.Name = "GardenAreaLabel";
            GardenAreaLabel.Size = new Size(104, 15);
            GardenAreaLabel.TabIndex = 26;
            GardenAreaLabel.Text = "Garden area (m2)";
            // 
            // GarageYesRadio
            // 
            GarageYesRadio.AutoSize = true;
            GarageYesRadio.Location = new Point(13, 75);
            GarageYesRadio.Name = "GarageYesRadio";
            GarageYesRadio.Size = new Size(42, 19);
            GarageYesRadio.TabIndex = 27;
            GarageYesRadio.TabStop = true;
            GarageYesRadio.Text = "Yes";
            GarageYesRadio.UseVisualStyleBackColor = true;
            // 
            // GardenAreaText
            // 
            GardenAreaText.BorderStyle = BorderStyle.FixedSingle;
            GardenAreaText.Location = new Point(9, 21);
            GardenAreaText.Name = "GardenAreaText";
            GardenAreaText.Size = new Size(52, 23);
            GardenAreaText.TabIndex = 25;
            // 
            // BathroomsLabel
            // 
            BathroomsLabel.AutoSize = true;
            BathroomsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BathroomsLabel.Location = new Point(8, 105);
            BathroomsLabel.Name = "BathroomsLabel";
            BathroomsLabel.Size = new Size(131, 15);
            BathroomsLabel.TabIndex = 28;
            BathroomsLabel.Text = "Number of bathrooms";
            // 
            // BathroomsText
            // 
            BathroomsText.BorderStyle = BorderStyle.FixedSingle;
            BathroomsText.Location = new Point(10, 122);
            BathroomsText.Name = "BathroomsText";
            BathroomsText.Size = new Size(52, 23);
            BathroomsText.TabIndex = 27;
            // 
            // BedroomsLabel
            // 
            BedroomsLabel.AutoSize = true;
            BedroomsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BedroomsLabel.Location = new Point(8, 55);
            BedroomsLabel.Name = "BedroomsLabel";
            BedroomsLabel.Size = new Size(127, 15);
            BedroomsLabel.TabIndex = 26;
            BedroomsLabel.Text = "Number of bedrooms";
            // 
            // BedroomsText
            // 
            BedroomsText.BorderStyle = BorderStyle.FixedSingle;
            BedroomsText.Location = new Point(10, 73);
            BedroomsText.Name = "BedroomsText";
            BedroomsText.Size = new Size(52, 23);
            BedroomsText.TabIndex = 25;
            // 
            // LivingAreaLabel
            // 
            LivingAreaLabel.AutoSize = true;
            LivingAreaLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LivingAreaLabel.Location = new Point(8, 3);
            LivingAreaLabel.Name = "LivingAreaLabel";
            LivingAreaLabel.Size = new Size(96, 15);
            LivingAreaLabel.TabIndex = 24;
            LivingAreaLabel.Text = "Living area (m2)";
            // 
            // LivingAreaText
            // 
            LivingAreaText.BorderStyle = BorderStyle.FixedSingle;
            LivingAreaText.Location = new Point(10, 21);
            LivingAreaText.Name = "LivingAreaText";
            LivingAreaText.Size = new Size(52, 23);
            LivingAreaText.TabIndex = 23;
            // 
            // InstitutionalPanel
            // 
            InstitutionalPanel.Controls.Add(CommunalLabel);
            InstitutionalPanel.Controls.Add(CommunalNoRadio);
            InstitutionalPanel.Controls.Add(UniversityPanel);
            InstitutionalPanel.Controls.Add(CommunalYesRadio);
            InstitutionalPanel.Controls.Add(SchoolPanel);
            InstitutionalPanel.Controls.Add(HospitalPanel);
            InstitutionalPanel.Location = new Point(3, 3);
            InstitutionalPanel.Name = "InstitutionalPanel";
            InstitutionalPanel.Size = new Size(259, 225);
            InstitutionalPanel.TabIndex = 32;
            InstitutionalPanel.Visible = false;
            // 
            // CommunalLabel
            // 
            CommunalLabel.AutoSize = true;
            CommunalLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CommunalLabel.Location = new Point(6, 10);
            CommunalLabel.Name = "CommunalLabel";
            CommunalLabel.Size = new Size(77, 15);
            CommunalLabel.TabIndex = 32;
            CommunalLabel.Text = "Is communal";
            // 
            // CommunalNoRadio
            // 
            CommunalNoRadio.AutoSize = true;
            CommunalNoRadio.Location = new Point(61, 29);
            CommunalNoRadio.Name = "CommunalNoRadio";
            CommunalNoRadio.Size = new Size(41, 19);
            CommunalNoRadio.TabIndex = 31;
            CommunalNoRadio.TabStop = true;
            CommunalNoRadio.Text = "No";
            CommunalNoRadio.UseVisualStyleBackColor = true;
            // 
            // UniversityPanel
            // 
            UniversityPanel.Controls.Add(StudentCapLabel);
            UniversityPanel.Controls.Add(StudentCapText);
            UniversityPanel.Location = new Point(0, 59);
            UniversityPanel.Name = "UniversityPanel";
            UniversityPanel.Size = new Size(202, 130);
            UniversityPanel.TabIndex = 31;
            UniversityPanel.Visible = false;
            // 
            // StudentCapLabel
            // 
            StudentCapLabel.AutoSize = true;
            StudentCapLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            StudentCapLabel.Location = new Point(7, 5);
            StudentCapLabel.Name = "StudentCapLabel";
            StudentCapLabel.Size = new Size(100, 15);
            StudentCapLabel.TabIndex = 26;
            StudentCapLabel.Text = "Student capacity";
            // 
            // StudentCapText
            // 
            StudentCapText.BorderStyle = BorderStyle.FixedSingle;
            StudentCapText.Location = new Point(9, 23);
            StudentCapText.Name = "StudentCapText";
            StudentCapText.Size = new Size(52, 23);
            StudentCapText.TabIndex = 25;
            // 
            // CommunalYesRadio
            // 
            CommunalYesRadio.AutoSize = true;
            CommunalYesRadio.Location = new Point(10, 29);
            CommunalYesRadio.Name = "CommunalYesRadio";
            CommunalYesRadio.Size = new Size(42, 19);
            CommunalYesRadio.TabIndex = 30;
            CommunalYesRadio.TabStop = true;
            CommunalYesRadio.Text = "Yes";
            CommunalYesRadio.UseVisualStyleBackColor = true;
            // 
            // SchoolPanel
            // 
            SchoolPanel.Controls.Add(SchoolTypeCombo);
            SchoolPanel.Controls.Add(SchoolTypeLabel);
            SchoolPanel.Controls.Add(SchoolNameLabel);
            SchoolPanel.Controls.Add(SchoolNameText);
            SchoolPanel.Location = new Point(0, 59);
            SchoolPanel.Name = "SchoolPanel";
            SchoolPanel.Size = new Size(202, 128);
            SchoolPanel.TabIndex = 30;
            SchoolPanel.Visible = false;
            // 
            // SchoolTypeCombo
            // 
            SchoolTypeCombo.FormattingEnabled = true;
            SchoolTypeCombo.Items.AddRange(new object[] { "Preschool", "Elementary school", "Middle school", "High school" });
            SchoolTypeCombo.Location = new Point(10, 82);
            SchoolTypeCombo.Name = "SchoolTypeCombo";
            SchoolTypeCombo.Size = new Size(121, 23);
            SchoolTypeCombo.TabIndex = 29;
            // 
            // SchoolTypeLabel
            // 
            SchoolTypeLabel.AutoSize = true;
            SchoolTypeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SchoolTypeLabel.Location = new Point(8, 61);
            SchoolTypeLabel.Name = "SchoolTypeLabel";
            SchoolTypeLabel.Size = new Size(72, 15);
            SchoolTypeLabel.TabIndex = 28;
            SchoolTypeLabel.Text = "School type";
            // 
            // SchoolNameLabel
            // 
            SchoolNameLabel.AutoSize = true;
            SchoolNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SchoolNameLabel.Location = new Point(8, 7);
            SchoolNameLabel.Name = "SchoolNameLabel";
            SchoolNameLabel.Size = new Size(78, 15);
            SchoolNameLabel.TabIndex = 26;
            SchoolNameLabel.Text = "School name";
            // 
            // SchoolNameText
            // 
            SchoolNameText.BorderStyle = BorderStyle.FixedSingle;
            SchoolNameText.Location = new Point(10, 25);
            SchoolNameText.Name = "SchoolNameText";
            SchoolNameText.Size = new Size(52, 23);
            SchoolNameText.TabIndex = 25;
            // 
            // HospitalPanel
            // 
            HospitalPanel.Controls.Add(EmergencyLabel);
            HospitalPanel.Controls.Add(EmergencyNoRadio);
            HospitalPanel.Controls.Add(HospitalLabel);
            HospitalPanel.Controls.Add(EmergencyYesRadio);
            HospitalPanel.Controls.Add(HospitalNameText);
            HospitalPanel.Location = new Point(1, 59);
            HospitalPanel.Name = "HospitalPanel";
            HospitalPanel.Size = new Size(202, 130);
            HospitalPanel.TabIndex = 22;
            HospitalPanel.Visible = false;
            // 
            // EmergencyLabel
            // 
            EmergencyLabel.AutoSize = true;
            EmergencyLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EmergencyLabel.Location = new Point(6, 53);
            EmergencyLabel.Name = "EmergencyLabel";
            EmergencyLabel.Size = new Size(126, 15);
            EmergencyLabel.TabIndex = 29;
            EmergencyLabel.Text = "Has emergency room";
            // 
            // EmergencyNoRadio
            // 
            EmergencyNoRadio.AutoSize = true;
            EmergencyNoRadio.Location = new Point(61, 71);
            EmergencyNoRadio.Name = "EmergencyNoRadio";
            EmergencyNoRadio.Size = new Size(41, 19);
            EmergencyNoRadio.TabIndex = 28;
            EmergencyNoRadio.TabStop = true;
            EmergencyNoRadio.Text = "No";
            EmergencyNoRadio.UseVisualStyleBackColor = true;
            // 
            // HospitalLabel
            // 
            HospitalLabel.AutoSize = true;
            HospitalLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            HospitalLabel.Location = new Point(5, 7);
            HospitalLabel.Name = "HospitalLabel";
            HospitalLabel.Size = new Size(86, 15);
            HospitalLabel.TabIndex = 26;
            HospitalLabel.Text = "Hospital name";
            // 
            // EmergencyYesRadio
            // 
            EmergencyYesRadio.AutoSize = true;
            EmergencyYesRadio.Location = new Point(10, 71);
            EmergencyYesRadio.Name = "EmergencyYesRadio";
            EmergencyYesRadio.Size = new Size(42, 19);
            EmergencyYesRadio.TabIndex = 27;
            EmergencyYesRadio.TabStop = true;
            EmergencyYesRadio.Text = "Yes";
            EmergencyYesRadio.UseVisualStyleBackColor = true;
            // 
            // HospitalNameText
            // 
            HospitalNameText.BorderStyle = BorderStyle.FixedSingle;
            HospitalNameText.Location = new Point(8, 25);
            HospitalNameText.Name = "HospitalNameText";
            HospitalNameText.Size = new Size(52, 23);
            HospitalNameText.TabIndex = 25;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(InstitutionalPanel);
            MainPanel.Controls.Add(CommercialPanel);
            MainPanel.Controls.Add(ResidentialPanel);
            MainPanel.Location = new Point(25, 373);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(363, 326);
            MainPanel.TabIndex = 34;
            // 
            // picBox
            // 
            picBox.Location = new Point(368, 123);
            picBox.Name = "picBox";
            picBox.Size = new Size(252, 244);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            picBox.TabIndex = 35;
            picBox.TabStop = false;
            // 
            // addPicButton
            // 
            addPicButton.Location = new Point(368, 94);
            addPicButton.Name = "addPicButton";
            addPicButton.Size = new Size(105, 23);
            addPicButton.TabIndex = 36;
            addPicButton.Text = "Insert Picture";
            addPicButton.UseVisualStyleBackColor = true;
            addPicButton.Click += addPicButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 68);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 37;
            label1.Text = "Estate ID:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            idLabel.Location = new Point(97, 68);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(0, 15);
            idLabel.TabIndex = 38;
            // 
            // DescTextBox
            // 
            DescTextBox.Location = new Point(368, 344);
            DescTextBox.Name = "DescTextBox";
            DescTextBox.Size = new Size(236, 103);
            DescTextBox.TabIndex = 39;
            DescTextBox.Text = "";
            DescTextBox.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 747);
            Controls.Add(DescTextBox);
            Controls.Add(idLabel);
            Controls.Add(label1);
            Controls.Add(addPicButton);
            Controls.Add(picBox);
            Controls.Add(MainPanel);
            Controls.Add(TypeLabel);
            Controls.Add(TypeCombo);
            Controls.Add(ZipLabel);
            Controls.Add(ZipText);
            Controls.Add(CityLabel);
            Controls.Add(CityText);
            Controls.Add(streetLabel);
            Controls.Add(StreetText);
            Controls.Add(EditButton);
            Controls.Add(DeleteButton);
            Controls.Add(AddButton);
            Controls.Add(headerLabel);
            Controls.Add(CountriesCombo);
            Controls.Add(CountriesLabel);
            Controls.Add(LegalLabel);
            Controls.Add(LegalCombo);
            Controls.Add(CategoryLabel);
            Controls.Add(CategoryCombo);
            Name = "Form1";
            Text = "Modern Real Estates by Axel Collin";
            CommercialPanel.ResumeLayout(false);
            CommercialPanel.PerformLayout();
            WareHousePanel.ResumeLayout(false);
            WareHousePanel.PerformLayout();
            ShopPanel.ResumeLayout(false);
            ShopPanel.PerformLayout();
            ResidentialPanel.ResumeLayout(false);
            ResidentialPanel.PerformLayout();
            ApartmentPanel.ResumeLayout(false);
            ApartmentPanel.PerformLayout();
            TownhousePanel.ResumeLayout(false);
            TownhousePanel.PerformLayout();
            VillaPanel.ResumeLayout(false);
            VillaPanel.PerformLayout();
            InstitutionalPanel.ResumeLayout(false);
            InstitutionalPanel.PerformLayout();
            UniversityPanel.ResumeLayout(false);
            UniversityPanel.PerformLayout();
            SchoolPanel.ResumeLayout(false);
            SchoolPanel.PerformLayout();
            HospitalPanel.ResumeLayout(false);
            HospitalPanel.PerformLayout();
            MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CategoryCombo;
        private Label CategoryLabel;
        private ComboBox LegalCombo;
        private Label LegalLabel;
        private Label CountriesLabel;
        private ComboBox CountriesCombo;
        private Label headerLabel;
        private Button AddButton;
        private Button DeleteButton;
        private Button EditButton;
        private TextBox StreetText;
        private Label streetLabel;
        private Label CityLabel;
        private TextBox CityText;
        private Label ZipLabel;
        private TextBox ZipText;
        private Label TypeLabel;
        private ComboBox TypeCombo;
        private Panel CommercialPanel;
        private Panel WareHousePanel;
        private Panel ShopPanel;
        private Label PropertyNameLabel;
        private TextBox PropertyNameText;
        private Label RetailSpaceLabel;
        private TextBox RetailSpaceText;
        private Label ParkingCapacityLabel;
        private TextBox ParkingCapacityText;
        private Label LoadingDockLabel;
        private TextBox CeilingHeightText;
        private RadioButton LoadingNoRadio;
        private Label CeilingHeightLabel;
        private RadioButton LoadingYesRadio;
        private Panel ResidentialPanel;
        private Label BathroomsLabel;
        private TextBox BathroomsText;
        private Label BedroomsLabel;
        private TextBox BedroomsText;
        private Label LivingAreaLabel;
        private TextBox LivingAreaText;
        private Panel VillaPanel;
        private Label GarageLabel;
        private RadioButton GarageNoRadio;
        private Label GardenAreaLabel;
        private RadioButton GarageYesRadio;
        private TextBox GardenAreaText;
        private Panel TownhousePanel;
        private Label NumberOfFLoorLabel;
        private TextBox NumberOfFloorText;
        private Label CommonAreaLabel;
        private TextBox CommonAreaText;
        private Panel ApartmentPanel;
        private Label ApartmentNumberLabel;
        private TextBox ApartmentNumberText;
        private Label FloorNumberLabel;
        private TextBox FloorNumberText;
        private Panel InstitutionalPanel;
        private Label CommunalLabel;
        private RadioButton CommunalNoRadio;
        private Panel UniversityPanel;
        private Label StudentCapLabel;
        private TextBox StudentCapText;
        private RadioButton CommunalYesRadio;
        private Panel SchoolPanel;
        private Label SchoolTypeLabel;
        private Label SchoolNameLabel;
        private TextBox SchoolNameText;
        private Panel HospitalPanel;
        private Label EmergencyLabel;
        private RadioButton EmergencyNoRadio;
        private Label HospitalLabel;
        private RadioButton EmergencyYesRadio;
        private TextBox HospitalNameText;
        private ComboBox SchoolTypeCombo;
        private Panel MainPanel;
        private PictureBox picBox;
        private Button addPicButton;
        private Label label1;
        private Label idLabel;
        private RichTextBox DescTextBox;
    }
}