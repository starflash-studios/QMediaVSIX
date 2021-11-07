// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IAsymmetricKeyAlgorithmProvider2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  [ExclusiveTo(typeof (AsymmetricKeyAlgorithmProvider))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1311910526, 31821, 18839, 172, 79, 27, 132, 139, 54, 48, 110)]
  internal interface IAsymmetricKeyAlgorithmProvider2
  {
    CryptographicKey CreateKeyPairWithCurveName(string curveName);

    CryptographicKey CreateKeyPairWithCurveParameters([Range(0, 65536)] byte[] parameters);
  }
}
