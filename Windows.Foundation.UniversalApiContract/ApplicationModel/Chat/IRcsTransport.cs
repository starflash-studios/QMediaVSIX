// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IRcsTransport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RcsTransport))]
  [Guid(4272113497, 62332, 17177, 133, 70, 236, 132, 210, 29, 48, 255)]
  internal interface IRcsTransport
  {
    IMapView<string, object> ExtendedProperties { get; }

    bool IsActive { get; }

    string TransportFriendlyName { get; }

    string TransportId { get; }

    RcsTransportConfiguration Configuration { get; }

    bool IsStoreAndForwardEnabled(RcsServiceKind serviceKind);

    bool IsServiceKindSupported(RcsServiceKind serviceKind);

    event TypedEventHandler<RcsTransport, RcsServiceKindSupportedChangedEventArgs> ServiceKindSupportedChanged;
  }
}
