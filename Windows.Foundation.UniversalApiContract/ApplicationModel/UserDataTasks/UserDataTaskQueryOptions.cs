// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.UserDataTaskQueryOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  /// <summary>Represents the options selected for task query.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UserDataTaskQueryOptions : IUserDataTaskQueryOptions
  {
    /// <summary>Instantiates a new instance of the UserDataTaskQueryOptions class.</summary>
    [MethodImpl]
    public extern UserDataTaskQueryOptions();

    /// <summary>Gets or sets a Boolean value indicating whether the query results should be sorted.</summary>
    /// <returns>A Boolean value indicating whether the query results should be sorted.</returns>
    public extern UserDataTaskQuerySortProperty SortProperty { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the kind of tasks for which to query.</summary>
    /// <returns>The kind of emails for which to query.</returns>
    public extern UserDataTaskQueryKind Kind { [MethodImpl] get; [MethodImpl] set; }
  }
}
