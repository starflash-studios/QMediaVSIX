// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ConversationalAgent.IDetectionConfigurationAvailabilityInfo2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ConversationalAgent
{
  [Guid(820012083, 14515, 23627, 132, 195, 98, 182, 230, 133, 178, 255)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [ExclusiveTo(typeof (DetectionConfigurationAvailabilityInfo))]
  internal interface IDetectionConfigurationAvailabilityInfo2
  {
    IVectorView<SignalDetectorResourceKind> UnavailableSystemResources { get; }
  }
}
