// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.BackgroundWorkCost
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Retrieves a hint about resource availability for background tasks. Background tasks can use this hint to decide how much work to do when they are activated.</summary>
  [Static(typeof (IBackgroundWorkCostStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class BackgroundWorkCost
  {
    /// <summary>Retrieves a hint about resource availability for background tasks.</summary>
    /// <returns>A hint about background resource availability. A background task can use this hint to decide how much work to do when it is activated.</returns>
    public static extern BackgroundWorkCostValue CurrentBackgroundWorkCost { [MethodImpl] get; }
  }
}
