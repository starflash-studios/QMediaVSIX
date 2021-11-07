// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ContentLinkChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Documents;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides data for the RichEditBox.ContentLinkChanged event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ContentLinkChangedEventArgs : IContentLinkChangedEventArgs
  {
    /// <summary>Gets a value that indicates how the content link is changed.</summary>
    /// <returns>An enumeration value that indicates how the content link is changed.</returns>
    public extern ContentLinkChangeKind ChangeKind { [MethodImpl] get; }

    /// <summary>Gets an object that contains information about the content link.</summary>
    /// <returns>An object that contains information about the content link.</returns>
    public extern ContentLinkInfo ContentLinkInfo { [MethodImpl] get; }

    /// <summary>Gets the text range that contains the content link.</summary>
    /// <returns>The text range that contains the content link.</returns>
    public extern TextRange TextRange { [MethodImpl] get; }
  }
}
