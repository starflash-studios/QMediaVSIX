// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextCompositionStartedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3743591346, 4303, 18718, 145, 232, 211, 205, 114, 216, 160, 211)]
  [ExclusiveTo(typeof (TextCompositionStartedEventArgs))]
  [WebHostHidden]
  internal interface ITextCompositionStartedEventArgs
  {
    int StartIndex { get; }

    int Length { get; }
  }
}
