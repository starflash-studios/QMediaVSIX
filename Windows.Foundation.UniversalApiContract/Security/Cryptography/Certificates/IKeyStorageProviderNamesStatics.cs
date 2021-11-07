// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.IKeyStorageProviderNamesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [Guid(2937613024, 21801, 17922, 189, 148, 10, 171, 145, 149, 123, 92)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (KeyStorageProviderNames))]
  internal interface IKeyStorageProviderNamesStatics
  {
    string SoftwareKeyStorageProvider { get; }

    string SmartcardKeyStorageProvider { get; }

    string PlatformKeyStorageProvider { get; }
  }
}
