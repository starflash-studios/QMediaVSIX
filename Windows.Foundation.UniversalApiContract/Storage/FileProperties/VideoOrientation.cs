// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.VideoOrientation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  /// <summary>Indicates how to rotate the video to display it correctly.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum VideoOrientation
  {
    /// <summary>No rotation needed. The video can be displayed using its current orientation.</summary>
    Normal = 0,
    /// <summary>Rotate the video 90 degrees.</summary>
    Rotate90 = 90, // 0x0000005A
    /// <summary>Rotate the video counter-clockwise 180 degrees.</summary>
    Rotate180 = 180, // 0x000000B4
    /// <summary>Rotate the video counter-clockwise 270 degrees.</summary>
    Rotate270 = 270, // 0x0000010E
  }
}
