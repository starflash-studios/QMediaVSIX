// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.CashDrawerEventSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Provides event sources that allow a developer to detect when the cash drawer is opened or closed.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CashDrawerEventSource : ICashDrawerEventSource
  {
    /// <summary>Occurs when the cash drawer is closed.</summary>
    public extern event TypedEventHandler<CashDrawerEventSource, CashDrawerClosedEventArgs> DrawerClosed;

    /// <summary>Occurs when the cash drawer is opened.</summary>
    public extern event TypedEventHandler<CashDrawerEventSource, CashDrawerOpenedEventArgs> DrawerOpened;
  }
}
