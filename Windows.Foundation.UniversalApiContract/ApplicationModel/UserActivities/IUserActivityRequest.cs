// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserActivities.IUserActivityRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserActivities
{
  [Guid(2700043093, 53045, 20464, 136, 51, 80, 203, 75, 114, 224, 109)]
  [ExclusiveTo(typeof (UserActivityRequest))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IUserActivityRequest
  {
    void SetUserActivity(UserActivity activity);
  }
}
