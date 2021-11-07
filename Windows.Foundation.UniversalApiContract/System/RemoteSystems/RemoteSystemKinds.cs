// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemKinds
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Contains read-only strings that identify various device types.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IRemoteSystemKindStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IRemoteSystemKindStatics2), 327680, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public static class RemoteSystemKinds
  {
    /// <summary>Gets the string representation of the **Internet of Things (IoT)** device type.</summary>
    /// <returns>String representing **IoT**.</returns>
    public static extern string Iot { [MethodImpl] get; }

    /// <summary>Gets the string representation of the **tablet** device type.</summary>
    /// <returns>String representing **tablet**.</returns>
    public static extern string Tablet { [MethodImpl] get; }

    /// <summary>Gets the string representation of the **laptop** device type.</summary>
    /// <returns>String representing **laptop**.</returns>
    public static extern string Laptop { [MethodImpl] get; }

    /// <summary>Gets the string representation of the **phone** device type.</summary>
    /// <returns>String representing **phone**.</returns>
    public static extern string Phone { [MethodImpl] get; }

    /// <summary>Gets the string representation of the **hub** device type.</summary>
    /// <returns>String representing **hub**.</returns>
    public static extern string Hub { [MethodImpl] get; }

    /// <summary>Gets the string representation of the **holographic** device type.</summary>
    /// <returns>String representing **holographic**.</returns>
    public static extern string Holographic { [MethodImpl] get; }

    /// <summary>Gets the string representation of the **desktop** device type.</summary>
    /// <returns>String representing **desktop**.</returns>
    public static extern string Desktop { [MethodImpl] get; }

    /// <summary>Gets the string representation of the **Xbox** device type.</summary>
    /// <returns>String representing **Xbox**.</returns>
    public static extern string Xbox { [MethodImpl] get; }
  }
}
