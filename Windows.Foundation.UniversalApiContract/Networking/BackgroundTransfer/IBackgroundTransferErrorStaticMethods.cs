// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundTransferErrorStaticMethods
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web;

namespace Windows.Networking.BackgroundTransfer
{
  [ExclusiveTo(typeof (BackgroundTransferError))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2865969924, 4498, 19444, 139, 104, 57, 197, 173, 210, 68, 226)]
  internal interface IBackgroundTransferErrorStaticMethods
  {
    WebErrorStatus GetStatus(int hresult);
  }
}
