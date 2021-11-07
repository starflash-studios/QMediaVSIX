// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICheckBoxFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (CheckBox))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1336322747, 16203, 17153, 190, 7, 17, 114, 234, 97, 238, 251)]
  internal interface ICheckBoxFactory
  {
    CheckBox CreateInstance(object baseInterface, out object innerInterface);
  }
}
