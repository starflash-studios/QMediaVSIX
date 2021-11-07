// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.ScrollPatternIdentifiers
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  /// <summary>Contains values used as identifiers by IScrollProvider, and also contains the NoScroll constant.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IScrollPatternIdentifiersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ScrollPatternIdentifiers : IScrollPatternIdentifiers
  {
    /// <summary>Identifies the HorizontallyScrollable automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty HorizontallyScrollableProperty { [MethodImpl] get; }

    /// <summary>Identifies the HorizontalScrollPercent automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty HorizontalScrollPercentProperty { [MethodImpl] get; }

    /// <summary>Identifies the HorizontalViewSize automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty HorizontalViewSizeProperty { [MethodImpl] get; }

    /// <summary>Specifies that scrolling should not be performed.</summary>
    /// <returns>The value – 1. This is the value to return if a client asks for the scrolling percentage, but scrolling is not enabled.</returns>
    public static extern double NoScroll { [MethodImpl] get; }

    /// <summary>Identifies the VerticallyScrollable automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty VerticallyScrollableProperty { [MethodImpl] get; }

    /// <summary>Identifies the VerticalScrollPercent automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty VerticalScrollPercentProperty { [MethodImpl] get; }

    /// <summary>Identifies the VerticalViewSize automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty VerticalViewSizeProperty { [MethodImpl] get; }
  }
}
