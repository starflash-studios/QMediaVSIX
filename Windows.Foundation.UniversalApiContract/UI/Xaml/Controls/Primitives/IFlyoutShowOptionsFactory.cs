// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IFlyoutShowOptionsFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ExclusiveTo(typeof (FlyoutShowOptions))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(3461967713, 11956, 23374, 175, 105, 249, 175, 66, 50, 14, 238)]
  [WebHostHidden]
  internal interface IFlyoutShowOptionsFactory
  {
    FlyoutShowOptions CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
