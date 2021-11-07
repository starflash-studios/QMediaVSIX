// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.IVoiceCommandDefinitionManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.VoiceCommands
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2414323358, 1662, 20246, 161, 140, 91, 23, 233, 73, 153, 64)]
  [ExclusiveTo(typeof (VoiceCommandDefinitionManager))]
  internal interface IVoiceCommandDefinitionManagerStatics
  {
    [RemoteAsync]
    IAsyncAction InstallCommandDefinitionsFromStorageFileAsync(StorageFile file);

    IMapView<string, VoiceCommandDefinition> InstalledCommandDefinitions { get; }
  }
}
