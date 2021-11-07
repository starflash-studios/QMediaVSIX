// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ITranslateTransform
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3379925084, 15414, 16937, 129, 123, 23, 143, 100, 192, 225, 19)]
  [ExclusiveTo(typeof (TranslateTransform))]
  internal interface ITranslateTransform
  {
    double X { get; set; }

    double Y { get; set; }
  }
}
