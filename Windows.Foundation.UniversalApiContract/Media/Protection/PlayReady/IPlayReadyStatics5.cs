// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyStatics5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(587886709, 57248, 20366, 167, 121, 206, 254, 169, 198, 130, 75)]
  [ExclusiveTo(typeof (PlayReadyStatics))]
  internal interface IPlayReadyStatics5 : 
    IPlayReadyStatics4,
    IPlayReadyStatics3,
    IPlayReadyStatics2,
    IPlayReadyStatics
  {
    IReference<DateTime> HardwareDRMDisabledAtTime { get; }

    IReference<DateTime> HardwareDRMDisabledUntilTime { get; }

    void ResetHardwareDRMDisabled();
  }
}
