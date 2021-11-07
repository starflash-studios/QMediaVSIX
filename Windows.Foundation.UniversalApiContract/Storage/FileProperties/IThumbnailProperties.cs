// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.IThumbnailProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  [ExclusiveTo(typeof (StorageItemThumbnail))]
  [Guid(1765659695, 56295, 18869, 179, 179, 40, 147, 172, 93, 52, 35)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IThumbnailProperties
  {
    uint OriginalWidth { get; }

    uint OriginalHeight { get; }

    bool ReturnedSmallerCachedSize { get; }

    ThumbnailType Type { get; }
  }
}
