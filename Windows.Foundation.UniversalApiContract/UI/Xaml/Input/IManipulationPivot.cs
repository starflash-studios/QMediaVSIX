// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IManipulationPivot
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(775436453, 59074, 18840, 130, 172, 24, 116, 139, 20, 22, 102)]
  [ExclusiveTo(typeof (ManipulationPivot))]
  internal interface IManipulationPivot
  {
    Point Center { get; set; }

    double Radius { get; set; }
  }
}
