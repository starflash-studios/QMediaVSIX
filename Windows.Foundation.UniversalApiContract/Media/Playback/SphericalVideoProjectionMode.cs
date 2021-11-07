// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.SphericalVideoProjectionMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>Specifies the spherical projection mode used for rendering video.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum SphericalVideoProjectionMode
  {
    /// <summary>The video is rendered using spherical projection.</summary>
    Spherical,
    /// <summary>The video is rendered flat with no spherical projection.</summary>
    Flat,
  }
}
