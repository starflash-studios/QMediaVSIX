// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IButtonFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2158050329, 33850, 17692, 140, 245, 68, 199, 1, 176, 226, 22)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Button))]
  [WebHostHidden]
  internal interface IButtonFactory
  {
    Button CreateInstance(object baseInterface, out object innerInterface);
  }
}
