// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IApplicationStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Application))]
  [Guid(105486743, 63412, 17918, 183, 99, 117, 119, 209, 211, 203, 74)]
  internal interface IApplicationStatics
  {
    Application Current { get; }

    void Start(ApplicationInitializationCallback callback);

    [Overload("LoadComponent")]
    void LoadComponent(object component, Uri resourceLocator);

    [Overload("LoadComponentWithResourceLocation")]
    void LoadComponent(
      object component,
      Uri resourceLocator,
      ComponentResourceLocation componentResourceLocation);
  }
}
