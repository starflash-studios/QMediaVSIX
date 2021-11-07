// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemWatcherErrorOccurredEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Gets information about an **ErrorOccurred ** event, namely the **RemoteSystemWatcherError ** value describing the error.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class RemoteSystemWatcherErrorOccurredEventArgs : 
    IRemoteSystemWatcherErrorOccurredEventArgs
  {
    /// <summary>The **RemoteSystemWatcherError ** value representing the error that occurred during discovery, causing the containing **ErrorOccurred ** event to be raised.</summary>
    /// <returns>A **RemoteSystemWatcherError ** value corresponding to the error.</returns>
    public extern RemoteSystemWatcherError Error { [MethodImpl] get; }
  }
}
