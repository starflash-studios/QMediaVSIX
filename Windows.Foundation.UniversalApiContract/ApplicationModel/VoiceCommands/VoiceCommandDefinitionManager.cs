// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinitionManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.VoiceCommands
{
  /// <summary>A static class that enables registering and using command sets from a Voice Command Data (VCD) file.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IVoiceCommandDefinitionManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class VoiceCommandDefinitionManager
  {
    /// <summary>Installs the CommandSet elements in a Voice Command Definition (VCD) file.</summary>
    /// <param name="file">An object representing a Voice Command Definition (VCD) file.</param>
    /// <returns>An asynchronous handler called when the operation is complete.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction InstallCommandDefinitionsFromStorageFileAsync(
      StorageFile file);

    /// <summary>A dictionary that contains all installed command sets that have a Name attribute set in the Voice Command Definition (VCD) file.</summary>
    /// <returns>The dictionary of installed command sets that have a Name attribute set in the Voice Command Definition (VCD) file.</returns>
    public static extern IMapView<string, VoiceCommandDefinition> InstalledCommandDefinitions { [MethodImpl] get; }
  }
}
