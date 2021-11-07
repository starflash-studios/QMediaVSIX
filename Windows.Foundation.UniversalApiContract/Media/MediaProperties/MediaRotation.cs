// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.MediaRotation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  /// <summary>Defines the direction and angle of a media rotation transform.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MediaRotation
  {
    /// <summary>No rotation.</summary>
    None,
    /// <summary>Rotate 90 degrees clockwise.</summary>
    Clockwise90Degrees,
    /// <summary>Rotate 180 degrees clockwise.</summary>
    Clockwise180Degrees,
    /// <summary>Rotate 270 degrees clockwise.</summary>
    Clockwise270Degrees,
  }
}
