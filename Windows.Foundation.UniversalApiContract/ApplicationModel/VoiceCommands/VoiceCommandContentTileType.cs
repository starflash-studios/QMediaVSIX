// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.VoiceCommandContentTileType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.VoiceCommands
{
  /// <summary>The layout template used for content tiles on the **Cortana** canvas.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum VoiceCommandContentTileType
  {
    /// <summary>Only item title.&lt;img src="./windows.applicationmodel.voicecommands/images/VoiceCommandContentTileType_TitleOnly_small.png" alt="TitleOnly" /&gt;</summary>
    TitleOnly,
    /// <summary>Item title with up to three lines of text. &lt;img src="./windows.applicationmodel.voicecommands/images/VoiceCommandContentTileType_TitleWithText_small.png" alt="TitleWithText" /&gt;</summary>
    TitleWithText,
    /// <summary>Item title with small, square image.</summary>
    TitleWith68x68Icon,
    /// <summary>Item title, up to three lines of text, and small square image. &lt;img src="./windows.applicationmodel.voicecommands/images/VoiceCommandContentTileType_TitleWith68x68IconAndText_small.png" alt="TitleWith68x68IconAndText" /&gt;</summary>
    TitleWith68x68IconAndText,
    /// <summary>Item title with tall image.</summary>
    TitleWith68x92Icon,
    /// <summary>Item title, up to three lines of text, and tall image. &lt;img src="./windows.applicationmodel.voicecommands/images/VoiceCommandContentTileType_TitleWith68x92IconAndText_small.png" alt="TitleWith68x92IconAndText" /&gt;</summary>
    TitleWith68x92IconAndText,
    /// <summary>Item title with wide image.</summary>
    TitleWith280x140Icon,
    /// <summary>Item title, up to two lines of text, and wide image. &lt;img src="./windows.applicationmodel.voicecommands/images/VoiceCommandContentTileType_TitleWith280x140IconAndText_small.png" alt="TitleWith280x140IconAndText" /&gt;</summary>
    TitleWith280x140IconAndText,
  }
}
