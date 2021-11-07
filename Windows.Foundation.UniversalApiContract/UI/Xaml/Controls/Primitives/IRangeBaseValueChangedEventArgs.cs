// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IRangeBaseValueChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2710706039, 54721, 20380, 167, 176, 4, 1, 183, 230, 220, 92)]
  [WebHostHidden]
  [ExclusiveTo(typeof (RangeBaseValueChangedEventArgs))]
  internal interface IRangeBaseValueChangedEventArgs
  {
    double OldValue { get; }

    double NewValue { get; }
  }
}
