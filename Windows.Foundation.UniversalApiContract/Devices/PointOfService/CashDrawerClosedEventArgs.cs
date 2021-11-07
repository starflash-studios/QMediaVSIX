﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.CashDrawerClosedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>This object is passed as a parameter to the event handlers for the DrawerClosed event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class CashDrawerClosedEventArgs : ICashDrawerEventSourceEventArgs
  {
    /// <summary>Gets the data associated with the DrawerClosed event.</summary>
    /// <returns>The cash drawer.</returns>
    public extern CashDrawer CashDrawer { [MethodImpl] get; }
  }
}