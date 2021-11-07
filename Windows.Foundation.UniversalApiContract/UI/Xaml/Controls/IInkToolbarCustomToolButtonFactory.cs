// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarCustomToolButtonFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(3264609870, 12523, 16688, 166, 182, 140, 133, 216, 226, 110, 137)]
  [ExclusiveTo(typeof (InkToolbarCustomToolButton))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IInkToolbarCustomToolButtonFactory
  {
    InkToolbarCustomToolButton CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
