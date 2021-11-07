// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.FlowDirection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Defines constants that specify the content flow direction for text and UI elements.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum FlowDirection
  {
    /// <summary>Indicates that content should flow from left to right.</summary>
    LeftToRight,
    /// <summary>Indicates that content should flow from right to left.</summary>
    RightToLeft,
  }
}
