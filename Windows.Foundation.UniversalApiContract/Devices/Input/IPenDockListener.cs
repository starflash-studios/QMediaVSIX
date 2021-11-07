// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.IPenDockListener
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  [ExclusiveTo(typeof (PenDockListener))]
  [Guid(1973374352, 7616, 21963, 173, 24, 185, 16, 20, 86, 245, 146)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  internal interface IPenDockListener
  {
    bool IsSupported();

    event TypedEventHandler<PenDockListener, object> IsSupportedChanged;

    event TypedEventHandler<PenDockListener, PenDockedEventArgs> Docked;

    event TypedEventHandler<PenDockListener, PenUndockedEventArgs> Undocked;
  }
}
