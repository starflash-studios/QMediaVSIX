// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ContentDialogButtonClickEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides data for the button click events.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ContentDialogButtonClickEventArgs : IContentDialogButtonClickEventArgs
  {
    /// <summary>Gets or sets a value that can cancel the button click. A **true** value for Cancel cancels the default behavior.</summary>
    /// <returns>True to cancel the button click; Otherwise, false.</returns>
    public extern bool Cancel { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a ContentDialogButtonClickDeferral that the app can use to respond asynchronously to a button click event.</summary>
    /// <returns>A ContentDialogButtonClickDeferral that the app can use to respond asynchronously to a button click event.</returns>
    [MethodImpl]
    public extern ContentDialogButtonClickDeferral GetDeferral();
  }
}
