// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ContentPrefetchTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Provides the ability to run custom handlers when prefetching web resources.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  [Activatable(typeof (IContentPrefetchTriggerFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class ContentPrefetchTrigger : IContentPrefetchTrigger, IBackgroundTrigger
  {
    [MethodImpl]
    public extern ContentPrefetchTrigger(TimeSpan waitInterval);

    /// <summary>Initializes a new instance of the ContentPrefetchTrigger class.</summary>
    [MethodImpl]
    public extern ContentPrefetchTrigger();

    /// <summary>Retrieves the time interval for prefetching web content.</summary>
    /// <returns>The time interval set for refreshing web content.</returns>
    public extern TimeSpan WaitInterval { [MethodImpl] get; }
  }
}
