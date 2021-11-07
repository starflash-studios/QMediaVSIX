// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IStoryboardStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (Storyboard))]
  [Guid(3626960856, 29653, 17273, 189, 72, 126, 5, 24, 74, 139, 173)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IStoryboardStatics
  {
    DependencyProperty TargetPropertyProperty { get; }

    string GetTargetProperty(Timeline element);

    void SetTargetProperty(Timeline element, string path);

    DependencyProperty TargetNameProperty { get; }

    string GetTargetName(Timeline element);

    void SetTargetName(Timeline element, string name);

    void SetTarget(Timeline timeline, DependencyObject target);
  }
}
