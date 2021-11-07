// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.Core.CoreInputViewHidingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement.Core
{
  /// <summary>Contains event data for the PrimaryViewHiding event.</summary>
  [DualApiPartition(version = 1)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  public sealed class CoreInputViewHidingEventArgs : ICoreInputViewHidingEventArgs
  {
    /// <summary>Attempts to cancel the PrimaryViewHiding event of the input pane associated with the CoreInputView pane (if input pane is visible).</summary>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public extern bool TryCancel();
  }
}
