// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.ExifOrientationMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  /// <summary>Specifies the EXIF orientation flag behavior when obtaining pixel data.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ExifOrientationMode
  {
    /// <summary>The EXIF orientation flag is ignored. No rotation or flip operations are performed.</summary>
    IgnoreExifOrientation,
    /// <summary>If the image frame contains a valid EXIF orientation flag, the specified rotation and/or flip operations are performed on the pixel data.</summary>
    RespectExifOrientation,
  }
}
