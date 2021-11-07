// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IColorChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(888610847, 43728, 19514, 185, 123, 42, 191, 54, 69, 85, 57)]
  [ExclusiveTo(typeof (ColorChangedEventArgs))]
  internal interface IColorChangedEventArgs
  {
    Color OldColor { get; }

    Color NewColor { get; }
  }
}
