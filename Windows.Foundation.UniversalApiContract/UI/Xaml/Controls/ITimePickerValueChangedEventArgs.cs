// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITimePickerValueChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(793697165, 47509, 20017, 139, 169, 196, 220, 222, 178, 28, 163)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TimePickerValueChangedEventArgs))]
  internal interface ITimePickerValueChangedEventArgs
  {
    TimeSpan OldTime { get; }

    TimeSpan NewTime { get; }
  }
}
