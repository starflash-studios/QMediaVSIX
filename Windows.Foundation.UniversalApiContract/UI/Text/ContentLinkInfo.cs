// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.ContentLinkInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  /// <summary>Represents information about a ContentLink.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Activatable(393216, "Windows.Foundation.UniversalApiContract")]
  public sealed class ContentLinkInfo : IContentLinkInfo
  {
    /// <summary>Initializes a new instance of the ContentLinkInfo class.</summary>
    [MethodImpl]
    public extern ContentLinkInfo();

    /// <summary>Gets or sets the identifier for the content link.</summary>
    /// <returns>The identifier for the content link.</returns>
    public extern uint Id { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the text to display for the link.</summary>
    /// <returns>The text to display for the link.</returns>
    public extern string DisplayText { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets additional information about the ContentLink to display to the user.</summary>
    /// <returns>Additional information about the ContentLink to display to the user. The default is an empty string.</returns>
    public extern string SecondaryText { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Uniform Resource Identifier (URI) of the app to launch when the link is activated.</summary>
    /// <returns>The Uniform Resource Identifier (URI) of the app to launch when the link is activated. The default is **null**.</returns>
    public extern Uri Uri { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates what kind of content the link contains.</summary>
    /// <returns>A string that indicates what kind of content the link contains.</returns>
    public extern string LinkContentKind { [MethodImpl] get; [MethodImpl] set; }
  }
}
