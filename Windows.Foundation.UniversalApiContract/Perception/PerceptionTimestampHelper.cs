// Decompiled with JetBrains decompiler
// Type: Windows.Perception.PerceptionTimestampHelper
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception
{
  /// <summary>Static methods for working with PerceptionTimestamp objects.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IPerceptionTimestampHelperStatics2), 458752, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPerceptionTimestampHelperStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 1)]
  public static class PerceptionTimestampHelper
  {
    [MethodImpl]
    public static extern PerceptionTimestamp FromSystemRelativeTargetTime(
      TimeSpan targetTime);

    [MethodImpl]
    public static extern PerceptionTimestamp FromHistoricalTargetTime(
      DateTime targetTime);
  }
}
