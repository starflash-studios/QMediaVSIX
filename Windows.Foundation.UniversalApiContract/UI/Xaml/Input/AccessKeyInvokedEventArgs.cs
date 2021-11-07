// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.AccessKeyInvokedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Provides event data for the AccessKeyInvoked event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class AccessKeyInvokedEventArgs : IAccessKeyInvokedEventArgs
  {
    /// <summary>Initializes a new instance of the AccessKeyInvokedEventArgs class.</summary>
    [MethodImpl]
    public extern AccessKeyInvokedEventArgs();

    /// <summary>Gets or sets a value that marks the routed event as handled. A **true** value for Handled prevents most handlers along the event route from handling the same event again.</summary>
    /// <returns>**true** to mark the routed event handled. **false** to leave the routed event unhandled, which permits the event to potentially route further and be acted on by other handlers. The default is **false**.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }
  }
}
