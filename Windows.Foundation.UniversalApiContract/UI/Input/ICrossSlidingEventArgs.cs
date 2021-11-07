// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.ICrossSlidingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ExclusiveTo(typeof (CrossSlidingEventArgs))]
  [Guid(3912714040, 28552, 16857, 135, 32, 120, 224, 142, 57, 131, 73)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICrossSlidingEventArgs
  {
    PointerDeviceType PointerDeviceType { get; }

    Point Position { get; }

    CrossSlidingState CrossSlidingState { get; }
  }
}
