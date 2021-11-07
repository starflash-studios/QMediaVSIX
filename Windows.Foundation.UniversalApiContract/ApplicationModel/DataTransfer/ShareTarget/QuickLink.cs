// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.ShareTarget.QuickLink
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.DataTransfer.ShareTarget
{
  /// <summary>Represents shortcuts that help users share content with the apps they use most.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class QuickLink : IQuickLink
  {
    /// <summary>Creates a new instance of a QuickLink object.</summary>
    [MethodImpl]
    public extern QuickLink();

    /// <summary>Specifies the title of a QuickLink. The system displays this info when the user is presented with a list of possible apps to share content with.</summary>
    /// <returns>Specifies the title of the QuickLink.</returns>
    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Specifies a thumbnail image for the QuickLink. The system displays this image when the user is presented with a list of possible apps to share content with.</summary>
    /// <returns>Contains the thumbnail image to use with the QuickLink.</returns>
    public extern RandomAccessStreamReference Thumbnail { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Specifies an ID for the QuickLink. Your app receives this ID when the user selects its QuickLink. You can use this ID to further customize the sharing process for the user.</summary>
    /// <returns>Specifies the ID for the QuickLink.</returns>
    public extern string Id { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>An array of strings that specify the data formats supported by the QuickLink app. The system shows the QuickLink only when the data that a user wants to share matches a format in this array.</summary>
    /// <returns>An array of format ids that specify the data formats supported by the QuickLink app.</returns>
    public extern IVector<string> SupportedDataFormats { [MethodImpl] get; }

    /// <summary>An array of strings that specify the file types supported by a QuickLink app. The system shows the QuickLink only when the data that a user wants to share contains file items, and the file extensions for those file items match a file type in this array.</summary>
    /// <returns>An array of file extensions that specify the file types supported by the QuickLinks app.</returns>
    public extern IVector<string> SupportedFileTypes { [MethodImpl] get; }
  }
}
