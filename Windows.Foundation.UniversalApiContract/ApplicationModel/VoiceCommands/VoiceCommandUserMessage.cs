// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.VoiceCommandUserMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.VoiceCommands
{
  /// <summary>The message that is spoken by **Cortana** and shown on the **Cortana** canvas.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class VoiceCommandUserMessage : IVoiceCommandUserMessage
  {
    /// <summary>Creates an instance of the VoiceCommandUserMessage class.</summary>
    [MethodImpl]
    public extern VoiceCommandUserMessage();

    /// <summary>Gets or sets the message that is shown on the **Cortana** canvas.</summary>
    /// <returns>+ An informative statement on progress, completion, and error screens (see ReportProgressAsync, ReportSuccessAsync, ReportFailureAsync ).</returns>
    public extern string DisplayMessage { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The message that is spoken by **Cortana**.</summary>
    /// <returns>+ An informative statement on progress, completion, and error screens (see ReportProgressAsync, ReportSuccessAsync, ReportFailureAsync ).</returns>
    public extern string SpokenMessage { [MethodImpl] get; [MethodImpl] set; }
  }
}
