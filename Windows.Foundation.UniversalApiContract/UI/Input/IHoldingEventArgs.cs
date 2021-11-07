// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IHoldingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [Guid(737629637, 59289, 16820, 187, 64, 36, 47, 64, 149, 155, 113)]
  [ExclusiveTo(typeof (HoldingEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHoldingEventArgs
  {
    PointerDeviceType PointerDeviceType { get; }

    Point Position { get; }

    HoldingState HoldingState { get; }
  }
}
