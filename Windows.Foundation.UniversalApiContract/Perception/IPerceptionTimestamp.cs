// Decompiled with JetBrains decompiler
// Type: Windows.Perception.IPerceptionTimestamp
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2277656580, 41518, 19163, 186, 38, 215, 142, 246, 57, 188, 244)]
  [ExclusiveTo(typeof (PerceptionTimestamp))]
  internal interface IPerceptionTimestamp
  {
    DateTime TargetTime { get; }

    TimeSpan PredictionAmount { get; }
  }
}
