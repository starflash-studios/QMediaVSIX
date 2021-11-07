// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.IGlobalizationPreferencesStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.UserProfile
{
  [ExclusiveTo(typeof (GlobalizationPreferences))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(4241393137, 17152, 19664, 156, 172, 26, 142, 123, 126, 24, 244)]
  internal interface IGlobalizationPreferencesStatics2
  {
    bool TrySetHomeGeographicRegion(string region);

    bool TrySetLanguages(IIterable<string> languageTags);
  }
}
