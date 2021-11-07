// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.SupportedTextSelection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  /// <summary>Contains values that specify whether a text provider supports selection and, if so, whether it supports a single, continuous selection or multiple, disjoint selections.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum SupportedTextSelection
  {
    /// <summary>Does not support text selections.</summary>
    None,
    /// <summary>Supports a single, continuous text selection.</summary>
    Single,
    /// <summary>Supports multiple, disjoint text selections.</summary>
    Multiple,
  }
}
