﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace OnlineVideos.MPUrlSourceFilter.UserSettings
{
    /// <summary>
    /// Represents class for network interface converter.
    /// </summary>
    public class NetworkInterfaceConverter : StringConverter
    {
        #region Methods

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return false;
        }

        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            List<String> nics = new List<String>();
            System.Net.NetworkInformation.NetworkInterface[] networkInterfaces = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces();

            nics.Add(OnlineVideoSettings.NetworkInterfaceSystemDefault);
            foreach (var networkInterface in networkInterfaces)
            {
                nics.Add(networkInterface.Name);
            }

            return new StandardValuesCollection(nics);
        }

        #endregion
    }
}
