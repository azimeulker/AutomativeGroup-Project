using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Name: Azime Ulker
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2023-02-26
 */

namespace Ulker.Azime.Business
{
    /// <summary>
    /// This program contains functionality that supports the business process of 
    /// creating an invoice for the car wash department.
    /// 
    /// @author Azime Ulker
    /// @version 1.0
    /// </summary>
    public class CarWashInvoice : Invoice
    {
        private decimal packageCost;
        private decimal fragranceCost;

        /// <summary>
        /// Occurs when the package cost changes.
        /// </summary>
        public event EventHandler PackageCostChanged;

        /// <summary>
        /// Occurs when the fragrance cost changes.
        /// </summary>
        public event EventHandler FragranceCostChanged;

        /// <summary>
        /// Gets and sets the amount charged for the chosen package.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Occurs when the property is set to less than 0.
        /// </exception>
        public decimal PackageCost
        {
            get
            {
                return this.packageCost;
            }

            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("The value cannot be less than 0.", "value");
                }

                //invoking event
                if (this.packageCost != value)
                {
                    this.packageCost = value;

                    //trigger the event
                    OnPackageCostChanged();
                }
                
            }
        }

        /// <summary>
        /// Gets and sets the amount charged for the chosen fragrance.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Occurs when the property is set to less than 0.
        /// </exception>
        public decimal FragranceCost
        {
            get
            {
                return this.fragranceCost;
            }

            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("The value cannot be less than 0.", "value");
                }

                //invoking event
                if (this.fragranceCost != value)
                {
                    this.fragranceCost = value;

                    //trigger the event
                    OnFragranceCostChanged();
                }
           
            }
        }

        /// <summary>
        /// Gets the amount of provincial sales tax charged to the customer.
        /// No provincial sales tax is charged for a car wash.
        /// </summary>
        public override decimal ProvincialSalesTaxCharged
        {
            get
            {
                return 0;
            }

        }

        /// <summary>
        /// Gets amount of provincial sales tax charged to the customer.
        /// (Rounded to 2 decimal places). The tax is calculated by multiplying
        /// the tax rate by the subtotal.
        /// </summary>
        public override decimal GoodsAndServicesTaxCharged
        {
            get
            {
                //return Math.Round(this.SubTotal + (base.GoodsAndServicesTaxRate * this.SubTotal), 2);
                return Math.Round(this.SubTotal * base.GoodsAndServicesTaxRate, 2);

                //return Math.Round(base.GoodsAndServicesTaxRate + (base.GoodsAndServicesTaxRate * this.SubTotal), 2);

            }

        }

        /// <summary>
        /// Gets the subtotal of the Invoice. The subtotal is the sum of the 
        /// package and fragrance cost.
        /// </summary>
        public override decimal SubTotal
        {
            get
            {
                return this.packageCost + this.fragranceCost;
            }

     
        }

        /// <summary>
        /// Initializes an instance of CarWashInvoice with a provincial and 
        /// goods and services tax rates. The package cost and fragrance cost are zero
        /// </summary>
        /// <param name="provincialSalesTaxRate"></param>
        /// <param name="goodsAndServicesTaxRate"></param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Occurs when provincialSalesTaxRate and goodsAndServiceTaxRate are 
        /// set to less than zero or greater than 1.
        /// </exception>
        public CarWashInvoice(decimal provincialSalesTaxRate, decimal goodsAndServicesTaxRate)
                        :this(provincialSalesTaxRate, goodsAndServicesTaxRate, 0, 0) 
        {

        }

        /// <summary>
        /// Initializes an instance of CarWashInvoice with a provincial and goods,services tax
        /// rate,package cost and fragrance cost.
        /// </summary>
        /// <param name="provincialSalesTaxRate"></param>
        /// <param name="goodsAndServicesTaxRate"></param>
        /// <param name="packageCost"></param>
        /// <param name="fragranceCost"></param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Occurs when provincialSalesTaxRate,goodsAndServiceTaxRate,packageCost and
        /// fragrance cost are set to less than zero or provincialSalesTaxRate and goodsAndServiceTaxRate
        /// are set to greater than 1.
        /// </exception>
        public CarWashInvoice(decimal provincialSalesTaxRate, decimal goodsAndServicesTaxRate, decimal packageCost, decimal fragranceCost)
                       : base(provincialSalesTaxRate, goodsAndServicesTaxRate)
        {
            if(provincialSalesTaxRate < 0)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be less than 0.", "provincialSalesTaxRate");
            }

            if (provincialSalesTaxRate > 1)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be greater than.", "provincialSalesTaxRate");
            }

            if (goodsAndServicesTaxRate < 0)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be less than 0.", "goodsAndServicesTaxRate");
            }

            if (goodsAndServicesTaxRate > 1)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be greater than 1.", "goodsAndServicesTaxRate");
            }

            if (packageCost < 0)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be less than 0.", "packageCost");
            }

            if (fragranceCost < 0)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be less than 0.", "fragranceCost");
            }
            this.packageCost = packageCost;
            this.fragranceCost = fragranceCost;
        }

        /// <summary>
        /// Raises the PackageCostChanged event
        /// </summary>
        protected virtual void OnPackageCostChanged()
        {
            if(PackageCostChanged != null)
            {
                PackageCostChanged(this, new EventArgs());
            }
        }

        /// <summary>
        /// Raises the FragranceCostChanged event
        /// </summary>
        protected virtual void OnFragranceCostChanged()
        {
            if (FragranceCostChanged != null)
            {
                FragranceCostChanged(this, new EventArgs());
            }
        }
    }
}
