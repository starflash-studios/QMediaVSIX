// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.ColorManagementMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  /// <summary>Specifies the color management behavior when obtaining pixel data.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ColorManagementMode
  {
    /// <summary>No color management is performed</summary>
    DoNotColorManage,
    /// <summary>Color management is performed from the color space embedded with the source bitmap to the sRGB color space.</summary>
    ColorManageToSRgb,
  }
}
