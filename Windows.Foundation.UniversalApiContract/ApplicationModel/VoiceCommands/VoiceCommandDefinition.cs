// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.VoiceCommands
{
  /// <summary>Enables operations on a specific installed command set.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VoiceCommandDefinition : IVoiceCommandDefinition
  {
    /// <summary>Gets the language (xml:lang ) value of the `CommandSet` element in the Voice Command Definition (VCD) file.</summary>
    /// <returns>The language (`xml:lang`) of the command set.</returns>
    public extern string Language { [MethodImpl] get; }

    /// <summary>Gets the `Name` attribute value of the `CommandSet` element in the Voice Command Definition (VCD) file.</summary>
    /// <returns>The Name attribute value of the `CommandSet` element.</returns>
    public extern string Name { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetPhraseListAsync(
      string phraseListName,
      IIterable<string> phraseList);
  }
}
