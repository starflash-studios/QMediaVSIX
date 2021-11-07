// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.ZoomUnit
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  /// <summary>Contains possible values for the ZoomByUnit method, which zooms the viewport of a control by the specified unit.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ZoomUnit
  {
    /// <summary>No increase or decrease in zoom.</summary>
    NoAmount,
    /// <summary>Decrease zoom by a large decrement.</summary>
    LargeDecrement,
    /// <summary>Decrease zoom by a small decrement.</summary>
    SmallDecrement,
    /// <summary>Increase zoom by a large increment.</summary>
    LargeIncrement,
    /// <summary>Increase zoom by a small increment.</summary>
    SmallIncrement,
  }
}
