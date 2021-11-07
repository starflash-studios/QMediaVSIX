// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IVisualStateManagerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(2246416637, 42357, 18358, 158, 48, 56, 60, 208, 133, 133, 242)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VisualStateManager))]
  internal interface IVisualStateManagerFactory
  {
    VisualStateManager CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
