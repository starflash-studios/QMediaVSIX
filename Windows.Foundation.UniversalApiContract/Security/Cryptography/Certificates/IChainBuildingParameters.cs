// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.IChainBuildingParameters
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ChainBuildingParameters))]
  [Guid(1110157602, 31885, 18359, 181, 155, 177, 39, 3, 115, 58, 195)]
  internal interface IChainBuildingParameters
  {
    IVector<string> EnhancedKeyUsages { get; }

    DateTime ValidationTimestamp { get; set; }

    bool RevocationCheckEnabled { get; set; }

    bool NetworkRetrievalEnabled { get; set; }

    bool AuthorityInformationAccessEnabled { get; set; }

    bool CurrentTimeValidationEnabled { get; set; }

    IVector<Certificate> ExclusiveTrustRoots { get; }
  }
}
