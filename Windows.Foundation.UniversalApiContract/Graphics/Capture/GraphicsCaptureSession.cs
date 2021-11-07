// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Capture.GraphicsCaptureSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Capture
{
  /// <summary>Allows the application to take screen captures.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IGraphicsCaptureSessionStatics), 393216, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  [DualApiPartition(version = 167772164)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GraphicsCaptureSession : 
    IGraphicsCaptureSession,
    IGraphicsCaptureSession2,
    IGraphicsCaptureSession3,
    IClosable
  {
    /// <summary>Starts the capture session, allowing the application to capture frames.</summary>
    [MethodImpl]
    public extern void StartCapture();

    /// <summary>Gets or sets a value specifying whether the capture session will include the cursor in the captured content.</summary>
    /// <returns>True if the cursor should be captured; otherwise, false.</returns>
    public extern bool IsCursorCaptureEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsBorderRequired { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void Close();

    /// <summary>Returns true if screen capture is supported on the device.</summary>
    /// <returns>True if screen capture is supported on the device.</returns>
    [MethodImpl]
    public static extern bool IsSupported();
  }
}
