// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.IPhotoImportItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Import
{
  [ExclusiveTo(typeof (PhotoImportItem))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2849013366, 39932, 17336, 179, 86, 99, 59, 106, 152, 140, 158)]
  internal interface IPhotoImportItem
  {
    string Name { get; }

    ulong ItemKey { get; }

    PhotoImportContentType ContentType { get; }

    ulong SizeInBytes { get; }

    DateTime Date { get; }

    PhotoImportSidecar Sibling { get; }

    IVectorView<PhotoImportSidecar> Sidecars { get; }

    IVectorView<PhotoImportVideoSegment> VideoSegments { get; }

    bool IsSelected { get; set; }

    IRandomAccessStreamReference Thumbnail { get; }

    IVectorView<string> ImportedFileNames { get; }

    IVectorView<string> DeletedFileNames { get; }
  }
}
