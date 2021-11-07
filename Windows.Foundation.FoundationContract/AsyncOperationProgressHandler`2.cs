// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.AsyncOperationProgressHandler`2
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  /// <summary>Represents a method that handles progress update events of an asynchronous operation that provides progress updates.</summary>
  /// <typeparam name="TResult">
  /// </typeparam>
  /// <typeparam name="TProgress">
  /// </typeparam>
  /// <param name="asyncInfo">The asynchronous operation.</param>
  /// <param name="progressInfo">The progress information.</param>
  [Guid(1432946946, 2731, 16922, 135, 120, 248, 206, 80, 38, 215, 88)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public delegate void AsyncOperationProgressHandler<TResult, TProgress>(
    IAsyncOperationWithProgress<TResult, TProgress> asyncInfo,
    TProgress progressInfo);
}
