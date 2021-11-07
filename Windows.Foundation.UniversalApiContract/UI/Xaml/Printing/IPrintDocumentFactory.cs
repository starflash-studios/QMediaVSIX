// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Printing.IPrintDocumentFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Printing
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PrintDocument))]
  [Guid(4219974031, 9734, 18991, 153, 212, 167, 205, 188, 53, 215, 199)]
  [WebHostHidden]
  internal interface IPrintDocumentFactory
  {
    PrintDocument CreateInstance(object baseInterface, out object innerInterface);
  }
}
