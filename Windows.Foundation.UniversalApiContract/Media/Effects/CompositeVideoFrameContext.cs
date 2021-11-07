// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.CompositeVideoFrameContext
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Media.Editing;

namespace Windows.Media.Effects
{
  /// <summary>Provides context for performing a custom overlay operation within the CompositeFrame method.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [GCPressure(amount = GCPressureAmount.High)]
  [DualApiPartition(version = 167772160)]
  public sealed class CompositeVideoFrameContext : ICompositeVideoFrameContext
  {
    /// <summary>Gets the list of Direct3D surfaces to be used in an overlay operation.</summary>
    /// <returns>The list of Direct3D surfaces to be used in an overlay operation.</returns>
    public extern IVectorView<IDirect3DSurface> SurfacesToOverlay { [MethodImpl] get; }

    /// <summary>Gets the background frame for an overlay operation.</summary>
    /// <returns>The background frame for an overlay operation.</returns>
    public extern VideoFrame BackgroundFrame { [MethodImpl] get; }

    /// <summary>Gets the output frame for an overlay operation.</summary>
    /// <returns>The output frame for an overlay operation.</returns>
    public extern VideoFrame OutputFrame { [MethodImpl] get; }

    /// <summary>Gets a MediaOverlay object for the provided Direct3D surface.</summary>
    /// <param name="surfaceToOverlay">The Direct3D surface.</param>
    /// <returns>The created MediaOverlay object.</returns>
    [MethodImpl]
    public extern MediaOverlay GetOverlayForSurface(IDirect3DSurface surfaceToOverlay);
  }
}
