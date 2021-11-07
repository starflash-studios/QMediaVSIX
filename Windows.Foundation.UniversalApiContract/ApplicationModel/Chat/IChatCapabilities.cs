// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [Guid(989820860, 14793, 19921, 173, 45, 57, 100, 221, 157, 64, 63)]
  [ExclusiveTo(typeof (ChatCapabilities))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IChatCapabilities
  {
    bool IsOnline { get; }

    bool IsChatCapable { get; }

    bool IsFileTransferCapable { get; }

    bool IsGeoLocationPushCapable { get; }

    bool IsIntegratedMessagingCapable { get; }
  }
}
