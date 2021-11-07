// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.AppServiceClosedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppService
{
  /// <summary>Provides data for the AppServiceConnection.ServiceClosed event that occurs when the other endpoint closes connection to the app service. App services enable app-to-app communication by allowing you to provide services from your Universal Windows app to other Universal Windows app.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 1)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AppServiceClosedEventArgs : IAppServiceClosedEventArgs
  {
    /// <summary>Gets the status that was set when the endpoint for the app service was closed.</summary>
    /// <returns>The status that was set when the endpoint for the app service was closed.</returns>
    public extern AppServiceClosedStatus Status { [MethodImpl] get; }
  }
}
