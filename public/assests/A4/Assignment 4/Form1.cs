namespace Assignment_4
{
    public partial class Form1 : Form
    {
        public enum Size
        {
            Small, Medium, Large
        }

        List<Order> Orderlist;

        public Form1()
        {
            Orderlist = new List<Order>();

            InitializeComponent();

            numQuantity.Minimum = 1;
            numQuantity.Maximum = 5;

            this.cmbSize.DataSource = Enum.GetNames(typeof(Size));

            this.rdbNonV.Checked = true;

            this.chkPepperoni.Checked = true;
            this.txtName.Text = "Neil";
            this.txtPhone.Text = "4161234567";
            this.cmbSize.SelectedIndex = 1;
            this.txtCoupon.Text = "";
            this.numQuantity.Value = 1;
        }

        private void btnSpecial_Click(object sender, EventArgs e)
        {
            cmbSize.SelectedItem = "Large";
            numQuantity.Value = 2;
            rdbNonV.Checked = true;
            txtCoupon.Text = "OFFERSPECIAL";
        }

        private void btnStartOver_Click(object sender, EventArgs e)
        {
            this.txtPhone.Text = "";
            this.txtName.Text = "";
            this.cmbSize.SelectedIndex = 0;

            this.rdbNonV.Checked = true;

            this.chkPepperoni.Checked = false;
            this.chkSausage.Checked = false;
            this.chkSteak.Checked = false;
            this.chkOlive.Checked = false;
            this.chkMushroom.Checked = false;
            this.chkPineapple.Checked = false;

            this.lblPhone.Text = "";
            this.lblName.Text = "";
            this.lblSize.Text = "";
            this.lblType.Text = "";
            this.lblTop.Text = "";
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Order currentOrder = new Order();

            if (String.IsNullOrEmpty(this.txtName.Text))
            {
                this.lblName.Text = "Name cannot be empty";
            }
            else
            {
                this.lblName.Text = this.txtName.Text;
                currentOrder.Name = this.txtName.Text;
            }

            if (String.IsNullOrEmpty(this.lblPhone.Text))
            {
                this.lblPhone.Text = "Please enter a phone number";
            }
            else
            {
                if (this.txtPhone.Text.Length == 10 && int.TryParse(this.txtPhone.Text, out int phone))
                {
                    this.lblPhone.Text = this.txtPhone.Text;
                    currentOrder.Phone = phone;
                }
                else if (this.txtPhone.Text.Length < 10)
                {
                    this.lblPhone.Text = "Phone number should be 10 digits";
                }
                else
                {
                    this.lblPhone.Text = "Please provide numeric input only";
                }

            }


            this.lblSize.Text = this.cmbSize.SelectedItem.ToString();
            currentOrder.Size = this.cmbSize.SelectedItem.ToString();

            if (this.rdbNonV.Checked)
            {
                this.lblType.Text = this.rdbNonV.Text;
                currentOrder.Type = this.rdbNonV.Text;
            }
            else if (this.rdbVeg.Checked)
            {
                this.lblType.Text = this.rdbVeg.Text;
                currentOrder.Type = this.rdbVeg.Text;
            }

            this.lblTop.Text = "";

            if (this.chkPepperoni.Checked)
            {
                this.lblTop.Text += this.chkPepperoni.Text + ", ";
            }

            if (this.chkSausage.Checked)
            {
                this.lblTop.Text += this.chkSausage.Text + ", ";
            }

            if (this.chkSteak.Checked)
            {
                this.lblTop.Text += this.chkSteak.Text + ", ";
            }

            if (this.chkOlive.Checked)
            {
                this.lblTop.Text += this.chkOlive.Text + ", ";
            }

            if (this.chkMushroom.Checked)
            {
                this.lblTop.Text += this.chkMushroom.Text + ", ";
            }

            if (this.chkPineapple.Checked)
            {
                this.lblTop.Text += this.chkPineapple.Text + ", ";
            }
            currentOrder.Toppings = this.lblTop.Text;


            if (String.IsNullOrEmpty(this.txtCoupon.Text))
            {
                this.lblCoupon.Text = "";
            }
            else
            {
                this.lblCoupon.Text = this.txtCoupon.Text;
                currentOrder.Coupon = this.txtCoupon.Text;
            }

            if (this.numQuantity.Value >= 1)
            {
                this.lblQuantity.Text = this.numQuantity.Value.ToString();
                currentOrder.Quantity = (int)this.numQuantity.Value;
            }
            else
            {
                this.lblQuantity.Text = "1";
                currentOrder.Quantity = 1;
            }

            double basePrice = 0;
            double toppingCharge = 0.33;
            double salesTaxRate = 0.13;

            if (currentOrder.Type == "Vegetarian")
            {
                switch (currentOrder.Size)
                {
                    case "Small":
                        basePrice = 5.99;
                        break;
                    case "Medium":
                        basePrice = 7.99;
                        break;
                    case "Large":
                        basePrice = 10.99;
                        break;
                    
                }
            }

            else if (currentOrder.Type == "Non-Vegetarian")
            {
                switch (currentOrder.Size)
                {
                    case "Small":
                        basePrice = 6.99;
                        break;
                    case "Medium":
                        basePrice = 8.99;
                        break;
                    case "Large":
                        basePrice = 12.99;
                        break;
                    
                }
            }

                double totalCost = (basePrice + currentOrder.Toppings.Split(',').Length * toppingCharge) * currentOrder.Quantity;
                    
                double salesTax = totalCost * salesTaxRate;
                
                lblTax.Text = $"${salesTax:F2}";
                lblTotal.Text = $"${totalCost + salesTax:F2}";
        }

            private void Form1_Load(object sender, EventArgs e)
            {

            }
        }
    }
