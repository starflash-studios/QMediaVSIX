// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Printing.IPrintDocumentStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Printing
{
  [ExclusiveTo(typeof (PrintDocument))]
  [Guid(4254534204, 45394, 18912, 166, 189, 106, 166, 71, 126, 67, 199)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IPrintDocumentStatics
  {
    DependencyProperty DocumentSourceProperty { get; }
  }
}
