// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.LightDismissOverlayMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify whether the area outside of a *light-dismiss* UI is darkened.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum LightDismissOverlayMode
  {
    /// <summary>The device-family the app is running on determines whether the area outside of a *light-dismiss* UI is darkened.</summary>
    Auto,
    /// <summary>The area outside of a *light-dismiss* UI is darkened for all device families.</summary>
    On,
    /// <summary>The area outside of a *light-dismiss* UI is not darkened for all device families.</summary>
    Off,
  }
}
