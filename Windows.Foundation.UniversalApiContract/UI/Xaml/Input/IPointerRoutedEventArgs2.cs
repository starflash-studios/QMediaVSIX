// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IPointerRoutedEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ExclusiveTo(typeof (PointerRoutedEventArgs))]
  [Guid(136442516, 7654, 18193, 186, 124, 141, 75, 139, 9, 17, 208)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  internal interface IPointerRoutedEventArgs2
  {
    bool IsGenerated { get; }
  }
}
