// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.AppServiceRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppService
{
  /// <summary>Represents a message that the endpoint for one app service sends to another app service. App services enable app-to-app communication by allowing you to provide services from your Universal Windows app to other Universal Windows app.</summary>
  [DualApiPartition(version = 1)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AppServiceRequest : IAppServiceRequest
  {
    /// <summary>Gets the message that request from the app service contains.</summary>
    /// <returns>The message that request from the app service contains.</returns>
    public extern ValueSet Message { [MethodImpl] get; }

    /// <summary>Sends a response to a received request.</summary>
    /// <param name="message">The message that you want to include in the response.</param>
    /// <returns>An asynchronous operation to send the response.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AppServiceResponseStatus> SendResponseAsync(
      ValueSet message);
  }
}
