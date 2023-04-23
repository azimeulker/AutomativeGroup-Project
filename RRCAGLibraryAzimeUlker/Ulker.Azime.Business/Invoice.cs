using System;
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
    /// This program is an abstract invoice class that contains functionality 
    /// that supports the business process of creating an invoice.
    /// @author Azime Ulker
    /// @version 1.0
    /// </summary>
    public abstract class Invoice
    {
        private decimal provincialSalesTaxRate;
        private decimal goodsAndServicesTaxRate;

        /// <summary>
        /// Occurs when the provincial sales tax rate of the Invoice changes.
        /// </summary>
        public event EventHandler ProvincialSalesTaxRateChanged;

        /// <summary>
        /// Occurs when the goods and services tax rate of the Invoice changes.
        /// </summary>
        public event EventHandler GoodsAndServicesTaxRateChanged;

        /// <summary>
        /// Gets and sets the provincial sales tax rate.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Occurs when property is set to less than 0 or greater than 1.
        /// </exception>
        public decimal ProvincialSalesTaxRate
        {
            get
            {
                return this.provincialSalesTaxRate;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("The value cannot be less than 0.", "value");
                }

                if (value > 1)
                {
                    throw new ArgumentOutOfRangeException("The value cannot be greater than 1.", "value");
                }

                //invoking event
                if (this.provincialSalesTaxRate != value)
                {
                    this.provincialSalesTaxRate = value;

                    //trigger the event
                    OnProvincialSalesTaxRateChanged();
                }
               
            }
        }

        /// <summary>
        /// Gets and sets the goods and services tax rate.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Occurs when property is set to less than 0 or greater than 1.
        /// </exception>
        public decimal GoodsAndServicesTaxRate
        {
            get
            {
                return this.goodsAndServicesTaxRate;

            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The value cannot be less than 0.", "value");
                }

                if (value > 1)
                {
                    throw new ArgumentOutOfRangeException("The value cannot be greater than 1.", "value");
                }

                //invoking event
                if (this.goodsAndServicesTaxRate != value)
                {
                    this.goodsAndServicesTaxRate = value;

                    //trigger the event
                    OnGoodsAndServicesTaxRateChanged();
                }

            }
        }

        /// <summary>
        /// Gets the amount of provincial sales tax charged to the customer
        /// (rounded to two decimal places)
        /// </summary>
        public abstract decimal ProvincialSalesTaxCharged
        {
            get;
       
        }

        /// <summary>
        /// Gets the amount of goods and services tax charged to the customer
        /// (Rounded to two decimal places)
        /// </summary>
        public abstract decimal GoodsAndServicesTaxCharged
        {
            get;
        }

        /// <summary>
        /// Gets the subtotal of the Invoice.
        /// </summary>
        public abstract decimal SubTotal
        {
            get;
        }

        /// <summary>
        /// Gets the total of the Invoice. The total is the sum of the subtotal and taxes.
        /// </summary>
        public decimal Total
        {
            get
            {
                return this.SubTotal + this.ProvincialSalesTaxCharged + this.GoodsAndServicesTaxCharged;
            }
        }

        /// <summary>
        /// Initializes an instance of Invoice with a provincial and goods and services tax rates.
        /// </summary>
        /// <param name="provincialSalesTaxRate"></param>
        /// <param name="goodsAndServicesTaxRate"></param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Occurs when provincialSalesTaxRate and goodsAndServicesTaxRate are set to less than 0
        /// or greater than 1.
        /// </exception>
        public Invoice(decimal provincialSalesTaxRate, decimal goodsAndServicesTaxRate) 
        {
            if(provincialSalesTaxRate < 0)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be less than 0.", "provincialSalesTaxRate");
            }

            if (provincialSalesTaxRate > 1)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be greater than 1.", "provincialSalesTaxRate");
            }

            if (goodsAndServicesTaxRate < 0)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be less than 0.", "goodsAndServicesTaxRate");
            }

            if (goodsAndServicesTaxRate > 1)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be greater than 1.", "goodAndServicesTaxRate");
            }

            this.provincialSalesTaxRate = provincialSalesTaxRate;
            this.goodsAndServicesTaxRate = goodsAndServicesTaxRate;
        }

        /// <summary>
        /// Raises the ProvincialSalesTaxRateChanged event.
        /// </summary>
        protected virtual void OnProvincialSalesTaxRateChanged()
        {
            if (ProvincialSalesTaxRateChanged != null)
            {
                ProvincialSalesTaxRateChanged(this, new EventArgs());
            }
        }

        /// <summary>
        /// Raises the GoodsAndServicesTaxRateChanged event.
        /// </summary>
        protected virtual void OnGoodsAndServicesTaxRateChanged()
        {
            if(GoodsAndServicesTaxRateChanged != null)
            {
                GoodsAndServicesTaxRateChanged(this, new EventArgs());
            }
        }
    }
}
