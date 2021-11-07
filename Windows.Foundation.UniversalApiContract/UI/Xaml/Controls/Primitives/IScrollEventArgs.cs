// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IScrollEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ScrollEventArgs))]
  [Guid(3313389928, 15102, 17549, 183, 82, 47, 54, 76, 117, 215, 67)]
  internal interface IScrollEventArgs
  {
    double NewValue { get; }

    ScrollEventType ScrollEventType { get; }
  }
}
