// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IViewSwitcherProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.ViewManagement;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides the object that allows you to set the view for the application.</summary>
  [Guid(871532710, 23596, 19751, 186, 199, 117, 54, 8, 143, 18, 25)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IViewSwitcherProvider : IActivatedEventArgs
  {
    /// <summary>Provides the view switcher object that allows you to set the view for the application.</summary>
    /// <returns>Use the ActivationViewSwitcher to show or switch the view in response to the activation. The value will be **null** in hosted scenarios such as Share and File Picker activations.</returns>
    ActivationViewSwitcher ViewSwitcher { get; }
  }
}
