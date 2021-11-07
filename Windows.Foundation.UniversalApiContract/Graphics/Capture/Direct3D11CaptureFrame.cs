// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Capture.Direct3D11CaptureFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;

namespace Windows.Graphics.Capture
{
  /// <summary>A frame captured by the application.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [DualApiPartition(version = 167772164)]
  public sealed class Direct3D11CaptureFrame : IDirect3D11CaptureFrame, IClosable
  {
    /// <summary>The Direct3D surface on which the frame was drawn.</summary>
    /// <returns>The Direct3D surface on which the frame was drawn.</returns>
    public extern IDirect3DSurface Surface { [MethodImpl] get; }

    /// <summary>The QPC (Query Performance Counter) time at which the compositor rendered the frame.</summary>
    /// <returns>The QPC (Query Performance Counter) time at which the compositor rendered the frame.</returns>
    public extern TimeSpan SystemRelativeTime { [MethodImpl] get; }

    /// <summary>The content size at the time the frame was rendered.</summary>
    /// <returns>The content size at the time the frame was rendered.</returns>
    public extern SizeInt32 ContentSize { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();
  }
}
