// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.ScrollAmount
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  /// <summary>Contains values that are used by the IScrollProvider pattern to indicate the direction and distance to scroll.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum ScrollAmount
  {
    /// <summary>Specifies that scrolling is performed in large decrements, which is equivalent to pressing the PAGE UP key or to clicking a blank part of a scrollbar. If the distance represented by the PAGE UP key is not a relevant amount for the control, or if no scrollbar exists, the value represents an amount equal to the size of the currently visible window.</summary>
    LargeDecrement,
    /// <summary>Specifies that scrolling is performed in small decrements, which is equivalent to pressing an arrow key or to clicking the arrow button on a scrollbar.</summary>
    SmallDecrement,
    /// <summary>Specifies that scrolling should not be performed.</summary>
    NoAmount,
    /// <summary>Specifies that scrolling is performed in large increments, which is equivalent to pressing the PAGE DOWN key or to clicking a blank part of a scrollbar. If the distance represented by the PAGE DOWN key is not a relevant amount for the control, or if no scrollbar exists, the value represents an amount equal to the size of the currently visible region.</summary>
    LargeIncrement,
    /// <summary>Specifies that scrolling is performed in small increments, which is equivalent to pressing an arrow key or to clicking the arrow button on a scrollbar.</summary>
    SmallIncrement,
  }
}
