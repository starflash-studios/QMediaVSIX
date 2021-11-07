// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.ILineStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Shapes
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(645665341, 28324, 19536, 139, 29, 80, 32, 122, 255, 30, 138)]
  [ExclusiveTo(typeof (Line))]
  internal interface ILineStatics
  {
    DependencyProperty X1Property { get; }

    DependencyProperty Y1Property { get; }

    DependencyProperty X2Property { get; }

    DependencyProperty Y2Property { get; }
  }
}
