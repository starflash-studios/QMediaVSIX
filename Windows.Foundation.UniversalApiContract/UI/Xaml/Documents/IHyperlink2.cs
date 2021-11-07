// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IHyperlink2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [ExclusiveTo(typeof (Hyperlink))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1290394207, 31999, 17041, 183, 143, 223, 236, 114, 73, 5, 118)]
  internal interface IHyperlink2
  {
    UnderlineStyle UnderlineStyle { get; set; }
  }
}
