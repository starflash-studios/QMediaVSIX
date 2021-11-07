// Decompiled with JetBrains decompiler
// Type: Windows.System.IUser2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [Guid(2562348584, 42723, 20878, 137, 217, 211, 178, 177, 153, 26, 16)]
  [ContractVersion(typeof (UniversalApiContract), 917504)]
  [ExclusiveTo(typeof (User))]
  internal interface IUser2
  {
    [RemoteAsync]
    IAsyncOperation<UserAgeConsentResult> CheckUserAgeConsentGroupAsync(
      UserAgeConsentGroup consentGroup);
  }
}
