// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynBusObject
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  /// <summary>Represents a bus object available over the transport agnostic communication pipeline.</summary>
  [DualApiPartition(version = 167772160)]
  [Deprecated("AllJoynBusObject has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Activatable(typeof (IAllJoynBusObjectFactory), 196608, "Windows.Foundation.UniversalApiContract")]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AllJoynBusObject : IAllJoynBusObject
  {
    /// <summary>Create an AllJoynBusObject that will implement one or more interfaces at the specified object path.</summary>
    /// <param name="objectPath">The object path.</param>
    [Deprecated("AllJoynBusObject has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern AllJoynBusObject(string objectPath);

    /// <summary>Create an AllJoynBusObject that will implement one or more interfaces at the specified object path with the AllJoynBusAttachment specified.</summary>
    /// <param name="objectPath">The object path.</param>
    /// <param name="busAttachment">The bus attachment instance.</param>
    [Deprecated("AllJoynBusObject has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern AllJoynBusObject(string objectPath, AllJoynBusAttachment busAttachment);

    /// <summary>Creates an AllJoynBusObject with the object path as the root object path. i.e. "/".</summary>
    [MethodImpl]
    public extern AllJoynBusObject();

    /// <summary>Starts the AllJoynBusObject. If the bus attachment is not already explicitly connected, starting the producer will automatically connect the bus attachment.</summary>
    [Deprecated("AllJoynBusObject has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void Start();

    /// <summary>Stops the AllJoynBusObject.</summary>
    [Deprecated("AllJoynBusObject has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void Stop();

    /// <summary>Adds an additional interface to be produced to the service provider.</summary>
    /// <param name="producer">The interface to be produced.</param>
    [Deprecated("AllJoynBusObject has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void AddProducer(IAllJoynProducer producer);

    /// <summary>Gets the bus attachment of this AllJoynBusObject.</summary>
    /// <returns>The bus attachment.</returns>
    public extern AllJoynBusAttachment BusAttachment { [Deprecated("AllJoynBusObject has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the AllJoynSession for this AllJoynBusObject.</summary>
    /// <returns>The AllJoyn session.</returns>
    public extern AllJoynSession Session { [Deprecated("AllJoynBusObject has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Event triggered when the AllJoynBusObject is stopped.</summary>
    public extern event TypedEventHandler<AllJoynBusObject, AllJoynBusObjectStoppedEventArgs> Stopped;
  }
}
