<%@ Page Title="Vinyl Labels - Sign Service Label Products" Language="C#" MasterPageFile="~/Public.Master" AutoEventWireup="true" CodeBehind="products.aspx.cs" Inherits="Sign_Service_Label_Products.vinyl_labels" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="page-content" class="container well-background">
        <div class="page-header">
            <h1>Products</h1>
        </div>

        <div class="row">
            <section class="col-sm-12 col-md-4 col-lg-4">
                <div class="thumbnail">
                    <img src="img/products/vinyl_thumb.jpg" alt="..." />
                    <div class="caption">
                        <h3>Vinyl Labels</h3>
                        <p>This is one of our most cost effective stocks, with it's wide variety of uses, it is an ideal product for anything from P.O.P display labels to product markings and yes, even bumper stickers.</p>
                        <p>
                            <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#vinyl_labels">Read More...</button>
                        </p>
                    </div>
                </div>
            </section>
            <section class="col-sm-12 col-md-4 col-lg-4">
                <div class="thumbnail">
                    <img src="img/products/corvette_decal.jpg" alt="..." />
                    <div class="caption">
                        <h3>Digital Print</h3>
                        <p>Our digitally printed decals are solvent printed on vinyl stock and laminated with polyester or vinyl overlamination.</p>
                        <p>
                            <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#digital_print">Read More...</button>
                        </p>
                    </div>
                </div>
            </section>

            <section class="col-sm-12 col-md-4 col-lg-4">
                <div class="thumbnail">
                    <img src="img/products/truck_meg.jpg" alt="..." />
                    <div class="caption">
                        <h3>Magnetics</h3>
                        <p>Fridge Magnets are a great way to get your message across and keep it going. Everytime that fridge door, metal filing cabinet or any metallic surface opens your name is again seen.</p>
                        <p>
                            <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#magnetics">Read More...</button>
                        </p>
                    </div>
                </div>

            </section>
        </div>







        <!--Vinyl Labels Modal -->
        <div class="modal fade" id="vinyl_labels" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                        <h4 class="modal-title" id="myModalLabel">Vinyl Labels</h4>
                    </div>
                    <div class="modal-body">
                        <p>This is one of our most cost effective stocks, with it's wide variety of uses, it is an ideal product for anything from P.O.P display labels to product markings and yes, even bumper stickers. This product is good for application above 50ºF but once the adhesive has set for 72 hours it can withstand outdoor temperatures of -30ºF to +170ºF and has an indoor/outdoor expected life of 2-3 years.</p>
                        <p>Four colour process solvent based digital printing & cutting available on most vinyl stocks including some of our specialty adhesives.</p>

                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    </div>
                </div>
            </div>
        </div>

        <!--Digital Print Modal -->
        <div class="modal fade" id="digital_print" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                        <h4 class="modal-title" id="myModalLabel">Digital Print</h4>
                    </div>
                    <div class="modal-body">
                        <p>Our digitally printed decals are solvent printed on vinyl stock and laminated with polyester or vinyl overlamination.</p>
                        <p>This allows an outdoor life of up to 3 years and not only does the polyester lamination protect the decal from abrasives, chemicals and weather but it adds a nice gloss to it's finish. The vinyl lamination is great when the surface has a small curve to it allowing the overlamination to stretch with the vinyl base.</p>
                        <p>With capabilities of up to 28" high and unlimited length, we can print and custom cut with our plotter to suit your needs.</p>
                        <p>At Sign Service Label Products we have developed a procedure to create single and two sided digitally printed decals and are always working on new digital products to offer our customers.. call for details.</p>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    </div>
                </div>
            </div>
        </div>

        <!--Magnetics Modal -->
        <div class="modal fade" id="magnetics" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                        <h4 class="modal-title" id="myModalLabel">Magnetics</h4>
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            <section class="col-sm-12 col-md-12 col-lg-12">
                                <p>Fridge Magnets are a great way to get your message across and keep it going. Everytime that fridge door, metal filing cabinet or any metallic surface opens your name is again seen. We can custom cut different shapes as well as your standard sizes. We can also digitally print, laminate and mount the print to a magnetic base for a more economical square cut magnetic product.</p>
                                <p>Magnets also make a great industrial racking marking product for temporary marking of shelves.</p>
                                <p>Venicle Magnets give you exposure everywhere you drive, printed on a 0.030" magnetic sheet to give you maximum adhesion while still staying flexible. They are a great temporary sign for your trucks on a specific job site or when your business and personal vehicles are the same one. This allows you to advertise your name without having to permanently mark up your vehicle. They are also perfect for adhering to metal doors for temporary locations or sales.</p>
                            </section>
                        </div>
                        <div class="row">
                            <section class="col-sm-12 col-md-6 col-lg-6">
                                <img id="product-modal-img" src="img/products/stewarttown_school_meg.jpg" alt="Alternate Text" />
                            </section>
                            <section class="col-sm-12 col-md-6 col-lg-6">
                                <img id="product-modal-img" src="img/products/flower_meg.jpg" alt="Alternate Text" />
                            </section>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    </div>
                </div>
            </div>
        </div>




    </div>
    <!-- /.container -->
</asp:Content>
