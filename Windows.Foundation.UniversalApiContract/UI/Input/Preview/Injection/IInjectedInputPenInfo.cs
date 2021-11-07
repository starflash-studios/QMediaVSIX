// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.IInjectedInputPenInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  [Guid(1799400707, 51742, 21799, 126, 2, 40, 40, 84, 11, 177, 212)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (InjectedInputPenInfo))]
  internal interface IInjectedInputPenInfo
  {
    InjectedInputPointerInfo PointerInfo { get; set; }

    InjectedInputPenButtons PenButtons { get; set; }

    InjectedInputPenParameters PenParameters { get; set; }

    double Pressure { get; set; }

    double Rotation { get; set; }

    int TiltX { get; set; }

    int TiltY { get; set; }
  }
}
