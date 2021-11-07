// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.IPhotoImportSidecar
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  [ExclusiveTo(typeof (PhotoImportSidecar))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1188550487, 63490, 17607, 156, 152, 122, 113, 244, 188, 20, 134)]
  internal interface IPhotoImportSidecar
  {
    string Name { get; }

    ulong SizeInBytes { get; }

    DateTime Date { get; }
  }
}
