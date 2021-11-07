// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.AsyncOperationWithProgressCompletedHandler`2
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  /// <summary>Represents a method that handles the completed event of an asynchronous operation that provides progress updates.</summary>
  /// <typeparam name="TResult">
  /// </typeparam>
  /// <typeparam name="TProgress">
  /// </typeparam>
  /// <param name="asyncInfo">The asynchronous operation.</param>
  /// <param name="asyncStatus">One of the enumeration values.</param>
  [Guid(3898471453, 27303, 18147, 168, 226, 240, 9, 216, 64, 198, 39)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public delegate void AsyncOperationWithProgressCompletedHandler<TResult, TProgress>(
    IAsyncOperationWithProgress<TResult, TProgress> asyncInfo,
    AsyncStatus asyncStatus);
}
