// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.OnlineId.IOnlineIdSystemAuthenticatorStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Security.Authentication.OnlineId
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (OnlineIdSystemAuthenticator))]
  [Guid(2231662482, 63028, 16867, 150, 164, 81, 100, 233, 2, 199, 64)]
  internal interface IOnlineIdSystemAuthenticatorStatics
  {
    OnlineIdSystemAuthenticatorForUser Default { get; }

    OnlineIdSystemAuthenticatorForUser GetForUser(User user);
  }
}
