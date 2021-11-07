// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.IInjectedInputTouchInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (InjectedInputTouchInfo))]
  [Guid(575656415, 17384, 24309, 81, 10, 105, 202, 140, 155, 76, 40)]
  internal interface IInjectedInputTouchInfo
  {
    InjectedInputRectangle Contact { get; set; }

    int Orientation { get; set; }

    InjectedInputPointerInfo PointerInfo { get; set; }

    double Pressure { get; set; }

    InjectedInputTouchParameters TouchParameters { get; set; }
  }
}
