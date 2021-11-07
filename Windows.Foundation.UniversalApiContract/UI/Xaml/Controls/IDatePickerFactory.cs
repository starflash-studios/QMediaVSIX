// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IDatePickerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(4005808772, 39062, 19069, 187, 53, 111, 178, 30, 174, 202, 17)]
  [WebHostHidden]
  [ExclusiveTo(typeof (DatePicker))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDatePickerFactory
  {
    DatePicker CreateInstance(object baseInterface, out object innerInterface);
  }
}
