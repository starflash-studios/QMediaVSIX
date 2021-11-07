// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IRadialControllerRotationChangedEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Haptics;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [Guid(1029144300, 19694, 4582, 181, 53, 0, 27, 220, 6, 171, 59)]
  [ExclusiveTo(typeof (RadialControllerRotationChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IRadialControllerRotationChangedEventArgs2
  {
    bool IsButtonPressed { get; }

    SimpleHapticsController SimpleHapticsController { get; }
  }
}
