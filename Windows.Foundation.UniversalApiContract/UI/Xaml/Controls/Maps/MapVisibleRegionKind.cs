// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapVisibleRegionKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Indicates the kind of visible region.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  public enum MapVisibleRegionKind
  {
    /// <summary>Visible region on the map control that doesn't include things that are further away towards the horizon and is orthogonal to whether landmarks are present or not.</summary>
    Near,
    /// <summary>The full visible region of the map control.</summary>
    Full,
  }
}
