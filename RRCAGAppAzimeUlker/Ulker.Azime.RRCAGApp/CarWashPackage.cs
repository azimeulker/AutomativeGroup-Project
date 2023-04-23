using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ulker.Azime.Business;

/**
 * Name: Azime Ulker
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2023-03-25
 */
namespace Ulker.Azime.RRCAGApp
{   
    /// <summary>
    /// Initializes CarWashPackage details
    /// </summary>
    public class CarWashPackage
    {
        private string packageName;
        private decimal packagePrice;

        /// <summary>
        /// Initialize pacakageName and packagePrice
        /// </summary>
        public CarWashPackage(string packageName, decimal packagePrice)
        {
            this.packageName = packageName;
            this.packagePrice = packagePrice;
        }

        /// <summary>
        /// gets PackageName
        /// </summary>
        public string PackageName
        {
            get
            {
                return this.packageName;
            }
        }

        /// <summary>
        /// Gets packagePrice
        /// </summary>
        public decimal PackagePrice
        {
            get
            {
                return this.packagePrice;
            }
        }
    }
}
