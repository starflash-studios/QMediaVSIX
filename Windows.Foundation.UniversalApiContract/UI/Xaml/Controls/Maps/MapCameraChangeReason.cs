// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapCameraChangeReason
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Specifies the reason the position of the map's camera has changed.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  public enum MapCameraChangeReason
  {
    /// <summary>The system changed the position of the map's camera.</summary>
    System,
    /// <summary>The user manually changed the position of the map's camera.</summary>
    UserInteraction,
    /// <summary>The position of the map's camera changed programmatically.</summary>
    Programmatic,
  }
}
