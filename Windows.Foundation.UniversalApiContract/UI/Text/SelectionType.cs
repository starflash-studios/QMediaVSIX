// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.SelectionType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  /// <summary>Specifies the type of a selection.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SelectionType
  {
    /// <summary>No selection and no insertion point.</summary>
    None = 0,
    /// <summary>An insertion point.</summary>
    InsertionPoint = 1,
    /// <summary>A single nondegenerate range.</summary>
    Normal = 2,
    /// <summary>An image (see ITextRange.InsertImage ).</summary>
    InlineShape = 7,
    /// <summary>A shape.</summary>
    Shape = 8,
  }
}
