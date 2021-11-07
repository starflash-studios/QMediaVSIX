// Decompiled with JetBrains decompiler
// Type: Windows.Media.DialProtocol.DialApp
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.DialProtocol
{
  /// <summary>Represents a DIAL application running on a remote device.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DialApp : IDialApp
  {
    /// <summary>Gets the application's registered DIAL name.</summary>
    /// <returns>The DIAL name.</returns>
    public extern string AppName { [MethodImpl] get; }

    /// <summary>Initiates the launching of the app on the remote device. When this method is called, the DialDevice is paired if necessary, the user is prompted to allow access to the device, connection is established, app existence is validated on the device, and finally the application is launched with the provided argument.</summary>
    /// <param name="appArgument">Optional.</param>
    /// <returns>Indicates the result of attempting to launch the app.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DialAppLaunchResult> RequestLaunchAsync(
      string appArgument);

    /// <summary>Stops the app on the remote device, if the remote device supports this functionality.</summary>
    /// <returns>The result of sending the request to stop the app.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DialAppStopResult> StopAsync();

    /// <summary>Gets the current status of the application on the remote device.</summary>
    /// <returns>The app status, a value from DialAppStateDetails.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DialAppStateDetails> GetAppStateAsync();
  }
}
