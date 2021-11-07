// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IWindow4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Guid(3219241166, 27712, 20729, 133, 76, 112, 33, 210, 188, 157, 230)]
  [ExclusiveTo(typeof (Window))]
  internal interface IWindow4
  {
    UIContext UIContext { get; }
  }
}
