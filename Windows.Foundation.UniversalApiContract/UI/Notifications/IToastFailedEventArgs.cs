// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastFailedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Guid(890726498, 53204, 17656, 173, 100, 245, 0, 253, 137, 108, 59)]
  [ExclusiveTo(typeof (ToastFailedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IToastFailedEventArgs
  {
    HResult ErrorCode { get; }
  }
}
