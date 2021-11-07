// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISymbolIconFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(3341101960, 59244, 19268, 138, 5, 4, 107, 157, 199, 114, 184)]
  [ExclusiveTo(typeof (SymbolIcon))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISymbolIconFactory
  {
    SymbolIcon CreateInstanceWithSymbol(Symbol symbol);
  }
}
