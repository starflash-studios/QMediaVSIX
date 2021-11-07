// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.TextReadingOrder
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Provides a value for **TextReadingOrder** properties.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum TextReadingOrder
  {
    /// <summary>Do not detect flow direction from content. Use FlowDirection value (if any) for reading order decisions. (Windows 8.1 only. See Remarks.)</summary>
    /// <deprecated type="deprecate">Consider using UseFlowDirection, which is an improved version of Default. For more info, see MSDN.</deprecated>
    [Deprecated("Consider using UseFlowDirection, which is an improved version of Default. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] Default = 0,
    /// <summary>Do not detect flow direction from content. Use FlowDirection value (if any) for reading order decisions. (Windows 10 only. See Remarks.)</summary>
    UseFlowDirection = 0,
    /// <summary>Detect flow direction from text content. For bidirectional text, text containers will infer the reading order for text based on the content. See Remarks.</summary>
    DetectFromContent = 1,
  }
}
