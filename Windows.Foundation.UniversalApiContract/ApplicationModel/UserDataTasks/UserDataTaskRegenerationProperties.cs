// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.UserDataTaskRegenerationProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  /// <summary>Represents how often a task occurs.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class UserDataTaskRegenerationProperties : IUserDataTaskRegenerationProperties
  {
    /// <summary>Initializes a new instance of the UserDataTaskRegenerationProperties class.</summary>
    [MethodImpl]
    public extern UserDataTaskRegenerationProperties();

    /// <summary>Gets or sets a UserDataTaskRecurrenceUnit -typed value that indicates the frequency for which the task occurs.</summary>
    /// <returns>A UserDataTaskRecurrenceUnit -typed value that indicates the frequency for which the task occurs.</returns>
    public extern UserDataTaskRegenerationUnit Unit { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the number of times a task recurs. Occurrences is of type IReference(UInt32) and is **NULL** by default. Occurrences is mutually exclusive with Until.</summary>
    /// <returns>The number of times a task recurs.</returns>
    public extern IReference<int> Occurrences { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the date and time until which a task is valid. Until is of type IReference(DateTime) and is **NULL** by default. Until is mutually exclusive with Occurrences.</summary>
    /// <returns>The date and time until which a task is valid.</returns>
    public extern IReference<DateTime> Until { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the interval between occurrences of a task. Interval is of type UInt32 and has a default value of 1. For daily, the interval is the number of days in between, for weekly, the number of weeks, and so on.</summary>
    /// <returns>The interval on which a task occurs.</returns>
    public extern int Interval { [MethodImpl] get; [MethodImpl] set; }
  }
}
