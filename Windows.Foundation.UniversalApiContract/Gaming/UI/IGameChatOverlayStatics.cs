// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.UI.IGameChatOverlayStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.UI
{
  [Guid(2309813780, 30823, 18935, 150, 135, 37, 217, 219, 244, 68, 209)]
  [ExclusiveTo(typeof (GameChatOverlay))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IGameChatOverlayStatics
  {
    GameChatOverlay GetDefault();
  }
}
