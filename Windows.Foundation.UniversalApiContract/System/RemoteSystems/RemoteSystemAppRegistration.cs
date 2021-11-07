// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemAppRegistration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>This class represents an application that is to be registered in the cloud for remote connectivity. A registered app can provide remote app services or be used to launch a URI.</summary>
  [Static(typeof (IRemoteSystemAppRegistrationStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RemoteSystemAppRegistration : IRemoteSystemAppRegistration
  {
    /// <summary>The user under which to register the app.</summary>
    /// <returns>The user.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Gets the attributes associated with this application.</summary>
    /// <returns>A map of key/value attributes.</returns>
    public extern IMap<string, string> Attributes { [MethodImpl] get; }

    /// <summary>Starts the process of registering this application in the cloud.</summary>
    /// <returns>An asynchronous operation with a value of **true** if the registration was successful, otherwise **false**.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> SaveAsync();

    /// <summary>Gets a **RemoteSystemAppRegistration ** instance to register an app for the device's default user account.</summary>
    /// <returns>A new **RemoteSystemAppRegistration** instance.</returns>
    [MethodImpl]
    public static extern RemoteSystemAppRegistration GetDefault();

    /// <summary>Gets a **RemoteSystemAppRegistration ** instance to register an app for the given user.</summary>
    /// <param name="user">The user.</param>
    /// <returns>A new **RemoteSystemAppRegistration** instance.</returns>
    [MethodImpl]
    public static extern RemoteSystemAppRegistration GetForUser(User user);
  }
}
