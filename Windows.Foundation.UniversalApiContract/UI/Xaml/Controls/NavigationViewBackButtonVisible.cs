// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.NavigationViewBackButtonVisible
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify whether the back button is visible in NavigationView.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum NavigationViewBackButtonVisible
  {
    /// <summary>Do not display the back button in NavigationView, and do not reserve space for it in layout.</summary>
    Collapsed,
    /// <summary>Display the back button in NavigationView.</summary>
    Visible,
    /// <summary>The system chooses whether or not to display the back button, depending on the device/form factor. On phones, tablets, desktops, and hubs, the back button is visible. On Xbox/TV, the back button is collapsed.</summary>
    Auto,
  }
}
