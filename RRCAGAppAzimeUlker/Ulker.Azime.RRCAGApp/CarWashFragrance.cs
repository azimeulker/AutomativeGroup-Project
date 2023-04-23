using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Name: Azime Ulker
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2023-03-25
 */
namespace Ulker.Azime.RRCAGApp
{   
    /// <summary>
    /// Initialize car wash fragrance details to create car wash form
    /// </summary>
    public class CarWashFragrance
    {
        private string fragranceName;
        private decimal fragrancePrice;

        /// <summary>
        /// Initialize fragranceName and fragrancePrice
        /// </summary>
        public CarWashFragrance(string fragranceName, decimal fragrancePrice)
        {
            this.fragranceName = fragranceName;
            this.fragrancePrice = fragrancePrice;

        }

        /// <summary>
        /// Gets fragranceName
        /// </summary>
        public string FragranceName
        {
            get
            {
                return this.fragranceName;
            }
        }
        /// <summary>
        /// Gets fragrancePrice
        /// </summary>
        public decimal FragrancePrice
        {
            get
            {
                return this.fragrancePrice;
            }
        }
        /// <summary>
        /// Returns fragranceName.
        /// </summary>
        public override string ToString()
        {
            return FragranceName;
        }
    }
}
