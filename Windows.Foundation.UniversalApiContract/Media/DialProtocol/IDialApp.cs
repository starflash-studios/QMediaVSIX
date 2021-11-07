// Decompiled with JetBrains decompiler
// Type: Windows.Media.DialProtocol.IDialApp
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.DialProtocol
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DialApp))]
  [Guid(1432353747, 17847, 18931, 187, 215, 48, 45, 182, 8, 70, 70)]
  internal interface IDialApp
  {
    string AppName { get; }

    [RemoteAsync]
    IAsyncOperation<DialAppLaunchResult> RequestLaunchAsync(
      string appArgument);

    [RemoteAsync]
    IAsyncOperation<DialAppStopResult> StopAsync();

    [RemoteAsync]
    IAsyncOperation<DialAppStateDetails> GetAppStateAsync();
  }
}
