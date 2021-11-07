// Decompiled with JetBrains decompiler
// Type: Windows.Media.DialProtocol.IDialReceiverApp2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.DialProtocol
{
  [ExclusiveTo(typeof (DialReceiverApp))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(1393317893, 37168, 17068, 165, 4, 25, 119, 220, 178, 234, 138)]
  internal interface IDialReceiverApp2
  {
    [RemoteAsync]
    IAsyncOperation<string> GetUniqueDeviceNameAsync();
  }
}
