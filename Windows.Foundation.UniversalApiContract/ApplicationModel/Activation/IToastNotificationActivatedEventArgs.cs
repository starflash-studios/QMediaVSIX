// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IToastNotificationActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides information about an event that occurs when the app is activated because a user tapped on the body of a toast notification or performed an action inside a toast notification.</summary>
  [Guid(2460512130, 21136, 17181, 190, 133, 196, 170, 238, 184, 104, 95)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IToastNotificationActivatedEventArgs : IActivatedEventArgs
  {
    /// <summary>Gets the arguments that the app can retrieve after it is activated through an interactive toast notification.</summary>
    /// <returns>The arguments that the app can retrieve after it is activated through an interactive toast notification. The value of this property is defined previously in the XML that describes the data to deliver for the toast notification. The following elements and attributes of that XML define the value:</returns>
    string Argument { get; }

    /// <summary>Gets a set of values that you can use to obtain the user input from an interactive toast notification.</summary>
    /// <returns>A set of values that you can use to obtain the user input from an interactive toast notification.</returns>
    ValueSet UserInput { get; }
  }
}
