// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.IPhotoImportVideoSegment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  [ExclusiveTo(typeof (PhotoImportVideoSegment))]
  [Guid(1648099977, 12826, 16856, 145, 102, 140, 98, 163, 51, 39, 108)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPhotoImportVideoSegment
  {
    string Name { get; }

    ulong SizeInBytes { get; }

    DateTime Date { get; }

    PhotoImportSidecar Sibling { get; }

    IVectorView<PhotoImportSidecar> Sidecars { get; }
  }
}
