// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppInstance
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  /// <summary>Represents an instance of an app.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Static(typeof (IAppInstanceStatics), 393216, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class AppInstance : IAppInstance
  {
    /// <summary>The key for the current instance.</summary>
    /// <returns>The app-defined key for the current instance.</returns>
    public extern string Key { [MethodImpl] get; }

    /// <summary>Whether the current instance of the app is the registered instance of the app for the specific key that this instance has defined.</summary>
    /// <returns>A Boolean that indicates whether the current app is the registered instance of the app.</returns>
    public extern bool IsCurrentInstance { [MethodImpl] get; }

    /// <summary>Redirects activation of the current app instance to the specified instance.</summary>
    [MethodImpl]
    public extern void RedirectActivationTo();

    /// <summary>A shell can recommend an instance of an app to which an application activation is redirected.</summary>
    /// <returns>The app instance that the shell prefers to use for an app, or `null` if there is no preference.</returns>
    public static extern AppInstance RecommendedInstance { [MethodImpl] get; }

    /// <summary>Gets the current **IActivatedEventArgs**, the same as would normally be passed in to the *OnActivated* method of the app.</summary>
    /// <returns>The current **IActivatedEventArgs**, or `null`.</returns>
    [MethodImpl]
    public static extern IActivatedEventArgs GetActivatedEventArgs();

    /// <summary>Registers an app instance with the platform, or finds an existing instance if another instance has already registered this key.</summary>
    /// <param name="key">A non-empty string as a key for the instance.</param>
    /// <returns>An app instance that represents the first app that registered the key. </returns>
    [MethodImpl]
    public static extern AppInstance FindOrRegisterInstanceForKey(string key);

    /// <summary>Updates the system cache so that the current instance is no longer available for activation redirection.</summary>
    [MethodImpl]
    public static extern void Unregister();

    /// <summary>Gets the registered instances of the current app.</summary>
    /// <returns>A list of the registered instances of the current app.</returns>
    [MethodImpl]
    public static extern IVector<AppInstance> GetInstances();
  }
}
