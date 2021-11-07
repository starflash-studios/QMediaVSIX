// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionMappingMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Defines constants that specify whether the gradient brush's positioning coordinates (StartPoint, EndPoint) are absolute or relative to the output area.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum CompositionMappingMode
  {
    /// <summary>Positioning coordinates (StartPoint, EndPoint) are absolute.</summary>
    Absolute,
    /// <summary>Positioning coordinates (StartPoint, EndPoint) are relative to the output area.</summary>
    Relative,
  }
}
