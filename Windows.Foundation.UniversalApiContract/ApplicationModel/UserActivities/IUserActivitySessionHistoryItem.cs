// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserActivities.IUserActivitySessionHistoryItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserActivities
{
  [Guid(3906313171, 15965, 18941, 152, 215, 109, 169, 117, 33, 226, 85)]
  [ExclusiveTo(typeof (UserActivitySessionHistoryItem))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IUserActivitySessionHistoryItem
  {
    UserActivity UserActivity { get; }

    DateTime StartTime { get; }

    IReference<DateTime> EndTime { get; }
  }
}
