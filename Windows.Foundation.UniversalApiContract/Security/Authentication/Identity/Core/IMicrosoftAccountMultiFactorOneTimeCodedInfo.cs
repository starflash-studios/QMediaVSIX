// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Core.IMicrosoftAccountMultiFactorOneTimeCodedInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Core
{
  [ExclusiveTo(typeof (MicrosoftAccountMultiFactorOneTimeCodedInfo))]
  [Guid(2193237579, 55420, 18024, 169, 118, 64, 207, 174, 84, 125, 8)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IMicrosoftAccountMultiFactorOneTimeCodedInfo
  {
    string Code { get; }

    TimeSpan TimeInterval { get; }

    TimeSpan TimeToLive { get; }

    MicrosoftAccountMultiFactorServiceResponse ServiceResponse { get; }
  }
}
