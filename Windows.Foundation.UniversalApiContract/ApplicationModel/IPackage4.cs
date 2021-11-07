// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackage4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1705955758, 47451, 17676, 136, 43, 98, 85, 24, 127, 57, 126)]
  [ExclusiveTo(typeof (Package))]
  internal interface IPackage4
  {
    PackageSignatureKind SignatureKind { get; }

    bool IsOptional { get; }

    [RemoteAsync]
    IAsyncOperation<bool> VerifyContentIntegrityAsync();
  }
}
