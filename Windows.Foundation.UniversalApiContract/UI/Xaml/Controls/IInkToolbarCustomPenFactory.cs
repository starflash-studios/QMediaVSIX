// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarCustomPenFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3524580918, 61866, 20296, 191, 44, 169, 38, 202, 174, 76, 96)]
  [ExclusiveTo(typeof (InkToolbarCustomPen))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  internal interface IInkToolbarCustomPenFactory
  {
    InkToolbarCustomPen CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
