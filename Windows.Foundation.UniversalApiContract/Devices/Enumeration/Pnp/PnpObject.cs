// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.Pnp.PnpObject
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration.Pnp
{
  /// <summary>Represents a PnP object. This class allows access to well-known properties of a PnP object as well as a property store of additional properties that are specified to be retrieved from the PnP object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IPnpObjectStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class PnpObject : IPnpObject
  {
    /// <summary>The type of the PnpObject.</summary>
    /// <returns>The type of the object.</returns>
    public extern PnpObjectType Type { [MethodImpl] get; }

    /// <summary>A string representing the identity of the PnpObject.</summary>
    /// <returns>The identity string.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>A property store containing well-known values as well as additional specified properties.</summary>
    /// <returns>A pointer to the property store.</returns>
    public extern IMapView<string, object> Properties { [MethodImpl] [return: HasVariant] get; }

    /// <summary>Updates the properties of an existing PnpObject by applying the changes described in a PnpObjectUpdate object.</summary>
    /// <param name="updateInfo">Indicates the properties to update.</param>
    [MethodImpl]
    public extern void Update(PnpObjectUpdate updateInfo);

    [MethodImpl]
    public static extern IAsyncOperation<PnpObject> CreateFromIdAsync(
      PnpObjectType type,
      string id,
      IIterable<string> requestedProperties);

    [Overload("FindAllAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<PnpObjectCollection> FindAllAsync(
      PnpObjectType type,
      IIterable<string> requestedProperties);

    [Overload("FindAllAsyncAqsFilter")]
    [MethodImpl]
    public static extern IAsyncOperation<PnpObjectCollection> FindAllAsync(
      PnpObjectType type,
      IIterable<string> requestedProperties,
      string aqsFilter);

    [Overload("CreateWatcher")]
    [MethodImpl]
    public static extern PnpObjectWatcher CreateWatcher(
      PnpObjectType type,
      IIterable<string> requestedProperties);

    [Overload("CreateWatcherAqsFilter")]
    [MethodImpl]
    public static extern PnpObjectWatcher CreateWatcher(
      PnpObjectType type,
      IIterable<string> requestedProperties,
      string aqsFilter);
  }
}
