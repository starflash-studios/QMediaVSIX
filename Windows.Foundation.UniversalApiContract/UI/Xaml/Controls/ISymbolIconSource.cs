// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISymbolIconSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1650300322, 46769, 16522, 178, 137, 234, 178, 236, 186, 98, 216)]
  [WebHostHidden]
  [ExclusiveTo(typeof (SymbolIconSource))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface ISymbolIconSource
  {
    Symbol Symbol { get; set; }
  }
}
