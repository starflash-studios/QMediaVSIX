// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBlock4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2954162800, 38920, 19164, 180, 82, 96, 205, 165, 65, 0, 193)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (TextBlock))]
  internal interface ITextBlock4
  {
    CompositionBrush GetAlphaMask();
  }
}
