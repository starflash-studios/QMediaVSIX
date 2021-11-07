// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Core.IMicrosoftAccountMultiFactorGetSessionsResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Core
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MicrosoftAccountMultiFactorGetSessionsResult))]
  [Guid(1310960032, 59898, 18810, 149, 222, 109, 87, 71, 191, 151, 76)]
  internal interface IMicrosoftAccountMultiFactorGetSessionsResult
  {
    IVectorView<MicrosoftAccountMultiFactorSessionInfo> Sessions { get; }

    MicrosoftAccountMultiFactorServiceResponse ServiceResponse { get; }
  }
}
