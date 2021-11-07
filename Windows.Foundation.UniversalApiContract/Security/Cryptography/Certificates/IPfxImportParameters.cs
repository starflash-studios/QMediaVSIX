// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.IPfxImportParameters
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ExclusiveTo(typeof (PfxImportParameters))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1745696017, 39432, 18376, 134, 74, 46, 221, 77, 142, 180, 108)]
  internal interface IPfxImportParameters
  {
    ExportOption Exportable { get; set; }

    KeyProtectionLevel KeyProtectionLevel { get; set; }

    InstallOptions InstallOptions { get; set; }

    string FriendlyName { get; set; }

    string KeyStorageProviderName { get; set; }

    string ContainerNamePrefix { get; set; }

    string ReaderName { get; set; }
  }
}
