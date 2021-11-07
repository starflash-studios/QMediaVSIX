// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkDrawingAttributesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [ExclusiveTo(typeof (InkDrawingAttributes))]
  [Guid(4147241023, 6757, 18530, 150, 203, 110, 22, 101, 225, 127, 109)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IInkDrawingAttributesStatics
  {
    InkDrawingAttributes CreateForPencil();
  }
}
