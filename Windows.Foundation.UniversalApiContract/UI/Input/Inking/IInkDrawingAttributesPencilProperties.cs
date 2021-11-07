// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkDrawingAttributesPencilProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [Guid(1327838411, 11654, 16827, 176, 232, 228, 194, 160, 37, 60, 82)]
  [ExclusiveTo(typeof (InkDrawingAttributesPencilProperties))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IInkDrawingAttributesPencilProperties
  {
    double Opacity { get; set; }
  }
}
