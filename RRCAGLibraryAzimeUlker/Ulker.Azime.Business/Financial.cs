using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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
    /// This program contains functionality that includes financial functions.
    /// 
    /// @author Azime Ulker
    /// @version 1.0
    /// </summary>
    public static class Financial
    {
        /// <summary>
        /// Returns the payment amount for an annuity based on periodic, fixed payments
        /// and fixed interest rate.
        /// </summary>
        /// <param name="rate"></param>
        /// <param name="numberOfPaymentPeriods"></param>
        /// <param name="presentValue"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Occurs when rate, numberOfPaymentPeriods and presentValue are set to equal or 
        /// less than 0 , or greater than 1.
        /// </exception>
        public static decimal GetPayment(decimal rate, int numberOfPaymentPeriods,decimal presentValue)
        {

            if(rate < 0)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be less than 0. Parameter name: rate");
            }

            if (rate > 1)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be greater than 1. Parameter name: rate");
            }

            if (numberOfPaymentPeriods == 0)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be less than or equal to zero.Parameter name :numberOfPeriods");
            }

            if (numberOfPaymentPeriods < 0)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be less than or equal to zero.Parameter name :numberOfPeriods");
            }

            if(presentValue == 0)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be less than or equal to 0. Parameter name: presentValue");
            }

            if (presentValue < 0)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be less than or equal to 0. Parameter name: presentValue");
            }


            decimal futureValue = 0;
            decimal type = 0;
            decimal payment = 0;

            if (rate == 0)
                payment = presentValue / numberOfPaymentPeriods;


            else
                payment = rate * (futureValue + presentValue * (decimal)Math.Pow((double)(1 + rate),
                          (double)numberOfPaymentPeriods)) / (((decimal)Math.Pow((double)(1 + rate),
                          (double)numberOfPaymentPeriods) - 1) * (1 + rate * type));

            return Math.Round(payment, 2);

        }

    }
}
