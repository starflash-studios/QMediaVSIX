// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.WebAccountPictureSize
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  /// <summary>Represents the sizes of a web account picture.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum WebAccountPictureSize
  {
    /// <summary>64x64</summary>
    Size64x64 = 64, // 0x00000040
    /// <summary>208x208</summary>
    Size208x208 = 208, // 0x000000D0
    /// <summary>424x424</summary>
    Size424x424 = 424, // 0x000001A8
    /// <summary>1080x1080</summary>
    Size1080x1080 = 1080, // 0x00000438
  }
}
