// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.VoiceCommandContentTile
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.VoiceCommands
{
  /// <summary>An asset, containing image, text, and link data, provided by the background app service for display on the **Cortana** canvas.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VoiceCommandContentTile : IVoiceCommandContentTile
  {
    /// <summary>Creates an instance of the VoiceCommandContentTile class.</summary>
    [MethodImpl]
    public extern VoiceCommandContentTile();

    /// <summary>Gets or sets the title used on the content tile.</summary>
    /// <returns>The title associated with the content tile.</returns>
    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the first line of text used on the content tile.</summary>
    /// <returns>The first line of text associated with the content tile.</returns>
    public extern string TextLine1 { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the second line of text used on the content tile.</summary>
    /// <returns>The second line of text associated with the content tile.</returns>
    public extern string TextLine2 { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the third line of text used on the content tile.</summary>
    /// <returns>The third line of text associated with the content tile.</returns>
    public extern string TextLine3 { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the image used on the content tile.</summary>
    /// <returns>The image associated with the content tile.</returns>
    public extern IStorageFile Image { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets supplementary information the background app service can associate with the content tile. This information is not used by **Cortana**.</summary>
    /// <returns>Supplementary information associated with the content tile.</returns>
    public extern object AppContext { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a string as a launch parameter that can be associated with the response by the background app service.</summary>
    /// <returns>The key/value pair.</returns>
    public extern string AppLaunchArgument { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the layout template used for the content tiles on the **Cortana** canvas.</summary>
    /// <returns>The content tile template.</returns>
    public extern VoiceCommandContentTileType ContentTileType { [MethodImpl] get; [MethodImpl] set; }
  }
}
