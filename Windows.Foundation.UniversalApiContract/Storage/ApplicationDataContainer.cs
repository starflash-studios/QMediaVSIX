// Decompiled with JetBrains decompiler
// Type: Windows.Storage.ApplicationDataContainer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  /// <summary>Represents a container for app settings. The methods and properties of this class support creating, deleting, enumerating, and traversing the container hierarchy.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  public sealed class ApplicationDataContainer : IApplicationDataContainer, IClosable
  {
    /// <summary>Gets the name of the current settings container.</summary>
    /// <returns>The name of the settings container.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets the type (local or roaming) of the app data store that is associated with the current settings container.</summary>
    /// <returns>One of the enumeration values.</returns>
    public extern ApplicationDataLocality Locality { [MethodImpl] get; }

    /// <summary>Gets an object that represents the settings in this settings container.</summary>
    /// <returns>The settings map object.</returns>
    public extern IPropertySet Values { [MethodImpl] get; }

    /// <summary>Gets the child application settings containers of this application settings container.</summary>
    /// <returns>The application settings containers.</returns>
    public extern IMapView<string, ApplicationDataContainer> Containers { [MethodImpl] get; }

    /// <summary>Creates or opens the specified settings container in the current settings container.</summary>
    /// <param name="name">The name of the container.</param>
    /// <param name="disposition">One of the enumeration values.</param>
    /// <returns>The settings container.</returns>
    [MethodImpl]
    public extern ApplicationDataContainer CreateContainer(
      string name,
      ApplicationDataCreateDisposition disposition);

    /// <summary>Deletes the specified settings container, its subcontainers, and all application settings in the hierarchy.</summary>
    /// <param name="name">The name of the settings container.</param>
    [MethodImpl]
    public extern void DeleteContainer(string name);

    [MethodImpl]
    public extern void Close();
  }
}
