// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.VoiceCommandDisambiguationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.VoiceCommands
{
  /// <summary>The result obtained from the disambiguation screen displayed on the **Cortana** canvas.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VoiceCommandDisambiguationResult : IVoiceCommandDisambiguationResult
  {
    /// <summary>The item selected from the list of items displayed on the **Cortana** disambiguation screen.</summary>
    /// <returns>An asset, containing image and text data, provided by the background app service for display on the **Cortana** canvas.</returns>
    public extern VoiceCommandContentTile SelectedItem { [MethodImpl] get; }
  }
}
