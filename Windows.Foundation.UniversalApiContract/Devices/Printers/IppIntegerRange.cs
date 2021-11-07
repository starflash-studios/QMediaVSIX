// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Printers.IppIntegerRange
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Printers
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IIppIntegerRangeFactory), 851968, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  public sealed class IppIntegerRange : IIppIntegerRange
  {
    [MethodImpl]
    public extern IppIntegerRange(int start, int end);

    public extern int Start { [MethodImpl] get; }

    public extern int End { [MethodImpl] get; }
  }
}
