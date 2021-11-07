// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.ParagraphStyle
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  /// <summary>Specifies the paragraph style.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ParagraphStyle
  {
    /// <summary>The paragraph style is undefined.</summary>
    Undefined,
    /// <summary>There is no paragraph style.</summary>
    None,
    /// <summary>The paragraph style is normal.</summary>
    Normal,
    /// <summary>The top level heading.</summary>
    Heading1,
    /// <summary>The second level heading.</summary>
    Heading2,
    /// <summary>Third level heading.</summary>
    Heading3,
    /// <summary>Fourth level heading.</summary>
    Heading4,
    /// <summary>Fifth level heading.</summary>
    Heading5,
    /// <summary>Sixth level heading.</summary>
    Heading6,
    /// <summary>Seventh level heading.</summary>
    Heading7,
    /// <summary>Eighth level heading.</summary>
    Heading8,
    /// <summary>Ninth level heading.</summary>
    Heading9,
  }
}
