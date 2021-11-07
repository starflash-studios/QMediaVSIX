﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Analysis.InkAnalysisStrokeKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Analysis
{
  /// <summary>Specifies the types of ink strokes that can be recognized by the ink analysis process.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum InkAnalysisStrokeKind
  {
    /// <summary>Indicates a non-specific ink stroke.</summary>
    Auto,
    /// <summary>Indicates a handwriting ink stroke.</summary>
    Writing,
    /// <summary>Indicates a non-handwriting ink stroke.</summary>
    Drawing,
  }
}