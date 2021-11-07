// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IIconSourceElementFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(649437099, 8338, 23445, 181, 158, 242, 127, 33, 6, 137, 231)]
  [WebHostHidden]
  [ExclusiveTo(typeof (IconSourceElement))]
  internal interface IIconSourceElementFactory
  {
    IconSourceElement CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
