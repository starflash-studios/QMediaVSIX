// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.LinkType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  /// <summary>Indicates the link type of a range of text.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum LinkType
  {
    /// <summary>A mix of link and nonlink attributes.</summary>
    Undefined,
    /// <summary>Not a link.</summary>
    NotALink,
    /// <summary>A link specified by the client; that is, not an autolink or a friendly-name link.</summary>
    ClientLink,
    /// <summary>The name part of a friendly-name link. The name is the part that is displayed.</summary>
    FriendlyLinkName,
    /// <summary>The address Uniform Resource Identifier (URI) part of friendly-name link. The address it the part that is sent when the user clicks the name.</summary>
    FriendlyLinkAddress,
    /// <summary>A Uniform Resource Identifier (URI) that is automatically recognized.</summary>
    AutoLink,
    /// <summary>An email address that is automatically recognized.</summary>
    AutoLinkEmail,
    /// <summary>A phone number that is automatically recognized.</summary>
    AutoLinkPhone,
    /// <summary>A file name, including the full path, that is automatically recognized.</summary>
    AutoLinkPath,
  }
}
