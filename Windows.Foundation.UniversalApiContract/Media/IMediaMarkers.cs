// Decompiled with JetBrains decompiler
// Type: Windows.Media.IMediaMarkers
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  /// <summary>Represents a collection of media markers.</summary>
  [Guid(2951393673, 63709, 18030, 170, 16, 146, 11, 82, 53, 63, 223)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IMediaMarkers
  {
    /// <summary>Gets the collection of media markers.</summary>
    /// <returns>The collection of media markers.</returns>
    IVectorView<IMediaMarker> Markers { get; }
  }
}
