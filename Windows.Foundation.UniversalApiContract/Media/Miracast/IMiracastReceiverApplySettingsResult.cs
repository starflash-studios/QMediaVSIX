// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.IMiracastReceiverApplySettingsResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Miracast
{
  [ExclusiveTo(typeof (MiracastReceiverApplySettingsResult))]
  [Guid(3500827250, 2509, 22753, 164, 242, 93, 81, 67, 211, 18, 249)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IMiracastReceiverApplySettingsResult
  {
    MiracastReceiverApplySettingsStatus Status { get; }

    HResult ExtendedError { get; }
  }
}
