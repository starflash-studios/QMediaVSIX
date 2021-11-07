// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.IUserDataTaskRecurrenceProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  [Guid(1944027312, 10182, 16590, 177, 73, 156, 212, 20, 133, 166, 158)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (UserDataTaskRecurrenceProperties))]
  internal interface IUserDataTaskRecurrenceProperties
  {
    UserDataTaskRecurrenceUnit Unit { get; set; }

    IReference<int> Occurrences { get; set; }

    IReference<DateTime> Until { get; set; }

    int Interval { get; set; }

    IReference<UserDataTaskDaysOfWeek> DaysOfWeek { get; set; }

    IReference<UserDataTaskWeekOfMonth> WeekOfMonth { get; set; }

    IReference<int> Month { get; set; }

    IReference<int> Day { get; set; }
  }
}
