// Decompiled with JetBrains decompiler
// Type: Windows.Networking.PushNotifications.IRawNotification2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.PushNotifications
{
  [ExclusiveTo(typeof (RawNotification))]
  [Guid(3872444185, 3183, 19677, 148, 36, 238, 197, 190, 1, 77, 38)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IRawNotification2
  {
    IMapView<string, string> Headers { get; }

    string ChannelId { get; }
  }
}
