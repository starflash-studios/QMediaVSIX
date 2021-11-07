// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IClaimedLineDisplay3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(1680788882, 59860, 20172, 175, 117, 50, 156, 39, 76, 209, 143)]
  [ExclusiveTo(typeof (ClaimedLineDisplay))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IClaimedLineDisplay3
  {
    event TypedEventHandler<ClaimedLineDisplay, ClaimedLineDisplayClosedEventArgs> Closed;
  }
}
