// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ContentDialogClosingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides data for the closing event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class ContentDialogClosingEventArgs : IContentDialogClosingEventArgs
  {
    /// <summary>Gets the ContentDialogResult of the closing event.</summary>
    /// <returns>The ContentDialogResult of the closing event.</returns>
    public extern ContentDialogResult Result { [MethodImpl] get; }

    /// <summary>Gets or sets a value that can cancel the closing of the dialog.. A **true** value for Cancel cancels the default behavior.</summary>
    /// <returns>True to cancel the closing of the dialog; Otherwise, false.</returns>
    public extern bool Cancel { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a ContentDialogClosingDeferral that the app can use to respond asynchronously to the closing event.</summary>
    /// <returns>A ContentDialogClosingDeferral that the app can use to respond asynchronously to the closing event.</returns>
    [MethodImpl]
    public extern ContentDialogClosingDeferral GetDeferral();
  }
}
