﻿// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.IChainValidationParameters
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking;

namespace Windows.Security.Cryptography.Certificates
{
  [Guid(3295951690, 32432, 19286, 160, 64, 185, 200, 230, 85, 221, 243)]
  [ExclusiveTo(typeof (ChainValidationParameters))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IChainValidationParameters
  {
    CertificateChainPolicy CertificateChainPolicy { get; set; }

    HostName ServerDnsName { get; set; }
  }
}