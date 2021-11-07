// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPathIconFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (PathIcon))]
  [WebHostHidden]
  [Guid(2946340434, 40029, 18999, 158, 26, 4, 74, 190, 239, 121, 43)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPathIconFactory
  {
    PathIcon CreateInstance(object baseInterface, out object innerInterface);
  }
}
