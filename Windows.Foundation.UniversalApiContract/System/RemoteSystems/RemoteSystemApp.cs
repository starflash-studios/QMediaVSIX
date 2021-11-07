// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemApp
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Represents an application on a remote system.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public sealed class RemoteSystemApp : IRemoteSystemApp, IRemoteSystemApp2
  {
    /// <summary>The unique identifier for this application.</summary>
    /// <returns>A unique String identifier.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>The display-friendly name for this application. This is the name used by the device for Bluetooth identification. If this hasn't been set or the device doesn't support Bluetooth, this field will be empty.</summary>
    /// <returns>A String of the display name.</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>Indicates whether this application is currently available for proximal connection.</summary>
    /// <returns>**true** if the application is available for proximal connection, otherwise **false**.</returns>
    public extern bool IsAvailableByProximity { [MethodImpl] get; }

    /// <summary>Indicates whether this application is currently available for spatial sharing connection.</summary>
    /// <returns>**true** if the application is available for spatial sharing, otherwise **false**.</returns>
    public extern bool IsAvailableBySpatialProximity { [MethodImpl] get; }

    /// <summary>The app-specific attributes of this application.</summary>
    /// <returns>A Map of key/value pairs defining the attributes.</returns>
    public extern IMapView<string, string> Attributes { [MethodImpl] get; }

    /// <summary>Gets the User.</summary>
    /// <returns>The User.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Gets a token that can be persisted by a RemoteSystemApp so that it can be connected back to later.</summary>
    /// <returns>A string of the ConnectionToken.</returns>
    public extern string ConnectionToken { [MethodImpl] get; }
  }
}
