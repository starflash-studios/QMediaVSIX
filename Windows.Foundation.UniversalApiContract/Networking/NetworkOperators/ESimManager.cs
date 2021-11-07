// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.ESimManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>A class that you can use to construct an ESimWatcher, and to obtain service information.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IESimManagerStatics), 393216, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class ESimManager
  {
    /// <summary>Gets service information for the eSIM manager object.</summary>
    /// <returns>Service information for the eSIM manager object.</returns>
    public static extern ESimServiceInfo ServiceInfo { [MethodImpl] get; }

    /// <summary>Attempts to create a new instance of the ESimWatcher class.</summary>
    /// <returns>A new instance of the ESimWatcher class, or `null` if the caller's user security identifier (SID) is not authorized by the Windows service that handles eSIM-related operation requests.</returns>
    [MethodImpl]
    public static extern ESimWatcher TryCreateESimWatcher();

    /// <summary>Occurs when a property of the service information object changes.</summary>
    public static extern event EventHandler<object> ServiceInfoChanged;
  }
}
