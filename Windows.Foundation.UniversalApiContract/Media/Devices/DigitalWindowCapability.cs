// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.DigitalWindowCapability
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  public sealed class DigitalWindowCapability : IDigitalWindowCapability
  {
    public extern int Width { [MethodImpl] get; }

    public extern int Height { [MethodImpl] get; }

    public extern double MinScaleValue { [MethodImpl] get; }

    public extern double MaxScaleValue { [MethodImpl] get; }

    public extern double MinScaleValueWithoutUpsampling { [MethodImpl] get; }

    public extern Rect NormalizedFieldOfViewLimit { [MethodImpl] get; }
  }
}
