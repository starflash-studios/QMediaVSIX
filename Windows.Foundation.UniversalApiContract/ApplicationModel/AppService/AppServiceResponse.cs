// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.AppServiceResponse
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppService
{
  /// <summary>Represents the message that the app service sent in response to a request. App services enable app-to-app communication by allowing you to provide services from your Universal Windows app to other Universal Windows app.</summary>
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AppServiceResponse : IAppServiceResponse
  {
    /// <summary>Gets the message that the response from the app service contains.</summary>
    /// <returns>The message that the response from the app service contains.</returns>
    public extern ValueSet Message { [MethodImpl] get; }

    /// <summary>Gets the status for the response from the app service.</summary>
    /// <returns>The status for the response from the app service.</returns>
    public extern AppServiceResponseStatus Status { [MethodImpl] get; }
  }
}
