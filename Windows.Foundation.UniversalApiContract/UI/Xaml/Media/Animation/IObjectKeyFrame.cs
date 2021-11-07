// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IObjectKeyFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2555553873, 34195, 18670, 166, 164, 213, 212, 114, 15, 2, 154)]
  [ExclusiveTo(typeof (ObjectKeyFrame))]
  internal interface IObjectKeyFrame
  {
    object Value { get; set; }

    KeyTime KeyTime { get; set; }
  }
}
