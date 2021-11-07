// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.UI.GameChatMessageOrigin
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.UI
{
  /// <summary>Indicates the origin of the source message.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum GameChatMessageOrigin
  {
    /// <summary>The message was transcribed through speech-to-text.</summary>
    Voice,
    /// <summary>The message was a typed text message.</summary>
    Text,
  }
}
