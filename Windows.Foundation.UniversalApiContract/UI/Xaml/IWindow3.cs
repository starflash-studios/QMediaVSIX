// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IWindow3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3071007901, 7221, 17962, 155, 151, 128, 141, 90, 249, 242, 142)]
  [ExclusiveTo(typeof (Window))]
  internal interface IWindow3
  {
    Compositor Compositor { get; }
  }
}
