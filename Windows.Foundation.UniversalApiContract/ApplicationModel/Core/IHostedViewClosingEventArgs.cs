// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.IHostedViewClosingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3526923324, 45646, 18320, 172, 181, 62, 66, 67, 196, 255, 135)]
  [ExclusiveTo(typeof (HostedViewClosingEventArgs))]
  internal interface IHostedViewClosingEventArgs
  {
    Deferral GetDeferral();
  }
}
