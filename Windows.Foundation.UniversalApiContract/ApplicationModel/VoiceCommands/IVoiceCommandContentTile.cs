// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.IVoiceCommandContentTile
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.VoiceCommands
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1055910384, 47303, 19574, 160, 222, 22, 7, 137, 94, 227, 39)]
  [ExclusiveTo(typeof (VoiceCommandContentTile))]
  internal interface IVoiceCommandContentTile
  {
    string Title { get; set; }

    string TextLine1 { get; set; }

    string TextLine2 { get; set; }

    string TextLine3 { get; set; }

    IStorageFile Image { get; set; }

    object AppContext { get; set; }

    string AppLaunchArgument { get; set; }

    VoiceCommandContentTileType ContentTileType { get; set; }
  }
}
