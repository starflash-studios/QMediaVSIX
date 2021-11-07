// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.IPathFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Shapes
{
  [Guid(591439075, 23174, 20422, 154, 80, 203, 185, 59, 130, 135, 102)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Path))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPathFactory
  {
    Path CreateInstance(object baseInterface, out object innerInterface);
  }
}
