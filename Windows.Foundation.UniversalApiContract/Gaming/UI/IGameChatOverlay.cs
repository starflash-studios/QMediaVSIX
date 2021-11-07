// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.UI.IGameChatOverlay
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.UI
{
  [Guid(4224075877, 63228, 19016, 174, 7, 3, 172, 110, 212, 55, 4)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (GameChatOverlay))]
  internal interface IGameChatOverlay
  {
    GameChatOverlayPosition DesiredPosition { get; set; }

    void AddMessage(string sender, string message, GameChatMessageOrigin origin);
  }
}
