// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.HolographicViewConfigurationKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  /// <summary>Defines constants that indicate the kind of a HolographicViewConfiguration.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public enum HolographicViewConfigurationKind
  {
    /// <summary>Specifies that the view configuration is for a display.</summary>
    Display,
    /// <summary>Specifies that the view configuration is for a photo/video camera.</summary>
    PhotoVideoCamera,
  }
}
