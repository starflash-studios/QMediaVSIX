// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.UserDataTaskReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  /// <summary>Used to read UserDataTask objects in batches from the UserDataTaskStore which may be local or remotely located.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class UserDataTaskReader : IUserDataTaskReader
  {
    /// <summary>Asynchronously reads a batch of UserDataTask objects from the UserDataTaskStore.</summary>
    /// <returns>The batch of tasks read from the UserDataTaskStore.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<UserDataTaskBatch> ReadBatchAsync();
  }
}
