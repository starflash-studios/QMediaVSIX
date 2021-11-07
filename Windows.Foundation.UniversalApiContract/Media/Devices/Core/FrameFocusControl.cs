// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.FrameFocusControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  /// <summary>Represents the focus settings for a frame in a variable photo sequence.</summary>
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class FrameFocusControl : IFrameFocusControl
  {
    /// <summary>Gets or sets the focus value for a frame in a variable photo sequence.</summary>
    /// <returns>The focus value for a frame in a variable photo sequence.</returns>
    public extern IReference<uint> Value { [MethodImpl] get; [MethodImpl] set; }
  }
}
