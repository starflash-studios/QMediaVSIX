// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.IUserProfilePersonalizationSettingsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.UserProfile
{
  [ExclusiveTo(typeof (UserProfilePersonalizationSettings))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2444015681, 20535, 17739, 152, 131, 187, 119, 45, 8, 221, 22)]
  internal interface IUserProfilePersonalizationSettingsStatics
  {
    UserProfilePersonalizationSettings Current { get; }

    bool IsSupported();
  }
}
