using CarRental.EFDBModel;
using CarRentalContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarRentalWeb
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        private CarRentalCtx _ctx = new CarRentalCtx();

        protected void Page_Load(object sender, EventArgs e)
        {
            this.labelSaved.Visible = false;


            // Borrowers
            this.gvBorrowers.DataSource = _ctx.Borrower.ToList().Select( a=> new{a.Name, a.PermanentAddress, a.HotelAddress} );
            this.gvBorrowers.DataBind();

            //
            this.lbBorrowers.DataSource = _ctx.Borrower.ToList().Select(a => a.Name);
            this.lbBorrowers.DataBind();
        }


        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            this.labelSaved.Visible = false;

            Menu _sender = (Menu)sender;

            if (_sender.SelectedValue == this.CarRentalMenu.Items[0].ChildItems[0].Text)
            {
                this.rentPanel.Visible = true;
            }
            else
            {
                this.panelAddReservation.Visible = false;
            }
            
        }

        protected void AddBorrower_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tbPermanentAddress.Text) ||
                 string.IsNullOrEmpty(this.tbPermanentAddress.Text) ||
                 string.IsNullOrEmpty(this.tbPermanentAddress.Text) ||
                 string.IsNullOrEmpty(this.tbMobileNumber.Text) ||
                 string.IsNullOrEmpty(this.tbLandlineNumber.Text) ||
                 string.IsNullOrEmpty(this.tbEmailAddress.Text))
            {
                this.lblError.Visible = true;
            }
            else
            {
                Borrower _borrower = new Borrower()
                {
                    Name = this.tbPermanentAddress.Text,
                    HotelAddress = this.tbPermanentAddress.Text,
                    PermanentAddress = this.tbPermanentAddress.Text,
                    MobileNumber = this.tbMobileNumber.Text,
                    LandLineNumber = this.tbLandlineNumber.Text,
                    EmailAddress = this.tbEmailAddress.Text,
                    CreatedOn = DateTime.Now,
                    CreatedByID = 1
                };

                _ctx.Borrower.Add(_borrower);

                this.labelSaved.Visible = true;
                this.lblError.Visible = false;
                this.panelAddReservation.Visible = false;
                _ctx.SaveChanges();
            }
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            this.panelAddReservation.Visible = true;
        }
    }
}