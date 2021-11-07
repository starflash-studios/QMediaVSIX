// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IDropShadow2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (DropShadow))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  [Guid(1816271036, 5561, 19501, 141, 74, 7, 103, 223, 17, 151, 122)]
  internal interface IDropShadow2
  {
    CompositionDropShadowSourcePolicy SourcePolicy { get; set; }
  }
}
