// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Analysis.InkAnalysisNodeKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Analysis
{
  /// <summary>Specifies the types of nodes (or categories of ink input) that ink analysis can differentiate and recognize.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum InkAnalysisNodeKind
  {
    /// <summary>Node is for unrecognized ink.</summary>
    UnclassifiedInk,
    /// <summary>Node is the first, or topmost, in the collection of nodes.</summary>
    Root,
    /// <summary>Node is for a generic writing region.</summary>
    WritingRegion,
    /// <summary>Node is for a paragraph of text.</summary>
    Paragraph,
    /// <summary>Node is for a single line of text.</summary>
    Line,
    /// <summary>Node is for a single word of text.</summary>
    InkWord,
    /// <summary>Node is for a list item bullet.</summary>
    InkBullet,
    /// <summary>Node is for one of the recognized shapes specified in InkAnalysisDrawingKind.</summary>
    InkDrawing,
    /// <summary>Node is for a list item.</summary>
    ListItem,
  }
}
