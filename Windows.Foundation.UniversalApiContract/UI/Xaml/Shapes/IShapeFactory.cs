// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.IShapeFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Shapes
{
  [WebHostHidden]
  [ExclusiveTo(typeof (Shape))]
  [Guid(1265726995, 63146, 18645, 149, 136, 225, 209, 136, 234, 203, 201)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IShapeFactory
  {
    Shape CreateInstance(object baseInterface, out object innerInterface);
  }
}
