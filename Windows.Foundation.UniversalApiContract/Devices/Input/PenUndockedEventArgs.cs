// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.PenUndockedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  /// <summary>Contains event data for the PenDockListener.Undocked event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [DualApiPartition(version = 1)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PenUndockedEventArgs : IPenUndockedEventArgs
  {
  }
}
