// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.NoFocusCandidateFoundEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Provides data for the NoFocusCandidateFound event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  public sealed class NoFocusCandidateFoundEventArgs : 
    RoutedEventArgs,
    INoFocusCandidateFoundEventArgs
  {
    /// <summary>Gets the direction that focus moved from element to element within the app UI.</summary>
    /// <returns>The direction of focus movement.</returns>
    public extern FocusNavigationDirection Direction { [MethodImpl] get; }

    /// <summary>Gets or sets a value that marks the routed event as handled. A **true** value for **Handled** prevents most handlers along the event route from handling the same event again.</summary>
    /// <returns>**true** to mark the routed event handled. **false** to leave the routed event unhandled, which permits the event to potentially route further and be acted on by other handlers. The default is **false**.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the input device type from which input events are received.</summary>
    /// <returns>The input device type.</returns>
    public extern FocusInputDeviceKind InputDevice { [MethodImpl] get; }
  }
}
