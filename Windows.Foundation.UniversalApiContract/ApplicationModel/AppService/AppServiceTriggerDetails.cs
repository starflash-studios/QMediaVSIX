// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.AppServiceTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppService
{
  /// <summary>Represents details associated with the background task for the app service. App services enable app-to-app communication by allowing you to provide services from your Universal Windows app to other Universal Windows app.</summary>
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AppServiceTriggerDetails : 
    IAppServiceTriggerDetails,
    IAppServiceTriggerDetails2,
    IAppServiceTriggerDetails3,
    IAppServiceTriggerDetails4
  {
    /// <summary>Gets the name of the app service.</summary>
    /// <returns>The name of the app service.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets the name of the package family for the client app that called the background task for the app service.</summary>
    /// <returns>The name of the package family for the client app that called the background task for the app service.</returns>
    public extern string CallerPackageFamilyName { [MethodImpl] get; }

    /// <summary>Gets the connection to the endpoint of the other app service.</summary>
    /// <returns>The connection to the endpoint of the other app service.</returns>
    public extern AppServiceConnection AppServiceConnection { [MethodImpl] get; }

    /// <summary>Gets whether the client app that called the background task for the app service is on another device.</summary>
    /// <returns>Returns **true** if the client app is calling from another device; **false** otherwise.</returns>
    public extern bool IsRemoteSystemConnection { [MethodImpl] get; }

    /// <summary>Determines whether the caller of the app service has the specified capability.</summary>
    /// <param name="capabilityName">The name of the capability.</param>
    /// <returns>**True** if it was possible to get the capabilities of the caller and the caller has the specified capability; **false** otherwise.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> CheckCallerForCapabilityAsync(
      string capabilityName);

    /// <summary>A string token which can be used to connect back to caller of a remote app service via RemoteSystemConnectionRequest.CreateFromConnectionToken.</summary>
    /// <returns>The string token.</returns>
    public extern string CallerRemoteConnectionToken { [MethodImpl] get; }
  }
}
