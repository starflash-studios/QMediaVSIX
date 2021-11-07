// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IRadialControllerButtonClickedEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Haptics;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ExclusiveTo(typeof (RadialControllerButtonClickedEventArgs))]
  [Guid(1029144307, 15598, 4582, 181, 53, 0, 27, 220, 6, 171, 59)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IRadialControllerButtonClickedEventArgs2
  {
    SimpleHapticsController SimpleHapticsController { get; }
  }
}
