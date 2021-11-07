// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IInlineUIContainer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [Guid(337038977, 10478, 17710, 177, 33, 95, 196, 246, 11, 134, 166)]
  [WebHostHidden]
  [ExclusiveTo(typeof (InlineUIContainer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IInlineUIContainer
  {
    UIElement Child { get; set; }
  }
}
