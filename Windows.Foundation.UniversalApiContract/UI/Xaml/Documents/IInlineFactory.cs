// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IInlineFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [Guid(1079553233, 12176, 19343, 153, 221, 66, 24, 239, 95, 3, 222)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Inline))]
  internal interface IInlineFactory
  {
    Inline CreateInstance(object baseInterface, out object innerInterface);
  }
}
