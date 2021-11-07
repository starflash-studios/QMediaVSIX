// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ISingleSelectMediaTrackList
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Represents a media track list that allows a single item to be selected at a time.</summary>
  [Guid(1998614303, 49999, 18767, 128, 119, 43, 173, 159, 244, 236, 241)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ISingleSelectMediaTrackList
  {
    /// <summary>Occurs when the SelectedIndex property changes.</summary>
    event TypedEventHandler<ISingleSelectMediaTrackList, object> SelectedIndexChanged;

    /// <summary>Gets or set the currently selected media track in the list.</summary>
    /// <returns>The currently selected media track in the list.</returns>
    int SelectedIndex { set; get; }
  }
}
