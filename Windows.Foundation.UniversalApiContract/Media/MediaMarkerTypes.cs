// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaMarkerTypes
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  /// <summary>Provides a static list of media marker types.</summary>
  [Static(typeof (IMediaMarkerTypesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class MediaMarkerTypes
  {
    /// <summary>Gets the value of the Bookmark type which is returned as the string "Bookmark"</summary>
    /// <returns>The bookmark type which is return as the string "Bookmark".</returns>
    public static extern string Bookmark { [MethodImpl] get; }
  }
}
