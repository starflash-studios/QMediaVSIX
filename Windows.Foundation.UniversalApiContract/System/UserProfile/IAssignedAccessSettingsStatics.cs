// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.IAssignedAccessSettingsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.UserProfile
{
  [Guid(883432717, 35369, 24307, 167, 190, 97, 142, 106, 195, 189, 1)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (AssignedAccessSettings))]
  internal interface IAssignedAccessSettingsStatics
  {
    AssignedAccessSettings GetDefault();

    AssignedAccessSettings GetForUser(User user);
  }
}
