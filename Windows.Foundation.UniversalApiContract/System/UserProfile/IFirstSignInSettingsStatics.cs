// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.IFirstSignInSettingsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.UserProfile
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(484544271, 7233, 20128, 183, 162, 111, 12, 28, 126, 132, 56)]
  [ExclusiveTo(typeof (FirstSignInSettings))]
  internal interface IFirstSignInSettingsStatics
  {
    FirstSignInSettings GetDefault();
  }
}
