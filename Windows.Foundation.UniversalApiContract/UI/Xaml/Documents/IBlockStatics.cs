// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IBlockStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [Guid(4167732276, 36120, 19539, 174, 189, 145, 230, 16, 165, 224, 16)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Block))]
  internal interface IBlockStatics
  {
    DependencyProperty TextAlignmentProperty { get; }

    DependencyProperty LineHeightProperty { get; }

    DependencyProperty LineStackingStrategyProperty { get; }

    DependencyProperty MarginProperty { get; }
  }
}
