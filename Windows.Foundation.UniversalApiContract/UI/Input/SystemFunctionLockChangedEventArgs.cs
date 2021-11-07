// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.SystemFunctionLockChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  /// <summary>Contains event data for the SystemFunctionLockChanged event.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  public sealed class SystemFunctionLockChangedEventArgs : ISystemFunctionLockChangedEventArgs
  {
    /// <summary>Gets the date and time of the SystemFunctionLockChanged event.</summary>
    /// <returns>The date and time of the SystemFunctionLockChanged event.</returns>
    public extern ulong Timestamp { [MethodImpl] get; }

    /// <summary>Gets the state of the Function key lock for the SystemFunctionLockChanged event.</summary>
    /// <returns>True, if the Function key lock is on. Otherwise, false.</returns>
    public extern bool IsLocked { [MethodImpl] get; }

    /// <summary>Gets or sets a value that marks the SystemFunctionLockChanged event as handled.</summary>
    /// <returns>If false (default), the event bubbles up to the next event handler. Otherwise, the event does not bubble up to the next event handler.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }
  }
}
