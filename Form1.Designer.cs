namespace CurrencyConverter
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
            components = new System.ComponentModel.Container();
            picUS = new PictureBox();
            picCurrency = new PictureBox();
            labelUS = new Label();
            labelCountry = new Label();
            textUS = new TextBox();
            textCountry = new TextBox();
            btnUK = new Button();
            btnYen = new Button();
            btnCan = new Button();
            btnMarks = new Button();
            btnClear = new Button();
            btnExit = new Button();
            btnConvert = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            btnFranc = new Button();
            errorProviderApp = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)picUS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCurrency).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderApp).BeginInit();
            SuspendLayout();
            // 
            // picUS
            // 
            picUS.Image = Properties.Resources.usa;
            picUS.InitialImage = Properties.Resources.usa;
            picUS.Location = new Point(204, 79);
            picUS.Name = "picUS";
            picUS.Size = new Size(272, 148);
            picUS.SizeMode = PictureBoxSizeMode.StretchImage;
            picUS.TabIndex = 0;
            picUS.TabStop = false;
            // 
            // picCurrency
            // 
            picCurrency.Location = new Point(204, 263);
            picCurrency.Name = "picCurrency";
            picCurrency.Size = new Size(272, 157);
            picCurrency.SizeMode = PictureBoxSizeMode.StretchImage;
            picCurrency.TabIndex = 1;
            picCurrency.TabStop = false;
            // 
            // labelUS
            // 
            labelUS.AutoSize = true;
            labelUS.Location = new Point(559, 130);
            labelUS.Name = "labelUS";
            labelUS.Size = new Size(121, 32);
            labelUS.TabIndex = 2;
            labelUS.Text = "Dollars ($)";
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Location = new Point(559, 312);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(0, 32);
            labelCountry.TabIndex = 3;
            labelCountry.TextAlign = ContentAlignment.MiddleLeft;
            labelCountry.Click += labelCountry_Click;
            // 
            // textUS
            // 
            textUS.Location = new Point(793, 130);
            textUS.Name = "textUS";
            textUS.Size = new Size(202, 39);
            textUS.TabIndex = 4;
            textUS.Text = "1";
 //           textUS.Enter += textUS_Enter;
            textUS.Validating += textUS_Validating;
            // 
            // textCountry
            // 
            textCountry.Location = new Point(793, 321);
            textCountry.Name = "textCountry";
            textCountry.Size = new Size(200, 39);
            textCountry.TabIndex = 5;
            // 
            // btnUK
            // 
            btnUK.Location = new Point(70, 481);
            btnUK.Name = "btnUK";
            btnUK.Size = new Size(150, 46);
            btnUK.TabIndex = 6;
            btnUK.Text = "Pounds";
            btnUK.UseVisualStyleBackColor = true;
            btnUK.Click += btnUK_Click;
            // 
            // btnYen
            // 
            btnYen.Location = new Point(70, 594);
            btnYen.Name = "btnYen";
            btnYen.Size = new Size(150, 46);
            btnYen.TabIndex = 7;
            btnYen.Text = "Yen";
            btnYen.UseVisualStyleBackColor = true;
            btnYen.Click += btnYen_Click;
            // 
            // btnCan
            // 
            btnCan.Location = new Point(326, 481);
            btnCan.Name = "btnCan";
            btnCan.Size = new Size(150, 46);
            btnCan.TabIndex = 8;
            btnCan.Text = "Canadian";
            btnCan.UseVisualStyleBackColor = true;
            btnCan.Click += btnCan_Click;
            // 
            // btnMarks
            // 
            btnMarks.Location = new Point(326, 594);
            btnMarks.Name = "btnMarks";
            btnMarks.Size = new Size(150, 46);
            btnMarks.TabIndex = 9;
            btnMarks.Text = "Euros";
            btnMarks.UseVisualStyleBackColor = true;
            btnMarks.Click += btnMarks_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(793, 481);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 46);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(793, 584);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 46);
            btnExit.TabIndex = 12;
            btnExit.Text = "Close";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnConvert
            // 
            btnConvert.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnConvert.Location = new Point(815, 189);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(150, 103);
            btnConvert.TabIndex = 13;
            btnConvert.Text = "|  |";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.money;
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.money;
            pictureBox2.Location = new Point(0, 763);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.money;
            pictureBox3.Location = new Point(1078, 763);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 100);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.money;
            pictureBox4.Location = new Point(1078, 1);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 100);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // btnFranc
            // 
            btnFranc.Location = new Point(559, 481);
            btnFranc.Name = "btnFranc";
            btnFranc.Size = new Size(150, 46);
            btnFranc.TabIndex = 18;
            btnFranc.Text = "Francs";
            btnFranc.UseVisualStyleBackColor = true;
            btnFranc.Click += btnFranc_Click;
            // 
            // errorProviderApp
            // 
            errorProviderApp.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.world;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1177, 866);
            Controls.Add(btnFranc);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnConvert);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnMarks);
            Controls.Add(btnCan);
            Controls.Add(btnYen);
            Controls.Add(btnUK);
            Controls.Add(textCountry);
            Controls.Add(textUS);
            Controls.Add(labelCountry);
            Controls.Add(labelUS);
            Controls.Add(picCurrency);
            Controls.Add(picUS);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Currency Converter";
            ((System.ComponentModel.ISupportInitialize)picUS).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCurrency).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderApp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picUS;
        private PictureBox picCurrency;
        private Label labelUS;
        private Label labelCountry;
        private TextBox textUS;
        private TextBox textCountry;
        private Button btnUK;
        private Button btnYen;
        private Button btnCan;
        private Button btnMarks;
        private Button btnClear;
        private Button btnExit;
        private Button btnConvert;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button btnFranc;
        private ErrorProvider errorProviderApp;
    }
}
