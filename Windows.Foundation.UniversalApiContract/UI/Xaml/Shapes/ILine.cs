// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.ILine
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Shapes
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1185235773, 20475, 18655, 135, 50, 78, 21, 200, 52, 129, 107)]
  [ExclusiveTo(typeof (Line))]
  internal interface ILine
  {
    double X1 { get; set; }

    double Y1 { get; set; }

    double X2 { get; set; }

    double Y2 { get; set; }
  }
}
