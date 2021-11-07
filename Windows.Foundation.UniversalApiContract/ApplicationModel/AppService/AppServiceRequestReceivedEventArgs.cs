// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.AppServiceRequestReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppService
{
  /// <summary>Provides data for the AppServiceConnection.RequestReceived event that occurs when a message arrives from the other endpoint of the app service connection. App services enable app-to-app communication by allowing you to provide services from your Universal Windows app to other Universal Windows app.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 1)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AppServiceRequestReceivedEventArgs : IAppServiceRequestReceivedEventArgs
  {
    /// <summary>Gets the request that was received from the app service.</summary>
    /// <returns>The request that was received from the app service.</returns>
    public extern AppServiceRequest Request { [MethodImpl] get; }

    /// <summary>Informs the system that the event handler might continue to perform work after the event handler returns.</summary>
    /// <returns>The deferral.</returns>
    [MethodImpl]
    public extern AppServiceDeferral GetDeferral();
  }
}
