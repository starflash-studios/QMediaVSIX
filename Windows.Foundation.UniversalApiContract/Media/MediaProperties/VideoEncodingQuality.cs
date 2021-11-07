// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.VideoEncodingQuality
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  /// <summary>Determines the video encoding format.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum VideoEncodingQuality
  {
    /// <summary>**Auto** fills in the proper settings based on the current camera settings. So when **Auto** is used, settings that are manually modified are ignored. For example, if you create a preset profile using one the static create methods, such as CreateWmv, and specify **Auto** as the encoding quality, any changes you make to the properties will be overwritten with values based on the current camera settings.</summary>
    Auto,
    /// <summary>HD1080p format.</summary>
    HD1080p,
    /// <summary>HD720p format.</summary>
    HD720p,
    /// <summary>Wvga format.</summary>
    Wvga,
    /// <summary>Ntsc format.</summary>
    Ntsc,
    /// <summary>Pal format.</summary>
    Pal,
    /// <summary>Vga format.</summary>
    Vga,
    /// <summary>Qvga format.</summary>
    Qvga,
    /// <summary>2160p UHD format.  </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] Uhd2160p,
    /// <summary>4320p UHD format.  </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] Uhd4320p,
  }
}
