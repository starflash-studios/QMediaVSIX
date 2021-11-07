// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ConversationalAgent.IDetectionConfigurationAvailabilityInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ConversationalAgent
{
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [ExclusiveTo(typeof (DetectionConfigurationAvailabilityInfo))]
  [Guid(3048210096, 16624, 21400, 184, 56, 145, 151, 156, 44, 98, 8)]
  internal interface IDetectionConfigurationAvailabilityInfo
  {
    bool IsEnabled { get; }

    bool HasSystemResourceAccess { get; }

    bool HasPermission { get; }

    bool HasLockScreenPermission { get; }
  }
}
