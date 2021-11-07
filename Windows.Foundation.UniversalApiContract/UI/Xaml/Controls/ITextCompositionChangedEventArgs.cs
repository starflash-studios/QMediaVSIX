// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextCompositionChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TextCompositionChangedEventArgs))]
  [Guid(3116884210, 20663, 17437, 153, 12, 104, 85, 62, 46, 5, 107)]
  [WebHostHidden]
  internal interface ITextCompositionChangedEventArgs
  {
    int StartIndex { get; }

    int Length { get; }
  }
}
