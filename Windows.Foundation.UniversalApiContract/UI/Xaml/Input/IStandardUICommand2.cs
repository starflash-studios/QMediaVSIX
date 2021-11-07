// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IStandardUICommand2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ExclusiveTo(typeof (StandardUICommand))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Guid(3815137385, 63972, 20971, 136, 91, 122, 98, 10, 7, 130, 234)]
  [WebHostHidden]
  internal interface IStandardUICommand2
  {
    StandardUICommandKind Kind { set; }
  }
}
