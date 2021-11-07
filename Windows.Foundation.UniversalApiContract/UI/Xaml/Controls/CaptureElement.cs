// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.CaptureElement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Capture;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Renders a stream from a capture device, such as a camera or webcam.  CaptureElement is used in conjunction with the Windows.Media.Capture.MediaCapture API, and must be hooked up in the code behind.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ICaptureElementStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class CaptureElement : FrameworkElement, ICaptureElement
  {
    /// <summary>Initializes a new instance of the CaptureElement class.</summary>
    [MethodImpl]
    public extern CaptureElement();

    /// <summary>Gets or sets the source MediaCapture that this CaptureElement represents.</summary>
    /// <returns>The source MediaCapture</returns>
    public extern MediaCapture Source { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets how content from Source is resized to fill its allocated space, as declared by the Height and Width properties of the CaptureElement.</summary>
    /// <returns>A value of the enumeration.</returns>
    public extern Stretch Stretch { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Source dependency property.</summary>
    /// <returns>The identifier for the Source dependency property.</returns>
    public static extern DependencyProperty SourceProperty { [MethodImpl] get; }

    /// <summary>Identifies the Stretch dependency property.</summary>
    /// <returns>The identifier for the Stretch dependency property.</returns>
    public static extern DependencyProperty StretchProperty { [MethodImpl] get; }
  }
}
