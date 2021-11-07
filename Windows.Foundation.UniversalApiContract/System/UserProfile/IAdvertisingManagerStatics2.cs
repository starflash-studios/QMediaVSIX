// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.IAdvertisingManagerStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.UserProfile
{
  [ExclusiveTo(typeof (AdvertisingManager))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3708372911, 6765, 18096, 149, 188, 243, 249, 214, 190, 185, 251)]
  internal interface IAdvertisingManagerStatics2
  {
    AdvertisingManagerForUser GetForUser(User user);
  }
}
