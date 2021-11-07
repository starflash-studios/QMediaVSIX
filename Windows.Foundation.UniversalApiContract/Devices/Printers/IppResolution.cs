// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Printers.IppResolution
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Printers
{
  [Activatable(typeof (IIppResolutionFactory), 851968, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  public sealed class IppResolution : IIppResolution
  {
    [MethodImpl]
    public extern IppResolution(int width, int height, IppResolutionUnit unit);

    public extern int Width { [MethodImpl] get; }

    public extern int Height { [MethodImpl] get; }

    public extern IppResolutionUnit Unit { [MethodImpl] get; }
  }
}
