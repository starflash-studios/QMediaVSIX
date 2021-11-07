// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlaybackItemChangedReason
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>Specifies the reason why the current MediaPlaybackItem in a MediaPlaybackList changed. Check for the reason by accessing the Reason property of the CurrentMediaPlaybackItemChangedEventArgs object passed into the MediaPlaybackList.CurrentItemChanged event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum MediaPlaybackItemChangedReason
  {
    /// <summary>The current item is the first item in the playback list.</summary>
    InitialItem,
    /// <summary>The current item changed because the previous item in the list played successfully to the end of its media stream.</summary>
    EndOfStream,
    /// <summary>The current item changed because there was an error playing back the previous item in the list.</summary>
    Error,
    /// <summary>The current item changed because the app initiated the change.</summary>
    AppRequested,
  }
}
