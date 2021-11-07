// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackageIdWithMetadata
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ExclusiveTo(typeof (PackageId))]
  [Guid(1079474812, 3230, 17469, 144, 116, 133, 95, 92, 224, 160, 141)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPackageIdWithMetadata
  {
    string ProductId { get; }

    string Author { get; }
  }
}
