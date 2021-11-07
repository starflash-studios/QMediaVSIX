// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.BitmapRotation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  /// <summary>Specifies the rotation operation to be performed on pixel data.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum BitmapRotation
  {
    /// <summary>No rotation operation is performed.</summary>
    None,
    /// <summary>Perform a clockwise rotation of 90 degrees.</summary>
    Clockwise90Degrees,
    /// <summary>Perform a clockwise rotation of 180 degrees.</summary>
    Clockwise180Degrees,
    /// <summary>Perform a clockwise rotation of 270 degrees.</summary>
    Clockwise270Degrees,
  }
}
