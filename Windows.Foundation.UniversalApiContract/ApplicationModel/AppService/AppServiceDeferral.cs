// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.AppServiceDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppService
{
  /// <summary>Enables the background task for an app service to get a deferral so that the app service can respond to subsequent requests. App service providers enable app-to-app communication by providing services that other Universal Windows app can consume.</summary>
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AppServiceDeferral : IAppServiceDeferral
  {
    /// <summary>Indicates that the content for an asynchronous handler for the AppServiceConnection.RequestReceived event is ready, or that an error occurred.</summary>
    [MethodImpl]
    public extern void Complete();
  }
}
