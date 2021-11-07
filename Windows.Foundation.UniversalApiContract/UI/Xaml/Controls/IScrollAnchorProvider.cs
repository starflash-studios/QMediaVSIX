// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IScrollAnchorProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Specifies a contract for a scrolling control that supports scroll anchoring.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(1793694223, 18316, 21568, 178, 198, 234, 212, 55, 142, 248, 228)]
  [WebHostHidden]
  public interface IScrollAnchorProvider
  {
    /// <summary>The currently chosen anchor element to use for scroll anchoring.</summary>
    /// <returns>The most recently chosen UIElement for scroll anchoring after a layout pass, or **null**.</returns>
    UIElement CurrentAnchor { get; }

    /// <summary>Registers a UIElement as a potential scroll anchor candidate.</summary>
    /// <param name="element">A UIElement within the subtree of the IScrollAnchorProvider.</param>
    void RegisterAnchorCandidate(UIElement element);

    /// <summary>Unregisters a UIElement as a potential scroll anchor candidate.</summary>
    /// <param name="element">A UIElement within the subtree of the IScrollAnchorProvider.</param>
    void UnregisterAnchorCandidate(UIElement element);
  }
}
