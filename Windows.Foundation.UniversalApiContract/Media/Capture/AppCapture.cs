// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.AppCapture
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  /// <summary>Provides information about the app capture feature.</summary>
  [Static(typeof (IAppCaptureStatics2), 327680, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Static(typeof (IAppCaptureStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  public sealed class AppCapture : IAppCapture
  {
    /// <summary>Gets a value indicating whether another app is currently capturing audio.</summary>
    /// <returns>True if another app is currently capturing audio; otherwise, false.</returns>
    public extern bool IsCapturingAudio { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether another app is currently capturing video.</summary>
    /// <returns>True if another app is currently capturing video; otherwise, false.</returns>
    public extern bool IsCapturingVideo { [MethodImpl] get; }

    /// <summary>Raised when the capturing status changes.</summary>
    public extern event TypedEventHandler<AppCapture, object> CapturingChanged;

    /// <summary>Sets a value that specifies whether the app capture is currently allowed for the calling app.</summary>
    /// <param name="allowed">True if app capture is allowed; otherwise, false.</param>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction SetAllowedAsync(bool allowed);

    /// <summary>Gets the instance of this class for the current view.</summary>
    /// <returns>The instance for the current view.</returns>
    [MethodImpl]
    public static extern AppCapture GetForCurrentView();
  }
}
