// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.IKeyStorageProviderNamesStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ExclusiveTo(typeof (KeyStorageProviderNames))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(640513085, 39982, 16844, 136, 18, 196, 217, 113, 221, 124, 96)]
  internal interface IKeyStorageProviderNamesStatics2
  {
    string PassportKeyStorageProvider { get; }
  }
}
