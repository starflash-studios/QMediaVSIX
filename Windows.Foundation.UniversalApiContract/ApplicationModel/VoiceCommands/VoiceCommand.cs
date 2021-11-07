// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.VoiceCommand
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.SpeechRecognition;

namespace Windows.ApplicationModel.VoiceCommands
{
  /// <summary>The command given to **Cortana**, using either speech or text, and routed to a background app.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class VoiceCommand : IVoiceCommand
  {
    /// <summary>Gets the value of the **Name** attribute for the **Command** element declared in the Voice Command Definition (VCD) file.</summary>
    /// <returns>The command name.</returns>
    public extern string CommandName { [MethodImpl] get; }

    /// <summary>Gets a dictionary containing the semantic properties of the recognized phrase in the voice command.</summary>
    /// <returns>The semantic properties recognized in the voice command.</returns>
    public extern IMapView<string, IVectorView<string>> Properties { [MethodImpl] get; }

    /// <summary>Gets the SpeechRecognitionResult object representing the results returned by the voice command.</summary>
    /// <returns>The result of a speech recognition session.</returns>
    public extern SpeechRecognitionResult SpeechRecognitionResult { [MethodImpl] get; }
  }
}
