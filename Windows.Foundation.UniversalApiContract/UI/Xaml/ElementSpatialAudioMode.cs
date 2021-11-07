// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.ElementSpatialAudioMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Defines constants that indicate whether spatial sound is on, off, or handled automatically.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  public enum ElementSpatialAudioMode
  {
    /// <summary>Spatial sound is turned on or off by the system.</summary>
    Auto,
    /// <summary>Spatial sound is off.</summary>
    Off,
    /// <summary>Spatial sound is on.</summary>
    On,
  }
}
