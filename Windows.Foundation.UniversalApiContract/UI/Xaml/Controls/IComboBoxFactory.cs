// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IComboBoxFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ComboBox))]
  [Guid(2886534212, 42587, 19133, 134, 223, 48, 22, 4, 158, 254, 220)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IComboBoxFactory
  {
    ComboBox CreateInstance(object baseInterface, out object innerInterface);
  }
}
