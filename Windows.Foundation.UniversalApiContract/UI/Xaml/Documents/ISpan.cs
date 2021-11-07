// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.ISpan
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [WebHostHidden]
  [Guid(2553926825, 687, 18449, 170, 21, 107, 239, 58, 202, 201, 122)]
  [ExclusiveTo(typeof (Span))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISpan
  {
    InlineCollection Inlines { get; set; }
  }
}
