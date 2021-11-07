// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.IUserDataTask
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2087028177, 57556, 20377, 174, 226, 188, 45, 93, 218, 223, 76)]
  [ExclusiveTo(typeof (UserDataTask))]
  internal interface IUserDataTask
  {
    string Id { get; }

    string ListId { get; }

    string RemoteId { get; set; }

    IReference<DateTime> CompletedDate { get; set; }

    string Details { get; set; }

    UserDataTaskDetailsKind DetailsKind { get; set; }

    IReference<DateTime> DueDate { get; set; }

    UserDataTaskKind Kind { get; }

    UserDataTaskPriority Priority { get; set; }

    UserDataTaskRecurrenceProperties RecurrenceProperties { get; set; }

    UserDataTaskRegenerationProperties RegenerationProperties { get; set; }

    IReference<DateTime> Reminder { get; set; }

    UserDataTaskSensitivity Sensitivity { get; set; }

    string Subject { get; set; }

    IReference<DateTime> StartDate { get; set; }
  }
}
