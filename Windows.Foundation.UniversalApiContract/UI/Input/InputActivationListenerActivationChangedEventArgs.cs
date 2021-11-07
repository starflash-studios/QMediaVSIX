// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.InputActivationListenerActivationChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  /// <summary>Contains event data for the InputActivationChanged event.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public sealed class InputActivationListenerActivationChangedEventArgs : 
    IInputActivationListenerActivationChangedEventArgs
  {
    /// <summary>Gets the activation state of a window, view, or other visual element.</summary>
    /// <returns>The activation state of the window, view, or other visual element.</returns>
    public extern InputActivationState State { [MethodImpl] get; }
  }
}
