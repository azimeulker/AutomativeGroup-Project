using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;

/**
 * Name: Azime Ulker
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2023-02-26
 */


namespace Ulker.Azime.Business

{   /// <summary>
    /// This program is a library class of RRC Automotive Group
    /// applications project.
    /// @author Azime Ulker
    /// @version 1.0
    /// </summary>
    public class SalesQuote
    {
        private decimal vehicleSalePrice;
        private decimal tradeInAmount;
        private decimal salesTaxRate;
        private Accessories accessoriesChosen;
        private ExteriorFinish exteriorFinishChosen;

        /// <summary>
        /// Occurs when the price of the vehicle being quoted on changes
        /// </summary>
        public event EventHandler VehiclePriceChanged;

        /// <summary>
        /// Occurs when the amount for the trade in vehicle changes
        /// </summary>
        public event EventHandler TradeInAmountChanged;

        /// <summary>
        /// Occurs when the chosen accessories changes.
        /// </summary>
        public event EventHandler AccessoriesChosenChanged;

        /// <summary>
        /// Occurs when the chosen exterior finish changes.
        /// </summary>
        public event EventHandler ExteriorFinishChosenChanged;


        /// <summary>
        /// Gets and sets the sale price of the vehicle.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Occurs when the vehicle sale price is set to less than or
        /// equal to 0.
        /// </exception>
        public decimal VehicleSalePrice
        {

            get
            {
                return this.vehicleSalePrice;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The value cannot be less than or equal to 0", "value");
                }

                //invoking event
                if(this.vehicleSalePrice != value)
                {
                    this.vehicleSalePrice = value;

                    //trigger the event
                    OnVehiclePriceChanged();
                }
            }
        }


        /// <summary>
        /// Gets and sets the trade in amount.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Occurs when the trade in amount is set to less than 0.
        /// </exception>
        public decimal TradeInAmount
        {
            get
            {
                return this.tradeInAmount;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The value cannot be less than 0.", "value");
                }


                //invoking event
                if(this.tradeInAmount != value)
                {
                    this.tradeInAmount = value;

                    //trigger the event
                    OnTradeInAmountChanged();
                }
               
            }
        }

        /// <summary>
        /// Gets and sets the accessories that were chosen.
        /// </summary>
        /// <exception cref="InvalidEnumArgumentException">
        /// Occurs when the accessories are set to an invalid value.
        /// </exception>
        public Accessories AccessoriesChosen
        {
            get
            {
                return this.accessoriesChosen;
            }

            set
            {
                if (!Enum.IsDefined(typeof(Accessories), value))
                {
                    InvalidEnumArgumentException exception;
                    exception = new InvalidEnumArgumentException("The value is  an invalid enumeration value.", (int)value, typeof(Accessories));

                    throw exception;
                }
                
                //invoking event
                if(this.accessoriesChosen != value)
                {
                    this.accessoriesChosen = value;

                    //trigger the event
                    OnAccessoriesChosenChanged();
                }
             
            }
        }

        /// <summary>
        /// Gets and sets the exterior finish that was chosen.
        /// </summary>
        /// <exception cref="InvalidEnumArgumentException">
        /// Occurs when exterior finish is set to an invalid value.
        /// </exception>
        public ExteriorFinish ExteriorFinishChosen
        {
            get
            {
                return this.exteriorFinishChosen;
            }

            set
            {
                if (!Enum.IsDefined(typeof(ExteriorFinish), value))
                {
                    InvalidEnumArgumentException exception;
                    exception = new InvalidEnumArgumentException("The value is an invalid enumeration value.", (int)value, typeof(ExteriorFinish));

                    throw exception;
                }

                //invoking event
                if(this.exteriorFinishChosen != value)
                {
                    this.exteriorFinishChosen = value;

                    //trigger the event
                    OnExteriorFinishChosenChanged();
                }

                
            }
        }

        /// <summary>
        /// Gets the cost of accessories chosen.
        /// </summary>
        public decimal AccessoryCost
        {
            get
            {
                decimal cost1 = 0;

                switch (accessoriesChosen)
                {
                    case Accessories.StereoSystem:
                        cost1 = 505.05m;
                        break;

                    case Accessories.LeatherInterior:
                        cost1 = 1010.10m;
                        break;

                    case Accessories.ComputerNavigation:
                        cost1 = 1515.15m;
                        break;

                    case Accessories.StereoAndLeather:
                        cost1 = 505.05m + 1010.10m;
                        break;

                    case Accessories.StereoAndNavigation:
                        cost1 = 505.05m + 1515.15m;
                        break;

                    case Accessories.LeatherAndNavigation:
                        cost1 = 1010.10m + 1515.15m;
                        break;

                    case Accessories.All:
                        cost1 = 505.05m + 1010.10m + 1515.15m;
                        break;

                    default:
                        cost1 = 0.00m;
                        break;
                }

                return cost1;
            }

            set
            {
                this.AccessoryCost = value;
            }
        }

        /// <summary>
        /// Gets the cost of the exterior finish chosen.
        /// </summary>
        public decimal FinishCost
        {
            get
            {
                decimal cost2 = 0;

                switch (exteriorFinishChosen)
                {
                    case ExteriorFinish.Standard:
                        cost2 = 202.02m;
                        break;

                    case ExteriorFinish.Pearlized:
                        cost2 = 404.04m;
                        break;

                    case ExteriorFinish.Custom:
                        cost2 = 606.06m;
                        break;

                    default:
                        cost2 = 0.00m;
                        break;
                }

                return cost2;
            }

            set
            {
                this.FinishCost = value;
            }
        }

        /// <summary>
        /// Gets the sum of the cost of the chosen accessories and exterior
        /// finish(rounded to two decimal places.)
        /// </summary>
        public decimal TotalOptions
        {
            get
            {
                return Math.Round(this.AccessoryCost + this.FinishCost, 2);
            }

            set
            {
                this.TotalOptions = value;
            }
        }

        /// <summary>
        /// Gets the sum of the vehicle's sale price and the Accessory and Finish
        /// cost (rounded to two decimal places).
        /// </summary>
        public decimal SubTotal
        {
            get
            {
                return Math.Round(this.VehicleSalePrice + this.AccessoryCost + this.FinishCost, 2);
            }

            set
            {
                this.SubTotal = value;
            }
        }

        /// <summary>
        /// Gets the amount of tax to charge based on the subtotal
        /// (rounded to two decimal places.)
        /// </summary>
        public decimal SalesTax
        {
            get
            {
                return Math.Round(this.SubTotal * this.salesTaxRate, 2);
            }

            set
            {
                this.SalesTax = value;
            }
        }

        /// <summary>
        /// Get the sum of the subtotal and taxes.
        /// </summary>
        public decimal Total
        {
            get
            {
                return Math.Round(this.SubTotal + this.SalesTax, 2);
            }

            set
            {
                this.Total = value;
            }
        }

        /// <summary>
        /// Gets the result of subtracting the trade-in amount from the total
        /// (rounded to two decimal places).
        /// </summary>
        public decimal AmountDue
        {
            get
            {
                return Math.Round(this.Total - this.tradeInAmount, 2);
            }

            set
            {
                this.AmountDue = value;
            }
        }
        /// <summary>
        /// Initializes a new instance of the Sale Quote class with the specified
        /// vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, and exteriorFinishChosen.
        /// </summary>
        /// <param name="vehicleSalePrice"></param>
        /// <param name="tradeInAmount"></param>
        /// <param name="salesTaxRate"></param>
        /// <param name="accessoriesChosen"></param>
        /// <param name="exteriorFinishChosen"></param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Occurs when argument is less than or equal to zero and greater than 1.
        /// </exception>
        /// <exception cref="InvalidEnumArgumentException">
        /// Occurs when argument is an invalid enumeration value. 
        /// </exception>
        public SalesQuote(decimal vehicleSalePrice, decimal tradeInAmount, decimal salesTaxRate, Accessories accessoriesChosen, ExteriorFinish exteriorFinishChosen)

        {
            if (vehicleSalePrice <= 0)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be less than or equal to 0", "vehicleSalePrice");
            }

            if (tradeInAmount < 0)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be less than 0.", "tradeInAmount");
            }

            if (salesTaxRate < 0)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be less than 0.", "salesTaxRate");
            }

            if (salesTaxRate > 1)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be greater than 1", "salesTaxRate");
            }

            if (!Enum.IsDefined(typeof(Accessories), accessoriesChosen))
            {
                InvalidEnumArgumentException exception;
                exception = new InvalidEnumArgumentException("The value is an invalid enumeration value.", (int)accessoriesChosen, typeof(Accessories));
            }

            if (!Enum.IsDefined(typeof(ExteriorFinish), exteriorFinishChosen))
            {
                InvalidEnumArgumentException exception;
                exception = new InvalidEnumArgumentException("The value is an invalid enumeration value.", (int)exteriorFinishChosen, typeof(ExteriorFinish));
            }

            this.vehicleSalePrice = vehicleSalePrice;
            this.tradeInAmount = tradeInAmount;
            this.salesTaxRate = salesTaxRate;
            this.accessoriesChosen = accessoriesChosen;
            this.exteriorFinishChosen = exteriorFinishChosen;
        }

        /// <summary>
        /// Initializes an instance of SalesQuote with a vehicle price, trade-in amount, sales tax rate, no accessories chosen and no exterior finish chosen.
        /// </summary>
        /// <param name="vehicleSalePrice"></param>
        /// <param name="tradeInAmount"></param>
        /// <param name="salesTaxRate"></param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Occurs when argument is less than or equal to zero and greater than 1.
        /// </exception>
        public SalesQuote(decimal vehicleSalePrice, decimal tradeInAmount, decimal salesTaxRate)
                          : this(vehicleSalePrice, tradeInAmount, salesTaxRate, Accessories.None, ExteriorFinish.None)
        {


        }

        /// <summary>
        /// Raises the VehiclePriceChanged event.
        /// </summary>
        protected virtual void OnVehiclePriceChanged()
        {
            if(VehiclePriceChanged != null)
            {
                VehiclePriceChanged(this, new EventArgs());
            }
        }

        /// <summary>
        /// Raises the TradeInAmountChanged event.
        /// </summary>
        protected virtual void OnTradeInAmountChanged()
        {
            if(TradeInAmountChanged != null)
            {
                TradeInAmountChanged(this, new EventArgs());
            }
        }

        /// <summary>
        /// Raises the AccessoriesChosenChanged event.
        /// </summary>
        protected virtual void OnAccessoriesChosenChanged()
        {
            if(AccessoriesChosenChanged != null)
            {
                AccessoriesChosenChanged(this, new EventArgs());
            }
        }

        /// <summary>
        /// Raises the ExteriorFinishChosenChanged event.
        /// </summary>
        protected virtual void OnExteriorFinishChosenChanged()
        {
            if(ExteriorFinishChosenChanged != null)
            {
                ExteriorFinishChosenChanged(this, new EventArgs());
            }
        }
    }

}
