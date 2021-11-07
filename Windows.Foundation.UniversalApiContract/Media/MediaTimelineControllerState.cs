// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaTimelineControllerState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  /// <summary>Specifies the state of a MediaTimelineController.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum MediaTimelineControllerState
  {
    /// <summary>The **MediaTimelineController** is paused.</summary>
    Paused,
    /// <summary>The **MediaTimelineController** is running.</summary>
    Running,
    /// <summary>The **MediaTimelineController** is stalled due to starvation of streaming data. Apps may choose to show a buffering indicator when the timeline controller is stalled.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] Stalled,
    /// <summary>The **MediaTimelineController** has encountered an error.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] Error,
  }
}
