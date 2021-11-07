// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.ISelectableWordSegment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [ExclusiveTo(typeof (SelectableWordSegment))]
  [Guid(2439662775, 35495, 19576, 179, 116, 93, 237, 183, 82, 230, 11)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISelectableWordSegment
  {
    string Text { get; }

    TextSegment SourceTextSegment { get; }
  }
}
