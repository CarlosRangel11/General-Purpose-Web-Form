using System.Text;

namespace Custom_Browser {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        // formats urls for more flexibility
        private async void URLButton_Click(object sender, EventArgs e) {
            string url = URLBox.Text;
            string[] commonExtensions = { ".com", ".org", ".net", ".edu", ".gov" };

            // Corrects url formatting
            if (!url.StartsWith("http://") && (!url.StartsWith("https://")))
                url = "https://" + url;
            if (!commonExtensions.Any(ext => url.EndsWith(ext, StringComparison.OrdinalIgnoreCase)))
                url += ".com";

            await WebBox.EnsureCoreWebView2Async();
            WebBox.CoreWebView2.Navigate(url);
        }

        // Changes font to Black when URLTextBox is clicked
        private void URLBox_TextChanged(object sender, EventArgs e) {
            URLBox.ForeColor = Color.Black;
        }

        private async void URLBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true;
                //same logic as the search button
                string url = URLBox.Text;
                string[] commonExtensions = { ".com", ".org", ".net", ".edu", ".gov" };

                // Corrects url formatting
                if (!url.StartsWith("http://") && (!url.StartsWith("https://")))
                    url = "https://" + url;
                if (!commonExtensions.Any(ext => url.EndsWith(ext, StringComparison.OrdinalIgnoreCase)))
                    url += ".com";

                await WebBox.EnsureCoreWebView2Async();
                WebBox.CoreWebView2.Navigate(url);
            }
        }

        // Clear ghost text in URLBox
        private void URLBox_click(object sender, EventArgs e) {
            URLBox.Text = string.Empty;
        }

        /// //////////////////////////////////////////////////////////////////////////////
        // ASU service that encrypts a piece of text, in this case the text
        // in the adjacent textbox
        private void EncryptionButton_Click(object sender, EventArgs e) {
            EncryptionService.ServiceClient encryptor = new EncryptionService.ServiceClient(EncryptionService.ServiceClient.EndpointConfiguration.BasicHttpsBinding_IService);

            EncryptionOutput.Text = $"Output: {encryptor.Encrypt(EncryptionTextBox.Text)}";
            EncryptionOutput.Visible = true;
        }

        static string CAPCHASolution;
        private void CAPCHAImageGetter(object sender, EventArgs e) {
            ImageVerifierService.ServiceClient image_verifier = new ImageVerifierService.ServiceClient(ImageVerifierService.ServiceClient.EndpointConfiguration.BasicHttpsBinding_IService);
            CAPCHASolution = image_verifier.GetVerifierString(CAPCHAStringLengthBox.Text);

            Stream imageStream = image_verifier.GetImage(CAPCHASolution);
            CAPCHABox.Image = Image.FromStream(imageStream);

            CAPCHABox.Visible = true;
            CAPCHALabel.Visible = true;
            CAPCHAInputBox.Visible = true;
            CAPCHAVerifyButton.Visible = true;
        }

        private void CAPCHAResult(object sender, EventArgs e) {
            if (CAPCHAInputBox.Text == CAPCHASolution)
                CAPCHAResultLabel.Text = "Correct!";
            else CAPCHAResultLabel.Text = "Incorrect.";
            CAPCHAResultLabel.Visible = true;
        }



        private void DropDown_SelectedIndexChanged(object sender, EventArgs e) {
            //this.Controls.Clear();
            int selectedMode = DropDownMenu.SelectedIndex;

            switch (selectedMode) {
                // Web Browser
                case 0:
                    URLBox.Visible = true;
                    URLButton.Visible = true;
                    WebBox.Visible = true;

                    // Add other window's items here to make invisible
                    EncryptionInputLabel.Visible = false;
                    EncryptionButton.Visible = false;
                    EncryptionTextBox.Visible = false;
                    EncryptionOutput.Visible = false;

                    CAPCHABox.Visible = false;
                    CAPCHALabel.Visible = false;
                    CAPCHAStringLengthBox.Visible = false;
                    CAPCHALengthLabel.Visible = false;
                    GetImageButton.Visible = false;

                    break;

                // Image Verifier
                case 1:
                    // Add relevant objects here to make visible
                    CAPCHAStringLengthBox.Visible = true;
                    CAPCHALengthLabel.Visible = true;
                    GetImageButton.Visible = true;

                    // Making other objects invisible
                    URLBox.Visible = false;
                    URLButton.Visible = false;
                    WebBox.Visible = false;

                    EncryptionInputLabel.Visible = false;
                    EncryptionButton.Visible = false;
                    EncryptionTextBox.Visible = false;
                    EncryptionOutput.Visible = false;

                    break;

                // EncryptionOutput
                case 2:
                    // Add relevant objects here to make visible
                    EncryptionInputLabel.Visible = true;
                    EncryptionButton.Visible = true;
                    EncryptionTextBox.Visible = true;


                    // Make other objects invisible
                    URLBox.Visible = false;
                    URLButton.Visible = false;
                    WebBox.Visible = false;

                    CAPCHABox.Visible = false;
                    CAPCHALabel.Visible = false;
                    CAPCHAStringLengthBox.Visible = false;
                    CAPCHALengthLabel.Visible = false;
                    GetImageButton.Visible = false;

                    break;
            }
            this.Controls.Add(URLBox);
        }
        // When the combobox is opened, expand to see all the different options
        private void DropDown_opened(object sender, EventArgs e) {
            DropDownMenu.DropDownWidth = 200;
        }

        //utility class used by the CAPCHA system to create a random string from valid characters
        private string GenerateRandomString() {
            const string validCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder result;
            Random random = new Random();

            if (int.Parse(CAPCHAStringLengthBox.Text) <= 0)
                result = new StringBuilder(4);
            else result = new StringBuilder(CAPCHAStringLengthBox.Text);

            for (int i = 0; i < int.Parse(CAPCHAStringLengthBox.Text); i++) {
                int index = random.Next(validCharacters.Length);
                result.Append(validCharacters[index]);
            }
            return result.ToString();
        }
    }
}