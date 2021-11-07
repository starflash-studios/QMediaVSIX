// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IVisualStateChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (VisualStateChangedEventArgs))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4263602865, 62239, 18321, 137, 137, 199, 14, 29, 155, 89, 255)]
  internal interface IVisualStateChangedEventArgs
  {
    VisualState OldState { get; set; }

    VisualState NewState { get; set; }

    Control Control { get; set; }
  }
}
