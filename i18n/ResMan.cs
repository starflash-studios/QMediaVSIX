#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.Diagnostics;
using System.Globalization;
using System.Resources;

#endregion

//[assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)]
namespace QMediaVSIX.i18n {

    public class ResMan {
        public ResMan() {

            Debug.WriteLine($"Constructing ResourceManager named '{nameof(ResMan)}' in the assembly '{typeof(ResMan).Assembly}'...");
            ResourceManager RM = new ResourceManager(nameof(ResMan), typeof(ResMan).Assembly);
            //string TestString = RM.GetString("TestString");
            //Debug.WriteLine($"Retrieved TestString {TestString}");
            Debug.WriteLine($"Constructing ResourceSet with the culture '{CultureInfo.CurrentUICulture}'...");
            ResourceSet RS = RM.GetResourceSet(CultureInfo.CurrentUICulture, false, true);

            Debug.WriteLine($"Retrieved TestString {RS.GetString("TestString")}");
        }
    }
}
