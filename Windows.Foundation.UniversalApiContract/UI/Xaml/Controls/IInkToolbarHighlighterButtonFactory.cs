// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarHighlighterButtonFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [ExclusiveTo(typeof (InkToolbarHighlighterButton))]
  [Guid(2083736285, 17098, 18755, 148, 164, 35, 181, 166, 229, 92, 241)]
  internal interface IInkToolbarHighlighterButtonFactory
  {
    InkToolbarHighlighterButton CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
