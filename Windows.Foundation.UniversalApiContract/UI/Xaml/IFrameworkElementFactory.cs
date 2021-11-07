// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IFrameworkElementFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(3736002854, 970, 18790, 181, 118, 96, 76, 206, 147, 181, 232)]
  [ExclusiveTo(typeof (FrameworkElement))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFrameworkElementFactory
  {
    FrameworkElement CreateInstance(object baseInterface, out object innerInterface);
  }
}
