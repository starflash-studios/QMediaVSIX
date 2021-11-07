// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IHyperlink5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [ExclusiveTo(typeof (Hyperlink))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  [Guid(1618859986, 2373, 17192, 145, 238, 148, 204, 236, 46, 166, 195)]
  internal interface IHyperlink5
  {
    bool IsTabStop { get; set; }

    int TabIndex { get; set; }
  }
}
