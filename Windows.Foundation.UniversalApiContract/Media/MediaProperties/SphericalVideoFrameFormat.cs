// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.SphericalVideoFrameFormat
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  /// <summary>Specifies the format of a spherical video frame.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum SphericalVideoFrameFormat
  {
    /// <summary>The video frame does not use a spherical video format.</summary>
    None,
    /// <summary>The video frame uses an unsupported spherical video format.</summary>
    Unsupported,
    /// <summary>The video frame uses equirectangular format for spherical video.</summary>
    Equirectangular,
  }
}
