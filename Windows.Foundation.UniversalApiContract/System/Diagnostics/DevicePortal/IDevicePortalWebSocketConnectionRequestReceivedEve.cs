// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.DevicePortal.IDevicePortalWebSocketConnectionRequestReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.DevicePortal
{
  [Guid(2046675642, 5980, 18233, 159, 116, 221, 167, 151, 195, 91, 63)]
  [ExclusiveTo(typeof (DevicePortalConnectionRequestReceivedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IDevicePortalWebSocketConnectionRequestReceivedEventArgs
  {
    bool IsWebSocketUpgradeRequest { get; }

    IVectorView<string> WebSocketProtocolsRequested { get; }

    Deferral GetDeferral();
  }
}
