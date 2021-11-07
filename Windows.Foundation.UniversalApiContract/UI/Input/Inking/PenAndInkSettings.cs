// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.PenAndInkSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  /// <summary>Provides access to user settings related to accepting and converting ink to text input in a text control (when HandwritingView is enabled).</summary>
  [Static(typeof (IPenAndInkSettingsStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PenAndInkSettings : IPenAndInkSettings, IPenAndInkSettings2
  {
    /// <summary>Gets whether ink can be used for text input in a text control (when HandwritingView is enabled).</summary>
    /// <returns>True if ink can be used for text input. Otherwise, false.</returns>
    public extern bool IsHandwritingDirectlyIntoTextFieldEnabled { [MethodImpl] get; }

    /// <summary>Gets whether the user prefers to write with their left or right hand.</summary>
    /// <returns>The user's preferred writing hand. The default is Right.</returns>
    public extern PenHandedness PenHandedness { [MethodImpl] get; }

    /// <summary>Gets the handwriting space available when using ink for text input in a text control (when HandwritingView is enabled).</summary>
    /// <returns>One of Small, Medium (default), or Large.</returns>
    public extern HandwritingLineHeight HandwritingLineHeight { [MethodImpl] get; }

    /// <summary>Gets the font used for converting ink to text input in a text control (when HandwritingView is enabled).</summary>
    /// <returns>One of the fonts from the *Font when using handwriting* ListBox on the **Pen &amp; Windows Ink** settings screen. The default is Segoe UI.</returns>
    public extern string FontFamilyName { [MethodImpl] get; }

    /// <summary>Gets whether ink/handwriting input telemetry data can be collected and sent to Microsoft for improving recognition and suggestion capabilities.</summary>
    /// <returns>True if consent has been granted. Otherwise, false.</returns>
    public extern bool UserConsentsToHandwritingTelemetryCollection { [MethodImpl] get; }

    /// <summary>Gets whether touch inking can be used for text input in a text control (when HandwritingView is enabled).</summary>
    /// <returns>True if touch inking can be used for text input. Otherwise, false.</returns>
    public extern bool IsTouchHandwritingEnabled { [MethodImpl] get; }

    [MethodImpl]
    public extern void SetPenHandedness(PenHandedness value);

    /// <summary>Creates a PenAndInkSettings object with default property values.</summary>
    /// <returns>A PenAndInkSettings object with default property values.</returns>
    [MethodImpl]
    public static extern PenAndInkSettings GetDefault();
  }
}
