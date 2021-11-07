// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.IGlobalizationPreferencesStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.UserProfile
{
  [ExclusiveTo(typeof (GlobalizationPreferences))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(503682867, 13813, 16600, 185, 232, 174, 243, 239, 133, 111, 206)]
  internal interface IGlobalizationPreferencesStatics3
  {
    GlobalizationPreferencesForUser GetForUser(User user);
  }
}
