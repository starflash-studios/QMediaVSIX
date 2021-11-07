// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IDraggingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(479220612, 2108, 19411, 181, 89, 23, 156, 221, 235, 51, 236)]
  [ExclusiveTo(typeof (DraggingEventArgs))]
  internal interface IDraggingEventArgs
  {
    PointerDeviceType PointerDeviceType { get; }

    Point Position { get; }

    DraggingState DraggingState { get; }
  }
}
