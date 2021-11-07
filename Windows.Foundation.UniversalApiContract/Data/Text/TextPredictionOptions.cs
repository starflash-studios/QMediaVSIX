// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.TextPredictionOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  /// <summary>Defines constants that specify text prediction options.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum TextPredictionOptions : uint
  {
    /// <summary>Indicates that neither corrections nor predictions should be retrieved.</summary>
    None = 0,
    /// <summary>Indicates that predictions should be retrieved.</summary>
    Predictions = 1,
    /// <summary>Indicates that corrections should be retrieved.</summary>
    Corrections = 2,
  }
}
