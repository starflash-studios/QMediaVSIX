// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IBitmapIconFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(1188449053, 31305, 20326, 151, 41, 40, 72, 199, 136, 228, 2)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BitmapIcon))]
  internal interface IBitmapIconFactory
  {
    BitmapIcon CreateInstance(object baseInterface, out object innerInterface);
  }
}
