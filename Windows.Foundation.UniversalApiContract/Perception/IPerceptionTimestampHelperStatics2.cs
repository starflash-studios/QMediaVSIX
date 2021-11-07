// Decompiled with JetBrains decompiler
// Type: Windows.Perception.IPerceptionTimestampHelperStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(1943119870, 16313, 17777, 135, 212, 60, 146, 10, 94, 134, 235)]
  [ExclusiveTo(typeof (PerceptionTimestampHelper))]
  internal interface IPerceptionTimestampHelperStatics2
  {
    PerceptionTimestamp FromSystemRelativeTargetTime(TimeSpan targetTime);
  }
}
