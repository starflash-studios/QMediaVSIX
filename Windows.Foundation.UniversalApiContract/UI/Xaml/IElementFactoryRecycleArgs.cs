// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IElementFactoryRecycleArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  [Guid(2263968532, 14312, 24024, 169, 12, 37, 211, 113, 3, 24, 176)]
  [ExclusiveTo(typeof (ElementFactoryRecycleArgs))]
  internal interface IElementFactoryRecycleArgs
  {
    UIElement Element { get; set; }

    UIElement Parent { get; set; }
  }
}
