using System.Diagnostics;
using System.Runtime.InteropServices.JavaScript;
using ModernRealEstate.Estates;
using ModernRealEstate.Estates.Commercial;
using ModernRealEstate.Estates.Residential;
using ModernRealEstate.Estates;
using ModernRealEstate.Estates.Commercial;
using ModernRealEstate.Estates.Institutional;

namespace ModernRealEstate
{
    public partial class Form1 : Form
    {
        // Create Formcontroller to store current Estate
        FormController FormController = new FormController();

        public Form1()
        {
            InitializeComponent();
            // Populate combobobox for countries
            InitializeCountriesComboBox();


        }

        // Gets the countries from the enum and adds them to the combobox instead of manually adding them
        private void InitializeCountriesComboBox()
        {
            CountriesCombo.Items.AddRange(Enum.GetNames(typeof(Countries)));
        }


        // Handles changed estate category
        private void CategoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            String CategoryChosen = CategoryCombo.SelectedItem as String;
            TypeCombo.Items.Clear();
            TypeCombo.Text = "";
            TypeCombo.Enabled = true;
            ChangeCategoryPanels(CategoryChosen);

            // Make sure the specific type values are hidden again
            ShopPanel.Visible = false;
            WareHousePanel.Visible = false;
            HospitalPanel.Visible = false;
            SchoolPanel.Visible = false;
            UniversityPanel.Visible = false;
            VillaPanel.Visible = false;
            TownhousePanel.Visible = false;
            ApartmentPanel.Visible = false;


            //Add correct options to type combobox depending on category
            switch (CategoryChosen)
            {
                case "Residential":
                    TypeCombo.Items.Add("Villa");
                    TypeCombo.Items.Add("Apartment");
                    TypeCombo.Items.Add("Townhouse");
                    break;
                case "Commercial":
                    TypeCombo.Items.Add("Shop");
                    TypeCombo.Items.Add("Warehouse");
                    break;
                case "Institutional":
                    TypeCombo.Items.Add("Hospital");
                    TypeCombo.Items.Add("School");
                    TypeCombo.Items.Add("University");
                    break;
            }
        }

        // Updates GUI depending on current category
        private void ChangeCategoryPanels(String Category)
        {
            InstitutionalPanel.Visible = false;
            CommercialPanel.Visible = false;
            ResidentialPanel.Visible = false;
            // removes the data from now hidden controls
            ClearPanels(MainPanel);

            switch (Category)
            {
                case "Residential":
                    ResidentialPanel.Visible = true;
                    break;
                case "Commercial":
                    CommercialPanel.Visible = true;
                    break;
                case "Institutional":
                    InstitutionalPanel.Visible = true;
                    break;
            }
        }

        // Handles the GUI fields for different types of each category
        private void TypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            String TypeChosen = TypeCombo.SelectedItem as String;

            ShopPanel.Visible = false;
            WareHousePanel.Visible = false;
            HospitalPanel.Visible = false;
            SchoolPanel.Visible = false;
            UniversityPanel.Visible = false;
            VillaPanel.Visible = false;
            TownhousePanel.Visible = false;
            ApartmentPanel.Visible = false;

            // removes the data from now hidden controls
            ClearPanels(MainPanel);

            switch (TypeChosen)
            {
                case "Shop":
                    ShopPanel.Visible = true;
                    break;
                case "Warehouse":
                    WareHousePanel.Visible = true;
                    break;
                case "Hospital":
                    HospitalPanel.Visible = true;
                    break;
                case "School":
                    SchoolPanel.Visible = true;
                    break;
                case "University":
                    UniversityPanel.Visible = true;
                    break;
                case "Villa":
                    VillaPanel.Visible = true;
                    break;
                case "Townhouse":
                    TownhousePanel.Visible = true;
                    break;
                case "Apartment":
                    ApartmentPanel.Visible = true;
                    break;
            }

        }

        // recursive method to find all panels within the "main" panel and empty all of its controls
        public void ClearPanels(Panel panel)
        {
            foreach (Control c in panel.Controls)
            {
                if (c is TextBox textBox)
                {
                    textBox.Text = "";

                }
                else if (c is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }

                else if (c is Panel nextPanel)
                {
                    ClearPanels(nextPanel);
                }
            }
        }

        // Logic for adding a new object called when button is clicked
        private void AddButton_Click(object sender, EventArgs e)
        {
            String EstateType = TypeCombo.SelectedItem as String;

            // first check both generic and specific type fields depending on what estate type is chosen
            if (GenericFieldCheck() && SpecificFieldCheck(EstateType))
            {
                // create address item from the generic fields
                Address EstateAddress = new Address(StreetText.Text, ZipText.Text, CityText.Text, CountriesCombo.Text);
                Estate Estate = null;

                // Create the correct object types with all of their necessary constructor attributes
                switch (EstateType)
                {
                    case "Shop":
                        Estate = new Shop(EstateAddress, CategoryCombo.Text, LegalCombo.SelectedItem as String, PropertyNameText.Text, int.Parse(RetailSpaceText.Text), int.Parse(ParkingCapacityText.Text));
                        MessageBox.Show("Shop created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "Warehouse":
                        Boolean hasLoadingDock = LoadingYesRadio.Checked;
                        Estate = new Warehouse(EstateAddress, CategoryCombo.Text, LegalCombo.SelectedItem as String, PropertyNameText.Text, int.Parse(CeilingHeightText.Text), hasLoadingDock);
                        MessageBox.Show("Warehouse created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "Hospital":
                        Boolean communalHospital = CommunalYesRadio.Checked;
                        Boolean hasEmergency = EmergencyYesRadio.Checked;
                        Estate = new Hospital(EstateAddress, CategoryCombo.Text, LegalCombo.SelectedItem as String, communalHospital, HospitalNameText.Text, hasEmergency);
                        MessageBox.Show("Hospital created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "School":
                        Boolean isCommunalSchool = CommunalYesRadio.Checked;
                        Estate = new School(EstateAddress, CategoryCombo.Text, LegalCombo.SelectedItem as String, isCommunalSchool, SchoolNameText.Text, SchoolTypeCombo.SelectedItem as String);
                        MessageBox.Show("School created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "University":
                        Boolean isCommunalUni = CommunalYesRadio.Checked;
                        Estate = new University(EstateAddress, CategoryCombo.Text, LegalCombo.SelectedItem as String, isCommunalUni, int.Parse(StudentCapText.Text));
                        MessageBox.Show("University created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "Villa":
                        Boolean hasGarage = GarageYesRadio.Checked;
                        Estate = new Villa(EstateAddress, CategoryCombo.Text, LegalCombo.SelectedItem as String, int.Parse(LivingAreaText.Text), int.Parse(BedroomsText.Text), int.Parse(BathroomsText.Text), int.Parse(GardenAreaText.Text), hasGarage);
                        MessageBox.Show("Villa created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "Townhouse":
                        Estate = new Townhouse(EstateAddress, CategoryCombo.Text, LegalCombo.SelectedItem as String, int.Parse(LivingAreaText.Text),
                            int.Parse(BedroomsText.Text), int.Parse(BathroomsText.Text),
                            int.Parse(NumberOfFloorText.Text), int.Parse(CommonAreaText.Text));
                        MessageBox.Show("Townhouse created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "Apartment":
                        Estate = new Apartment(EstateAddress, CategoryCombo.Text, LegalCombo.SelectedItem as String, int.Parse(LivingAreaText.Text),
                            int.Parse(BedroomsText.Text), int.Parse(BathroomsText.Text),
                            int.Parse(FloorNumberText.Text), int.Parse(ApartmentNumberText.Text));
                        MessageBox.Show("Apartment created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        MessageBox.Show("Pick an estate type and enter the additonal info");
                        return;
                }

                // On creation success we add object to formcontroller (just so I can access it, will probably be added to collection later)
                // enables some elements like buttons that can only be used on an "active" object
                // Shows textbox with description, this is mostly to test the abstract method I created and also to verify objects can be updated
                FormController.CurrentEstate = Estate;
                DeleteButton.Enabled = true;
                EditButton.Enabled = true;
                idLabel.Text = Estate.Id.ToString();
                DescTextBox.Visible = true;
                DescTextBox.Text = Estate.CreateDescription();
            }
        }

        // Generic fields check
        private Boolean GenericFieldCheck()
        {
            if (!string.IsNullOrEmpty(StreetText.Text) &&
                !string.IsNullOrEmpty(CityText.Text) &&
                !string.IsNullOrEmpty(ZipText.Text) &&
                !string.IsNullOrEmpty(CountriesCombo.Text) &&
                !string.IsNullOrEmpty(LegalCombo.Text) &&
                !string.IsNullOrEmpty(TypeCombo.Text)
                )
            {
                return true;
            }
            else
            {
                MessageBox.Show("Missing required data", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        // Check/verify specific fields 
        private Boolean SpecificFieldCheck(String EstateType)
        {
            switch (EstateType)
            {
                case "Shop":
                    if (!string.IsNullOrEmpty(PropertyNameText.Text) &&
                        int.TryParse(RetailSpaceText.Text, out int retailSpace) &&
                        int.TryParse(ParkingCapacityText.Text, out int parkingCapacity)
                       )
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Some shop data is invalid or missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                    break;
                case "Warehouse":
                    if (!string.IsNullOrEmpty(PropertyNameText.Text) &&
                        int.TryParse(CeilingHeightText.Text, out int ceilingHeight) &&
                        ((LoadingYesRadio.Checked) || (LoadingNoRadio.Checked))
                       )
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Some warehouse data is invalid or missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                    break;
                case "Hospital":
                    if (((CommunalYesRadio.Checked) || (CommunalNoRadio.Checked)) &&
                        !string.IsNullOrEmpty(HospitalNameText.Text) &&
                        ((EmergencyYesRadio.Checked) || (EmergencyNoRadio.Checked)))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Some hospital data is invalid or missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                    break;
                case "School":
                    if (((CommunalYesRadio.Checked) || (CommunalNoRadio.Checked)) &&
                        !string.IsNullOrEmpty(SchoolNameText.Text) &&
                        !string.IsNullOrEmpty(SchoolTypeCombo.SelectedItem as String))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Some school data is invalid or missinga", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                    break;
                case "University":
                    if (((CommunalYesRadio.Checked) || (CommunalNoRadio.Checked)) &&
                        int.TryParse(StudentCapText.Text, out int studentCap))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Some university data is invalid or missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                    break;
                case "Villa":
                    if (int.TryParse(LivingAreaText.Text, out int vLivingArea) &&
                        int.TryParse(BedroomsText.Text, out int vNoBedrooms) &&
                        int.TryParse(BathroomsText.Text, out int vNoBathrooms) &&
                        int.TryParse(GardenAreaText.Text, out int vGardenSize) &&
                        ((GarageYesRadio.Checked) || (GarageNoRadio.Checked))
                       )
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Some villa data is invalid or missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                    break;
                case "Townhouse":
                    if (int.TryParse(LivingAreaText.Text, out int tLivingArea) &&
                        int.TryParse(BedroomsText.Text, out int tNoBedrooms) &&
                        int.TryParse(BathroomsText.Text, out int tNoBathrooms) &&
                        int.TryParse(NumberOfFloorText.Text, out int NoFloors) &&
                        int.TryParse(CommonAreaText.Text, out int commonFee)
                       )
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Some townhouse data is invalid or missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                    break;
                case "Apartment":
                    if (int.TryParse(LivingAreaText.Text, out int aLivingArea) &&
                        int.TryParse(BedroomsText.Text, out int aNoBedrooms) &&
                        int.TryParse(BathroomsText.Text, out int aNoBathrooms) &&
                        int.TryParse(FloorNumberText.Text, out int FloorNo) &&
                        int.TryParse(ApartmentNumberText.Text, out int aNumber)
                       )
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Some apartment data is invalid or missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                    break;
                default:
                    return false;
            }
        }

        // Method to update the generic info of an object
        public void UpdateGenerics(Estate CurrEstate)
        {
            Address updatedAddress = new Address(StreetText.Text, ZipText.Text, CityText.Text,
                CountriesCombo.SelectedItem as String);
            CurrEstate.EstateAddress = updatedAddress;
            CurrEstate.Category = CategoryCombo.SelectedItem as String;
            CurrEstate.LegalForm = LegalCombo.SelectedItem as String;
        }

        // Method to update the category bound fields
        public void UpdateCategoryFields(Estate CurrEstate)
        {
            switch (CurrEstate)
            {
                case Residential residential:
                    residential.SquareFootage = int.Parse(LivingAreaText.Text);
                    residential.NumberOfBedrooms = int.Parse(BedroomsText.Text);
                    residential.NumberOfBathrooms = int.Parse(BathroomsText.Text);
                    break;
                case Institutional institutional:
                    institutional.IsCommunal = CommunalYesRadio.Checked;
                    break;
                case Commercial commercial:
                    commercial.PropertyName = PropertyNameText.Text;
                    break;
            }
        }

        // Method to update the type specific fields 
        public void UpdateTypeFields(Estate CurrEstate)
        {
            switch (CurrEstate)
            {
                case Shop shop:
                    shop.RetailSpace = int.Parse(RetailSpaceText.Text);
                    shop.ParkingCapacity = int.Parse(ParkingCapacityText.Text);
                    break;
                case Warehouse warehouse:
                    warehouse.CeilingHeight = int.Parse(CeilingHeightText.Text);
                    warehouse.HasLoadingDock = LoadingYesRadio.Checked;
                    break;
                case Villa villa:
                    villa.GardenArea = int.Parse(GardenAreaText.Text);
                    villa.HasGarage = GarageYesRadio.Checked;
                    break;
                case Townhouse townhouse:
                    townhouse.NumberOfFloors = int.Parse(NumberOfFloorText.Text);
                    townhouse.CommonAreaFee = int.Parse(CommonAreaText.Text);
                    break;
                case Apartment apartment:
                    apartment.ApartmentNumber = int.Parse(ApartmentNumberText.Text);
                    apartment.FloorNumber = int.Parse(FloorNumberText.Text);
                    break;
                case School school:
                    school.SchoolName = SchoolNameText.Text;
                    school.SchoolType = SchoolTypeCombo.SelectedItem as String;
                    break;
                case University university:
                    university.StudentCapacity = int.Parse(StudentCapText.Text);
                    break;
                case Hospital hospital:
                    hospital.HospitalName = HospitalNameText.Text;
                    hospital.HasEmergencyRoom = EmergencyYesRadio.Checked;
                    break;
            }
        }

        // delete and rebuild the form
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            FormController.CurrentEstate = null;
            this.Controls.Clear();
            InitializeComponent();
            InitializeCountriesComboBox();
            MessageBox.Show("Item deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // Handler for edit button, calls the different update methods and updates description textbox
        private void EditButton_Click(object sender, EventArgs e)
        {
            Estate CurrEstate = FormController.CurrentEstate;
            UpdateGenerics(CurrEstate);
            UpdateCategoryFields(CurrEstate);
            UpdateTypeFields(CurrEstate);
            MessageBox.Show("Item Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DescTextBox.Text = CurrEstate.CreateDescription();
        }

        // Simple picture insert, not bound to the object in any way (yet?)
        private void addPicButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file's path
                    string selectedFilePath = openFileDialog.FileName;

                    // Display the selected image in the PictureBox
                    picBox.Image = Image.FromFile(selectedFilePath);
                }
            }
        }
    }
}