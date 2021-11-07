// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ITimedMetadataTrackProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Defines the interface implemented by a custom stream that provides metadata tracks.</summary>
  [Guid(998187044, 63310, 19166, 147, 197, 33, 157, 160, 91, 104, 86)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public interface ITimedMetadataTrackProvider
  {
    /// <summary>Gets the list of timed metadata tracks provided by the object that implements this interface.</summary>
    /// <returns>The list of timed metadata tracks provided by the object that implements this interface.</returns>
    IVectorView<TimedMetadataTrack> TimedMetadataTracks { get; }
  }
}
