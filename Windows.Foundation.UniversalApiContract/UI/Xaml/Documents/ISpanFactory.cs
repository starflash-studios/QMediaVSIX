// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.ISpanFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [Guid(1536257884, 52525, 16576, 149, 106, 56, 100, 72, 50, 47, 121)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Span))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISpanFactory
  {
    Span CreateInstance(object baseInterface, out object innerInterface);
  }
}
