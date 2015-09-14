using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sign_Service_Label_Products.Dealer.Pricing
{
    public partial class vinyl_pricing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFindPrice_Click(object sender, EventArgs e)
        {
            //======================================================================================================
            //Stock 1 Pricing
            //======================================================================================================

            //50 Quantity.
           
            Double Stock1_0_2_5SqIn_50Quantity = 145.00;
            Double Stock1_5_10SqIn_50Quantity = 150.00;
            Double Stock1_10_15SqIn_50Quantity = 155.00;
            Double Stock1_15_20SqIn_50Quantity = 160.00;
            Double Stock1_20_25SqIn_50Quantity = 170.00;
            Double Stock1_25_30SqIn_50Quantity = 175.00;
            //Color, 50 Quantity.
            Double Stock1Color_50Quantity = 60.00;
            
           


            //======================================================================================================
            //Lamination Pricing
            //======================================================================================================
            //Lamination price is the value of the dropdpwn items.********
            Double LaminationSetupCharge = 0.00;
            
            //Checking to see if the Lamination has been seleted, if so add Setup charge to the price.
            if(ddlLamination.SelectedValue == "0")
            {
                LaminationSetupCharge = 0.00;
            }
            else if (Convert.ToDouble(ddlLamination.SelectedValue) > 0)
            {
                //Lamination Setup Charge.
                LaminationSetupCharge = 20.00;
            }
            
            //Getting the number of colours
            Decimal NumberOfColors = Convert.ToDecimal(txtNumberOfColours.Text);
            //Calculating the price for the colors.
 

            //Calculating the Square Inches from the form values.
            Double SqIn = Convert.ToDouble(txtLabelHeight.Text) * Convert.ToDouble(txtLabelWidth.Text);



            //======================================================================================================
            //Stock 1
            //======================================================================================================

            //50 Quantity If Statement
            //======================================================================================================
            
            //Finding out if the stock is and show the price for that stock.
            if (ddlStock.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "50")
            {
                Double Subtotal = 0;

                 //Displaying the Subtotal.
                if(SqIn >= 0 && SqIn <=5)
                {
                    Subtotal = Stock1_0_5SqIn_50Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock1_5_10SqIn_50Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock1_10_15SqIn_50Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock1_15_20SqIn_50Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock1_20_25SqIn_50Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock1_25_30SqIn_50Quantity;
                }
                else if (SqIn >30.1)
                {
                    lblCustomQuoteMessage.Text = "Please call our sales desk for a <br /> custom quote. 1 800-787-2382!";
                }
                    //Calculating the price for the colors.
                    Double ColorPrice = Stock1Color_50Quantity * Convert.ToDouble(NumberOfColors);
                 
                    //Geting the Lamination price from form.
                    //Lamination price is the value of the dropdpwn items.
                    Double LaminationPrice = Convert.ToDouble(ddlLamination.SelectedValue);
          
 
                    //Calculating Lamination.
                    //Calculating the TotalSqIn
                    Double TotalSqIn = SqIn * Convert.ToDouble(ddlLabelQuantities.SelectedValue);
                    //Calculating the TotalLaminationPrice
                    Double TotalLaminationPrice = TotalSqIn * LaminationPrice;
                    //Calculating the TotalLaminationWithMinPrice
                    Double TotalLaminationWithMinPrice = TotalLaminationPrice + LaminationSetupCharge;
                    
                    //Displaying the Price of Lamination.
                    lblOverlamination.Text = "Overlamination:" + " " + "$" + TotalLaminationWithMinPrice.ToString();

                    //Caluclating the Total without Lamination.
                   Double TotalPricewithoutLamination = Subtotal + ColorPrice;

                    //Displaying the Subtotal.
                   lblPriceWithoutLamination.Text = "Total Price Without Lamination:" + " " + "$" + TotalPricewithoutLamination.ToString();

                    //Calculating the Total Cost.
                    Double Total = Subtotal + ColorPrice + TotalLaminationWithMinPrice;

                    //Displaying the Total Price.
                    lblTotal.Text = "Total Cost with Overlamination:" + " " + "$" + Total.ToString() + "*";
                    
            }
        }
    }
}