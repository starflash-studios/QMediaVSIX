// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISymbolIconSourceFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (SymbolIconSource))]
  [Guid(2770774704, 16688, 18695, 176, 73, 33, 249, 36, 12, 122, 64)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface ISymbolIconSourceFactory
  {
    SymbolIconSource CreateInstance(object baseInterface, out object innerInterface);
  }
}
