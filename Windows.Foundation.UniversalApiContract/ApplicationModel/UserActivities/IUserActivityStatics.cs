// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserActivities.IUserActivityStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserActivities
{
  [Guid(2358235955, 3593, 18422, 154, 199, 149, 207, 92, 57, 54, 123)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (UserActivity))]
  internal interface IUserActivityStatics
  {
    UserActivity TryParseFromJson(string json);

    IVector<UserActivity> TryParseFromJsonArray(string json);

    string ToJsonArray(IIterable<UserActivity> activities);
  }
}
