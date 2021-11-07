// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.SocketActivityTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents a trigger that launches a background task for handling socket activity.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SocketActivityTrigger : IBackgroundTrigger, ISocketActivityTrigger
  {
    /// <summary>Initializes a new instance of a socket activity trigger.</summary>
    [MethodImpl]
    public extern SocketActivityTrigger();

    /// <summary>Gets whether a SocketActivityTrigger can wake the machine from a low power state.</summary>
    /// <returns>**True** indicates that this trigger can wake the machine from a low power state; **false** otherwise.</returns>
    public extern bool IsWakeFromLowPowerSupported { [MethodImpl] get; }
  }
}
