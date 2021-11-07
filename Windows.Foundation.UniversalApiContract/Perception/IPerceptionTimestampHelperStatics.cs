// Decompiled with JetBrains decompiler
// Type: Windows.Perception.IPerceptionTimestampHelperStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (PerceptionTimestampHelper))]
  [Guid(1202065876, 43487, 20188, 133, 93, 244, 211, 57, 217, 103, 172)]
  internal interface IPerceptionTimestampHelperStatics
  {
    PerceptionTimestamp FromHistoricalTargetTime(DateTime targetTime);
  }
}
