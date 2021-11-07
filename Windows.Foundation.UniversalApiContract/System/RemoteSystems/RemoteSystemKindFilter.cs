// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemKindFilter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>An IRemoteSystemFilter that limits the set of discoverable remote systems by allowing only those of specific device types.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IRemoteSystemKindFilterFactory), 196608, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class RemoteSystemKindFilter : IRemoteSystemKindFilter, IRemoteSystemFilter
  {
    [MethodImpl]
    public extern RemoteSystemKindFilter(IIterable<string> remoteSystemKinds);

    /// <summary>String representation(s) of the device type(s) that the containing RemoteSystemKindFilter object targets.</summary>
    /// <returns>A read-only list of string representations of the device types to target.</returns>
    public extern IVectorView<string> RemoteSystemKinds { [MethodImpl] get; }
  }
}
