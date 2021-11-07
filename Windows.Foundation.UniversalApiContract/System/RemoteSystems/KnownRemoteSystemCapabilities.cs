// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.KnownRemoteSystemCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Contains the string names of different features of the Remote Systems platform. A remote system is either compatible or incompatible with each of the capabilities corresponding to the properties of this class.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (IKnownRemoteSystemCapabilitiesStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class KnownRemoteSystemCapabilities
  {
    /// <summary>Gets the canonical string name of the app service capability.</summary>
    /// <returns>The canonical string name of the app service capability.</returns>
    public static extern string AppService { [MethodImpl] get; }

    /// <summary>Gets the canonical string name of the launch URI capability.</summary>
    /// <returns>The canonical string name of the launch URI capability.</returns>
    public static extern string LaunchUri { [MethodImpl] get; }

    /// <summary>Gets the canonical string name of the remote session capability.</summary>
    /// <returns>The canonical string name of the remote session capability.</returns>
    public static extern string RemoteSession { [MethodImpl] get; }

    /// <summary>Gets the canonical string name of the spatial entity capability.</summary>
    /// <returns>The canonical string name of the spatial entity capability.</returns>
    public static extern string SpatialEntity { [MethodImpl] get; }
  }
}
