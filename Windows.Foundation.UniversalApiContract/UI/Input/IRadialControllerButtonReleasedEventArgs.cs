// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IRadialControllerButtonReleasedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Haptics;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (RadialControllerButtonReleasedEventArgs))]
  [Guid(1029144303, 15598, 4582, 181, 53, 0, 27, 220, 6, 171, 59)]
  internal interface IRadialControllerButtonReleasedEventArgs
  {
    RadialControllerScreenContact Contact { get; }

    SimpleHapticsController SimpleHapticsController { get; }
  }
}
