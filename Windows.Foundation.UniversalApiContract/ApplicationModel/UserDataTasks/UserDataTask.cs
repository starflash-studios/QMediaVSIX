// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.UserDataTask
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  /// <summary>Represents a task.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class UserDataTask : IUserDataTask
  {
    /// <summary>Initializes a new instance of the UserDataTask class.</summary>
    [MethodImpl]
    public extern UserDataTask();

    /// <summary>Gets the unique identifier of the task.</summary>
    /// <returns>The unique identifier of the task.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets the unique identifier for the task list associated with the task.</summary>
    /// <returns>The unique identifier for the task list associated with the task.</returns>
    public extern string ListId { [MethodImpl] get; }

    /// <summary>Gets or sets an ID that can be used by a service provider to access the UserDataTask in their remote system.</summary>
    /// <returns>An ID that can be used by a service provider to access the UserDataTask in their remote system.</returns>
    public extern string RemoteId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the completion date and time of the task.</summary>
    /// <returns>The completion date and time of the task.</returns>
    public extern IReference<DateTime> CompletedDate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a string value. The string contains extended details that describe the task. Details is of type String and a maximum of 1,073,741,823 characters in length, which is the maximum length of a JET database string.</summary>
    /// <returns>The extended details that describe the task.</returns>
    public extern string Details { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the type of task details, plain text or HTML.</summary>
    /// <returns>The type of task details.</returns>
    public extern UserDataTaskDetailsKind DetailsKind { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the due date of the task.</summary>
    /// <returns>the due date of the task.</returns>
    public extern IReference<DateTime> DueDate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the kind of task (For example: Recurring etc.).</summary>
    /// <returns>The kind of task (For example: Recurring etc.).</returns>
    public extern UserDataTaskKind Kind { [MethodImpl] get; }

    /// <summary>Gets or sets the priority of the task.</summary>
    /// <returns>The priority of the task.</returns>
    public extern UserDataTaskPriority Priority { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an object that represents when and how often a task occurs.</summary>
    /// <returns>An object that represents when and how often a task occurs</returns>
    public extern UserDataTaskRecurrenceProperties RecurrenceProperties { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an object that represents how many times and at what interval the task is generated.</summary>
    /// <returns>An object that represents how many times and at what interval the task is generated.</returns>
    public extern UserDataTaskRegenerationProperties RegenerationProperties { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a time span value. The value declares the amount of time to subtract from the DueDate, and that time used as the issue time for a reminder for a task. A **null** value indicates that the task won't issue a reminder. Reminder is of type IReference(TimeSpan).</summary>
    /// <returns>A time span value, or **null** to issue no reminder.</returns>
    public extern IReference<DateTime> Reminder { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a UserDataTaskSensitivity -typed value that indicates the sensitivity of the task.</summary>
    /// <returns>A UserDataTaskSensitivity -typed value that indicates the sensitivity of the task.</returns>
    public extern UserDataTaskSensitivity Sensitivity { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a string that communicates the subject of the task. Subject is of type String and a maximum of 255 characters in length.</summary>
    /// <returns>The subject of the task.</returns>
    public extern string Subject { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the starting date and time for the task.</summary>
    /// <returns>The date and time to use as the starting time for the task.</returns>
    public extern IReference<DateTime> StartDate { [MethodImpl] get; [MethodImpl] set; }
  }
}
