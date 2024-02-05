using System.Globalization;
using System.Windows.Forms;
using System.Data;
using System.ComponentModel;
using System.Collections;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clearing out all fields and image.
            textCountry.Clear();
            picCurrency.Image = null;
            labelCountry.Text = string.Empty;
        }

        private void btnUK_Click(object sender, EventArgs e)
        {
            //when you click Pounds, UK flag appears and culture info
            //is initiated for currency data. Used unicode to show currency symbol.
            double currency;

            CultureInfo cul = new CultureInfo("en-GB");

            currency = (Convert.ToDouble(textUS.Text)) * .64;
            picCurrency.Image = Properties.Resources.uk;
            textCountry.Text = currency.ToString("C2", cul);
            labelCountry.Text = "Pounds " + '\u0028' + '\u00a3' + '\u0029';
        }

        private void btnYen_Click(object sender, EventArgs e)
        {
            //when you click Pounds, UK flag appears and culture info
            //is initiated for currency data. Used unicode to show currency symbol.
            double currency;
            CultureInfo cul = new CultureInfo("ja-JP");

            currency = (Convert.ToDouble(textUS.Text)) * 146.38;
            labelCountry.Text = "Yen " + '\u0028' + '\u00a5' + '\u0029';
            textCountry.Text = currency.ToString("C2", cul);
            picCurrency.Image = Properties.Resources.japan;

        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            //when you click Pounds, UK flag appears and culture info
            //is initiated for currency data. Used unicode to show currency symbol.
            double currency;

            CultureInfo cul = new CultureInfo("en-CA");

            currency = (Convert.ToDouble(textUS.Text)) * 1.34;
            picCurrency.Image = Properties.Resources.canada;
            textCountry.Text = currency.ToString("C2", cul);
            labelCountry.Text = "Canadian " + '\u0028' + '\u0024' + '\u0029';
        }

        private void labelCountry_Click(object sender, EventArgs e)
        {

        }

        private void btnMarks_Click(object sender, EventArgs e)
        {
            //when you click Pounds, UK flag appears and culture info
            //is initiated for currency data. Used unicode to show currency symbol.
            double currency;

            CultureInfo cul = new CultureInfo("de-DE");

            currency = (Convert.ToDouble(textUS.Text)) * .92;
            picCurrency.Image = Properties.Resources.germany;
            textCountry.Text = currency.ToString("C2", cul);
            labelCountry.Text = "Euro " + '\u0028' + '\u20ac' + '\u0029';
        }

        private void btnFranc_Click(object sender, EventArgs e)
        {
            //when you click Pounds, UK flag appears and culture info
            //is initiated for currency data. Used unicode to show currency symbol.
            double currency;

            CultureInfo cul = new CultureInfo("fr-FR");

            currency = (Convert.ToDouble(textUS.Text)) * .92;
            picCurrency.Image = Properties.Resources.france;
            textCountry.Text = currency.ToString("C2", cul);
            labelCountry.Text = "Euro " + '\u0028' + '\u20ac' + '\u0029';
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //this button event will exit and close out app
            this.Close();
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            //the convert(||) button will take the input number for dollars
            //and calculate the new conversion

            string? flagFile = labelCountry.Text;


            string gotDenom = GetDenom(flagFile);

            double mulaRate = GetMulaRate(gotDenom);
            double userAmt = double.Parse(textUS.Text);
            double conversionAmt = userAmt * mulaRate;

            textCountry.Text = conversionAmt.ToString();


        }
        private double GetMulaRate(string denom)
        {
            //got familar with dictionary again for searching key/values.
            Dictionary<string, double> denomRates = new Dictionary<string, double>
            {
                {"USD", 1.0},
                { "EUR", 0.92},
                { "GBP", 0.64},
                { "YEN", 146.38},
                { "CAD", 1.34}

            };

            if (denomRates.ContainsKey(denom))
            {
                return denomRates[denom];
            }
            else
            {
                return 0.0;
            }
        }
        private static string GetDenom(string flagFile)
        {
            //grabbing the data from labelCountry will convert to country code
            //in order to get the rate and perform conversion again.
            Dictionary<string, string> denomMap = new Dictionary<string, string>
            {
                {"Dollars ", "USD" },
                {"Euro ", "EUR" },
                {"Pounds ", "GBP" },
                {"Yen ", "YEN" },
                {"Canadian ", "CAD" }
            };

            string denom = GetDenomFile(flagFile);

            if (denomMap.ContainsKey(denom))
            {
                return denomMap[denom];
            }
            else
            {
                return "";
            }
        }
        private static string GetDenomFile(string flagFile)
        {
            //this will read the string to the point of the first open parenthesis

            int fileIndex = flagFile.IndexOf('(');

            if (fileIndex >= 0)
            {
                return flagFile.Substring(0, fileIndex);
            }
            else
            {
                return "";
            }
        }

        private void textUS_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textUS.Text))
            {
                e.Cancel = true;
                textUS.Focus();
                errorProviderApp.SetError(textUS, "Cannot be left blank and needs to be a number!");
            }
            else

            {
                e.Cancel = false;
                errorProviderApp.SetError(textUS, "");
            }
        }

        
    }
}