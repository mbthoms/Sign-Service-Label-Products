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
            Double Stock1_0_5SqIn_50Quantity = 145.00;
            Double Stock1_5_10SqIn_50Quantity = 150.00;
            Double Stock1_10_15SqIn_50Quantity = 155.00;
            Double Stock1_15_20SqIn_50Quantity = 160.00;
            Double Stock1_20_25SqIn_50Quantity = 170.00;
            Double Stock1_25_30SqIn_50Quantity = 175.00;
            //Color, 50 Quantity.
            Double Stock1Color_50Quantity = 60.00;
            
            //100 Quantity.
            Double Stock1_0_5SqIn_100Quantity = 155.00;
            Double Stock1_5_10SqIn_100Quantity = 160.00;
            Double Stock1_10_15SqIn_100Quantity = 170.00;
            Double Stock1_15_20SqIn_100Quantity = 175.00;
            Double Stock1_20_25SqIn_100Quantity = 185.00;
            Double Stock1_25_30SqIn_100Quantity = 190.00;
            //Color, 100 Quantity.
            Double Stock1Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock1_0_5SqIn_250Quantity = 170.00;
            Double Stock1_5_10SqIn_250Quantity = 180.00;
            Double Stock1_10_15SqIn_250Quantity = 195.00;
            Double Stock1_15_20SqIn_250Quantity = 200.00;
            Double Stock1_20_25SqIn_250Quantity = 205.00;
            Double Stock1_25_30SqIn_250Quantity = 210.00;
            //Color, 250 Quantity.
            Double Stock1Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock1_0_5SqIn_500Quantity = 190.00;
            Double Stock1_5_10SqIn_500Quantity = 200.00;
            Double Stock1_10_15SqIn_500Quantity = 215.00;
            Double Stock1_15_20SqIn_500Quantity = 235.00;
            Double Stock1_20_25SqIn_500Quantity = 245.00;
            Double Stock1_25_30SqIn_500Quantity = 265.00;
            //Color, 500 Quantity.
            Double Stock1Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock1_0_5SqIn_1000Quantity = 225.00;
            Double Stock1_5_10SqIn_1000Quantity = 250.00;
            Double Stock1_10_15SqIn_1000Quantity = 280.00;
            Double Stock1_15_20SqIn_1000Quantity = 305.00;
            Double Stock1_20_25SqIn_1000Quantity = 340.00;
            Double Stock1_25_30SqIn_1000Quantity = 380.00;
            //Color, 1000 Quantity.
            Double Stock1Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock1_0_5SqIn_2000Quantity = 265.00;
            Double Stock1_5_10SqIn_2000Quantity = 335.00;
            Double Stock1_10_15SqIn_2000Quantity = 410.00;
            Double Stock1_15_20SqIn_2000Quantity = 495.00;
            Double Stock1_20_25SqIn_2000Quantity = 550.00;
            Double Stock1_25_30SqIn_2000Quantity = 610.00;
            //Color, 2000 Quantity.
            Double Stock1Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock1_0_5SqIn_2500Quantity = 285.00;
            Double Stock1_5_10SqIn_2500Quantity = 380.00;
            Double Stock1_10_15SqIn_2500Quantity = 475.00;
            Double Stock1_15_20SqIn_2500Quantity = 590.00;
            Double Stock1_20_25SqIn_2500Quantity = 655.00;
            Double Stock1_25_30SqIn_2500Quantity = 725.00;
            //Color, 2500 Quantity.
            Double Stock1Color_2500Quantity = 115.00;


            //======================================================================================================
            //Stock 2 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock2_0_5SqIn_50Quantity = 145.00;
            Double Stock2_5_10SqIn_50Quantity = 150.00;
            Double Stock2_10_15SqIn_50Quantity = 155.00;
            Double Stock2_15_20SqIn_50Quantity = 160.00;
            Double Stock2_20_25SqIn_50Quantity = 170.00;
            Double Stock2_25_30SqIn_50Quantity = 175.00;
            //Color, 50 Quantity.
            Double Stock2Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock2_0_5SqIn_100Quantity = 155.00;
            Double Stock2_5_10SqIn_100Quantity = 160.00;
            Double Stock2_10_15SqIn_100Quantity = 170.00;
            Double Stock2_15_20SqIn_100Quantity = 175.00;
            Double Stock2_20_25SqIn_100Quantity = 185.00;
            Double Stock2_25_30SqIn_100Quantity = 190.00;
            //Color, 100 Quantity.
            Double Stock2Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock2_0_5SqIn_250Quantity = 170.00;
            Double Stock2_5_10SqIn_250Quantity = 180.00;
            Double Stock2_10_15SqIn_250Quantity = 195.00;
            Double Stock2_15_20SqIn_250Quantity = 200.00;
            Double Stock2_20_25SqIn_250Quantity = 205.00;
            Double Stock2_25_30SqIn_250Quantity = 210.00;
            //Color, 250 Quantity.
            Double Stock2Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock2_0_5SqIn_500Quantity = 190.00;
            Double Stock2_5_10SqIn_500Quantity = 200.00;
            Double Stock2_10_15SqIn_500Quantity = 215.00;
            Double Stock2_15_20SqIn_500Quantity = 235.00;
            Double Stock2_20_25SqIn_500Quantity = 245.00;
            Double Stock2_25_30SqIn_500Quantity = 265.00;
            //Color, 500 Quantity.
            Double Stock2Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock2_0_5SqIn_1000Quantity = 225.00;
            Double Stock2_5_10SqIn_1000Quantity = 250.00;
            Double Stock2_10_15SqIn_1000Quantity = 280.00;
            Double Stock2_15_20SqIn_1000Quantity = 305.00;
            Double Stock2_20_25SqIn_1000Quantity = 340.00;
            Double Stock2_25_30SqIn_1000Quantity = 380.00;
            //Color, 1000 Quantity.
            Double Stock2Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock2_0_5SqIn_2000Quantity = 265.00;
            Double Stock2_5_10SqIn_2000Quantity = 335.00;
            Double Stock2_10_15SqIn_2000Quantity = 410.00;
            Double Stock2_15_20SqIn_2000Quantity = 495.00;
            Double Stock2_20_25SqIn_2000Quantity = 550.00;
            Double Stock2_25_30SqIn_2000Quantity = 610.00;
            //Color, 2000 Quantity.
            Double Stock2Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock2_0_5SqIn_2500Quantity = 285.00;
            Double Stock2_5_10SqIn_2500Quantity = 380.00;
            Double Stock2_10_15SqIn_2500Quantity = 475.00;
            Double Stock2_15_20SqIn_2500Quantity = 590.00;
            Double Stock2_20_25SqIn_2500Quantity = 655.00;
            Double Stock2_25_30SqIn_2500Quantity = 725.00;
            //Color, 2500 Quantity.
            Double Stock2Color_2500Quantity = 115.00;


            //======================================================================================================
            //Stock 3 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock3_0_5SqIn_50Quantity = 145.00;
            Double Stock3_5_10SqIn_50Quantity = 150.00;
            Double Stock3_10_15SqIn_50Quantity = 155.00;
            Double Stock3_15_20SqIn_50Quantity = 160.00;
            Double Stock3_20_25SqIn_50Quantity = 170.00;
            Double Stock3_25_30SqIn_50Quantity = 175.00;
            //Color, 50 Quantity.
            Double Stock3Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock3_0_5SqIn_100Quantity = 155.00;
            Double Stock3_5_10SqIn_100Quantity = 160.00;
            Double Stock3_10_15SqIn_100Quantity = 170.00;
            Double Stock3_15_20SqIn_100Quantity = 175.00;
            Double Stock3_20_25SqIn_100Quantity = 185.00;
            Double Stock3_25_30SqIn_100Quantity = 190.00;
            //Color, 100 Quantity.
            Double Stock3Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock3_0_5SqIn_250Quantity = 170.00;
            Double Stock3_5_10SqIn_250Quantity = 180.00;
            Double Stock3_10_15SqIn_250Quantity = 195.00;
            Double Stock3_15_20SqIn_250Quantity = 200.00;
            Double Stock3_20_25SqIn_250Quantity = 205.00;
            Double Stock3_25_30SqIn_250Quantity = 210.00;
            //Color, 250 Quantity.
            Double Stock3Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock3_0_5SqIn_500Quantity = 190.00;
            Double Stock3_5_10SqIn_500Quantity = 200.00;
            Double Stock3_10_15SqIn_500Quantity = 215.00;
            Double Stock3_15_20SqIn_500Quantity = 235.00;
            Double Stock3_20_25SqIn_500Quantity = 245.00;
            Double Stock3_25_30SqIn_500Quantity = 265.00;
            //Color, 500 Quantity.
            Double Stock3Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock3_0_5SqIn_1000Quantity = 225.00;
            Double Stock3_5_10SqIn_1000Quantity = 250.00;
            Double Stock3_10_15SqIn_1000Quantity = 280.00;
            Double Stock3_15_20SqIn_1000Quantity = 305.00;
            Double Stock3_20_25SqIn_1000Quantity = 340.00;
            Double Stock3_25_30SqIn_1000Quantity = 380.00;
            //Color, 1000 Quantity.
            Double Stock3Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock3_0_5SqIn_2000Quantity = 265.00;
            Double Stock3_5_10SqIn_2000Quantity = 335.00;
            Double Stock3_10_15SqIn_2000Quantity = 410.00;
            Double Stock3_15_20SqIn_2000Quantity = 495.00;
            Double Stock3_20_25SqIn_2000Quantity = 550.00;
            Double Stock3_25_30SqIn_2000Quantity = 610.00;
            //Color, 2000 Quantity.
            Double Stock3Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock3_0_5SqIn_2500Quantity = 285.00;
            Double Stock3_5_10SqIn_2500Quantity = 380.00;
            Double Stock3_10_15SqIn_2500Quantity = 475.00;
            Double Stock3_15_20SqIn_2500Quantity = 590.00;
            Double Stock3_20_25SqIn_2500Quantity = 655.00;
            Double Stock3_25_30SqIn_2500Quantity = 725.00;
            //Color, 2500 Quantity.
            Double Stock3Color_2500Quantity = 115.00;


            //======================================================================================================
            //Stock 4 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock4_0_5SqIn_50Quantity = 145.00;
            Double Stock4_5_10SqIn_50Quantity = 150.00;
            Double Stock4_10_15SqIn_50Quantity = 155.00;
            Double Stock4_15_20SqIn_50Quantity = 160.00;
            Double Stock4_20_25SqIn_50Quantity = 170.00;
            Double Stock4_25_30SqIn_50Quantity = 175.00;
            //Color, 50 Quantity.
            Double Stock4Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock4_0_5SqIn_100Quantity = 155.00;
            Double Stock4_5_10SqIn_100Quantity = 160.00;
            Double Stock4_10_15SqIn_100Quantity = 170.00;
            Double Stock4_15_20SqIn_100Quantity = 175.00;
            Double Stock4_20_25SqIn_100Quantity = 185.00;
            Double Stock4_25_30SqIn_100Quantity = 190.00;
            //Color, 100 Quantity.
            Double Stock4Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock4_0_5SqIn_250Quantity = 170.00;
            Double Stock4_5_10SqIn_250Quantity = 180.00;
            Double Stock4_10_15SqIn_250Quantity = 195.00;
            Double Stock4_15_20SqIn_250Quantity = 200.00;
            Double Stock4_20_25SqIn_250Quantity = 205.00;
            Double Stock4_25_30SqIn_250Quantity = 210.00;
            //Color, 250 Quantity.
            Double Stock4Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock4_0_5SqIn_500Quantity = 190.00;
            Double Stock4_5_10SqIn_500Quantity = 200.00;
            Double Stock4_10_15SqIn_500Quantity = 215.00;
            Double Stock4_15_20SqIn_500Quantity = 235.00;
            Double Stock4_20_25SqIn_500Quantity = 245.00;
            Double Stock4_25_30SqIn_500Quantity = 265.00;
            //Color, 500 Quantity.
            Double Stock4Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock4_0_5SqIn_1000Quantity = 225.00;
            Double Stock4_5_10SqIn_1000Quantity = 250.00;
            Double Stock4_10_15SqIn_1000Quantity = 280.00;
            Double Stock4_15_20SqIn_1000Quantity = 305.00;
            Double Stock4_20_25SqIn_1000Quantity = 340.00;
            Double Stock4_25_30SqIn_1000Quantity = 380.00;
            //Color, 1000 Quantity.
            Double Stock4Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock4_0_5SqIn_2000Quantity = 265.00;
            Double Stock4_5_10SqIn_2000Quantity = 335.00;
            Double Stock4_10_15SqIn_2000Quantity = 410.00;
            Double Stock4_15_20SqIn_2000Quantity = 495.00;
            Double Stock4_20_25SqIn_2000Quantity = 550.00;
            Double Stock4_25_30SqIn_2000Quantity = 610.00;
            //Color, 2000 Quantity.
            Double Stock4Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock4_0_5SqIn_2500Quantity = 285.00;
            Double Stock4_5_10SqIn_2500Quantity = 380.00;
            Double Stock4_10_15SqIn_2500Quantity = 475.00;
            Double Stock4_15_20SqIn_2500Quantity = 590.00;
            Double Stock4_20_25SqIn_2500Quantity = 655.00;
            Double Stock4_25_30SqIn_2500Quantity = 725.00;
            //Color, 2500 Quantity.
            Double Stock4Color_2500Quantity = 115.00;


            //======================================================================================================
            //Stock 5 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock5_0_5SqIn_50Quantity = 145.00;
            Double Stock5_5_10SqIn_50Quantity = 150.00;
            Double Stock5_10_15SqIn_50Quantity = 155.00;
            Double Stock5_15_20SqIn_50Quantity = 160.00;
            Double Stock5_20_25SqIn_50Quantity = 170.00;
            Double Stock5_25_30SqIn_50Quantity = 175.00;
            //Color, 50 Quantity.
            Double Stock5Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock5_0_5SqIn_100Quantity = 155.00;
            Double Stock5_5_10SqIn_100Quantity = 160.00;
            Double Stock5_10_15SqIn_100Quantity = 170.00;
            Double Stock5_15_20SqIn_100Quantity = 175.00;
            Double Stock5_20_25SqIn_100Quantity = 185.00;
            Double Stock5_25_30SqIn_100Quantity = 190.00;
            //Color, 100 Quantity.
            Double Stock5Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock5_0_5SqIn_250Quantity = 170.00;
            Double Stock5_5_10SqIn_250Quantity = 180.00;
            Double Stock5_10_15SqIn_250Quantity = 195.00;
            Double Stock5_15_20SqIn_250Quantity = 200.00;
            Double Stock5_20_25SqIn_250Quantity = 205.00;
            Double Stock5_25_30SqIn_250Quantity = 210.00;
            //Color, 250 Quantity.
            Double Stock5Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock5_0_5SqIn_500Quantity = 190.00;
            Double Stock5_5_10SqIn_500Quantity = 200.00;
            Double Stock5_10_15SqIn_500Quantity = 215.00;
            Double Stock5_15_20SqIn_500Quantity = 235.00;
            Double Stock5_20_25SqIn_500Quantity = 245.00;
            Double Stock5_25_30SqIn_500Quantity = 265.00;
            //Color, 500 Quantity.
            Double Stock5Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock5_0_5SqIn_1000Quantity = 225.00;
            Double Stock5_5_10SqIn_1000Quantity = 250.00;
            Double Stock5_10_15SqIn_1000Quantity = 280.00;
            Double Stock5_15_20SqIn_1000Quantity = 305.00;
            Double Stock5_20_25SqIn_1000Quantity = 340.00;
            Double Stock5_25_30SqIn_1000Quantity = 380.00;
            //Color, 1000 Quantity.
            Double Stock5Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock5_0_5SqIn_2000Quantity = 265.00;
            Double Stock5_5_10SqIn_2000Quantity = 335.00;
            Double Stock5_10_15SqIn_2000Quantity = 410.00;
            Double Stock5_15_20SqIn_2000Quantity = 495.00;
            Double Stock5_20_25SqIn_2000Quantity = 550.00;
            Double Stock5_25_30SqIn_2000Quantity = 610.00;
            //Color, 2000 Quantity.
            Double Stock5Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock5_0_5SqIn_2500Quantity = 285.00;
            Double Stock5_5_10SqIn_2500Quantity = 380.00;
            Double Stock5_10_15SqIn_2500Quantity = 475.00;
            Double Stock5_15_20SqIn_2500Quantity = 590.00;
            Double Stock5_20_25SqIn_2500Quantity = 655.00;
            Double Stock5_25_30SqIn_2500Quantity = 725.00;
            //Color, 2500 Quantity.
            Double Stock5Color_2500Quantity = 115.00;


            //======================================================================================================
            //Stock 6 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock6_0_5SqIn_50Quantity = 145.00;
            Double Stock6_5_10SqIn_50Quantity = 150.00;
            Double Stock6_10_15SqIn_50Quantity = 155.00;
            Double Stock6_15_20SqIn_50Quantity = 160.00;
            Double Stock6_20_25SqIn_50Quantity = 170.00;
            Double Stock6_25_30SqIn_50Quantity = 175.00;
            //Color, 50 Quantity.
            Double Stock6Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock6_0_5SqIn_100Quantity = 155.00;
            Double Stock6_5_10SqIn_100Quantity = 160.00;
            Double Stock6_10_15SqIn_100Quantity = 170.00;
            Double Stock6_15_20SqIn_100Quantity = 175.00;
            Double Stock6_20_25SqIn_100Quantity = 185.00;
            Double Stock6_25_30SqIn_100Quantity = 190.00;
            //Color, 100 Quantity.
            Double Stock6Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock6_0_5SqIn_250Quantity = 170.00;
            Double Stock6_5_10SqIn_250Quantity = 180.00;
            Double Stock6_10_15SqIn_250Quantity = 195.00;
            Double Stock6_15_20SqIn_250Quantity = 200.00;
            Double Stock6_20_25SqIn_250Quantity = 205.00;
            Double Stock6_25_30SqIn_250Quantity = 210.00;
            //Color, 250 Quantity.
            Double Stock6Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock6_0_5SqIn_500Quantity = 190.00;
            Double Stock6_5_10SqIn_500Quantity = 200.00;
            Double Stock6_10_15SqIn_500Quantity = 215.00;
            Double Stock6_15_20SqIn_500Quantity = 235.00;
            Double Stock6_20_25SqIn_500Quantity = 245.00;
            Double Stock6_25_30SqIn_500Quantity = 265.00;
            //Color, 500 Quantity.
            Double Stock6Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock6_0_5SqIn_1000Quantity = 225.00;
            Double Stock6_5_10SqIn_1000Quantity = 250.00;
            Double Stock6_10_15SqIn_1000Quantity = 280.00;
            Double Stock6_15_20SqIn_1000Quantity = 305.00;
            Double Stock6_20_25SqIn_1000Quantity = 340.00;
            Double Stock6_25_30SqIn_1000Quantity = 380.00;
            //Color, 1000 Quantity.
            Double Stock6Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock6_0_5SqIn_2000Quantity = 265.00;
            Double Stock6_5_10SqIn_2000Quantity = 335.00;
            Double Stock6_10_15SqIn_2000Quantity = 410.00;
            Double Stock6_15_20SqIn_2000Quantity = 495.00;
            Double Stock6_20_25SqIn_2000Quantity = 550.00;
            Double Stock6_25_30SqIn_2000Quantity = 610.00;
            //Color, 2000 Quantity.
            Double Stock6Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock6_0_5SqIn_2500Quantity = 285.00;
            Double Stock6_5_10SqIn_2500Quantity = 380.00;
            Double Stock6_10_15SqIn_2500Quantity = 475.00;
            Double Stock6_15_20SqIn_2500Quantity = 590.00;
            Double Stock6_20_25SqIn_2500Quantity = 655.00;
            Double Stock6_25_30SqIn_2500Quantity = 725.00;
            //Color, 2500 Quantity.
            Double Stock6Color_2500Quantity = 115.00;


            //======================================================================================================
            //Stock 7 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock7_0_5SqIn_50Quantity = 145.00;
            Double Stock7_5_10SqIn_50Quantity = 150.00;
            Double Stock7_10_15SqIn_50Quantity = 155.00;
            Double Stock7_15_20SqIn_50Quantity = 160.00;
            Double Stock7_20_25SqIn_50Quantity = 170.00;
            Double Stock7_25_30SqIn_50Quantity = 175.00;
            //Color, 50 Quantity.
            Double Stock7Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock7_0_5SqIn_100Quantity = 155.00;
            Double Stock7_5_10SqIn_100Quantity = 160.00;
            Double Stock7_10_15SqIn_100Quantity = 170.00;
            Double Stock7_15_20SqIn_100Quantity = 175.00;
            Double Stock7_20_25SqIn_100Quantity = 185.00;
            Double Stock7_25_30SqIn_100Quantity = 190.00;
            //Color, 100 Quantity.
            Double Stock7Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock7_0_5SqIn_250Quantity = 170.00;
            Double Stock7_5_10SqIn_250Quantity = 180.00;
            Double Stock7_10_15SqIn_250Quantity = 195.00;
            Double Stock7_15_20SqIn_250Quantity = 200.00;
            Double Stock7_20_25SqIn_250Quantity = 205.00;
            Double Stock7_25_30SqIn_250Quantity = 210.00;
            //Color, 250 Quantity.
            Double Stock7Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock7_0_5SqIn_500Quantity = 190.00;
            Double Stock7_5_10SqIn_500Quantity = 200.00;
            Double Stock7_10_15SqIn_500Quantity = 215.00;
            Double Stock7_15_20SqIn_500Quantity = 235.00;
            Double Stock7_20_25SqIn_500Quantity = 245.00;
            Double Stock7_25_30SqIn_500Quantity = 265.00;
            //Color, 500 Quantity.
            Double Stock7Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock7_0_5SqIn_1000Quantity = 225.00;
            Double Stock7_5_10SqIn_1000Quantity = 250.00;
            Double Stock7_10_15SqIn_1000Quantity = 280.00;
            Double Stock7_15_20SqIn_1000Quantity = 305.00;
            Double Stock7_20_25SqIn_1000Quantity = 340.00;
            Double Stock7_25_30SqIn_1000Quantity = 380.00;
            //Color, 1000 Quantity.
            Double Stock7Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock7_0_5SqIn_2000Quantity = 265.00;
            Double Stock7_5_10SqIn_2000Quantity = 335.00;
            Double Stock7_10_15SqIn_2000Quantity = 410.00;
            Double Stock7_15_20SqIn_2000Quantity = 495.00;
            Double Stock7_20_25SqIn_2000Quantity = 550.00;
            Double Stock7_25_30SqIn_2000Quantity = 610.00;
            //Color, 2000 Quantity.
            Double Stock7Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock7_0_5SqIn_2500Quantity = 285.00;
            Double Stock7_5_10SqIn_2500Quantity = 380.00;
            Double Stock7_10_15SqIn_2500Quantity = 475.00;
            Double Stock7_15_20SqIn_2500Quantity = 590.00;
            Double Stock7_20_25SqIn_2500Quantity = 655.00;
            Double Stock7_25_30SqIn_2500Quantity = 725.00;
            //Color, 2500 Quantity.
            Double Stock7Color_2500Quantity = 115.00;


            //======================================================================================================
            //Stock 8 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock8_0_5SqIn_50Quantity = 145.00;
            Double Stock8_5_10SqIn_50Quantity = 150.00;
            Double Stock8_10_15SqIn_50Quantity = 155.00;
            Double Stock8_15_20SqIn_50Quantity = 160.00;
            Double Stock8_20_25SqIn_50Quantity = 170.00;
            Double Stock8_25_30SqIn_50Quantity = 175.00;
            //Color, 50 Quantity.
            Double Stock8Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock8_0_5SqIn_100Quantity = 155.00;
            Double Stock8_5_10SqIn_100Quantity = 160.00;
            Double Stock8_10_15SqIn_100Quantity = 170.00;
            Double Stock8_15_20SqIn_100Quantity = 175.00;
            Double Stock8_20_25SqIn_100Quantity = 185.00;
            Double Stock8_25_30SqIn_100Quantity = 190.00;
            //Color, 100 Quantity.
            Double Stock8Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock8_0_5SqIn_250Quantity = 170.00;
            Double Stock8_5_10SqIn_250Quantity = 180.00;
            Double Stock8_10_15SqIn_250Quantity = 195.00;
            Double Stock8_15_20SqIn_250Quantity = 200.00;
            Double Stock8_20_25SqIn_250Quantity = 205.00;
            Double Stock8_25_30SqIn_250Quantity = 210.00;
            //Color, 250 Quantity.
            Double Stock8Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock8_0_5SqIn_500Quantity = 190.00;
            Double Stock8_5_10SqIn_500Quantity = 200.00;
            Double Stock8_10_15SqIn_500Quantity = 215.00;
            Double Stock8_15_20SqIn_500Quantity = 235.00;
            Double Stock8_20_25SqIn_500Quantity = 245.00;
            Double Stock8_25_30SqIn_500Quantity = 265.00;
            //Color, 500 Quantity.
            Double Stock8Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock8_0_5SqIn_1000Quantity = 225.00;
            Double Stock8_5_10SqIn_1000Quantity = 250.00;
            Double Stock8_10_15SqIn_1000Quantity = 280.00;
            Double Stock8_15_20SqIn_1000Quantity = 305.00;
            Double Stock8_20_25SqIn_1000Quantity = 340.00;
            Double Stock8_25_30SqIn_1000Quantity = 380.00;
            //Color, 1000 Quantity.
            Double Stock8Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock8_0_5SqIn_2000Quantity = 265.00;
            Double Stock8_5_10SqIn_2000Quantity = 335.00;
            Double Stock8_10_15SqIn_2000Quantity = 410.00;
            Double Stock8_15_20SqIn_2000Quantity = 495.00;
            Double Stock8_20_25SqIn_2000Quantity = 550.00;
            Double Stock8_25_30SqIn_2000Quantity = 610.00;
            //Color, 2000 Quantity.
            Double Stock8Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock8_0_5SqIn_2500Quantity = 285.00;
            Double Stock8_5_10SqIn_2500Quantity = 380.00;
            Double Stock8_10_15SqIn_2500Quantity = 475.00;
            Double Stock8_15_20SqIn_2500Quantity = 590.00;
            Double Stock8_20_25SqIn_2500Quantity = 655.00;
            Double Stock8_25_30SqIn_2500Quantity = 725.00;
            //Color, 2500 Quantity.
            Double Stock8Color_2500Quantity = 115.00;


            //======================================================================================================
            //Stock 9 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock9_0_5SqIn_50Quantity = 145.00;
            Double Stock9_5_10SqIn_50Quantity = 150.00;
            Double Stock9_10_15SqIn_50Quantity = 155.00;
            Double Stock9_15_20SqIn_50Quantity = 160.00;
            Double Stock9_20_25SqIn_50Quantity = 170.00;
            Double Stock9_25_30SqIn_50Quantity = 175.00;
            //Color, 50 Quantity.
            Double Stock9Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock9_0_5SqIn_100Quantity = 155.00;
            Double Stock9_5_10SqIn_100Quantity = 160.00;
            Double Stock9_10_15SqIn_100Quantity = 170.00;
            Double Stock9_15_20SqIn_100Quantity = 175.00;
            Double Stock9_20_25SqIn_100Quantity = 185.00;
            Double Stock9_25_30SqIn_100Quantity = 190.00;
            //Color, 100 Quantity.
            Double Stock9Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock9_0_5SqIn_250Quantity = 170.00;
            Double Stock9_5_10SqIn_250Quantity = 180.00;
            Double Stock9_10_15SqIn_250Quantity = 195.00;
            Double Stock9_15_20SqIn_250Quantity = 200.00;
            Double Stock9_20_25SqIn_250Quantity = 205.00;
            Double Stock9_25_30SqIn_250Quantity = 210.00;
            //Color, 250 Quantity.
            Double Stock9Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock9_0_5SqIn_500Quantity = 190.00;
            Double Stock9_5_10SqIn_500Quantity = 200.00;
            Double Stock9_10_15SqIn_500Quantity = 215.00;
            Double Stock9_15_20SqIn_500Quantity = 235.00;
            Double Stock9_20_25SqIn_500Quantity = 245.00;
            Double Stock9_25_30SqIn_500Quantity = 265.00;
            //Color, 500 Quantity.
            Double Stock9Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock9_0_5SqIn_1000Quantity = 225.00;
            Double Stock9_5_10SqIn_1000Quantity = 250.00;
            Double Stock9_10_15SqIn_1000Quantity = 280.00;
            Double Stock9_15_20SqIn_1000Quantity = 305.00;
            Double Stock9_20_25SqIn_1000Quantity = 340.00;
            Double Stock9_25_30SqIn_1000Quantity = 380.00;
            //Color, 1000 Quantity.
            Double Stock9Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock9_0_5SqIn_2000Quantity = 265.00;
            Double Stock9_5_10SqIn_2000Quantity = 335.00;
            Double Stock9_10_15SqIn_2000Quantity = 410.00;
            Double Stock9_15_20SqIn_2000Quantity = 495.00;
            Double Stock9_20_25SqIn_2000Quantity = 550.00;
            Double Stock9_25_30SqIn_2000Quantity = 610.00;
            //Color, 2000 Quantity.
            Double Stock9Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock9_0_5SqIn_2500Quantity = 285.00;
            Double Stock9_5_10SqIn_2500Quantity = 380.00;
            Double Stock9_10_15SqIn_2500Quantity = 475.00;
            Double Stock9_15_20SqIn_2500Quantity = 590.00;
            Double Stock9_20_25SqIn_2500Quantity = 655.00;
            Double Stock9_25_30SqIn_2500Quantity = 725.00;
            //Color, 2500 Quantity.
            Double Stock9Color_2500Quantity = 115.00;


            //======================================================================================================
            //Stock 10 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock10_0_5SqIn_50Quantity = 145.00;
            Double Stock10_5_10SqIn_50Quantity = 150.00;
            Double Stock10_10_15SqIn_50Quantity = 155.00;
            Double Stock10_15_20SqIn_50Quantity = 160.00;
            Double Stock10_20_25SqIn_50Quantity = 170.00;
            Double Stock10_25_30SqIn_50Quantity = 175.00;
            //Color, 50 Quantity.
            Double Stock10Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock10_0_5SqIn_100Quantity = 155.00;
            Double Stock10_5_10SqIn_100Quantity = 160.00;
            Double Stock10_10_15SqIn_100Quantity = 170.00;
            Double Stock10_15_20SqIn_100Quantity = 175.00;
            Double Stock10_20_25SqIn_100Quantity = 185.00;
            Double Stock10_25_30SqIn_100Quantity = 190.00;
            //Color, 100 Quantity.
            Double Stock10Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock10_0_5SqIn_250Quantity = 170.00;
            Double Stock10_5_10SqIn_250Quantity = 180.00;
            Double Stock10_10_15SqIn_250Quantity = 195.00;
            Double Stock10_15_20SqIn_250Quantity = 200.00;
            Double Stock10_20_25SqIn_250Quantity = 205.00;
            Double Stock10_25_30SqIn_250Quantity = 210.00;
            //Color, 250 Quantity.
            Double Stock10Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock10_0_5SqIn_500Quantity = 190.00;
            Double Stock10_5_10SqIn_500Quantity = 200.00;
            Double Stock10_10_15SqIn_500Quantity = 215.00;
            Double Stock10_15_20SqIn_500Quantity = 235.00;
            Double Stock10_20_25SqIn_500Quantity = 245.00;
            Double Stock10_25_30SqIn_500Quantity = 265.00;
            //Color, 500 Quantity.
            Double Stock10Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock10_0_5SqIn_1000Quantity = 225.00;
            Double Stock10_5_10SqIn_1000Quantity = 250.00;
            Double Stock10_10_15SqIn_1000Quantity = 280.00;
            Double Stock10_15_20SqIn_1000Quantity = 305.00;
            Double Stock10_20_25SqIn_1000Quantity = 340.00;
            Double Stock10_25_30SqIn_1000Quantity = 380.00;
            //Color, 1000 Quantity.
            Double Stock10Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock10_0_5SqIn_2000Quantity = 265.00;
            Double Stock10_5_10SqIn_2000Quantity = 335.00;
            Double Stock10_10_15SqIn_2000Quantity = 410.00;
            Double Stock10_15_20SqIn_2000Quantity = 495.00;
            Double Stock10_20_25SqIn_2000Quantity = 550.00;
            Double Stock10_25_30SqIn_2000Quantity = 610.00;
            //Color, 2000 Quantity.
            Double Stock10Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock10_0_5SqIn_2500Quantity = 285.00;
            Double Stock10_5_10SqIn_2500Quantity = 380.00;
            Double Stock10_10_15SqIn_2500Quantity = 475.00;
            Double Stock10_15_20SqIn_2500Quantity = 590.00;
            Double Stock10_20_25SqIn_2500Quantity = 655.00;
            Double Stock10_25_30SqIn_2500Quantity = 725.00;
            //Color, 2500 Quantity.
            Double Stock10Color_2500Quantity = 115.00;


            //======================================================================================================
            //Stock 11 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock11_0_5SqIn_50Quantity = 145.00;
            Double Stock11_5_10SqIn_50Quantity = 150.00;
            Double Stock11_10_15SqIn_50Quantity = 155.00;
            Double Stock11_15_20SqIn_50Quantity = 160.00;
            Double Stock11_20_25SqIn_50Quantity = 170.00;
            Double Stock11_25_30SqIn_50Quantity = 175.00;
            //Color, 50 Quantity.
            Double Stock11Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock11_0_5SqIn_100Quantity = 155.00;
            Double Stock11_5_10SqIn_100Quantity = 160.00;
            Double Stock11_10_15SqIn_100Quantity = 170.00;
            Double Stock11_15_20SqIn_100Quantity = 175.00;
            Double Stock11_20_25SqIn_100Quantity = 185.00;
            Double Stock11_25_30SqIn_100Quantity = 190.00;
            //Color, 100 Quantity.
            Double Stock11Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock11_0_5SqIn_250Quantity = 170.00;
            Double Stock11_5_10SqIn_250Quantity = 180.00;
            Double Stock11_10_15SqIn_250Quantity = 195.00;
            Double Stock11_15_20SqIn_250Quantity = 200.00;
            Double Stock11_20_25SqIn_250Quantity = 205.00;
            Double Stock11_25_30SqIn_250Quantity = 210.00;
            //Color, 250 Quantity.
            Double Stock11Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock11_0_5SqIn_500Quantity = 190.00;
            Double Stock11_5_10SqIn_500Quantity = 200.00;
            Double Stock11_10_15SqIn_500Quantity = 215.00;
            Double Stock11_15_20SqIn_500Quantity = 235.00;
            Double Stock11_20_25SqIn_500Quantity = 245.00;
            Double Stock11_25_30SqIn_500Quantity = 265.00;
            //Color, 500 Quantity.
            Double Stock11Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock11_0_5SqIn_1000Quantity = 225.00;
            Double Stock11_5_10SqIn_1000Quantity = 250.00;
            Double Stock11_10_15SqIn_1000Quantity = 280.00;
            Double Stock11_15_20SqIn_1000Quantity = 305.00;
            Double Stock11_20_25SqIn_1000Quantity = 340.00;
            Double Stock11_25_30SqIn_1000Quantity = 380.00;
            //Color, 1000 Quantity.
            Double Stock11Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock11_0_5SqIn_2000Quantity = 265.00;
            Double Stock11_5_10SqIn_2000Quantity = 335.00;
            Double Stock11_10_15SqIn_2000Quantity = 410.00;
            Double Stock11_15_20SqIn_2000Quantity = 495.00;
            Double Stock11_20_25SqIn_2000Quantity = 550.00;
            Double Stock11_25_30SqIn_2000Quantity = 610.00;
            //Color, 2000 Quantity.
            Double Stock11Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock11_0_5SqIn_2500Quantity = 285.00;
            Double Stock11_5_10SqIn_2500Quantity = 380.00;
            Double Stock11_10_15SqIn_2500Quantity = 475.00;
            Double Stock11_15_20SqIn_2500Quantity = 590.00;
            Double Stock11_20_25SqIn_2500Quantity = 655.00;
            Double Stock11_25_30SqIn_2500Quantity = 725.00;
            //Color, 2500 Quantity.
            Double Stock11Color_2500Quantity = 115.00;


            //======================================================================================================
            //Stock 12 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock12_0_5SqIn_50Quantity = 145.00;
            Double Stock12_5_10SqIn_50Quantity = 150.00;
            Double Stock12_10_15SqIn_50Quantity = 155.00;
            Double Stock12_15_20SqIn_50Quantity = 160.00;
            Double Stock12_20_25SqIn_50Quantity = 170.00;
            Double Stock12_25_30SqIn_50Quantity = 175.00;
            //Color, 50 Quantity.
            Double Stock12Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock12_0_5SqIn_100Quantity = 155.00;
            Double Stock12_5_10SqIn_100Quantity = 160.00;
            Double Stock12_10_15SqIn_100Quantity = 170.00;
            Double Stock12_15_20SqIn_100Quantity = 175.00;
            Double Stock12_20_25SqIn_100Quantity = 185.00;
            Double Stock12_25_30SqIn_100Quantity = 190.00;
            //Color, 100 Quantity.
            Double Stock12Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock12_0_5SqIn_250Quantity = 170.00;
            Double Stock12_5_10SqIn_250Quantity = 180.00;
            Double Stock12_10_15SqIn_250Quantity = 195.00;
            Double Stock12_15_20SqIn_250Quantity = 200.00;
            Double Stock12_20_25SqIn_250Quantity = 205.00;
            Double Stock12_25_30SqIn_250Quantity = 210.00;
            //Color, 250 Quantity.
            Double Stock12Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock12_0_5SqIn_500Quantity = 190.00;
            Double Stock12_5_10SqIn_500Quantity = 200.00;
            Double Stock12_10_15SqIn_500Quantity = 215.00;
            Double Stock12_15_20SqIn_500Quantity = 235.00;
            Double Stock12_20_25SqIn_500Quantity = 245.00;
            Double Stock12_25_30SqIn_500Quantity = 265.00;
            //Color, 500 Quantity.
            Double Stock12Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock12_0_5SqIn_1000Quantity = 225.00;
            Double Stock12_5_10SqIn_1000Quantity = 250.00;
            Double Stock12_10_15SqIn_1000Quantity = 280.00;
            Double Stock12_15_20SqIn_1000Quantity = 305.00;
            Double Stock12_20_25SqIn_1000Quantity = 340.00;
            Double Stock12_25_30SqIn_1000Quantity = 380.00;
            //Color, 1000 Quantity.
            Double Stock12Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock12_0_5SqIn_2000Quantity = 265.00;
            Double Stock12_5_10SqIn_2000Quantity = 335.00;
            Double Stock12_10_15SqIn_2000Quantity = 410.00;
            Double Stock12_15_20SqIn_2000Quantity = 495.00;
            Double Stock12_20_25SqIn_2000Quantity = 550.00;
            Double Stock12_25_30SqIn_2000Quantity = 610.00;
            //Color, 2000 Quantity.
            Double Stock12Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock12_0_5SqIn_2500Quantity = 285.00;
            Double Stock12_5_10SqIn_2500Quantity = 380.00;
            Double Stock12_10_15SqIn_2500Quantity = 475.00;
            Double Stock12_15_20SqIn_2500Quantity = 590.00;
            Double Stock12_20_25SqIn_2500Quantity = 655.00;
            Double Stock12_25_30SqIn_2500Quantity = 725.00;
            //Color, 2500 Quantity.
            Double Stock12Color_2500Quantity = 115.00;


            //======================================================================================================
            //Stock 13 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock13_0_5SqIn_50Quantity = 145.00;
            Double Stock13_5_10SqIn_50Quantity = 150.00;
            Double Stock13_10_15SqIn_50Quantity = 155.00;
            Double Stock13_15_20SqIn_50Quantity = 160.00;
            Double Stock13_20_25SqIn_50Quantity = 170.00;
            Double Stock13_25_30SqIn_50Quantity = 175.00;
            //Color, 50 Quantity.
            Double Stock13Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock13_0_5SqIn_100Quantity = 155.00;
            Double Stock13_5_10SqIn_100Quantity = 160.00;
            Double Stock13_10_15SqIn_100Quantity = 170.00;
            Double Stock13_15_20SqIn_100Quantity = 175.00;
            Double Stock13_20_25SqIn_100Quantity = 185.00;
            Double Stock13_25_30SqIn_100Quantity = 190.00;
            //Color, 100 Quantity.
            Double Stock13Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock13_0_5SqIn_250Quantity = 170.00;
            Double Stock13_5_10SqIn_250Quantity = 180.00;
            Double Stock13_10_15SqIn_250Quantity = 195.00;
            Double Stock13_15_20SqIn_250Quantity = 200.00;
            Double Stock13_20_25SqIn_250Quantity = 205.00;
            Double Stock13_25_30SqIn_250Quantity = 210.00;
            //Color, 250 Quantity.
            Double Stock13Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock13_0_5SqIn_500Quantity = 190.00;
            Double Stock13_5_10SqIn_500Quantity = 200.00;
            Double Stock13_10_15SqIn_500Quantity = 215.00;
            Double Stock13_15_20SqIn_500Quantity = 235.00;
            Double Stock13_20_25SqIn_500Quantity = 245.00;
            Double Stock13_25_30SqIn_500Quantity = 265.00;
            //Color, 500 Quantity.
            Double Stock13Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock13_0_5SqIn_1000Quantity = 225.00;
            Double Stock13_5_10SqIn_1000Quantity = 250.00;
            Double Stock13_10_15SqIn_1000Quantity = 280.00;
            Double Stock13_15_20SqIn_1000Quantity = 305.00;
            Double Stock13_20_25SqIn_1000Quantity = 340.00;
            Double Stock13_25_30SqIn_1000Quantity = 380.00;
            //Color, 1000 Quantity.
            Double Stock13Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock13_0_5SqIn_2000Quantity = 265.00;
            Double Stock13_5_10SqIn_2000Quantity = 335.00;
            Double Stock13_10_15SqIn_2000Quantity = 410.00;
            Double Stock13_15_20SqIn_2000Quantity = 495.00;
            Double Stock13_20_25SqIn_2000Quantity = 550.00;
            Double Stock13_25_30SqIn_2000Quantity = 610.00;
            //Color, 2000 Quantity.
            Double Stock13Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock13_0_5SqIn_2500Quantity = 285.00;
            Double Stock13_5_10SqIn_2500Quantity = 380.00;
            Double Stock13_10_15SqIn_2500Quantity = 475.00;
            Double Stock13_15_20SqIn_2500Quantity = 590.00;
            Double Stock13_20_25SqIn_2500Quantity = 655.00;
            Double Stock13_25_30SqIn_2500Quantity = 725.00;
            //Color, 2500 Quantity.
            Double Stock13Color_2500Quantity = 115.00;


            //======================================================================================================
            //Stock 14 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock14_0_5SqIn_50Quantity = 145.00;
            Double Stock14_5_10SqIn_50Quantity = 150.00;
            Double Stock14_10_15SqIn_50Quantity = 155.00;
            Double Stock14_15_20SqIn_50Quantity = 160.00;
            Double Stock14_20_25SqIn_50Quantity = 170.00;
            Double Stock14_25_30SqIn_50Quantity = 175.00;
            //Color, 50 Quantity.
            Double Stock14Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock14_0_5SqIn_100Quantity = 155.00;
            Double Stock14_5_10SqIn_100Quantity = 160.00;
            Double Stock14_10_15SqIn_100Quantity = 170.00;
            Double Stock14_15_20SqIn_100Quantity = 175.00;
            Double Stock14_20_25SqIn_100Quantity = 185.00;
            Double Stock14_25_30SqIn_100Quantity = 190.00;
            //Color, 100 Quantity.
            Double Stock14Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock14_0_5SqIn_250Quantity = 170.00;
            Double Stock14_5_10SqIn_250Quantity = 180.00;
            Double Stock14_10_15SqIn_250Quantity = 195.00;
            Double Stock14_15_20SqIn_250Quantity = 200.00;
            Double Stock14_20_25SqIn_250Quantity = 205.00;
            Double Stock14_25_30SqIn_250Quantity = 210.00;
            //Color, 250 Quantity.
            Double Stock14Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock14_0_5SqIn_500Quantity = 190.00;
            Double Stock14_5_10SqIn_500Quantity = 200.00;
            Double Stock14_10_15SqIn_500Quantity = 215.00;
            Double Stock14_15_20SqIn_500Quantity = 235.00;
            Double Stock14_20_25SqIn_500Quantity = 245.00;
            Double Stock14_25_30SqIn_500Quantity = 265.00;
            //Color, 500 Quantity.
            Double Stock14Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock14_0_5SqIn_1000Quantity = 225.00;
            Double Stock14_5_10SqIn_1000Quantity = 250.00;
            Double Stock14_10_15SqIn_1000Quantity = 280.00;
            Double Stock14_15_20SqIn_1000Quantity = 305.00;
            Double Stock14_20_25SqIn_1000Quantity = 340.00;
            Double Stock14_25_30SqIn_1000Quantity = 380.00;
            //Color, 1000 Quantity.
            Double Stock14Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock14_0_5SqIn_2000Quantity = 265.00;
            Double Stock14_5_10SqIn_2000Quantity = 335.00;
            Double Stock14_10_15SqIn_2000Quantity = 410.00;
            Double Stock14_15_20SqIn_2000Quantity = 495.00;
            Double Stock14_20_25SqIn_2000Quantity = 550.00;
            Double Stock14_25_30SqIn_2000Quantity = 610.00;
            //Color, 2000 Quantity.
            Double Stock14Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock14_0_5SqIn_2500Quantity = 285.00;
            Double Stock14_5_10SqIn_2500Quantity = 380.00;
            Double Stock14_10_15SqIn_2500Quantity = 475.00;
            Double Stock14_15_20SqIn_2500Quantity = 590.00;
            Double Stock14_20_25SqIn_2500Quantity = 655.00;
            Double Stock14_25_30SqIn_2500Quantity = 725.00;
            //Color, 2500 Quantity.
            Double Stock14Color_2500Quantity = 115.00;


            //======================================================================================================
            //Stock 15 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock15_0_5SqIn_50Quantity = 145.00;
            Double Stock15_5_10SqIn_50Quantity = 150.00;
            Double Stock15_10_15SqIn_50Quantity = 155.00;
            Double Stock15_15_20SqIn_50Quantity = 160.00;
            Double Stock15_20_25SqIn_50Quantity = 170.00;
            Double Stock15_25_30SqIn_50Quantity = 175.00;
            //Color, 50 Quantity.
            Double Stock15Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock15_0_5SqIn_100Quantity = 155.00;
            Double Stock15_5_10SqIn_100Quantity = 160.00;
            Double Stock15_10_15SqIn_100Quantity = 170.00;
            Double Stock15_15_20SqIn_100Quantity = 175.00;
            Double Stock15_20_25SqIn_100Quantity = 185.00;
            Double Stock15_25_30SqIn_100Quantity = 190.00;
            //Color, 100 Quantity.
            Double Stock15Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock15_0_5SqIn_250Quantity = 170.00;
            Double Stock15_5_10SqIn_250Quantity = 180.00;
            Double Stock15_10_15SqIn_250Quantity = 195.00;
            Double Stock15_15_20SqIn_250Quantity = 200.00;
            Double Stock15_20_25SqIn_250Quantity = 205.00;
            Double Stock15_25_30SqIn_250Quantity = 210.00;
            //Color, 250 Quantity.
            Double Stock15Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock15_0_5SqIn_500Quantity = 190.00;
            Double Stock15_5_10SqIn_500Quantity = 200.00;
            Double Stock15_10_15SqIn_500Quantity = 215.00;
            Double Stock15_15_20SqIn_500Quantity = 235.00;
            Double Stock15_20_25SqIn_500Quantity = 245.00;
            Double Stock15_25_30SqIn_500Quantity = 265.00;
            //Color, 500 Quantity.
            Double Stock15Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock15_0_5SqIn_1000Quantity = 225.00;
            Double Stock15_5_10SqIn_1000Quantity = 250.00;
            Double Stock15_10_15SqIn_1000Quantity = 280.00;
            Double Stock15_15_20SqIn_1000Quantity = 305.00;
            Double Stock15_20_25SqIn_1000Quantity = 340.00;
            Double Stock15_25_30SqIn_1000Quantity = 380.00;
            //Color, 1000 Quantity.
            Double Stock15Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock15_0_5SqIn_2000Quantity = 265.00;
            Double Stock15_5_10SqIn_2000Quantity = 335.00;
            Double Stock15_10_15SqIn_2000Quantity = 410.00;
            Double Stock15_15_20SqIn_2000Quantity = 495.00;
            Double Stock15_20_25SqIn_2000Quantity = 550.00;
            Double Stock15_25_30SqIn_2000Quantity = 610.00;
            //Color, 2000 Quantity.
            Double Stock15Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock15_0_5SqIn_2500Quantity = 285.00;
            Double Stock15_5_10SqIn_2500Quantity = 380.00;
            Double Stock15_10_15SqIn_2500Quantity = 475.00;
            Double Stock15_15_20SqIn_2500Quantity = 590.00;
            Double Stock15_20_25SqIn_2500Quantity = 655.00;
            Double Stock15_25_30SqIn_2500Quantity = 725.00;
            //Color, 2500 Quantity.
            Double Stock15Color_2500Quantity = 115.00;



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