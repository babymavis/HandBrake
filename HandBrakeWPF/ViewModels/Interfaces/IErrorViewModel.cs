﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IErrorViewModel.cs" company="HandBrake Project (http://handbrake.fr)">
//   This file is part of the HandBrake source code - It may be used under the terms of the GNU General Public License.
// </copyright>
// <summary>
//   Defines the IErrorViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace HandBrakeWPF.ViewModels.Interfaces
{
    /// <summary>
    /// The Error View Model Interface
    /// </summary>
    public interface IErrorViewModel
    {
        /// <summary>
        /// The Error Details
        /// </summary>
        string Details { set; }

        /// <summary>
        /// The Error Message
        /// </summary>
        string ErrorMessage { set; }

        /// <summary>
        /// The Error Solution
        /// </summary>
        string Solution { set; }
    }
}
