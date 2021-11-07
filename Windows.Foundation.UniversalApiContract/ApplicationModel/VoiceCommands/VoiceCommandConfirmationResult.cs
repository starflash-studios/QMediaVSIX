// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.VoiceCommandConfirmationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.VoiceCommands
{
  /// <summary>The response to the question specified by the background app and shown on the **Cortana** confirmation screen. This screen is displayed when the background app service calls RequestConfirmationAsync.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class VoiceCommandConfirmationResult : IVoiceCommandConfirmationResult
  {
    /// <summary>Gets the response to the question specified by the background app and shown on the **Cortana** confirmation screen.</summary>
    /// <returns>**true** when the user responds with "Yes", **false** when the user responds with "No".</returns>
    public extern bool Confirmed { [MethodImpl] get; }
  }
}
