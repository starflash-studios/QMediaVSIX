// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserActivities.IUserActivity3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserActivities
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(3882448708, 57762, 20807, 142, 6, 85, 241, 238, 239, 39, 28)]
  [ExclusiveTo(typeof (UserActivity))]
  internal interface IUserActivity3
  {
    bool IsRoamable { get; set; }
  }
}
