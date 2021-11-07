// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichEditBoxTextChangingEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (RichEditBoxTextChangingEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(962268597, 25454, 16702, 158, 180, 252, 34, 235, 250, 54, 40)]
  internal interface IRichEditBoxTextChangingEventArgs2
  {
    bool IsContentChanging { get; }
  }
}
