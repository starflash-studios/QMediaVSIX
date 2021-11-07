// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IDatePickerValueChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (DatePickerValueChangedEventArgs))]
  [Guid(451305906, 45492, 17011, 150, 224, 25, 218, 255, 24, 116, 70)]
  internal interface IDatePickerValueChangedEventArgs
  {
    DateTime OldDate { get; }

    DateTime NewDate { get; }
  }
}
