// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.AppWindowFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.WindowManagement
{
  /// <summary>Represents the current frame that is applied around the window content.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public sealed class AppWindowFrame : IAppWindowFrameStyle, IAppWindowFrame
  {
    /// <summary>Returns the style of frame used for the current window.</summary>
    /// <returns>A value of the enumeration that specifies which frame style is used.</returns>
    [MethodImpl]
    public extern AppWindowFrameStyle GetFrameStyle();

    /// <summary>Sets the style of frame to use for the app window.</summary>
    /// <param name="frameStyle">A value of the enumeration that specifies which frame style to use.</param>
    [MethodImpl]
    public extern void SetFrameStyle(AppWindowFrameStyle frameStyle);

    /// <summary>Gets a list of drag visuals currently associated with the frame if any have been successfully set. The default system drag visual for the system drawn titlebar is not returned through this method.</summary>
    /// <returns>A list of drag visuals currently associated with the frame if any have been successfully set.</returns>
    public extern IVector<IVisualElement> DragRegionVisuals { [MethodImpl] get; }
  }
}
