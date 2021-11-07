// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.PhotoImportContentType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  /// <summary>Specifies the content type of an imported item.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PhotoImportContentType
  {
    /// <summary>The content type is unknown.</summary>
    Unknown,
    /// <summary>The item is an image.</summary>
    Image,
    /// <summary>The item is a video.</summary>
    Video,
  }
}
