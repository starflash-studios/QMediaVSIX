// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IGroupStyleFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1459578447, 58071, 20297, 128, 61, 199, 39, 205, 249, 55, 45)]
  [WebHostHidden]
  [ExclusiveTo(typeof (GroupStyle))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGroupStyleFactory
  {
    GroupStyle CreateInstance(object baseInterface, out object innerInterface);
  }
}
