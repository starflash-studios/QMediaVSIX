// Decompiled with JetBrains decompiler
// Type: Windows.Perception.IPerceptionTimestamp2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (PerceptionTimestamp))]
  [Guid(3813980141, 11217, 16823, 158, 208, 116, 161, 92, 53, 69, 55)]
  internal interface IPerceptionTimestamp2
  {
    TimeSpan SystemRelativeTargetTime { get; }
  }
}
