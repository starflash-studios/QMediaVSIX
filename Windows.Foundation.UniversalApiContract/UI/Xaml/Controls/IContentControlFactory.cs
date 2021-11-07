// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentControlFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(2869000985, 6510, 20181, 162, 127, 85, 197, 143, 177, 103, 63)]
  [ExclusiveTo(typeof (ContentControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContentControlFactory
  {
    ContentControl CreateInstance(object baseInterface, out object innerInterface);
  }
}
