// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.ContentLinkInvokedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Text;

namespace Windows.UI.Xaml.Documents
{
  /// <summary>Provides event data for the ContentLink.Invoked event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class ContentLinkInvokedEventArgs : IContentLinkInvokedEventArgs
  {
    /// <summary>Gets the ContentLinkInfo object that contains the data for the invoked link.</summary>
    /// <returns>The ContentLinkInfo object that contains the data for the invoked link.</returns>
    public extern ContentLinkInfo ContentLinkInfo { [MethodImpl] get; }

    /// <summary>Gets or sets a value that marks the event as handled.</summary>
    /// <returns>**true** to mark the event as handled; otherwise, **false**.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }
  }
}
