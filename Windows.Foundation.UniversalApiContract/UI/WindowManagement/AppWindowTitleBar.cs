﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.AppWindowTitleBar
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.WindowManagement
{
  /// <summary>Represents the title bar of an app window.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AppWindowTitleBar : IAppWindowTitleBarVisibility, IAppWindowTitleBar
  {
    /// <summary>Returns the preferred visibility mode for the title bar.</summary>
    /// <returns>A value of the enumeration that indicates the preferred visibility mode for the title bar.</returns>
    [MethodImpl]
    public extern AppWindowTitleBarVisibility GetPreferredVisibility();

    /// <summary>Sets the preferred visibility mode for the title bar.</summary>
    /// <param name="visibilityMode">A value of the enumeration that specifies the preferred visibility mode for the title bar.</param>
    [MethodImpl]
    public extern void SetPreferredVisibility(AppWindowTitleBarVisibility visibilityMode);

    /// <summary>Gets or sets the color of the title bar background.</summary>
    /// <returns>The color of the title bar background. (See Color.)</returns>
    public extern IReference<Color> BackgroundColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the background color of the title bar buttons.</summary>
    /// <returns>The background color of the title bar buttons. (See Color.)</returns>
    public extern IReference<Color> ButtonBackgroundColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the foreground color of the title bar buttons.</summary>
    /// <returns>The foreground color of the title bar buttons. (See Color.)</returns>
    public extern IReference<Color> ButtonForegroundColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the background color of a title bar button when the pointer is over it.</summary>
    /// <returns>The background color of a title bar button when the pointer is over it. (See Color.)</returns>
    public extern IReference<Color> ButtonHoverBackgroundColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the foreground color of a title bar button when the pointer is over it.</summary>
    /// <returns>The foreground color of a title bar button when the pointer is over it. (See Color.)</returns>
    public extern IReference<Color> ButtonHoverForegroundColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the background color of a title bar button when it's inactive.</summary>
    /// <returns>The background color of a title bar button when it's inactive. (See Color.)</returns>
    public extern IReference<Color> ButtonInactiveBackgroundColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the foreground color of a title bar button when it's inactive.</summary>
    /// <returns>The foreground color of a title bar button when it's inactive. (See Color.)</returns>
    public extern IReference<Color> ButtonInactiveForegroundColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the background color of a title bar button when it's pressed.</summary>
    /// <returns>The background color of a title bar button when it's pressed. (See Color.)</returns>
    public extern IReference<Color> ButtonPressedBackgroundColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the foreground color of a title bar button when it's pressed.</summary>
    /// <returns>The foreground color of a title bar button when it's pressed. (See Color.)</returns>
    public extern IReference<Color> ButtonPressedForegroundColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies whether this title bar should replace the default window title bar.</summary>
    /// <returns>**true** to replace the default window title bar; otherwise, **false**. The default is **false**.</returns>
    public extern bool ExtendsContentIntoTitleBar { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the color of the title bar foreground.</summary>
    /// <returns>The color of the title bar foreground. (See Color.)</returns>
    public extern IReference<Color> ForegroundColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the color of the title bar background when it's inactive.</summary>
    /// <returns>The color of the title bar background when it's inactive. (See Color.)</returns>
    public extern IReference<Color> InactiveBackgroundColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the color of the title bar foreground when it's inactive.</summary>
    /// <returns>The color of the title bar foreground when it's inactive. (See Color.)</returns>
    public extern IReference<Color> InactiveForegroundColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that specifies whether this title bar is visible.</summary>
    /// <returns>**true** if this title bar is visible; otherwise, **false**.</returns>
    public extern bool IsVisible { [MethodImpl] get; }

    /// <summary>Gets a list of title bar occlusions.</summary>
    /// <returns>A list of title bar occlusions.</returns>
    [MethodImpl]
    public extern IVectorView<AppWindowTitleBarOcclusion> GetTitleBarOcclusions();
  }
}