// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.UI.GameChatOverlay
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.UI
{
  /// <summary>Represents the game chat overlay.</summary>
  [Static(typeof (IGameChatOverlayStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class GameChatOverlay : IGameChatOverlay
  {
    /// <summary>The desired position of the game chat overlay.</summary>
    /// <returns>The desired position of the game chat overlay.</returns>
    public extern GameChatOverlayPosition DesiredPosition { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Render a message in the game chat overlay.</summary>
    /// <param name="sender">The name of the account that sent the message. In most cases, this should be the gamertag.</param>
    /// <param name="message">The contents of the message.</param>
    /// <param name="origin">The origin of the message (voice or text).</param>
    [MethodImpl]
    public extern void AddMessage(string sender, string message, GameChatMessageOrigin origin);

    /// <summary>Gets the default game chat overlay instance.</summary>
    /// <returns>The default game chat overlay instance.</returns>
    [MethodImpl]
    public static extern GameChatOverlay GetDefault();
  }
}
