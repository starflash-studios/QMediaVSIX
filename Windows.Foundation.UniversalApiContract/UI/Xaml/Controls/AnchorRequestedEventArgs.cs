// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.AnchorRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides data for the ScrollViewer.AnchorRequested event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  public sealed class AnchorRequestedEventArgs : IAnchorRequestedEventArgs
  {
    /// <summary>Gets or sets the *anchor element* to use when performing scroll anchoring.</summary>
    /// <returns>The UIElement to use as the CurrentAnchor. The default is **null**.</returns>
    public extern UIElement Anchor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the set of anchor candidates that are currently registered with the scrolling control (for example, ScrollViewer).</summary>
    /// <returns>A list of UIElement anchor candidates.</returns>
    public extern IVector<UIElement> AnchorCandidates { [MethodImpl] get; }
  }
}
