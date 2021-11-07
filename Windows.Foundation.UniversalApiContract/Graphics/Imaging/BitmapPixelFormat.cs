// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.BitmapPixelFormat
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  /// <summary>Specifies the pixel format of pixel data. Each enumeration value defines a channel ordering, bit depth, and data type.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum BitmapPixelFormat
  {
    /// <summary>The pixel format is unknown.</summary>
    Unknown = 0,
    /// <summary>The pixel format is R16B16G16A16 unsigned integer.</summary>
    Rgba16 = 12, // 0x0000000C
    /// <summary>The pixel format is R8G8B8A8 unsigned integer.</summary>
    Rgba8 = 30, // 0x0000001E
    /// <summary>The pixel format is 16 bpp grayscale.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Gray16 = 57, // 0x00000039
    /// <summary>The pixel format is 8 bpp grayscale.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Gray8 = 62, // 0x0000003E
    /// <summary>The pixel format is B8G8R8A8 unsigned integer.</summary>
    Bgra8 = 87, // 0x00000057
    /// <summary>The pixel format is NV12.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Nv12 = 103, // 0x00000067
    /// <summary>The pixel format is P010.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 393216)] P010 = 104, // 0x00000068
    /// <summary>The pixel format is YUY2.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Yuy2 = 107, // 0x0000006B
  }
}
