// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ContentDialogClosingDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a deferral that can be used by an app to respond asynchronously to the closing event of the ContentDialog.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ContentDialogClosingDeferral : IContentDialogClosingDeferral
  {
    /// <summary>Notifies the system that the app has finished processing the closing event.</summary>
    [MethodImpl]
    public extern void Complete();
  }
}
