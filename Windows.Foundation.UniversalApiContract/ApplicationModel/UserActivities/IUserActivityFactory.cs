// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserActivities.IUserActivityFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserActivities
{
  [Guid(2084067160, 13853, 19047, 138, 59, 52, 202, 41, 120, 249, 163)]
  [ExclusiveTo(typeof (UserActivity))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IUserActivityFactory
  {
    UserActivity CreateWithActivityId(string activityId);
  }
}
