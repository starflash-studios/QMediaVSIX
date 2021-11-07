// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.ContentPrefetcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  /// <summary>Provides properties for specifying web resources to be prefetched. Windows will use heuristics to attempt to download the specified resources in advance of your app being launched by the user.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IContentPrefetcherTime), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IContentPrefetcher), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class ContentPrefetcher
  {
    /// <summary>Gets the date and time of the last successful content prefetch operation.</summary>
    /// <returns>A 64-bit signed integer that represents a date and time.</returns>
    public static extern IReference<DateTime> LastSuccessfulPrefetchTime { [MethodImpl] get; }

    /// <summary>Array of URIs to download when prefetch is performed for the app.</summary>
    /// <returns>A list of Uri objects.</returns>
    public static extern IVector<Uri> ContentUris { [MethodImpl] get; }

    /// <summary>Specifies the location of a well-formed XML file that contains a list of resources to be prefetched.</summary>
    /// <returns>A Uri for a web resource.</returns>
    public static extern Uri IndirectContentUri { [MethodImpl] set; [MethodImpl] get; }
  }
}
