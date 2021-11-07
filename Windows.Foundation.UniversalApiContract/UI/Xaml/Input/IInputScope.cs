// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IInputScope
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ExclusiveTo(typeof (InputScope))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1544521203, 63960, 16928, 182, 102, 4, 93, 7, 77, 155, 250)]
  [WebHostHidden]
  internal interface IInputScope
  {
    IVector<InputScopeName> Names { get; }
  }
}
