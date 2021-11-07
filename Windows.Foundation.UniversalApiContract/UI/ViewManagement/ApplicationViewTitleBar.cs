// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.ApplicationViewTitleBar
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  /// <summary>Represents the title bar of an app.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ApplicationViewTitleBar : IApplicationViewTitleBar
  {
    /// <summary>Gets or sets the color of the title bar foreground.</summary>
    /// <returns>The color of the title bar foreground. (See Color.)</returns>
    public extern IReference<Color> ForegroundColor { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the color of the title bar background.</summary>
    /// <returns>The color of the title bar background. (See Color.)</returns>
    public extern IReference<Color> BackgroundColor { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the foreground color of the title bar buttons.</summary>
    /// <returns>The foreground color of the title bar buttons. (See Color.)</returns>
    public extern IReference<Color> ButtonForegroundColor { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the background color of the title bar buttons.</summary>
    /// <returns>The background color of the title bar buttons. (See Color.)</returns>
    public extern IReference<Color> ButtonBackgroundColor { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the foreground color of a title bar button when the pointer is over it.</summary>
    /// <returns>The foreground color of a title bar button when the pointer is over it. (See Color.)</returns>
    public extern IReference<Color> ButtonHoverForegroundColor { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the background color of a title bar button when the pointer is over it.</summary>
    /// <returns>The background color of a title bar button when the pointer is over it. (See Color.)</returns>
    public extern IReference<Color> ButtonHoverBackgroundColor { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the foreground color of a title bar button when it's pressed.</summary>
    /// <returns>The foreground color of a title bar button when it's pressed. (See Color.)</returns>
    public extern IReference<Color> ButtonPressedForegroundColor { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the background color of a title bar button when it's pressed.</summary>
    /// <returns>The background color of a title bar button when it's pressed. (See Color.)</returns>
    public extern IReference<Color> ButtonPressedBackgroundColor { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the color of the title bar foreground when it's inactive.</summary>
    /// <returns>The color of the title bar foreground when it's inactive. (See Color.)</returns>
    public extern IReference<Color> InactiveForegroundColor { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the color of the title bar background when it's inactive.</summary>
    /// <returns>The color of the title bar background when it's inactive. (See Color.)</returns>
    public extern IReference<Color> InactiveBackgroundColor { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the foreground color of a title bar button when it's inactive.</summary>
    /// <returns>The foreground color of a title bar button when it's inactive. (See Color.)</returns>
    public extern IReference<Color> ButtonInactiveForegroundColor { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the background color of a title bar button when it's inactive.</summary>
    /// <returns>The background color of a title bar button when it's inactive. (See Color.)</returns>
    public extern IReference<Color> ButtonInactiveBackgroundColor { [MethodImpl] set; [MethodImpl] get; }
  }
}
