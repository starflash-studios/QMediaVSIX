// Decompiled with JetBrains decompiler
// Type: Windows.System.UserPictureSize
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Represents user picture sizes.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum UserPictureSize
  {
    /// <summary>The picture size is 64x64.</summary>
    Size64x64,
    /// <summary>The picture size is 208x208.</summary>
    Size208x208,
    /// <summary>The picture size is 424x424.</summary>
    Size424x424,
    /// <summary>The picture size is 1080x1080.</summary>
    Size1080x1080,
  }
}
