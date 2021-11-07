// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IVisualState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ExclusiveTo(typeof (VisualState))]
  [Guid(1663086588, 49946, 17488, 175, 222, 246, 234, 123, 209, 245, 134)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVisualState
  {
    string Name { get; }

    Storyboard Storyboard { get; set; }
  }
}
