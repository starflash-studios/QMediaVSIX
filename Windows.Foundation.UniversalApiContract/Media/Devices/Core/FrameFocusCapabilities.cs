// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.FrameFocusCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  /// <summary>Provides information about the focus capabilities of the capture device for frames in a variable photo sequences.</summary>
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class FrameFocusCapabilities : IFrameFocusCapabilities
  {
    /// <summary>Gets a value that indicates if the capture device supports the focus control for frames in a variable photo sequence.</summary>
    /// <returns>True if the capture device supports the focus control; otherwise, false.</returns>
    public extern bool Supported { [MethodImpl] get; }

    /// <summary>Gets the minimum focus length supported by the capture device for a frame in a variable photo sequence, specified in millimeters.</summary>
    /// <returns>The minimum focus length supported by the capture device for a frame in a variable photo sequence.</returns>
    public extern uint Min { [MethodImpl] get; }

    /// <summary>Gets the maximum focus length supported by the capture device for a frame in a variable photo sequence, specified in millimeters.</summary>
    /// <returns>The maximum focus length supported by the capture device for a frame in a variable photo sequence.</returns>
    public extern uint Max { [MethodImpl] get; }

    /// <summary>Gets the smallest focus increment supported by the capture device for a frame in a variable photo sequence, specified in millimeters.</summary>
    /// <returns>The smallest focus increment supported by the capture device for a frame in a variable photo sequence.</returns>
    public extern uint Step { [MethodImpl] get; }
  }
}
