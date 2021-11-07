// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IVisualTransition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml
{
  [Guid(1439010910, 11207, 16397, 170, 164, 26, 41, 129, 73, 30, 224)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (VisualTransition))]
  internal interface IVisualTransition
  {
    Duration GeneratedDuration { get; set; }

    EasingFunctionBase GeneratedEasingFunction { get; set; }

    string To { get; set; }

    string From { get; set; }

    Storyboard Storyboard { get; set; }
  }
}
