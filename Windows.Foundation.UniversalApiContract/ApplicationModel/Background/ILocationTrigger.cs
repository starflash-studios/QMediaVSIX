// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ILocationTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Guid(1197894172, 26743, 18462, 128, 38, 255, 126, 20, 168, 17, 160)]
  [ExclusiveTo(typeof (LocationTrigger))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILocationTrigger : IBackgroundTrigger
  {
    LocationTriggerType TriggerType { get; }
  }
}
